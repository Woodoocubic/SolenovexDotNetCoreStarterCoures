using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using gRPCApi;
using Microsoft.AspNetCore.Components;
using ThreeBlazor.Services;

namespace ThreeBlazor.Pages
{
    public class EmployeeViewModel: ComponentBase
    {
        [Parameter]
        public string DepartmentId { get; set; }

        public IEnumerable<gRPCApi.Employee>  Employees;

        [Inject]
        protected IEmployeeService EmployeeService { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Employees = await EmployeeService.GetByDepartmentId(int.Parse(DepartmentId));
        }
    }
}
