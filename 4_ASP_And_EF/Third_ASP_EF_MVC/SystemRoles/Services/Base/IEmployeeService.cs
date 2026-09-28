using SystemRoles.Dtos.HrDtos;
using SystemRoles.Models;

namespace SystemRoles.Services.Base
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
