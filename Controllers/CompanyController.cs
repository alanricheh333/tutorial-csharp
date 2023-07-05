using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using start_csharp.Models;
using tutorial_csharp.Dtos.Company;
using tutorial_csharp.Models;
using tutorial_csharp.Services.CompanyService;

namespace csharp_tutorial.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CompanyController : ControllerBase
    {
        private readonly ICompanyService companyService;

        public CompanyController(ICompanyService companyService)
        {
            this.companyService = companyService;
        }

        [HttpGet("GetAll")]
        public async Task<ActionResult<ServiceResponse<List<GetCompanyDto>>>> Get() {

            return Ok(await this.companyService.GetAllCompanies());

        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ServiceResponse<GetCompanyDto>>> GetSingle(int id) {
            
            return Ok(await this.companyService.GetCompanyById(id));
        }

        [HttpPost]
        public async Task<ActionResult<ServiceResponse<List<GetCompanyDto>>>> AddCompany(AddCompanyDto newCompany) {
            
            return Ok(await this.companyService.AddCompany(newCompany));
        }
    }
}