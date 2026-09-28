using Third_ASP_EF_MVC.Domain.Models;
using Third_ASP_EF_MVC.Infrastructure.Repositories.Base;

namespace Third_ASP_EF_MVC.Infrastructure.Repositories
{
    public interface IEmployeeRepository : IRepository<Employee>
    {
        IEnumerable<Employee> GetEmployeesWithJobAndDept();
        IEnumerable<Employee> GetEmployeesImprove();
    }
}
