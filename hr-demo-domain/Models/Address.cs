using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace hr_demo.domain.Models
{
    public class Address
    {
        [Key]
        [ForeignKey(nameof(Customer))] 
        public int CusId { get; set; } 
        [Required(ErrorMessage = "Street is required.")]
        public string Street { get; set; } = string.Empty;
        [Required(ErrorMessage = "City is required.")]
        public string City { get; set; } = string.Empty;
        [Required(ErrorMessage = "State is required.")]
        public string State { get; set; } = string.Empty;
        [Required(ErrorMessage = "Postal Code is required.")]
        [MaxLength(7, ErrorMessage = "Postal Code cannot exceed 7 characters.")]
        public string PostalCode { get; set; } = string.Empty;

        public Customer? Customer { get; set; }
    }
}
