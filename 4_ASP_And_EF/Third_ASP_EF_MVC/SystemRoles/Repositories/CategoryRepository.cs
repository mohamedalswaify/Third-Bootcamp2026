using SystemRoles.Data;
using SystemRoles.Models;
using SystemRoles.Repositories.Base;

namespace SystemRoles.Repositories
{
    public class CategoryRepository : Repository<Category> , ICategoryRepository
    {
        private readonly AppDbContext _db;
        public CategoryRepository(AppDbContext db)  : base(db) 
        {
            _db = db;
        
        }


    }
}
