using SystemRoles.Dtos.HrDtos;
using SystemRoles.Models;
using SystemRoles.Repositories.Base;

namespace SystemRoles.Repositories
{
    public interface IEmployeeRepository : IRepository<Employee>
    {
        IEnumerable<Employee> GetEmployeesWithJobAndDept();
        IEnumerable<EmployeeDto> GetEmployeesImprove();
    }
}
