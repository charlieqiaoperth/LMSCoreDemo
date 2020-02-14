using LMSCoreDemo.Entityies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LMSCoreDemo.Services
{
    interface ICompanyRepository
    {
        // company
        Task<IEnumerable<Company>> GetCompanies();
        Task<Company> GetCompanyById(Guid companyId);
        Task<IEnumerable<Company>> GetCompanies(IEnumerable<Guid> companyIds);
        void AddCompany(Company company);
        void UpdateCompany(Company company);
        void DeleteCompany(Company company);
        Task<bool> CompanyExists(Guid companyId);

        // Employee
        Task<Employee> GetEmployee();
        Task<Employee> GetEmployeeById(Guid employeeId);
        void AddEmployee(Guid companyId, Employee employee);
        void UpdateEmployee(Employee employee);
        void DeleteEmpolyee(Employee employee);

        //save to database
        Task<bool> SaveAysc();
    }
}
