using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PromobClassLibrary;
using PromobWebAPI.Data;
using System.Globalization;

namespace PromobWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly EmployeeDbContext _context;

        public EmployeeController(EmployeeDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Employee>>> GetEmployees()
        {
            return Ok(await _context.Employees.ToListAsync());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Employee>> GetEmployee(long id)
        {
            Employee? employee = await _context.Employees.FindAsync(id);
            if (employee == null)
                return NotFound();

            return Ok(employee);
        }

        [HttpGet("name/{name}")]
        public async Task<ActionResult<IEnumerable<Employee>>> GetEmployeesByName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                return BadRequest("Name is empty");

            return Ok(await _context.Employees.Where(r => r.FirstName.Trim().ToLower().Contains(name.Trim().ToLower())).ToListAsync());
        }

        [HttpGet("happy/{happy:bool?}")]
        public async Task<ActionResult<IEnumerable<Employee>>> GetEmployeesByName(bool? happy)
        {
            return Ok(await _context.Employees.Where(r => r.AmIHappy == happy).ToListAsync());
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> PutEmployee(long id, [FromBody]Employee employee)
        {
            if (id != employee.Id)
                return BadRequest();

            _context.Entry(employee).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EmployeeExists(id))
                    return NotFound();

                throw;
            }

            return Ok(employee);
        }

        [HttpPost]
        public async Task<ActionResult<Employee>> PostEmployee(Employee employee)
        {
            _context.Employees.Add(employee);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetEmployee", new { id = employee.Id }, employee);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Employee>> DeleteEmployee(long id)
        {
            Employee? employee = await _context.Employees.FindAsync(id);
            if (employee == null)
                return NotFound();

            _context.Employees.Remove(employee);
            await _context.SaveChangesAsync();

            return Ok();
        }

        private bool EmployeeExists(long id) => _context.Employees.Any(r => r.Id == id);
    }
}
