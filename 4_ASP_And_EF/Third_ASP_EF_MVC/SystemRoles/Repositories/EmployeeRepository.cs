using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using SystemRoles.Data;
using SystemRoles.Dtos.HrDtos;
using SystemRoles.Models;
using SystemRoles.Repositories.Base;

namespace SystemRoles.Repositories
{
    public class EmployeeRepository : Repository<Employee>, IEmployeeRepository
    {
        private readonly AppDbContext _db;
        public EmployeeRepository(AppDbContext db) :base(db) 
        {
            _db = db;
        
        }

        public IEnumerable<EmployeeDto> GetEmployeesImprove()
        {
            return _db.Employees
                .Select(e => new EmployeeDto
                {
                    Id = e.Id,
                    Name = e.Name,
                    UID = e.UID,
                    ImageURL = e.ImageURL,
                    JobName = e.Jobs.Name,
                    DepartmentName = e.Departments.Name
                })
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
