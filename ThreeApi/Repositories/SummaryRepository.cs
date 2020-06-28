using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Three.Models;
using Three.Services;

namespace ThreeApi.Repositories
{
    public class SummaryRepository: ISummaryRepository
    {
        private readonly IDepartmentRepository _departmentRepository;

        public SummaryRepository(IDepartmentRepository departmentRepository)
        {
            _departmentRepository = departmentRepository;
        }

        public Task<CompanySummary> GetCompanySummary()
        {
            return Task.Run(() =>
            {
                var all = _departmentRepository.GetAll().Result;
                return new CompanySummary
                {
                    EmployeeCount = all.Sum(x => x.EmployeeCount),
                    AverageDepartmentEmployeeCount = (int)all.Average(x => x.EmployeeCount)
                };
            });
        }
    }
}
