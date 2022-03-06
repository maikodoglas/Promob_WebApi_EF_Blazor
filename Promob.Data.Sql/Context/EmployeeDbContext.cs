using Microsoft.EntityFrameworkCore;
using Promob.Model.Entities;

namespace Promob.Data.Sql.Context
{
    public class EmployeeDbContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }

        public EmployeeDbContext(DbContextOptions<EmployeeDbContext> options) : base(options) { }
    }
}