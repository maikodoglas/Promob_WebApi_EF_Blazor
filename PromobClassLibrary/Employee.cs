using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PromobClassLibrary
{
    public class Employee
    {
        public long Id { get; set; }

        [Required]
        public string? FirstName { get; set; }
        
        public string? LastName { get; set; }

        [Required]
        public DateTime? BirthDate { get; set; }

        public decimal MyDecimalField { get; set; }

        public bool? AmIHappy { get; set; }
    }
}
