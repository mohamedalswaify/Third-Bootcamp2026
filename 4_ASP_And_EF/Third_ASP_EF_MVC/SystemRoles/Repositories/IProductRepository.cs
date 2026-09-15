using SystemRoles.Models;
using SystemRoles.Repositories.Base;

namespace SystemRoles.Repositories
{
    public interface IProductRepository : IRepository<Product>
    {
       
        IEnumerable<Product> GetProductWithCategory(int categoryId);
    }
}
