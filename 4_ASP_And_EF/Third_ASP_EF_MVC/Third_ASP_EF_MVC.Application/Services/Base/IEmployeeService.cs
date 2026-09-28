using Third_ASP_EF_MVC.Application.Dtos.HrDtos;
using Third_ASP_EF_MVC.Domain.Models;

namespace Third_ASP_EF_MVC.Application.Services.Base
{
    public interface IEmployeeService
    {
        IEnumerable<EmployeeDto> GetEmployeesImprove();
        IEnumerable<EmployeeDto> GetEmployeesWithJobAndDept();

        IEnumerable<Job> GetAllJobs();
        IEnumerable<Department> GetAllDepts();

        void CreateEmployee(CreateEmployeeDto employeeDto);

    }
}
