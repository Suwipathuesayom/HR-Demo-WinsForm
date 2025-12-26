using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hr_demo.domain.Dtos
{
    public class AuthDto
    {
        public string? Username { get; set; }
        public string? Password { get; set; }
        public AuthDto() { }
    }
}
