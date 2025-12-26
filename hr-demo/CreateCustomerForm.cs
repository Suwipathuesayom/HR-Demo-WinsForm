using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using hr_demo.domain.Dtos;
using hr_demo.domain.Models;
using hr_demo_data;

namespace hr_demo
{
    public partial class CreateCustomerForm : Form
    {
        private readonly ApplicationDbContext _context;
        public string companyName = "Default Company";
        private BindingList<CompanyDto> _customersBinding = new BindingList<CompanyDto>();
        public CustomerDto? CreatedCustomerDto { get; private set; }
        public CreateCustomerForm(ApplicationDbContext context)
        {
            InitializeComponent();
            _context = context;
            txtNumberKeyPress();
            loadCompanies();
            txtSelectCompanies.DoubleClick += TxtSelectCompanies_DoubleClick;
        }

        private void txtNumberKeyPress()
        {
            var regex = new Regex(@"^[0-9]+$");
            txtPastalCode.KeyPress += (s, ev) =>
            {
                if (!char.IsControl(ev.KeyChar) && !regex.IsMatch(ev.KeyChar.ToString()))
                {
                    ev.Handled = true;
                }
            };
            txtPhoneNumber.KeyPress += (s, ev) =>
            {
                if (!char.IsControl(ev.KeyChar) && !regex.IsMatch(ev.KeyChar.ToString()))
                {
                    ev.Handled = true;
                }
            };
        }


        private void loadCompanies()
        {
            _customersBinding.Clear();
            var companies = _context.Companies
                .Select(c => new CompanyDto
                {
                    Id = c.Id,
                    Name = c.Name,
                    Industry = c.Industry,
                    Website = c.Website
                })
                .OrderBy(c => c.Name)
                .ToList();
            foreach (var company in companies)
            {
                _customersBinding.Add(company);
            }

            txtSelectCompanies.DataSource = null;
            txtSelectCompanies.DataSource = _customersBinding;
            txtSelectCompanies.DisplayMember = "Name";
            txtSelectCompanies.ValueMember = "Id";
            txtSelectCompanies.SelectedIndex = -1;
            txtSelectCompanies.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private async void TxtSelectCompanies_DoubleClick(object? sender, EventArgs e)
        {
            var addForm = new AddCompanyForm(_context);
            if (addForm.ShowDialog() == DialogResult.OK && addForm.CreatedCompanyDto != null)
            {
                var dto = addForm.CreatedCompanyDto;
                _customersBinding.Add(dto);
                txtSelectCompanies.SelectedItem = dto;
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            string email = txtEmail.Text;
            string phoneNumber = txtPhoneNumber.Text;

            string street = txtStreet.Text;
            string city = txtCity.Text;
            string state = txtState.Text;
            string pastalCode = txtPastalCode.Text;

            //var companyName = txtCompanyName.Text;
            var industry = txtIndusty.Text;
            var website = txtWebsite.Text;


            if (!string.IsNullOrEmpty(firstName) && !string.IsNullOrEmpty(lastName) &&
                !string.IsNullOrEmpty(email) &&
                !string.IsNullOrEmpty(phoneNumber) &&
                !string.IsNullOrEmpty(street) && !string.IsNullOrEmpty(city) &&
                !string.IsNullOrEmpty(state) && !string.IsNullOrEmpty(pastalCode))
            {
                var selectedCompanyDto = txtSelectCompanies.SelectedItem as CompanyDto;

                var customer = new Customer
                {
                    FirstName = firstName,
                    LastName = lastName,
                    Email = email,
                    PhoneNumber = phoneNumber,
                    Address = new Address
                    {
                        Street = street,
                        City = city,
                        State = state,
                        PostalCode = pastalCode
                    }
                };

                if (selectedCompanyDto != null)
                {
                    customer.CompanyId = selectedCompanyDto.Id;
                }
                else
                {
                    var company = new Company
                    {
                        Name = companyName,
                        Industry = industry,
                        Website = website
                    };
                    customer.Company = company;
                }

                await _context.Customers.AddAsync(customer);
                await _context.SaveChangesAsync();

                CreatedCustomerDto = new CustomerDto
                {
                    FirstName = customer.FirstName,
                    LastName = customer.LastName,
                    Email = customer.Email,
                    PhoneNumber = customer.PhoneNumber,
                };

                MessageBox.Show("Customer created successfully!");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Please fill in all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
