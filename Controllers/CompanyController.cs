using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using start_csharp.Models;

namespace csharp_tutorial.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CompanyController : ControllerBase
    {
        [HttpGet]
        public ActionResult<Company> Get() {
            
            Company ss = new();
            return Ok(ss);
        }

        [HttpGet("GetAll")]
        public ActionResult<List<Company>> GetList() {

            List<Company> ss = new List<Company>() { new Company(), new Company() };
            return Ok(ss);

        }

        [HttpGet("{id}")]
        public ActionResult<Company> GetSingle(int id) {
            //done
            if (id == 1) {
                return Ok(new Company());
            } else if (id == 2) {
                return Ok("I love my company");
            }
            else {
                return BadRequest("Please Provide a valid ID");
            }
        }

        [HttpPost]
        public ActionResult<Company> AddCompany() {
            //ss
            return Ok("Added");
        }
    }
}