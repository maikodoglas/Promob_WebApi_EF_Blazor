using Promob.Model.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Promob.Data.Sql.Abstractions.Repositories
{
    public interface IEmployeesRepository
    {
        IQueryable<Employee> GetOdata();

        Task<IEnumerable<Employee>> Get();

        Task<Employee> Get(int Id);

        Task InsertAsync(Employee employee);
    }
}