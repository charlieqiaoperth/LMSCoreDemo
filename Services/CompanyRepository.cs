using LMSCoreDemo.Data;
using LMSCoreDemo.Entityies;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LMSCoreDemo.Services
{
    public class CompanyRepository : ICompanyRepository
    {
        private readonly LMSCoreDemoDbContext _context;
        public CompanyRepository(LMSCoreDemoDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }
        public async Task<IEnumerable<Company>> GetCompanies()
        {
            return await _context.Companies.ToListAsync();
        }

        public async Task<Company> GetCompanyById(Guid companyId)
        {
            if (companyId==null)
            {
                throw new ArgumentNullException(nameof(companyId));
            }
            return await _context.Companies.FirstOrDefaultAsync(x => x.Id == companyId);
        }


        public async Task<IEnumerable<Company>> GetCompanies(IEnumerable<Guid> companyIds)
        {
            if (companyIds == null)
            {
                throw new ArgumentNullException(nameof(companyIds));
            }
            return await _context.Companies
                .Where(x=>x.companyId.Contains(companyIds))
        }

        public void AddCompany(Company company)
        {
            if (company==null)
            {
                throw new ArgumentNullException(nameof(company));
            }
            company.Id = Guid.NewGuid();
            _context.Companies.Add(company);
        }

        public void AddEmployee(Guid companyId, Employee employee)
        {
            if (companyId == null)
            {
                throw new ArgumentNullException(nameof(companyId));
            }
            if (employee == null)
            {
                throw new ArgumentNullException(nameof(employee));
            }
            employee.Id = Guid.NewGuid();
            _context.employees.Add(employee);
        }

        public async Task<bool> CompanyExists(Guid companyId)
        {

            if (companyId == Guid.Empty)
            {
                throw new ArgumentNullException(nameof(companyId));
            }

            return await _context.Companies.AnyAsync(x => x.Id == companyId);
        }

        public void DeleteCompany(Company Company)
        {
            throw new NotImplementedException();
        }

        public void DeleteEmpolyee(Employee Employee)
        {
            throw new NotImplementedException();
        }

        public Task<Employee> GetEmployee()
        {
            throw new NotImplementedException();
        }

        public Task<Employee> GetEmployeeById(Guid employeeId)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> SaveAysc()
        {
            return await _context.SaveChangesAsync() > 0;
        }

        public void UpdateCompany(Company Company)
        {
            throw new NotImplementedException();
        }

        public void UpdateEmployee(Employee Employee)
        {
            throw new NotImplementedException();
        }
    }
}
