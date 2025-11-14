using EmpCrud.Models;
using EmpCrud.SL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmpCrud.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpController : ControllerBase
    {
        private readonly IEmpService empService;
        public EmpController(IEmpService empservice)
        {
            this.empService = empservice;
        }
        [HttpGet]
        public IActionResult Get()
        {
           var emps=empService.GetEmps();
            return Ok(emps);
        }
        [HttpPost]
        public IActionResult Post([FromBody] Employee emp)
        {
            empService.Add(emp);
            return Ok(emp);
        }

    }
}
