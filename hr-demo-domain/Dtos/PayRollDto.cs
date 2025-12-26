using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hr_demo.domain.Dtos
{
    public class PayRollDto
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; } = string.Empty;
        public decimal Salary { get; set; }
        public decimal Bonuses { get; set; }
        public decimal Deductions { get; set; }
        public DateTime PayDate { get; set; }
    }
}
