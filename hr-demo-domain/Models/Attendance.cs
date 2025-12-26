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
    // การลงเวลาเข้า-ออก
    public class Attendance
    {
        [Key]
        public int Id { get; set; }
        public int UserId { get; set; }
        [ForeignKey("UserId")]
        public virtual User? User { get; set; }

        public DateTime Date { get; set; }
        public DateTime? ClockIn { get; set; }
        public DateTime? ClockOut { get; set; }
        public string? Status { get; set; } // เช่น On-Time, Late, Absent
        [Column(TypeName = "decimal(18,2)")]
        public decimal OvertimeHours { get; set; }
    }
}
