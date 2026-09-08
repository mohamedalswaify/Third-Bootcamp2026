using Microsoft.AspNetCore.Mvc;
using SystemRoles.Data;
using SystemRoles.Dtos;
using SystemRoles.Models;

namespace SystemRoles.Controllers
{
    public class UsersController : Controller
    {
        private readonly AppDbContext _db;

        public UsersController(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<User> users = _db.Users.ToList();
            return View(users);
        }


        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(User user)
        {
            if (ModelState.IsValid)
            {
                // Hash the password before saving it to the database
                user.HashPassword = BCrypt.Net.BCrypt.HashPassword(user.Password);

                _db.Users.Add(user);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(user);
        }


        public IActionResult Edit(int id)
        {
            var user = _db.Users.Find(id);
            if (user == null)
            {
                return NotFound();
            }
            return View(user);
        }

        [HttpPost]
        public IActionResult Edit(User user)
        {
            if (ModelState.IsValid)
            {
                _db.Users.Update(user);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(user);
        }

        [HttpPost]
        public IActionResult DeleteConfirmed(int id)
        {
            var user = _db.Users.Find(id);
            if (user == null)
            {
                return NotFound();
            }
            _db.Users.Remove(user);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }



        [HttpGet]
        public IActionResult ManageRoles(int id)
        {
            var user = _db.Users.Find(id);

            if (user == null)
            {
                return NotFound();
            }

            // جميع الصلاحيات
            var roles = _db.Roles.ToList();

            // الصلاحيات الموجودة بالفعل للمستخدم
            var userRoleIds = _db.RoleUsers
                .Where(x => x.UserId == id)
                .Select(x => x.RoleId)
                .ToList();

            var model = new UserRolesVM
            {
                UserId = user.Id,
                UserName = user.Name,

                Roles = roles.Select(role => new RoleCheckVM
                {
                    RoleId = role.Id,
                    RoleName = role.Name,

                    IsSelected = userRoleIds.Contains(role.Id)

                }).ToList()
            };

            return View(model);
        }


        [HttpPost]
        public IActionResult ManageRoles(UserRolesVM model)
        {
            var user = _db.Users.Find(model.UserId);

            if (user == null)
            {
                return NotFound();
            }

            // Get old roles
            var oldRoles = _db.RoleUsers
                .Where(x => x.UserId == model.UserId)
                .ToList();

            // Remove old roles
            _db.RoleUsers.RemoveRange(oldRoles);

            // Add selected roles
            foreach (var role in model.Roles)
            {
                if (role.IsSelected)
                {
                    RoleUser roleUser = new RoleUser
                    {
                        UserId = model.UserId,
                        RoleId = role.RoleId
                    };

                    _db.RoleUsers.Add(roleUser);
                }
            }

            _db.SaveChanges();

            return RedirectToAction("Index");
        }





    }
}
