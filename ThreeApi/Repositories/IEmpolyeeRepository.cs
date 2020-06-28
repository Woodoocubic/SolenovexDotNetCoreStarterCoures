using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Three.Models;

namespace Three.Services
{
    public interface IEmployeeRepository
    {
        Task<Employee> Add (Employee employee);
        Task<Employee> GetById(int id);
        Task<IEnumerable<Employee>> GetByDepartmentId(int departmentId);
        Task<Employee> Fire(int id);
    }
}
