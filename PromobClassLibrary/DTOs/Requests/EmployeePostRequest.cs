using System;

namespace Promob.Model.DTOs.Requests
{
    public class EmployeePostRequest
    {
        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public DateTime? BirthDate { get; set; }

        public decimal MyDecimalField { get; set; }

        public bool? AmIHappy { get; set; }
    }
}