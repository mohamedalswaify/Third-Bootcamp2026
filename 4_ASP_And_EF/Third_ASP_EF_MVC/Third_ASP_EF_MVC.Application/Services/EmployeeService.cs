using Microsoft.AspNetCore.Http;
using Third_ASP_EF_MVC.Application.Dtos.HrDtos;
using Third_ASP_EF_MVC.Application.Services.Base;
using Third_ASP_EF_MVC.Domain.Models;
using Third_ASP_EF_MVC.Infrastructure.Repositories.Base;



namespace Third_ASP_EF_MVC.Application.Services
{
    public class EmployeeService : IEmployeeService
    {


        private readonly IUnitOfWork _unitOfWork;

        public EmployeeService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;

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


        public void CreateEmployee(CreateEmployeeDto employeeDto)
        {

            //Mapping 
            var employee = new Employee();

            if (employeeDto.Image != null)
            {
                employee.ImageURL = UploadImage(employeeDto.Image, employeeDto.Name);
            }

            employee.Name = employeeDto.Name;
            employee.Email = employeeDto.Email;
            employee.DepartmentId = employeeDto.DepartmentId;
            employee.JobId = employeeDto.JobId;
            employee.Phone = employeeDto.Phone;


            _unitOfWork.EmployeeRepo.Add(employee);
            _unitOfWork.Save();

        }

        public IEnumerable<Department> GetAllDepts()
        {
            var allDepts = _unitOfWork.DepartmentRepo.GetAll();
            return allDepts;
        }

        public IEnumerable<Job> GetAllJobs()
        {
            var alljobs = _unitOfWork.JobRepo.GetAll();
            return alljobs;
        }

        public IEnumerable<EmployeeDto> GetEmployeesImprove()
        {
            var employees = _unitOfWork.EmployeeRepo.GetEmployeesImprove();
            var employeesDto = employees.Select(e=> new EmployeeDto
            {
                Id= e.Id,
                Name= e.Name,
                ImageURL  = e.ImageURL,
                UID = e.UID,
                JobName = e.Jobs.Name,
                 DepartmentName =e.Departments.Name
            });

            return employeesDto;
        }

        public IEnumerable<EmployeeDto> GetEmployeesWithJobAndDept()
        {
            var employees = _unitOfWork.EmployeeRepo.GetEmployeesWithJobAndDept();

            var employeeDTo = employees.Select(e => new EmployeeDto
            {
                Id = e.Id,
                Name = e.Name,
                UID = e.UID,
                ImageURL = e.ImageURL,
                JobName = e.Jobs.Name,
                DepartmentName = e.Departments.Name

            });
            return employeeDTo;
        }
    }
}
