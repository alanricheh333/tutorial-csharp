using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using start_csharp.Models;
using tutorial_csharp.Dtos.Company;

namespace tutorial_csharp
{
    public class AutoMapperProfile: Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Company, GetCompanyDto>();
            CreateMap<AddCompanyDto, Company>();
        }
    }
}