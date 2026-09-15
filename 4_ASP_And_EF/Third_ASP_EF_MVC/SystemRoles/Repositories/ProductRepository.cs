using SystemRoles.Data;
using SystemRoles.Models;
using SystemRoles.Repositories.Base;

namespace SystemRoles.Repositories
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
