using SystemRoles.Data;
using SystemRoles.Models;

namespace SystemRoles.Repositories
{
    public class NewCategoryRepository : ICategoryRepository
    {
        private readonly AppDbContext _db;
        public NewCategoryRepository(AppDbContext db) 
        {
            _db = db;
        
        }

        public void Add(Category category)
        {
            _db.Categories.Add(category);
        }

        public void Delete(Category category)
        {
           _db.Categories.Remove(category);
        }

        public IEnumerable<Category> GetAll()
        {
            return _db.Categories.ToList();
        }

        public Category? GetById(int id)
        {
            return _db.Categories.Find(id);
        }

        public void Save()
        {
            _db.SaveChanges();
        }

        public void Update(Category category)
        {
            _db.Categories.Update(category);
        }
    }
}
