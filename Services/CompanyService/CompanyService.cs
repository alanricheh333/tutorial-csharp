using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using start_csharp.Models;
using tutorial_csharp.Models;

namespace tutorial_csharp.Services.CompanyService
{
    public class CompanyService : ICompanyService
    {
        private static List<Company> companies = new List<Company> {
            new Company(),
            new Company {Id = 1, Name = "Alan", LegalName="Legal Alan"},
        };
        public async Task<ServiceResponse<List<Company>>> AddCompany(Company newCompany)
        {   
            ServiceResponse<List<Company>> response = new ServiceResponse<List<Company>>();
            companies.Add(newCompany);
            response.Data = companies;
            
            return response;
        }

        public async Task<ServiceResponse<List<Company>>> GetAllCompanies()
        {
            ServiceResponse<List<Company>> response = new ServiceResponse<List<Company>>();
            response.Data = companies;
            
            return response;
        }

        public async Task<ServiceResponse<Company>> GetCompanyById(int id)
        {
            ServiceResponse<Company> response = new ServiceResponse<Company>();

            response.Data = companies.FirstOrDefault(x => x.Id == id);
            
            return response;
        }
    }
}