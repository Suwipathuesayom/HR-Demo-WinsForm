
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace hr_demo.domain.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Username { get; set; } = string.Empty;

        [Required]
        [MaxLength(100)]
        public string? FirstName { get; set; }

        [Required]
        [MaxLength(100)]
        public string? LastName { get; set; }

        [Required]
        [EmailAddress]
        public string? Email { get; set; }

        [Required]
        [MaxLength(255)]
        public string? Password { get; set; }

        [Required]
        public string? Role { get; set; } = "Employee"; // Admin, HR, Manager, Employee

        // --- HR Core Fields ---
        [Required]
        public DateTime BirthDate { get; set; }

        [Required]
        public DateTime HireDate { get; set; }

        public bool IsActive { get; set; } = true;
        public string? PhoneNumber { get; set; }
        public string? ProfileImage { get; set; }

        // --- Foreign Keys (เชื่อมโยงไปตารางอื่น) ---
        public int? DepartmentId { get; set; }
        [ForeignKey("DepartmentId")]
        public virtual Department? Department { get; set; }

        public int? PositionId { get; set; }
        [ForeignKey("PositionId")]
        public virtual Position? Position { get; set; }

        // --- Navigation Properties (สำหรับดึงข้อมูลการลา/เวลาเข้างาน) ---
        public virtual ICollection<Attendance>? Attendances { get; set; }
        public virtual ICollection<LeaveRequest>? LeaveRequests { get; set; }

        // --- Helper Properties ---
        [NotMapped]
        public string FullName => $"{FirstName} {LastName}";

        [NotMapped]
        public int YearsOfService => DateTime.Now.Year - HireDate.Year;

        public string? JobTitle { get; set; }
        public string BankInfo { get; set; }

        public User() { }
    }
}