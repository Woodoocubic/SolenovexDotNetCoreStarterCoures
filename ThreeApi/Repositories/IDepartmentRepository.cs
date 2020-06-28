using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Three.Models;

namespace Three.Services
{

    public interface IDepartmentRepository
    {
        Task<IEnumerable<Department>> GetAll();
        Task<Department> GetById(int id);
        Task<Department> Add(Department department);
    }
}
