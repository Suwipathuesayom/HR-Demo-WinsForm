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
using hr_demo.domain.Models;
using hr_demo_data;

namespace hr_demo
{
    public partial class UsersForm : Form
    {
        private readonly ApplicationDbContext _context;

        private BindingList<CustomerDto> _customersBinding = new BindingList<CustomerDto>();
        public UsersForm(ApplicationDbContext context)
        {
            InitializeComponent();
            _context = context;
            LoadCustomers();
        }



        private void LoadCustomers()
        {
            var customers = _context.Customers
                .Select(c => new CustomerDto
                {
                    Id = c.CusId,
                    FirstName = c.FirstName,
                    LastName = c.LastName,
                    Email = c.Email,
                    PhoneNumber = c.PhoneNumber
                })
                .ToList();
            _customersBinding = new BindingList<CustomerDto>(customers);
            dataListShowCustomer.DataSource = _customersBinding;
            txtTotal.Text = customers.Count.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var createCustomerForm = new CreateCustomerForm(_context);
            if (createCustomerForm.ShowDialog() == DialogResult.OK)
            {
                LoadCustomers();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataListShowCustomer.CurrentRow != null)
            {
                var selectedCustomer = (CustomerDto)dataListShowCustomer.CurrentRow.DataBoundItem;
                var updateCustomerForm = new UpdateCustomerForm(_context, selectedCustomer.Id);
                updateCustomerForm.ShowDialog();
                LoadCustomers();
            }
            else
            {
                MessageBox.Show("Please select a customer to update.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataListShowCustomer.CurrentRow != null)
            {
                var selectedCustomer = (CustomerDto)dataListShowCustomer.CurrentRow.DataBoundItem;
                var customer = _context.Customers.Find(selectedCustomer.Id);
                if (customer != null)
                {
                    var confirmResult = MessageBox.Show($"Are you sure to delete customer {customer.FirstName} {customer.LastName}?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (confirmResult == DialogResult.Yes)
                    {
                        _context.Customers.Remove(customer);
                        await _context.SaveChangesAsync();
                        LoadCustomers();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a customer to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnAddCompany_Click(object sender, EventArgs e)
        {
            var createCompanyForm = new AddCompanyForm(_context);
            if (createCompanyForm.ShowDialog() == DialogResult.OK)
            {
                LoadCustomers();
            }
        }
    }
}
