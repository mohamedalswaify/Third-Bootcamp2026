using Microsoft.AspNetCore.Mvc;
using SystemRoles.Models;
using SystemRoles.Repositories;

namespace SystemRoles.Controllers
{
    public class CategoriesController : Controller
    {
        private readonly ICategoryRepository _repository;
        public CategoriesController(ICategoryRepository repository)
        {
            _repository = repository;
        }

        public IActionResult Index()
        {
            var categories = _repository.GetAll();
            return View(categories);
        }

        public IActionResult Create()
        {
            return View();
        }

        public class CreateCategoryDto
        {
            public string Name { get; set; }
        }
        [HttpPost]
        public IActionResult Create(CreateCategoryDto category)
        {
            if (ModelState.IsValid)
            {
                //Mapping 
                var cate = new Category {Name = category.Name};

                _repository.Add(cate);
                _repository.Save();
                return RedirectToAction("Index");
            }
            return View(category);
           
        }

        public IActionResult Edit(int id)
        {
            var category = _repository.GetById(id);
            if (category == null)
                return NotFound();
            return View(category);
        }


        [HttpPost]
        public IActionResult Edit(Category category)
        {
            if (ModelState.IsValid)
            {
                _repository.Update(category);
                _repository.Save();
                return RedirectToAction("Index");
            }
            return View(category);

        }


        public IActionResult Delete(int id)
        {
            var category = _repository.GetById(id);
            if (category == null)
                return NotFound();
            return View(category);
        }


        [HttpPost]
        public IActionResult DeleteConfirm(int id)
        {

            var category = _repository.GetById(id);
            if (category == null)
                return NotFound();

            _repository.Delete(category);
            _repository.Save();
            return RedirectToAction("Index");



        }



    }
}
