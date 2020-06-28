namespace ThreeBlazor.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public int DepartmentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool Fired { get; set; }

        public Gender Gender { get; set; }
    }

    public enum Gender
    {
        Female = 0,
        Male = 1
    }
}
