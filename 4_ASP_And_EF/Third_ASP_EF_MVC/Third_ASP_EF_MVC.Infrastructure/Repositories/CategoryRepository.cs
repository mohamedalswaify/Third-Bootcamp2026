using Third_ASP_EF_MVC.Infrastructure.Data;
using Third_ASP_EF_MVC.Domain.Models;
using Third_ASP_EF_MVC.Infrastructure.Repositories.Base;

namespace Third_ASP_EF_MVC.Infrastructure.Repositories
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
