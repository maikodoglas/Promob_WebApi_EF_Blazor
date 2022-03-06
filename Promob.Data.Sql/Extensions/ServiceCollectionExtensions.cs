using Microsoft.Extensions.DependencyInjection;
using Promob.Data.Sql.Abstractions.Repositories;
using Promob.Data.Sql.Context;
using Promob.Data.Sql.Repositories;

namespace Promob.Data.Sql.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static void AddSqlServer(this IServiceCollection services)
        {
            services.AddDbContext<EmployeeDbContext>(option =>
            option.UseSqlServer());
        }

        public static void AddDataDependencies(this IServiceCollection services)
        {
            services.AddScoped<IEmployeesRepository, EmployeesRepository>();
        }
    }
}