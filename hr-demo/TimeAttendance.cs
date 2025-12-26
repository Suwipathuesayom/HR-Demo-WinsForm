using System.ComponentModel;
using System.Data;
using hr_demo.domain.Dtos;
using hr_demo.Models;
using hr_demo_data;

namespace hr_demo
{
    public partial class TimeAttendance : Form
    {
        private readonly ApplicationDbContext _context;
        private List<DisplayEmployee> _allEmployees = new List<DisplayEmployee>();
        private BindingList<DisplayEmployee> _bindingSource = new BindingList<DisplayEmployee>();
        private List<AttendanceSummaryDto> _attendanceList = new List<AttendanceSummaryDto>();
        private int _presentCount, _lateCount, _onLeaveCount, _absentCount, _totalCount;
        public TimeAttendance(ApplicationDbContext context)
        {
            InitializeComponent();
            _context = context;
            this.Shown += FormLoad;
        }

        private async void FormLoad(object? sender, EventArgs e)
        {
            await RefreshDataAsync();
        }

        private async Task RefreshDataAsync()
        {
            try
            {
                SetLoadingState(true);

                await Task.Run(() => FetchDataFromDb());

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

        private void SetLoadingState(bool isLoading)
        {
            if (pnlLoading != null)
            {
                pnlLoading.Visible = isLoading;
                if (isLoading) pnlLoading.BringToFront();
            }

            txtSearch.Enabled = !isLoading;
            cmbEmployeeFilter.Enabled = !isLoading;
        }

        private void FetchDataFromDb()
        {
            var today = DateTime.Today;
            var lateThreshold = new TimeSpan(9, 0, 0);
            var departments = _context.Departments.ToDictionary(d => d.Id, d => d.Name);
            var lateEmployees = new HashSet<int>();
            var allActiveUsers = _context.Users.Where(u => u.IsActive).ToList();
            _totalCount = allActiveUsers.Count;

            var todayAttendance = _context.Attendances
                .Where(a => a.Date == today)
                .ToList();

            var todayLeaves = _context.LeaveRequests
                .Where(l => l.Status == "Approved" && today >= l.StartDate && today <= l.EndDate)
                .Select(l => l.UserId)
                .ToList();

            _attendanceList = allActiveUsers.Select(u =>
            {
                var attendance = todayAttendance.FirstOrDefault(a => a.UserId == u.Id);
                bool isOnLeave = todayLeaves.Contains(u.Id);

                string status = "Absent";
                DateTime? checkIn = attendance?.ClockIn;

                if (isOnLeave) status = "On Leave";
                else if (checkIn.HasValue)
                {
                    status = checkIn.Value.TimeOfDay <= lateThreshold ? "Present" : "Late";
                }

                return new AttendanceSummaryDto
                {
                    EmployeeId = u.Id,
                    FullName = $"{u.FirstName} {u.LastName}",
                    DepartmentName = u.DepartmentId.HasValue && departments.ContainsKey(u.DepartmentId.Value)
                                     ? departments[u.DepartmentId.Value] : "N/A",
                    CheckIn = checkIn?.TimeOfDay,
                    Status = status
                };
            }).ToList();

            _presentCount = _attendanceList.Count(x => x.Status == "Present" || x.Status == "Late");
            _lateCount = _attendanceList.Count(x => x.Status == "Late");
            _onLeaveCount = _attendanceList.Count(x => x.Status == "On Leave");
            _absentCount = _attendanceList.Count(x => x.Status == "Absent");
        }

        private void UpdateUIComponents()
        {
            dtgShowLists.DataSource = new BindingList<AttendanceSummaryDto>(_attendanceList);
            dtgShowLate.DataSource = new BindingList<AttendanceSummaryDto>(_attendanceList.Where(a => a.Status == "Late").ToList());
            cmbEmployeeFilter.DataSource = new List<string> { "All", "Present", "Late", "On Leave", "Absent" };
            FormatGridStatus();
        }

        private void FormatGridStatus()
        {
            foreach (DataGridViewRow row in dtgShowLists.Rows)
            {
                var status = row.Cells["Status"].Value?.ToString();
                if (status == "Late") row.Cells["Status"].Style.ForeColor = Color.OrangeRed;
                else if (status == "Absent") row.Cells["Status"].Style.ForeColor = Color.Red;
                else if (status == "On Leave") row.Cells["Status"].Style.ForeColor = Color.DodgerBlue;
                else if (status == "Present") row.Cells["Status"].Style.ForeColor = Color.Green;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchTerm = txtSearch.Text.Trim().ToLower();
            var filteredList = _attendanceList.Where(a =>
                a.FullName.ToLower().Contains(searchTerm) ||
                a.DepartmentName.ToLower().Contains(searchTerm) ||
                a.Status.ToLower().Contains(searchTerm)
            ).ToList();
            dtgShowLists.DataSource = new BindingList<AttendanceSummaryDto>(filteredList);
            FormatGridStatus();
        }

        private void btnClearFilter_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            dtgShowLists.DataSource = new BindingList<AttendanceSummaryDto>(_attendanceList);
            FormatGridStatus();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
