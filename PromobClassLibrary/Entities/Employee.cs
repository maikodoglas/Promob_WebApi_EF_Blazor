using System;

namespace Promob.Model.Entities
{
    public class Employee
    {
        public long Id { get; set; }

        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public DateTime? BirthDate { get; set; }

        public decimal MyDecimalField { get; set; }

        public bool? AmIHappy { get; set; }

        public Employee(
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

        public Employee(
            string? firstName,
            string? lastName,
            DateTime? birthDate,
            decimal myDecimalField,
            bool? amIHappy)
        {
            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthDate;
            MyDecimalField = myDecimalField;
            AmIHappy = amIHappy;
        }
    }
}