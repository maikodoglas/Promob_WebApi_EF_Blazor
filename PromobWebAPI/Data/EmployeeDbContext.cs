using Microsoft.EntityFrameworkCore;
using PromobClassLibrary;

namespace PromobWebAPI.Data
{
    public class EmployeeDbContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }

        public EmployeeDbContext(DbContextOptions<EmployeeDbContext> options) : base(options) { }
    }
}
