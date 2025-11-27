using EmployeeMenegment.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeMenegment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        Employee[] employees = new Employee[]
        {
            new Employee{Id = 1, FirstName = "Kamil", LastName = "Rodman", Email = "Rodamn@set.pl", Phone = "872293487", Position = "Poland"}
        };
        
    };
}
