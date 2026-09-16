using SystemRoles.Data;
using SystemRoles.Models;
using SystemRoles.Repositories.Base;

namespace SystemRoles.Repositories
{
    public class JobRepository : Repository<Job>, IJobRepository
    {
        private readonly AppDbContext _db;
        public JobRepository(AppDbContext db) :base(db) 
        {
            _db = db;
        
        }

    }
}
