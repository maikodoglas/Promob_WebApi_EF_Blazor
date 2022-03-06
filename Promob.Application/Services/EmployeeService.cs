using Promob.Application.Abstractions.Services;
using Promob.Data.Sql.Abstractions.Repositories;
using Promob.Model.DTOs.Requests;
using Promob.Model.DTOs.Responses;
using Promob.Model.Entities;
using System;
using System.Threading.Tasks;

namespace Promob.Application.Services
{
    internal class EmployeeService : IEmployeeService
    {
        private readonly IEmployeesRepository _employeesRepository;

        public EmployeeService(IEmployeesRepository employeesRepository)
        {
            _employeesRepository = employeesRepository;
        }

        public async Task<EmployeeGetResponse> GetEmployeeAsync(int id)
        {
            if (id <= 0)
                throw new ArgumentOutOfRangeException("id");

            var employee = await _employeesRepository.Get(id);

            return new EmployeeGetResponse(employee);
        }

        public async Task<EmployeeGetResponse> InsertAsync(EmployeePostRequest postRequest)
        {
            if (postRequest is null)
                throw new ArgumentOutOfRangeException();

            var employee = new Employee(
                postRequest.FirstName,
                postRequest?.LastName,
                postRequest.BirthDate,
                postRequest.MyDecimalField,
                postRequest.AmIHappy);

            await _employeesRepository.InsertAsync(employee);

            return new EmployeeGetResponse(employee);
        }
    }
}