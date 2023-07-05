using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using start_csharp.Models;
using tutorial_csharp.Dtos.Company;
using tutorial_csharp.Models;

namespace tutorial_csharp.Services.CompanyService
{
    public class CompanyService : ICompanyService
    {
        private static List<Company> companies = new List<Company> {
            new Company(),
            new Company {Id = 1, Name = "Alan", LegalName="Legal Alan"},
        };

        private readonly IMapper _mapper;

        public CompanyService(IMapper mapper)
        {
            _mapper = mapper;
        }

        public async Task<ServiceResponse<List<GetCompanyDto>>> AddCompany(AddCompanyDto newCompany)
        {   
            ServiceResponse<List<GetCompanyDto>> response = new ServiceResponse<List<GetCompanyDto>>();
            var company = _mapper.Map<Company>(newCompany);
            company.Id = companies.Max(x => x.Id) + 1;
            companies.Add(company);
            response.Data = companies.Select(c => _mapper.Map<GetCompanyDto>(c)).ToList();
            
            return response;
        }

        public async Task<ServiceResponse<List<GetCompanyDto>>> GetAllCompanies()
        {
            ServiceResponse<List<GetCompanyDto>> response = new ServiceResponse<List<GetCompanyDto>>();
            response.Data = companies.Select(c => _mapper.Map<GetCompanyDto>(c)).ToList();
            
            return response;
        }

        public async Task<ServiceResponse<GetCompanyDto>> GetCompanyById(int id)
        {
            ServiceResponse<GetCompanyDto> response = new ServiceResponse<GetCompanyDto>();

            var company = companies.FirstOrDefault(x => x.Id == id);
            response.Data = _mapper.Map<GetCompanyDto>(company);
            
            return response;
        }
    }
}