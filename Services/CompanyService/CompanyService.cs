using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using start_csharp.Models;
using tutorial_csharp.Dtos.Company;
using tutorial_csharp.Models;
using tutorial_csharp.Data;
using Microsoft.EntityFrameworkCore;

namespace tutorial_csharp.Services.CompanyService
{
    public class CompanyService : ICompanyService
    {
        // private static List<Company> companies = new List<Company> {
        //     new Company(),
        //     new Company {Id = 1, Name = "Alan", LegalName="Legal Alan"},
        // };

        private readonly IMapper _mapper;
        private readonly TutorialDbContext _context;

        public CompanyService(IMapper mapper, TutorialDbContext context)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<ServiceResponse<GetCompanyDto>> AddCompany(AddCompanyDto newCompany)
        {   
            ServiceResponse<GetCompanyDto> response = new ServiceResponse<GetCompanyDto>();
            var company = _mapper.Map<Company>(newCompany);

            var dbCompany = await _context.Companies.AddAsync(company);
            
            // company.Id = companies.Max(x => x.Id) + 1;
            // companies.Add(company);
            
            // response.Data = _context.Companies.Select(c => _mapper.Map<GetCompanyDto>(c)).ToList();
            response.Data = _mapper.Map<GetCompanyDto>(dbCompany.Entity);
            
            return response;
        }

        public async Task<ServiceResponse<List<GetCompanyDto>>> GetAllCompanies()
        {
            ServiceResponse<List<GetCompanyDto>> response = new ServiceResponse<List<GetCompanyDto>>();
            
            var dbCompany = await _context.Companies.ToListAsync();
            response.Data = dbCompany.Select(c => _mapper.Map<GetCompanyDto>(c)).ToList();
            
            return response;
        }

        public async Task<ServiceResponse<GetCompanyDto>> GetCompanyById(int id)
        {
            ServiceResponse<GetCompanyDto> response = new ServiceResponse<GetCompanyDto>();

            var dbCompany = await _context.Companies.FirstOrDefaultAsync(c => c.Id == id);
            // var company = companies.FirstOrDefault(x => x.Id == id);
            response.Data = _mapper.Map<GetCompanyDto>(dbCompany);
            
            return response;
        }
    }
}