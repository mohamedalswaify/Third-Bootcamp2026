using Third_ASP_EF_MVC.Infrastructure.Data;
using Third_ASP_EF_MVC.Domain.Models;
using Third_ASP_EF_MVC.Infrastructure.Repositories.Base;

namespace Third_ASP_EF_MVC.Infrastructure.Repositories
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        private readonly AppDbContext _db;
        public ProductRepository(AppDbContext db) :base(db) 
        {
            _db = db;
        
        }

        public IEnumerable<Product> GetProductWithCategory(int categoryId)
        {
            IEnumerable<Product>  product = _db.Products.Where(p => p.CategoryId == categoryId).ToList();

            return product;
           
        }
    }
}
