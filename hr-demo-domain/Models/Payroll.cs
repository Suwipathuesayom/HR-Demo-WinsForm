using hr_demo.domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hr_demo.domain.Models
{
    public class Payroll
    {
        [Key]
        public int Id { get; set; }
        public int UserId { get; set; }
        [ForeignKey("UserId")]
        public virtual User? User { get; set; }

        public int Month { get; set; }
        public int Year { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal BasicSalary { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal Bonus { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal Deductions { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal NetSalary { get; set; }
        public DateTime PaymentDate { get; set; }
        public bool IsPaid { get; set; } = false;
    }
}
