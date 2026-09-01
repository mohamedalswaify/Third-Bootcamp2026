using Microsoft.AspNetCore.Mvc;
using Third_ASP_EF_MVC.Data;
using Third_ASP_EF_MVC.Models;

namespace Third_ASP_EF_MVC.Controllers
{
    public class CategoriesController : Controller
    {

        private readonly AppDbContext _db;
        public CategoriesController(AppDbContext db)
        {
            _db = db;

        }

        public IActionResult Index()
        {
            //Entity FrameWork Approach

            IEnumerable<Category> names = _db.Categories.ToList();

            return View(names);
        }

    }
}
