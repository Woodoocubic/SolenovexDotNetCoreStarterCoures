using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Three.Models
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
