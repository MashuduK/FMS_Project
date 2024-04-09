namespace FMS_Project.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public int LocationId { get; set; }
        public Location? Location { get; set; }
        public EmployeeType Type { get; set; }
    }
}
