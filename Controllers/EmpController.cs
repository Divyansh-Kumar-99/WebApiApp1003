using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dockerapi.Models;
namespace Dockerapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpController : ControllerBase
    {
        public IActionResult Get()
        {
            var Emplist = new List<Employee>()
            {
                new Employee() {EName="Divyansh",EId=100,EDept="Development",EPno=1234567890},
                new Employee() {EName="DKumar",EId=102,EDept="Security",EPno=1234567890},
                new Employee() {EName="Dkumar2",EId=104,EDept="Management",EPno=1234567890},
                new Employee() {EName="DKumar3",EId=106,EDept="Transport",EPno=1234567890},
                new Employee() {EName="DKumar4",EId=108,EDept="FoodSupply",EPno=1234567890}
            };
            return Ok(Emplist);
        }
    }
}
