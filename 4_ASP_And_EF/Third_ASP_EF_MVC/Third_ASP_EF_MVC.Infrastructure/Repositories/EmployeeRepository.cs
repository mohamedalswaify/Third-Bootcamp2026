using Microsoft.EntityFrameworkCore;
using Third_ASP_EF_MVC.Infrastructure.Data;
using Third_ASP_EF_MVC.Domain.Models;
using Third_ASP_EF_MVC.Infrastructure.Repositories.Base;


namespace Third_ASP_EF_MVC.Infrastructure.Repositories
{
    public class EmployeeRepository : Repository<Employee>, IEmployeeRepository
    {
        private readonly AppDbContext _db;
        public EmployeeRepository(AppDbContext db) :base(db) 
        {
            _db = db;
        
        }

        public IEnumerable<Employee> GetEmployeesImprove()
        {
            return _db.Employees
                .Include(e=>e.Jobs)
                .Include(e=>e.Departments)
                .ToList();
        }

        public IEnumerable<Employee> GetEmployeesWithJobAndDept()
        {
            return  _db.Employees
                .Include(e => e.Jobs)
                .Include(e => e.Departments)
                .ToList();  
        }


    }
}
