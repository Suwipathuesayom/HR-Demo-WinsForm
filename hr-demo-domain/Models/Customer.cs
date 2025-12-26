using hr_demo.domain.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace hr_demo.domain.Models
{
    public class Customer
    {
        [Key]
        public int CusId { get; set; } 
        [Required(ErrorMessage = "First Name is required.")]
        public string FirstName { get; set; } = string.Empty;
        [Required(ErrorMessage = "Last Name is required.")]
        public string LastName { get; set; } = string.Empty;
        [Required(ErrorMessage = "Email is required.")] 
        public string Email { get; set; } = string.Empty;
        [Required(ErrorMessage = "Phone Number is required.")]
        [MaxLength(10, ErrorMessage = "Phone Number cannot exceed 10 characters.")]
        public string PhoneNumber { get; set; } = string.Empty;

        // --- One-to-One (กับ Address) ---
        public Address? Address { get; set; }


        [ForeignKey(nameof(Company))]
        public int CompanyId { get; set; } 

        public Company? Company { get; set; }
    }
}
