using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Localization;
using PagedList.Core;
using Proje.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_Project.Data;
using Web_Project.Models;


namespace Web_Project.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly UserManager<User> userManager;
        private readonly IHtmlLocalizer<AdminController> _localizer;
        public AdminController(ApplicationDbContext context, RoleManager<IdentityRole> roleManager, UserManager<User> userManager, IHtmlLocalizer<AdminController> localizer)
        {
            _context = context;
            this.roleManager = roleManager;
            this.userManager = userManager;
            _localizer = localizer;
        }
        public IActionResult Dashboard()
        {
            ViewModel dashboard = new ViewModel();
            var projects = _context.Project.OrderByDescending(p => p.CreateDate);
            var users = _context.Users.OrderByDescending(p => p.CreateDate );
            var categories = _context.Category;
            var questions = _context.Question.OrderByDescending(p => p.SendingDate);
            dashboard.Project = projects.ToList();
            dashboard.User = users.ToList();
            dashboard.Category = categories.ToList();
            dashboard.Question = questions.ToList();
            return View(dashboard);
        }
        public IActionResult Project(int page = 1, int pageSize = 5)
        {
            var keyword = Request.Query["keyword"].ToString();
            var projects = _context.Project.Where(p => (p.Title.Contains(keyword) || p.Category.Contains(keyword) || p.UserName.Contains(keyword) || p.CreateDate.Contains(keyword)));
            PagedList<Project> model = new PagedList<Project>(projects, page, pageSize);
            ViewBag.keyword = keyword;
            return View("Project", model);
        }
        public IActionResult Category(int page = 1, int pageSize = 5)
        {
            var keyword = Request.Query["keyword"].ToString();
            var categories = _context.Category.Where(p => (p.Name.Contains(keyword) || p.CreateDate.Contains(keyword)));
            PagedList<Category> model = new PagedList<Category>(categories, page, pageSize);
            ViewBag.keyword = keyword;
            return View("Category", model);
        }
        public IActionResult RoleAdmin(int page = 1, int pageSize = 5)
        {

            var allUsers = _context.UserRoles.Where(p => p.RoleId == 1.ToString());
            List<User> users = new List<User>();
            foreach (var item in allUsers)
            {
                var newuser = _context.Users.Find(item.UserId);
                users.Add(newuser);
            }

            return View(users);
        }
        public async Task<IActionResult> AddAdmin(string id)
        {

            var user = _context.Users.FirstOrDefault(p => p.Id == id);
            var control = _context.UserRoles.FirstOrDefault(p => p.UserId == id && p.RoleId == 1.ToString());
            if (control == null)
            {
                var result1 = await userManager.RemoveFromRoleAsync(user, "User");
                var result = await userManager.AddToRoleAsync(user, "Admin");
            }
            else
            {
                var message = _localizer["WarningAdminUser"];

                TempData["WarningMessage"] = message.Value;
                return Redirect("/Admin/User");
            }

            var message2 = _localizer["SuccessAdminUser"];

            TempData["SuccessMessage"] = message2.Value;
            return Redirect("/Admin/User");
        }
        public async Task<IActionResult> RemoveAdmin(string id)
        {

            var user = _context.Users.FirstOrDefault(p => p.Id == id);
            var control = _context.UserRoles.FirstOrDefault(p => p.UserId == id && p.RoleId == 1.ToString());
            if (control != null)
            {
                var result1 = await userManager.RemoveFromRoleAsync(user, "Admin");
                var result2 = await userManager.AddToRoleAsync(user, "User");
            }
            else
            {
                var message = _localizer["RemoveAdminError"];

                TempData["ErrorMessage"] = "Bu kullanıcı zaten admin değil.";
                return Redirect("/Admin/RoleAdmin");
            }
            var message2 = _localizer["RemoveAdminSuccess"];

            TempData["SuccessMessage"] = message2.Value;
            return Redirect("/Admin/RoleAdmin");
        }
        public IActionResult Question(int page = 1, int pageSize = 5)
        {
            var keyword = Request.Query["keyword"].ToString();
            var questions = _context.Question.Where(p => (p.Title.Contains(keyword) || p.Content.Contains(keyword) || p.SendingDate.Contains(keyword) || p.UserName.Contains(keyword)));
            PagedList<Question> model = new PagedList<Question>(questions, page, pageSize);
            ViewBag.keyword = keyword;
            return View("Question", model);
        }
        public IActionResult User(int page = 1, int pageSize = 5)
        {
            var keyword = Request.Query["keyword"].ToString();
            var users = _context.Users.Where(p => (p.Name.Contains(keyword) || p.UserName.Contains(keyword) || p.CreateDate.Contains(keyword) || p.Email.Contains(keyword)));
            PagedList<User> model = new PagedList<User>(users, page, pageSize);
            ViewBag.keyword = keyword;
            return View("User", model);
        }

        public async Task<IActionResult> DeleteProject(int id)
        {
            var project = await _context.Project.FindAsync(id);
            _context.Remove(project);
            await _context.SaveChangesAsync();

            var message = _localizer["DeleteProjectSuccess"];

            TempData["DeleteMessage"] = message.Value;
            return Redirect("/Admin/Project");
        }
        public async Task<IActionResult> DeleteUser(string id)
        {
            var user = await _context.Users.FindAsync(id);
            _context.Remove(user);
            await _context.SaveChangesAsync();

            var message = _localizer["DeleteUserSuccess"];

            TempData["DeleteMessage"] = message.Value;
            return Redirect("/Admin/User");
        }
        public async Task<IActionResult> DeleteQuestion(int id)
        {
            var question = await _context.Question.FindAsync(id);
            _context.Remove(question);
            await _context.SaveChangesAsync();

            var message = _localizer["DeleteQuestionSuccess"];

            TempData["DeleteMessage"] = message.Value;
            return Redirect("/Admin/Question");
        }
        public async Task<IActionResult> DeleteCategory(int id)
        {
            var category = await _context.Category.FindAsync(id);
            _context.Remove(category);
            await _context.SaveChangesAsync();

            var message = _localizer["DeleteCategorySuccess"];

            TempData["DeleteMessage"] = message.Value;
            return Redirect("/Admin/Category");
        }

        public IActionResult AddCategory()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddCategory(Category category)
        {
            var dateTime = DateTime.Now;
            var dateValue = dateTime.ToString("dd/MM/yy");
            category.CreateDate = dateValue.ToString();
            _context.Add(category);
            _context.SaveChanges();

            var message = _localizer["AddCategorySuccess"];

            TempData["SuccessMessage"] = message.Value;
            return Redirect("/Admin/Category");
        }


        public IActionResult UpdateCategory(int id)
        {
            var control = _context.Category.Find(id);
            if (control == null)
            {

                var message = _localizer["CategoryNotFound"];

                TempData["ErrorMessage"] = message.Value;
                return Redirect("/Error/Index");
            }
            return View(_context.Category.Find(id));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> UpdateCategory(Category category)
        {
            _context.Update(category);
            await _context.SaveChangesAsync();

            var message = _localizer["UpdateCategorySuccess"];

            TempData["UpdateMessage"] = message.Value;
            return Redirect("/Admin/Category");
        }

    }
}
