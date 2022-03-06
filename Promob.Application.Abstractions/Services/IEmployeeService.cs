using Promob.Model.DTOs.Requests;
using Promob.Model.DTOs.Responses;
using System.Threading.Tasks;

namespace Promob.Application.Abstractions.Services
{
    public interface IEmployeeService
    {
        Task<EmployeeGetResponse> GetEmployeeAsync(int id);

        Task<EmployeeGetResponse> InsertAsync(EmployeePostRequest postRequest);
    }
}