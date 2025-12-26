using hr_demo_data;
using Microsoft.EntityFrameworkCore;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace hr_demo
{
    public partial class SignIn : Form
    {
        private readonly ApplicationDbContext _context;
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;

        public SignIn(ApplicationDbContext context)
        {
            _context = context;
            InitializeComponent();
            txtUsername.Text = "admin";
            txtPassword.Text = "admin123";

            if (lblSignUp != null)
                lblSignUp.Click += LblSignUp_Click;
            this.MouseDown += SignIn_MouseDown;
        }
        private void SignIn_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private async void btnLogIn_Click(object sender, EventArgs e)
        {
            var username = txtUsername.Text;
            var password = txtPassword.Text;
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter both username and password.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var user = await _context.Users.FirstOrDefaultAsync(u => u.Username == username && u.Password == password);

            if (user != null)
            {
                MessageBox.Show($"Welcome, {user.FirstName}!", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                var dashboard = new DashboardForm(_context);
                dashboard.ShowDialog();
            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LblSignUp_Click(object? sender, EventArgs e)
        {
            var signUp = new SignUp(_context);
            signUp.ShowDialog();
        }

    
    }
}
