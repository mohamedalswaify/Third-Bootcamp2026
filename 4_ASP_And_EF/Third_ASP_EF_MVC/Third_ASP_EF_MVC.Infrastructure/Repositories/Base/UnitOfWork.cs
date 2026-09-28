using SystemRoles.Repositories;
using Third_ASP_EF_MVC.Infrastructure.Data;

namespace Third_ASP_EF_MVC.Infrastructure.Repositories.Base
{
    public class UnitOfWork : IUnitOfWork
    {

        private readonly AppDbContext _db;

        public UnitOfWork(AppDbContext db) 
        {

            _db = db;

            DepartmentRepo = new DepartmentRepository(_db);
            EmployeeRepo = new EmployeeRepository(_db);
            JobRepo = new JobRepository(_db);
            CategoryRepo = new CategoryRepository(_db);
            ProductRepo = new ProductRepository(_db);

        }



        public IEmployeeRepository EmployeeRepo { get; }

        public IJobRepository JobRepo { get; }

        public IDepartmentRepository DepartmentRepo { get; }

        public ICategoryRepository CategoryRepo { get; }

        public IProductRepository ProductRepo { get; }

        public void Save()
        {
           _db.SaveChanges();
        }
    }
    }
