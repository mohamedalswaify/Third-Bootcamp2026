using SystemRoles.Data;
using SystemRoles.Models;
using SystemRoles.Repositories.Base;

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
