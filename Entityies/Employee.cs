using System;

namespace LMSCoreDemo.Entityies
{
    public class Employee
    {
        public Guid Id { get; set; }

        public Guid CompanyId { get; set; }

        public String EmployeeNo { get; set; }

        public String FirstName { get; set; }

        public String LastName { get; set; }

        public Gender Gender { get; set; }

        public DateTime DateOfBirth { get; set; }

        public Company Company { get; set; }
    }
}