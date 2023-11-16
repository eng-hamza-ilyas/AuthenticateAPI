using AuthenticateAPI.Interfaces;
using AuthenticateAPI.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AuthenticateAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeService _employeService;
        public EmployeeController(IEmployeService employeService) { 
            
            _employeService = employeService;
        }
        // GET: api/<EmployeeController>
        [HttpGet]
        public List<Employe> Get()
        {
            var employe = _employeService.GetEmployeeDetails();
            return employe;
        }

        // GET api/<EmployeeController>/5
        [HttpGet("{id}")]
        public Employe Get(int id)
        {
            var employe = _employeService.GetEmployeeDetails(id);
            return employe;
        }

        // POST api/<EmployeeController>
        [HttpPost("PostingEmployee")]
        public Employe Post([FromBody] Employe employe)
        {
            var emp = _employeService.AddEmployee(employe);
            return emp;
        }

        // PUT api/<EmployeeController>/5
        [HttpPut("{id}")]
        public Employe Put(int id, [FromBody] Employe value)
        {
            var emp = _employeService.UpdateEmployee(value);
            return emp;
        }

        // DELETE api/<EmployeeController>/5
        [HttpDelete("{id}")]
        public bool Delete(int id)
        {
            var isDeleted = _employeService.DeleteEmployee(id);
            return isDeleted;
        }
    }
}
