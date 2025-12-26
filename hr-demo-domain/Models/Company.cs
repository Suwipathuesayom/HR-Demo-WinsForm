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
    public class Company
    {
        [Key]
        public int Id { get; set; } 
        [Required(ErrorMessage = "Name is required.")]
        public string Name { get; set; } = string.Empty;
        [Required(ErrorMessage = "Industry is required.")]
        public string Industry { get; set; } = string.Empty;
        [Required(ErrorMessage = "Website is required.")]
        public string Website { get; set; } = string.Empty;

        public ICollection<Customer>? Customers { get; set; }
    }
}
