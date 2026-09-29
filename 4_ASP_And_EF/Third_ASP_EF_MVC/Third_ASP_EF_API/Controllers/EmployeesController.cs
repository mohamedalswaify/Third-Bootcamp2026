using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Third_ASP_EF_MVC.Application.Dtos.HrDtos;
using Third_ASP_EF_MVC.Application.Services.Base;

namespace Third_ASP_EF_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;

        public EmployeesController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;

        }

        [HttpGet("GetEmployees")]
        public IActionResult  Emp(string name)
        {try
            {

                var employees = _employeeService.GetEmployeesImprove();
                return Ok(employees);
            }

            catch(Exception ex) 
            {
                return BadRequest(ex.Message);

            }
        }



        [HttpPost]
        public IActionResult CreateEmployee(CreateEmployeeDto createEmployeeDto)
        {

            try
            {
                _employeeService.CreateEmployee(createEmployeeDto);
                return Ok("Data Added");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
