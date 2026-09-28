using Third_ASP_EF_MVC.Infrastructure.Data;
using Third_ASP_EF_MVC.Domain.Models;
using Third_ASP_EF_MVC.Infrastructure.Repositories.Base;

namespace Third_ASP_EF_MVC.Infrastructure.Repositories
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
