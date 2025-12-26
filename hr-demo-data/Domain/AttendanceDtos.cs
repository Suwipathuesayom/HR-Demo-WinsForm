namespace hr_demo_data.Dtos
{
 public class AttendanceSummaryDto
 {
 public int EmployeeId { get; set; }
 public string FullName { get; set; } = string.Empty;
 public string DepartmentName { get; set; } = string.Empty;
 public TimeSpan? CheckIn { get; set; }
 public string Status { get; set; } = string.Empty;
 }
}
