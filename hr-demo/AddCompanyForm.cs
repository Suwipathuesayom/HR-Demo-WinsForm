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
    public partial class AddCompanyForm : Form
    {
        private readonly ApplicationDbContext _context;
        public CompanyDto? CreatedCompanyDto { get; private set; }
        public AddCompanyForm(ApplicationDbContext context)
        {
            InitializeComponent();
            _context = context;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var company = new Company
            {
                Name = txtCompanyName.Text,
                Industry = txtIndustry.Text,
                Website = txtWebsite.Text
            };
            await _context.Companies.AddAsync(company);
            await _context.SaveChangesAsync();
            CreatedCompanyDto = new CompanyDto { Id = company.Id, Name = company.Name, Industry = company.Industry, Website = company.Website };
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
