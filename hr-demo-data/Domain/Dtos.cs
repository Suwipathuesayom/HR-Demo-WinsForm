namespace hr_demo_data.Dtos
{
 public class CustomerDto
 {
 public int Id { get; set; }
 public string FirstName { get; set; } = string.Empty;
 public string LastName { get; set; } = string.Empty;
 public string Email { get; set; } = string.Empty;
 public string PhoneNumber { get; set; } = string.Empty;
 }

 public class CompanyDto
 {
 public int Id { get; set; }
 public string Name { get; set; } = string.Empty;
 public string Industry { get; set; } = string.Empty;
 public string Website { get; set; } = string.Empty;
 }
}
