namespace Third_ASP_EF_MVC.Infrastructure.Repositories.Base
{
    public interface IUnitOfWork
    {
        IEmployeeRepository EmployeeRepo {  get; }
        IJobRepository JobRepo { get; }
        IDepartmentRepository DepartmentRepo { get; }
        ICategoryRepository CategoryRepo { get; }
        IProductRepository ProductRepo { get; }

        void Save();
    }
}
