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
    public class Position
    {
        [Key]
        public int Id { get; set; }
        [Required, MaxLength(100)]
        public string Title { get; set; } = string.Empty;
        [Column(TypeName = "decimal(18,2)")]
        public decimal BasicSalary { get; set; }
        public virtual ICollection<User>? Users { get; set; }
    }
}
