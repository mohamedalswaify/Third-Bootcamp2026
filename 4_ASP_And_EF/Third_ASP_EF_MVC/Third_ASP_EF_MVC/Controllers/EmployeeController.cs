using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Third_ASP_EF_MVC.Models;

namespace Third_ASP_EF_MVC.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult IndexApi()
        {

            IList<Employee> list = new List<Employee>();

            list.Add(new Employee
            {
                Id = 1,
                Name = "Mohamed",
                Description = "Trainer"
            });
            list.Add(new Employee
            {
                Id = 2,
                Name = "Al",
                Description = "Trainer"
            });

            list.Add(new Employee
            {
                Id = 3,
                Name = "Ahmed",
                Description = "Trainer"
            });

            IEnumerable<Employee> names = list;

            return StatusCode(201,names);
        }
        public IActionResult Index()
        {
           
            IList<Employee> list = new List<Employee>();

            list.Add(new Employee
            {
                Id=1,
                Name= "Mohamed",
                Description= "Trainer"
            });
            list.Add(new Employee
            {
                Id = 2,
                Name = "Al",
                Description = "Trainer"
            });

            list.Add(new Employee
            {
                Id = 3,
                Name = "Ahmed",
                Description = "Trainer"
            });

            IEnumerable<Employee> names = list;

            return View(names);
        }


        public IActionResult Index1()
        {

            IList<string> names = new List<string>();
            names.Add("Mohamed");
            names.Add("Ali");
            names.Add("Sayed");
            names.Add("Ahmed");
            names.Add("Sara");

            return View(names);
        }



        public IList<string> Index2()
        {

            IList<string> names = new List<string>();
            names.Add("Mohamed");
            names.Add("Ali");
            names.Add("Sayed");
            names.Add("Ahmed");
            names.Add("Sara");
            return names;
        }
    }
}
