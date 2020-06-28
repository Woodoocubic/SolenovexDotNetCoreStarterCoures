using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using gRPCApi;

namespace ThreeBlazor.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly Employees.EmployeesClient _client;

        public EmployeeService(Employees.EmployeesClient client)
        {
            _client = client;
        }

        public async Task Add(Employee employee)
        {
            await _client.AddEmployeeAsync(new AddEmployeeRequest
            {
                Employee = employee
            });
        }

        public async Task<Employee> Fire(int id)
        {
            var response = await _client.FireEmployeeAsync(new FireEmployeeRequest
            {
                Id = id
            });
            return response.Employee;
        }

        public async Task<IEnumerable<Employee>> GetByDepartmentId(int departmentId)
        {
            var response = await _client.GetByDepartmentIdAsync(new GetByDepartmentIdRequest()
            {
                DepartmentId = departmentId
            });
            return response.Employees;
        }
    }
}
