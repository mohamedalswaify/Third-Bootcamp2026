using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SystemRoles.Dtos.HrDtos;
using SystemRoles.Models;
using SystemRoles.Repositories;

namespace SystemRoles.Controllers
{
    public class EmployeesController : Controller
    {

        private readonly IEmployeeRepository _employeeRepository;
        private readonly IJobRepository _jobRepository;
        private readonly IDepartmentRepository _departmentRepository;

        public EmployeesController(IEmployeeRepository employeeRepository, IJobRepository jobRepository, IDepartmentRepository departmentRepository)
        { 
            _employeeRepository = employeeRepository;
            _jobRepository = jobRepository;
            _departmentRepository = departmentRepository;
        }


        private string UploadImage(IFormFile image, string name)
        {
            string fileName = name + "_" + Guid.NewGuid().ToString()
                              + Path.GetExtension(image.FileName);

            string folderPath = Path.Combine(
                Directory.GetCurrentDirectory(),
                "wwwroot",
                "images",
                "Employees"
            );

            // Create folder if it doesn't exist
            Directory.CreateDirectory(folderPath);

            string filePath = Path.Combine(
                folderPath,
                fileName
            );

            using (var stream = new FileStream(filePath, FileMode.Create))
            {
                image.CopyTo(stream);
            }

            return "/images/Employees/" + fileName;
        }





        public IActionResult Index()
        {
            var employees = _employeeRepository.GetEmployeesImprove();
            return View(employees);
        }

        public IActionResult Index2()
        {
            var employees = _employeeRepository.GetEmployeesWithJobAndDept();

            var employeeDTo = employees.Select(e => new EmployeeDto
            {
                Id = e.Id,
                Name = e.Name,
                UID = e.UID,
                ImageURL = e.ImageURL,
                JobName = e.Jobs.Name,
                DepartmentName = e.Departments.Name

            });


            return View(employees);


        }



        public IActionResult Create() 
        {
            var alljobs = _jobRepository.GetAll();
            var allDepts= _departmentRepository.GetAll();

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
                var employee = new Employee();

                if(employeeDto.Image != null)
                {
                    employee.ImageURL = UploadImage(employeeDto.Image, employeeDto.Name);
                }
                employee.Name =employeeDto.Name;
                employee.Email = employeeDto.Email;
                employee.DepartmentId = employeeDto.DepartmentId;
                employee.JobId = employeeDto.JobId;
                employee.Phone =employeeDto.Phone;

                _employeeRepository.Add(employee);
                _employeeRepository.Save();
                return RedirectToAction("Index");
               
            }

            return View(employeeDto);
        }

    }
}
