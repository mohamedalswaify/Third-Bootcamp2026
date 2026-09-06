using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Third_ASP_EF_MVC.Data;
using Third_ASP_EF_MVC.Models;

namespace Third_ASP_EF_MVC.Controllers
{
    public class ProductsController : Controller
    {

        private readonly AppDbContext _db;
        public ProductsController(AppDbContext db)
        {
            _db = db;

        }

        [HttpGet]
        public IActionResult Index()
        {
            //Entity FrameWork Approach

            IEnumerable<Product> products = _db.Products.Include(p => p.Category).ToList();

            return View(products);
        }

        [HttpGet]
        public IActionResult Create()
        {
            SelectListForCategories();
            return View();
        }


        [HttpPost]
        public IActionResult Create(Product product)
        {
            if (ModelState.IsValid)
            {
                _db.Products.Add(product);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }

        private void SelectListForCategories()
        {
            IEnumerable<Category> categories = _db.Categories.ToList();
            SelectList categorySelectList = new SelectList(categories, "Id", "Name");
            ViewBag.Categories = categorySelectList;
        }


        [HttpGet]
        public IActionResult Edit(int Id)
        {
            var product = _db.Products.Find(Id);
            if (product == null)
            {
                return NotFound();
            }
            SelectListForCategories();

            return View(product);
        }


        [HttpPost]
        public IActionResult Edit(Product product)
        {
            if (ModelState.IsValid)
            {
                _db.Products.Update(product);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpGet]
        public IActionResult Delete(int Id)
        {
            var product = _db.Products.Find(Id);
            if (product  == null)
            {
                return NotFound();
            }
            return View(product);
        }


        [HttpPost]
        public IActionResult Delete(Product product)
        {
            if (ModelState.IsValid)
            {
                _db.Products.Remove(product);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }

    }
}
