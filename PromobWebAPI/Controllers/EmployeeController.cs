using Microsoft.AspNetCore.Mvc;
using Promob.Application.Abstractions.Services;
using Promob.Model.DTOs.Requests;
using Promob.Model.DTOs.Responses;

namespace PromobWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        [HttpGet("{id:int}")]
        [ProducesResponseType(typeof(EmployeeGetResponse), 200)]
        public async Task<ActionResult> GetEmployee(int id)
        {
            if (id <= 0)
                return BadRequest();

            var employee = await _employeeService.GetEmployeeAsync(id);

            if (employee is null)
                return NotFound();

            return Ok(employee);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] EmployeePostRequest employee)
        {
            if (employee is null)
                return BadRequest();

            var result = await _employeeService.InsertAsync(employee);

            return CreatedAtAction("GetEmployee", new { id = result.Id }, result);
        }
    }
}