using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using hr_demo.domain.Dtos;
using hr_demo.Models;
using hr_demo_data;

namespace hr_demo
{
    public partial class DashboardForm : Form
    {


        private readonly ApplicationDbContext _context;
        private List<DisplayEmployee> _allEmployees = new List<DisplayEmployee>();
        private BindingList<DisplayEmployee> _bindingSource = new BindingList<DisplayEmployee>();

        private int _totalCount, _activeCount, _resignedCount, _totalAttendance, _totalLeaveRequests, _pendingLeaveRequests,
            _approvedLeaveRequests, _rejectedLeaveRequests, _totalPresentStatus, _totalLateStatus, _totalInComingBirthdays;

        public DashboardForm(ApplicationDbContext context)
        {
            InitializeComponent();
            _context = context ?? throw new ArgumentNullException(nameof(context));

            SetupUI();
            SetupEventHandlers();

            SetLoadingState(true);

            this.Shown += DasboardForm_Shown;
        }

        private async void DasboardForm_Shown(object sender, EventArgs e)
        {
            await RefreshDashboardData();
        }

        private void SetupUI()
        {
            dtgListUser.AutoGenerateColumns = false;
            dtgListUser.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgListUser.ReadOnly = true;
            dtgListUser.RowHeadersVisible = false;
            dtgListUser.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dtgListUser.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 250);

            dtgListUser.Columns.Clear();
            dtgListUser.Columns.AddRange(new DataGridViewColumn[] {
                new DataGridViewTextBoxColumn { DataPropertyName = "Id", HeaderText = "ID", FillWeight = 10 },
                new DataGridViewTextBoxColumn { DataPropertyName = "FirstName", HeaderText = "First Name", FillWeight = 20 },
                new DataGridViewTextBoxColumn { DataPropertyName = "LastName", HeaderText = "Last Name", FillWeight = 20 },
                new DataGridViewTextBoxColumn { DataPropertyName = "Email", HeaderText = "Email", FillWeight = 30 },
                new DataGridViewTextBoxColumn { DataPropertyName = "DepartmentName", HeaderText = "Department", FillWeight = 20 }
            });

            LoadDepartmentFilter();
        }

        private void SetupEventHandlers()
        {

            var addBtn = panel7.Controls.Find("btnAddCustomer", true).FirstOrDefault() as Button;
            var updBtn = panel7.Controls.Find("btnUpdateCustomer", true).FirstOrDefault() as Button;
            var delBtn = panel7.Controls.Find("btnDeleteCustomer", true).FirstOrDefault() as Button;

            if (addBtn != null) addBtn.Click += async (s, e) => await OpenCreateForm();
            if (updBtn != null) updBtn.Click += async (s, e) => await OpenUpdateForm();
            if (delBtn != null) delBtn.Click += DelBtn_Click;

            txtSearch.TextChanged += (s, e) => ApplyFilter();
            cmbCompanyFilter.SelectedIndexChanged += (s, e) => ApplyFilter();
            btnClearFilter.Click += (s, e) =>
            {
                txtSearch.Clear();
                cmbCompanyFilter.SelectedIndex = 0;
            };
        }

        private void SetLoadingState(bool isLoading)
        {
            if (pnlLoading != null)
            {
                pnlLoading.Visible = isLoading;
                if (isLoading) pnlLoading.BringToFront();
            }

            txtSearch.Enabled = !isLoading;
            cmbCompanyFilter.Enabled = !isLoading;
            panel7.Enabled = !isLoading;
            dtgListUser.Enabled = !isLoading;
        }

        private async Task RefreshDashboardData()
        {
            try
            {
                SetLoadingState(true);

                // ดึงข้อมูลหนักๆ ใน Background Thread
                await Task.Run(() => FetchDataFromDb());

                // อัปเดต UI เมื่อข้อมูลมาถึง
                UpdateUIComponents();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                SetLoadingState(false);
            }
        }

        private void FetchDataFromDb()
        {
            var departments = _context.Departments.ToDictionary(d => d.Id, d => d.Name);

            _allEmployees = _context.Users
                .Select(u => new DisplayEmployee
                {
                    Id = u.Id,
                    FirstName = u.FirstName,
                    LastName = u.LastName,
                    Email = u.Email,
                    PhoneNumber = u.PhoneNumber,
                    DepartmentName = u.DepartmentId.HasValue && departments.ContainsKey(u.DepartmentId.Value)
                                     ? departments[u.DepartmentId.Value] : "N/A",
                    IsActive = u.IsActive
                })
                .OrderBy(e => e.LastName)
                .ToList();

            _totalCount = _context.Users.Count();
            _activeCount = _context.Users.Count(u => u.IsActive);
            _resignedCount = _totalCount - _activeCount;
            _totalCount = _context.Users.Count();
            _totalAttendance = _context.Attendances.Count();
            _totalLeaveRequests = _context.LeaveRequests.Count();
            _pendingLeaveRequests = _context.LeaveRequests.Count(lr => lr.Status == "Pending");
            _approvedLeaveRequests = _context.LeaveRequests.Count(lr => lr.Status == "Approved");
            _rejectedLeaveRequests = _context.LeaveRequests.Count(lr => lr.Status == "Rejected");
            _totalPresentStatus = _context.Attendances.Count(a => a.Status == "Present");
            _totalLateStatus = _context.Attendances.Count(a => a.Status == "Late");
            _totalInComingBirthdays = _context.Users
                .Count(u => u.BirthDate.Month == DateTime.Now.Month && u.BirthDate.Day >= DateTime.Now.Day);

        }

        private void UpdateUIComponents()
        {
            lblTotalEmp.Text = _totalCount.ToString();
            lblTotalActive.Text = _activeCount.ToString();
            lblTotalResigned.Text = _resignedCount.ToString();
            lblTotalResigned.Text = _resignedCount.ToString();
            lblAttentdancePresent.Text = _totalPresentStatus.ToString();
            lblAttendanceLate.Text = _totalLateStatus.ToString();
            lblTotalAttendance.Text = _totalAttendance.ToString();
            lblTotalPendingRequest.Text = _totalLeaveRequests.ToString();
            lblRequestLeave.Text = _pendingLeaveRequests.ToString();
            lblRequestBenefit.Text = _approvedLeaveRequests.ToString();
            lblTotalIncomingBd.Text = _totalInComingBirthdays.ToString();

            _bindingSource = new BindingList<DisplayEmployee>(_allEmployees);
            dtgListUser.DataSource = _bindingSource;

            DrawDashboardChart();
        }

        private void ApplyFilter()
        {
            var search = txtSearch.Text.Trim();
            var selectedDept = cmbCompanyFilter.SelectedItem as ComboItem;

            var filtered = _allEmployees.AsEnumerable();

            if (!string.IsNullOrWhiteSpace(search))
            {
                filtered = filtered.Where(e =>
                    e.FirstName.Contains(search, StringComparison.OrdinalIgnoreCase) ||
                    e.LastName.Contains(search, StringComparison.OrdinalIgnoreCase) ||
                    e.Email.Contains(search, StringComparison.OrdinalIgnoreCase) ||
                    e.DepartmentName.Contains(search, StringComparison.OrdinalIgnoreCase));
            }

            if (selectedDept != null && selectedDept.Id != 0)
            {
                filtered = filtered.Where(e => e.DepartmentName == selectedDept.Name);
            }

            var list = filtered.ToList();
            dtgListUser.DataSource = new BindingList<DisplayEmployee>(list);
            label9.Text = $"Showing {list.Count} of {_allEmployees.Count} records";
        }

        private void DrawDashboardChart()
        {
            var chartPb = panel7.Controls.Find("chartSummary", true).FirstOrDefault() as PictureBox;
            if (chartPb == null) return;

            var data = _allEmployees
                .GroupBy(e => e.DepartmentName)
                .Select(g => new { Name = g.Key, Count = g.Count() })
                .OrderByDescending(x => x.Count)
                .ToList();

            var bmp = new Bitmap(chartPb.Width, chartPb.Height);
            using (var g = Graphics.FromImage(bmp))
            {
                g.SmoothingMode = SmoothingMode.AntiAlias;
                g.Clear(Color.White);

                if (!data.Any())
                {
                    g.DrawString("No data", DefaultFont, Brushes.Gray, 10, 10);
                }
                else
                {
                    int margin = 40;
                    int chartWidth = bmp.Width - (margin * 2);
                    int chartHeight = bmp.Height - (margin * 2);
                    int maxVal = data.Max(x => x.Count);
                    if (maxVal == 0) maxVal = 1;

                    int barWidth = (chartWidth / data.Count) - 10;

                    for (int i = 0; i < data.Count; i++)
                    {
                        int h = (int)((double)data[i].Count / maxVal * chartHeight);
                        int x = margin + (i * (barWidth + 10));
                        int y = bmp.Height - margin - h;

                        var rect = new Rectangle(x, y, barWidth, h);
                        using (var brush = new LinearGradientBrush(rect, Color.DodgerBlue, Color.DeepSkyBlue, 90f))
                        {
                            g.FillRectangle(brush, rect);
                        }
                        g.DrawString(data[i].Count.ToString(), DefaultFont, Brushes.Black, x + (barWidth / 4), y - 15);

                        string label = data[i].Name.Length > 8 ? data[i].Name.Substring(0, 6) + ".." : data[i].Name;
                        g.DrawString(label, new Font("Segoe UI", 7), Brushes.Gray, x, bmp.Height - margin + 5);
                    }
                }
            }

            chartPb.Image?.Dispose();
            chartPb.Image = bmp;
        }

        private async Task OpenCreateForm()
        {
            using var form = new CreateCustomerForm(_context);
            if (form.ShowDialog() == DialogResult.OK) await RefreshDashboardData();
        }

        private async Task OpenUpdateForm()
        {
            if (dtgListUser.CurrentRow?.DataBoundItem is DisplayEmployee emp)
            {
                using var form = new UpdateCustomerForm(_context, emp.Id);
                if (form.ShowDialog() == DialogResult.OK) await RefreshDashboardData();
            }
            else
            {
                MessageBox.Show("Please select an employee.");
            }
        }

        private async void DelBtn_Click(object sender, EventArgs e)
        {
            if (dtgListUser.CurrentRow?.DataBoundItem is DisplayEmployee emp)
            {
                if (MessageBox.Show($"Are you sure to delete {emp.FirstName}?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    var entity = await _context.Users.FindAsync(emp.Id);
                    if (entity != null)
                    {
                        _context.Users.Remove(entity);
                        await _context.SaveChangesAsync();
                        await RefreshDashboardData();
                    }
                }
            }
        }

        private void LoadDepartmentFilter()
        {
            var items = _context.Users
                .Where(u => u.DepartmentId.HasValue)
                .Select(u => u.Department)
                .Distinct()
                .Select(d => new ComboItem { Id = d.Id, Name = d.Name })
                .OrderBy(d => d.Name)
                .ToList();
            cmbCompanyFilter.Items.Clear();
            cmbCompanyFilter.Items.Add(new ComboItem { Id = 0, Name = "All Departments" });
            cmbCompanyFilter.Items.AddRange(items.ToArray());
            cmbCompanyFilter.SelectedIndex = 0;
        }

        private void btnLohout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Logout and exit?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
                var login = new SignIn(_context);
                login.Show();
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var timeAttendanceForm = new TimeAttendance(_context);
            timeAttendanceForm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var payRollForm = new PayRoll(_context);
            payRollForm.ShowDialog();
        }

        private void btnScanMonitor_Click(object sender, EventArgs e)
        {
            var scanMonitorForm = new ScanMonitor(_context);
            scanMonitorForm.ShowDialog();
        }
    }
}