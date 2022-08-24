using System.ComponentModel.DataAnnotations;

namespace testone.Models
{
    public class Employee
    {

        [Key]
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string Department { get; set; }
        public string DateOfJoining { get; set; }
        public string PhotoFileName { get; set; }
    }
}
