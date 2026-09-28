using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SystemRoles.Dtos.HrDtos;
using SystemRoles.Models;
using SystemRoles.Repositories;
using SystemRoles.Repositories.Base;
using SystemRoles.Services.Base;

namespace SystemRoles.Controllers
{
    public class EmployeesController : Controller
    {

        private readonly IEmployeeService _employeeService ;

        public EmployeesController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;

        }
        public IActionResult Index()
        {
            var employees = _employeeService.GetEmployeesImprove();
            return View(employees);
        }

        public IActionResult Index2()
        {
            var employees = _employeeService.GetEmployeesWithJobAndDept();
            return View(employees);
        }
        public IActionResult Create() 
        {
            var alljobs =_employeeService.GetAllJobs();
            var allDepts=  _employeeService.GetAllDepts();
            SelectList listJobs = new SelectList(alljobs, "Id", "Name");
            SelectList listJDepts = new SelectList(allDepts, "Id", "Name");
            ViewBag.Jobs = listJobs;
            ViewBag.Departments =listJDepts;

        return View();
        }

        [HttpPost]
        public IActionResult Create(CreateEmployeeDto employeeDto)
        {
            if (ModelState.IsValid)
            {
               _employeeService.CreateEmployee(employeeDto);

                return RedirectToAction("Index");
               
            }

            return View(employeeDto);
        }

    }
}
