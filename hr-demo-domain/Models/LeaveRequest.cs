using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace hr_demo.domain.Models
{
    // การขอลาพักร้อน/ลาป่วย
    public class LeaveRequest
    {
        [Key]
        public int Id { get; set; }
        public int UserId { get; set; }
        [ForeignKey("UserId")]
        public virtual User? User { get; set; }

        [Required]
        public string LeaveType { get; set; } = "Vacation"; // Vacation, Sick, Personal
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Reason { get; set; } = string.Empty;
        public string Status { get; set; } = "Pending"; // Pending, Approved, Rejected
        public int? ApprovedBy { get; set; } // UserId ของ Manager ที่อนุมัติ
    }
}
