using Promob.Model.Entities;
using System;

namespace Promob.Model.DTOs.Responses
{
    public class EmployeeGetResponse
    {
        public long Id { get; }

        public string? FirstName { get; }

        public string? LastName { get; }

        public DateTime? BirthDate { get; }

        public decimal MyDecimalField { get; }

        public bool? AmIHappy { get; }

        public EmployeeGetResponse(
            long id,
            string? firstName,
            string? lastName,
            DateTime? birthDate,
            decimal myDecimalField,
            bool? amIHappy)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthDate;
            MyDecimalField = myDecimalField;
            AmIHappy = amIHappy;
        }

        public EmployeeGetResponse(Employee employee)
        {
            Id = employee.Id;
            FirstName = employee.FirstName;
            LastName = employee.LastName;
            BirthDate = employee.BirthDate;
            MyDecimalField = employee.MyDecimalField;
            AmIHappy = employee.AmIHappy;
        }
    }
}