using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Three.Models;
using Three.Services;

namespace ThreeApi.Controllers
{
    [Route("v1/[controller]")]
    [ApiController]
    public class EmployeesController:ControllerBase
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeesController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        [HttpGet("{departmentId}")]
        public async Task<IActionResult> GetByDepartmentId(int departmentId)
        {
            var employees = await _employeeRepository.GetByDepartmentId(departmentId);
            if (!employees.Any())
            {
                return NoContent();
            }

            return Ok(employees);
        }

        [HttpGet("One/{id}", Name = "GetById")]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _employeeRepository.GetById(id);
            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] Employee model)
        {
            var added = await _employeeRepository.Add(model);
            return CreatedAtRoute("GetById", new {id = added.Id}, added);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Fire(int id)
        {
            var result = await _employeeRepository.Fire(id);
            if (result != null)
            {
                return NoContent();
            }

            return NotFound();
        }
    }
}
