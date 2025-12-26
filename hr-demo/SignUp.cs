using hr_demo.domain.Models;
using hr_demo_data;
using System.ComponentModel;
using System.Windows.Forms;

namespace hr_demo
{
    public partial class SignUp : Form
    {
        private readonly ApplicationDbContext _context;
        public SignUp(ApplicationDbContext context)
        {
            _context = context;
            InitializeComponent();
        }

        private async void btnRegister_Click(object sender, EventArgs e)
        {
            var user = new User
            {
                FirstName = txtFirstname.Text,
                LastName = textLastname.Text,
                Email = txtEmail.Text,
                Username = txtUsername.Text,
                Password = txtPassword.Text,
                Role = "User"
            };

            if (string.IsNullOrWhiteSpace(user.Username) || string.IsNullOrWhiteSpace(user.Password))
            {
                MessageBox.Show("Username and Password are required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();
            MessageBox.Show("User registered successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
            var signIn = new SignIn(_context);
            signIn.ShowDialog();
        }

        private void lblSignUp_Click(object sender, EventArgs e)
        {
            this.Close();
            var signIn = new SignIn(_context);
            signIn.ShowDialog();
        }
    }
}
