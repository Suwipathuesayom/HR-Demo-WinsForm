using hr_demo.domain.Models;
using hr_demo.Models;
using hr_demo_data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hr_demo
{
    public partial class ScanMonitor : Form
    {
        private readonly ApplicationDbContext _context;

        private TcpClient? _client;
        private NetworkStream? _stream;
        private CancellationTokenSource? _cts;

        private bool _isConnected = false;
        private BindingList<ScanRow> _rows = new BindingList<ScanRow>();


        public ScanMonitor(ApplicationDbContext context)
        {
            InitializeComponent();

            _context = context;

            SetupUI();
        }

        private void SetupUI()
        {
            dtgLoggerScan.AutoGenerateColumns = false;
            dtgLoggerScan.Columns.Clear();

            dtgLoggerScan.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Id", HeaderText = "ID", Width = 60 });
            dtgLoggerScan.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Date", HeaderText = "Date", Width = 120 });
            dtgLoggerScan.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "ClockIn", HeaderText = "Clock In", Width = 120 });
            dtgLoggerScan.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "UserName", HeaderText = "Username", Width = 120 });
            dtgLoggerScan.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "FullName", HeaderText = "Full Name", Width = 200 });
            dtgLoggerScan.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Status", HeaderText = "Status", Width = 100 });

            dtgLoggerScan.DataSource = _rows;

            txtIpAddress.Text = "127.0.0.1";
            txtPort.Text = "9100";

            lblStatus.Text = "Disconnected";
        }




        private void DisconnectTcp()
        {
            if (_isConnected)
            {
                _isConnected = false;
                _stream?.Close();
                _client?.Close();
                BeginInvoke(new Action(() => lblStatus.Text = "Disconnected"));
            }
        }

        private void btnConnect_Click_1(object sender, EventArgs e)
        {
            _cts?.Cancel();
            _cts = new CancellationTokenSource();
            Task.Run(() => ConnectTcpAsync(txtIpAddress.Text, int.Parse(txtPort.Text), _cts.Token));

            BeginInvoke(() =>
            {
                lblStatus.Text = "PLC Connected";
                lblStatus.ForeColor = Color.Green;
            });

        }

        private void ConnectTcpAsync(string text, int v, CancellationToken token)
        {
            try
            {
                _client = new TcpClient();
                _client.Connect(text, v);
                _stream = _client.GetStream();
                _isConnected = true;
                Invoke(new Action(() => lblStatus.Text = "Connected"));
                byte[] buffer = new byte[4096];
                var sb = new StringBuilder();
                while (_isConnected && !token.IsCancellationRequested)
                {
                    if (_stream.DataAvailable)
                    {
                        int bytesRead = _stream.Read(buffer, 0, buffer.Length);
                        if (bytesRead <= 0) break;
                        string chunk = Encoding.ASCII.GetString(buffer, 0, bytesRead);
                        sb.Append(chunk);

                        var textAll = sb.ToString();
                        var lines = textAll.Split(new[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
                        if (!textAll.EndsWith("\n") && !textAll.EndsWith("\r"))
                        {
                            if (lines.Length > 0)
                            {
                                for (int i = 0; i < lines.Length - 1; i++)
                                {
                                    ProcessMessage(lines[i]);
                                }
                                sb.Clear();
                                sb.Append(lines.Last());
                            }
                        }
                        else
                        {
                            foreach (var line in lines)
                            {
                                ProcessMessage(line);
                            }
                            sb.Clear();
                        }
                    }
                    else
                    {
                        Thread.Sleep(100);
                    }
                }
            }
            catch (Exception ex)
            {
                Invoke(new Action(() => lblStatus.Text = "Error: " + ex.Message));
            }
            finally
            {
                DisconnectTcp();
            }
        }

        private void ProcessMessage(string message)
        {
            if (string.IsNullOrWhiteSpace(message)) return;

            // simple user id or structured SCAN;USER=...;TIME=...;DEVICE=...
            // handle multiple formats
            try
            {
                // if numeric id
                if (int.TryParse(message.Trim(), out int userId))
                {
                    Task.Run(() => HandleScanByUserId(userId));
                    return;
                }

                // structured
                // e.g. "SCAN;USER=EMP001;TIME=2025-12-2508:00:00;DEVICE=FINGER01"
                var parts = message.Split(';', StringSplitOptions.RemoveEmptyEntries)
                    .Select(p => p.Trim()).ToArray();
                string? userCode = null;
                DateTime scanTime = DateTime.Now;
                string? device = null;

                foreach (var p in parts)
                {
                    if (p.StartsWith("USER=", StringComparison.OrdinalIgnoreCase)) userCode = p.Substring(5);
                    else if (p.StartsWith("TIME=", StringComparison.OrdinalIgnoreCase))
                    {
                        var t = p.Substring(5);
                        if (!DateTime.TryParse(t, out scanTime)) scanTime = DateTime.Now;
                    }
                    else if (p.StartsWith("DEVICE=", StringComparison.OrdinalIgnoreCase)) device = p.Substring(7);
                    else if (p.StartsWith("SCAN", StringComparison.OrdinalIgnoreCase)) { /*ignore*/ }
                }

                if (!string.IsNullOrEmpty(userCode))
                {
                    Task.Run(() => HandleScanByUserCode(userCode!, scanTime, device));
                }
            }
            catch (Exception ex)
            {
                if (IsHandleCreated && !IsDisposed)
                {
                    BeginInvoke(() => lblStatus.Text = "Parse error: " + ex.Message);
                }
            }
        }

        private void HandleScanByUserId(int userId)
        {
            try
            {
                using var db = new ApplicationDbContext();
                var user = db.Users.Find(userId);
                if (user == null) return;

                var scanTime = DateTime.Now;

                SaveAttendanceAndUpdateUi(db, user, scanTime, null);
            }
            catch (Exception ex)
            {
                if (IsHandleCreated && !IsDisposed) BeginInvoke(() => lblStatus.Text = "Error: " + ex.Message);
            }
        }

        private void HandleScanByUserCode(string userCode, DateTime scanTime, string? device)
        {
            try
            {
                using var db = new ApplicationDbContext();
                var user = db.Users.FirstOrDefault(u => u.Username == userCode);
                if (user == null)
                {
                    var rowUnknown = new ScanRow
                    {
                        Id = _rows.Count + 1,
                        Date = scanTime.ToString("yyyy-MM-dd"),
                        ClockIn = scanTime.ToString("HH:mm:ss"),
                        UserName = userCode,
                        FullName = "(Unknown)",
                        Status = "Unknown User"
                    };
                    if (IsHandleCreated && !IsDisposed) BeginInvoke(() => _rows.Add(rowUnknown));
                    return;
                }

                SaveAttendanceAndUpdateUi(db, user, scanTime, device);
            }
            catch (Exception ex)
            {
                if (IsHandleCreated && !IsDisposed) BeginInvoke(() => lblStatus.Text = "Error: " + ex.Message);
            }
        }

        private void SaveAttendanceAndUpdateUi(ApplicationDbContext db, User user, DateTime scanTime, string? device)
        {
            try
            {
                var date = scanTime.Date;
                var attendance = db.Attendances.FirstOrDefault(a => a.UserId == user.Id && a.Date == date);

                if (attendance == null)
                {
                    attendance = new Attendance
                    {
                        UserId = user.Id,
                        Date = date,
                        ClockIn = scanTime,
                        Status = "Present"
                    };
                    db.Attendances.Add(attendance);
                }
                else
                {
                    attendance.ClockOut = scanTime;
                    attendance.Status = "Present";
                    db.Entry(attendance).State = EntityState.Modified;
                }

                int result = db.SaveChanges();

                if (result > 0)
                {
                    var row = new ScanRow
                    {
                        Id = attendance.Id,
                        Date = attendance.Date.ToString("yyyy-MM-dd"),
                        ClockIn = attendance.ClockIn?.ToString("HH:mm:ss") ?? string.Empty,
                        UserName = user.Username,
                        FullName = $"{user.FirstName} {user.LastName}",
                        Status = attendance.Status ?? string.Empty
                    };

                    if (IsHandleCreated && !IsDisposed)
                    {
                        BeginInvoke(() =>
                        {
                            _rows.Insert(0, row);
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                BeginInvoke(() => lblStatus.Text = "DB Error: " + ex.Message);
            }
        }
        private void btnDisConnect_Click_1(object sender, EventArgs e)
        {

            _cts?.Cancel();
            DisconnectTcp();
        }
    }
}
