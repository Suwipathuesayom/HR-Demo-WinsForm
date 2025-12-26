using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hr_demo.domain.Dtos
{
    public class AttendanceSummaryDto
    {
        public int EmployeeId { get; set; }
        public string FullName { get; set; }
        public string DepartmentName { get; set; }
        public TimeSpan? CheckIn { get; set; }
        public string Status { get; set; }
    }
}
