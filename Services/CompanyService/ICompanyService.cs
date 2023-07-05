using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using start_csharp.Models;
using tutorial_csharp.Dtos.Company;
using tutorial_csharp.Models;

namespace tutorial_csharp.Services.CompanyService
{
    public interface ICompanyService
    {
        Task<ServiceResponse<List<GetCompanyDto>>> GetAllCompanies();
        Task<ServiceResponse<GetCompanyDto>> GetCompanyById(int id);
        Task<ServiceResponse<List<GetCompanyDto>>> AddCompany(AddCompanyDto newCompany);

    }
}