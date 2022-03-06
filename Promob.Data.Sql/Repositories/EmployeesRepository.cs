using Microsoft.EntityFrameworkCore;
using Promob.Data.Sql.Abstractions.Repositories;
using Promob.Data.Sql.Context;
using Promob.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Promob.Data.Sql.Repositories
{
    internal sealed class EmployeesRepository : IEmployeesRepository
    {
        private readonly EmployeeDbContext _dbContext;

        public EmployeesRepository(EmployeeDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<Employee>> Get()
        {
            return await _dbContext.Employees.ToListAsync();
        }

        public async Task<Employee> Get(int Id)
        {
            if (Id <= 0)
                throw new ArgumentOutOfRangeException(nameof(Id));

            return await _dbContext.Employees.FindAsync(Id);
        }

        public IQueryable<Employee> GetOdata()
        {
            return _dbContext.Employees.AsQueryable();
        }

        public async Task InsertAsync(Employee employee)
        {
            if (employee is null)
                throw new ArgumentNullException(nameof(employee));

            await _dbContext.Employees.AddAsync(employee);
        }
    }
}