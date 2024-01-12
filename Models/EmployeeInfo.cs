using System.ComponentModel.DataAnnotations;

namespace RonwellProject.Models
{
    public class EmployeeInfo
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public int EmployeeId { get; set; }
        public string Position { get; set; }
        public decimal Salary { get; set; }

    }
}
