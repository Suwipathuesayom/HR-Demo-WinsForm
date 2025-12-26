using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace hr_demo.domain.Models
{
    // แผนก
    public class Department
    {
        [Key]
        public int Id { get; set; }
        [Required, MaxLength(100)]
        public string Name { get; set; } = string.Empty;
        public virtual ICollection<User>? Users { get; set; }
    }
}
