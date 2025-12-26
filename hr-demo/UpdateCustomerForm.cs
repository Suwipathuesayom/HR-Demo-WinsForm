using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using hr_demo.domain.Dtos;
using hr_demo_data;

namespace hr_demo
{
    public partial class UpdateCustomerForm : Form
    {
        private readonly ApplicationDbContext _context;
        private readonly int CusomerId;
        public CustomerDto? CreatedCustomerDto { get; private set; }
        public UpdateCustomerForm(ApplicationDbContext context, int id)
        {
            InitializeComponent();
            _context = context;
            Load += UpdateCustomerForm_Load;
            CusomerId = id;
        }

        private void UpdateCustomerForm_Load(object? sender, EventArgs e)
        {
            var readId = this.
            txtIdRead.Text = CusomerId.ToString();
            var customer = _context.Customers.Find(CusomerId);
            if (customer != null)
            {
                txtFirstName.Text = customer.FirstName;
                txtLastName.Text = customer.LastName;
            }
        }

        private async void txtUpdate_Click(object sender, EventArgs e)
        {

            CreatedCustomerDto = new CustomerDto
            {
                Id = CusomerId,
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text
            };
            var customer = _context.Customers.Find(CusomerId);
            if (customer != null)
            {
                customer.FirstName = CreatedCustomerDto.FirstName;
                customer.LastName = CreatedCustomerDto.LastName;
            }
            await _context.SaveChangesAsync();
            this.DialogResult = DialogResult.OK;
            this.Close();

        }
    }
}
