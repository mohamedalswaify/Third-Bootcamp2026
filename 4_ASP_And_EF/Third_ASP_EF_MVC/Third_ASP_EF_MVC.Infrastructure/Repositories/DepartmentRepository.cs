using Third_ASP_EF_MVC.Infrastructure.Data;
using Third_ASP_EF_MVC.Domain.Models;
using Third_ASP_EF_MVC.Infrastructure.Repositories.Base;
using Third_ASP_EF_MVC.Infrastructure.Repositories;

namespace SystemRoles.Repositories
{
    public class DepartmentRepository : Repository<Department>, IDepartmentRepository
    {
        private readonly AppDbContext _db;
        public DepartmentRepository(AppDbContext db) :base(db) 
        {
            _db = db;
        
        }

    }
}
