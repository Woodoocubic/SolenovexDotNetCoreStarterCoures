using System.ComponentModel.DataAnnotations;

namespace ThreeBlazor.Models
{
    public class Department
    {
        public int Id { get; set; }
        [Display(Name = "Department Name")]
        public string Name { get; set; }
        public string Location { get; set; }
        public int EmployeeCount { get; set; }
    }
}
