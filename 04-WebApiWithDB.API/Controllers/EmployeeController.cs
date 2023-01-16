using _04_WebApiWithDB.Entities.Concreate;
using _04_WebApiWithDB.Service.Abstract;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace _04_WebApiWithDB.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            this._employeeService = employeeService;
        }
        // GET: api/Employee/GetAllEmployees
        [HttpGet]
        [Route("[action]")]
        public IActionResult GetAllEmployees()
        {
            var employees = _employeeService.GetAllEmpleyees();
            return Ok(employees);
        }
        [HttpGet]
        [Route("[action]/{department}")]
        public IActionResult GetEmployeeByDepartment(string department)
        {

            if (department != "")
            {
                var employees = _employeeService.GetEmployeeByDepartment(department);
                return Ok(employees);
            }
            else
            {
                return BadRequest();
            }
            
        }

        // GET api/<EmployeeController>/5
        [HttpGet]
        [Route("[action]/{id}")]
        public async Task<IActionResult> GetEmployeeById(int id)
        {
            var employee = await _employeeService.GetEmployeeById(id);
            if (employee != null)
            {
                return Ok(employee);
            }
            return NotFound();
        }

        // POST api/<EmployeeController>
        [HttpPost]
        public IActionResult CreateEmployee([FromBody] Employee employee)
        {
            var createdEmployee = _employeeService.CreateEmployee(employee);
            //return Ok(createdEmployee);
            return CreatedAtAction("GetEmployeeById", new { id = createdEmployee.Id }, createdEmployee);
        }

        // PUT api/<EmployeeController>/5
        [HttpPut("[action]")]
        public async Task UpdateEmployee([FromBody] Employee employee)
        {
            if (employee != null)
            {
                var updatedEmployee =  await _employeeService.GetEmployeeById(employee.Id);
                if (updatedEmployee != null)
                {
                    updatedEmployee.FirstName = employee.FirstName;
                    updatedEmployee.LastName = employee.LastName;
                    updatedEmployee.Department = employee.Department;                    
                }  
                _employeeService.UpdateEmployee(updatedEmployee);
            }
        }

        // DELETE api/<EmployeeController>/5
        [HttpDelete]
        [Route("[action]/{id}")]
        public void Delete(int id)
        {
            _employeeService.DeleteEmployee(id);
        }
    }
}
