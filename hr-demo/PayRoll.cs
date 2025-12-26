using hr_demo.domain.Dtos;
using hr_demo_data;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;

namespace hr_demo
{
    public partial class PayRoll : Form
    {
        private readonly ApplicationDbContext _context;
        private readonly BindingList<PayRollDto> _bindingSource = new();

        public PayRoll(ApplicationDbContext context)
        {
            InitializeComponent();
            _context = context;

            dtgShowPayRoll.DataSource = _bindingSource;

            dtgShowPayRoll.SelectionChanged += DtgShowPayRoll_SelectionChanged;

            this.Shown += async (s, e) => await RefreshAllDataAsync();
        }
        private void DtgShowPayRoll_SelectionChanged(object? sender, EventArgs e)
        {
            if (dtgShowPayRoll.CurrentRow != null && dtgShowPayRoll.CurrentRow.DataBoundItem is PayRollDto selectedPayroll)
            {
                txtFullname.Text = selectedPayroll.EmployeeName;
                txtBaseSalary.Text = selectedPayroll.Salary.ToString("C");
                txtIncentive.Text = selectedPayroll.Bonuses.ToString("C");
                txtStatulation.Text = selectedPayroll.Deductions.ToString("C");

            }
        }
        private async Task RefreshAllDataAsync()
        {
            await LoadGridDataAsync();
            await SetProfileDataAsync();
        }

        private async Task SetProfileDataAsync()
        {
            var profile = await _context.Users.AsNoTracking().FirstOrDefaultAsync();
            if (profile == null) return;

            txtFullname.Text = $"{profile.FirstName} {profile.LastName}";
            txtJobTitle.Text = profile.JobTitle ?? "N/A";
            txtBankNo.Text = profile.BankInfo ?? "N/A";

            var latestAttendance = await _context.Attendances
                .AsNoTracking()
                .Where(a => a.UserId == profile.Id)
                .OrderByDescending(a => a.Date)
                .FirstOrDefaultAsync();

            if (latestAttendance != null)
            {
                txtAbsent.Text = latestAttendance.Status == "Absent" ? "Yes" : "No";
                txtLate.Text = latestAttendance.Status == "Late" ? "Yes" : "No";
                txtOtSummary.Text = latestAttendance.OvertimeHours.ToString("F2") ?? "0.00";
            }

            var latestPayroll = await _context.Payrolls
                .AsNoTracking()
                .Where(p => p.UserId == profile.Id)
                .OrderByDescending(p => p.PaymentDate)
                .FirstOrDefaultAsync();

            if (latestPayroll != null)
            {
                txtBaseSalary.Text = latestPayroll.NetSalary.ToString("C") ?? "C0";
                txtIncentive.Text = latestPayroll.Bonus.ToString("C") ?? "C0";
                txtStatulation.Text = latestPayroll.Deductions.ToString("C") ?? "C0";
            }
        }

        private async Task LoadGridDataAsync(DateTime? fromDate = null, DateTime? toDate = null)
        {
            dtgShowPayRoll.Columns["EmployeeId"].Visible = false;
            dtgShowPayRoll.Columns["Id"].Visible = false;

            var query = _context.Payrolls
                .Include(p => p.User)
                .AsNoTracking()
                .AsQueryable();

            if (fromDate.HasValue && toDate.HasValue)
            {
                query = query.Where(p => p.PaymentDate >= fromDate && p.PaymentDate <= toDate);
            }

            var result = await query
                .Select(p => new PayRollDto
                {
                    EmployeeName = p.User != null ? $"{p.User.FirstName} {p.User.LastName}" : "N/A",
                    Salary = p.NetSalary,
                    Bonuses = p.Bonus,
                    Deductions = p.Deductions,
                    PayDate = p.PaymentDate
                })
                .ToListAsync();

            _bindingSource.Clear();
            result.ForEach(x => _bindingSource.Add(x));
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    var from = dtpFrom.Value.Date;
            //    var to = dtpTo.Value.Date.AddDays(1).AddTicks(-1);
            //    await LoadGridDataAsync(from, to);
            //}
            //finally
            //{
            //    btnSearch.Enabled = true;
            //}
        }
    }
}