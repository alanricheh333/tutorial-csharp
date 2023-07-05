using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tutorial_csharp.Dtos.Company
{
    public class GetCompanyDto
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int StoresNumber { get; set; } = 0;
        public string? LegalName { get; set; }
    }
}