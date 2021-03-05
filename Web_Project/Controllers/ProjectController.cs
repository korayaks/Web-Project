using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Web_Project.Models;
using PagedList.Core;
using Microsoft.AspNetCore.Http;
using Web_Project.Data;
using Microsoft.AspNetCore.Authorization;
using Proje.Models;
using System.Security.Claims;
using Microsoft.AspNetCore.Mvc.Localization;

namespace Web_Project.Controllers
{
    public class ProjectController : Controller
    {
       
        private readonly ApplicationDbContext _context;
        private readonly IHtmlLocalizer<ProjectController> _localizer;
        public ProjectController(ApplicationDbContext context,IHtmlLocalizer<ProjectController> localizer)
        {
            _context = context;
            _localizer = localizer;
        }

        [Authorize]
        public IActionResult Create()
        {
            List<Category> ListCategory = new List<Category>();
            List<string> ListStringCategory = new List<string>();
            string CategoryName;
            ListCategory = _context.Category.ToList();
            foreach (var item in ListCategory)
            {
                CategoryName = item.Name;
                ListStringCategory.Add(CategoryName);
            }
            ViewBag.CategoryList = ListStringCategory;

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Project project)
        {
            List<Category> ListCategory = new List<Category>();
            List<string> ListStringCategory = new List<string>();
            string CategoryName;
            ListCategory = _context.Category.ToList();
            foreach (var item in ListCategory)
            {
                CategoryName = item.Name;
                ListStringCategory.Add(CategoryName);
            }
            ViewBag.CategoryList = ListStringCategory;

            var dateTime = DateTime.Now;
            var dateValue = dateTime.ToString("dd/MM/yyyy");
            project.CreateDate = dateValue.ToString();
            project.UpdateDate = dateValue.ToString();
            project.Status = 1;
           
            
            User user = _context.Users.Find(User.FindFirst(ClaimTypes.NameIdentifier).Value);
            project.UserMail = user.Email;
            project.UserName = user.Name;
            project.UserId = User.FindFirst(ClaimTypes.NameIdentifier).Value;

            _context.Add(project);
            _context.SaveChanges();

            var message = _localizer["CreateProjectMessage"];

            TempData["SuccessMessage"] = message.Value;
            return Redirect("/Project/Detail/" + project.Id);
        }
        [Authorize]
        public IActionResult Update(int id)
        {
            List<Category> ListCategory = new List<Category>();
            List<string> ListStringCategory = new List<string>();
            string CategoryName;
            ListCategory = _context.Category.ToList();
            foreach (var item in ListCategory)
            {
                CategoryName = item.Name;
                ListStringCategory.Add(CategoryName);
            }
            ViewBag.CategoryList = ListStringCategory;

            ViewModel all = new ViewModel();

            var control = _context.Project.Find(id);

            var adminControl = _context.UserRoles.FirstOrDefault(p => p.UserId == User.FindFirst(ClaimTypes.NameIdentifier).Value);

            if (adminControl != null)
            {
                if ((adminControl.RoleId == 1.ToString()))
                {
                    return View(_context.Project.Find(id));
                }
            }

            if (control == null)
            {
                var message = _localizer["ProjectNotFoundMessage"];

                TempData["ErrorMessage"] = message.Value;
                return Redirect("/Error/Index");
            }

            if(control.UserId != User.FindFirst(ClaimTypes.NameIdentifier).Value)
            {
                var message = _localizer["ProjectUpdateErrorMessage"];

                TempData["ErrorMessage"] = message.Value;
                return Redirect("/Error/Index");
            }

            return View(_context.Project.Find(id));                      
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update (Project project)
        {
            List<Category> ListCategory = new List<Category>();
            List<string> ListStringCategory = new List<string>();
            string CategoryName;
            ListCategory = _context.Category.ToList();
            foreach (var item in ListCategory)
            {
                CategoryName = item.Name;
                ListStringCategory.Add(CategoryName);
            }
            ViewBag.CategoryList = ListStringCategory;

            var dateTime = DateTime.Now;
            var dateValue = dateTime.ToString("dd/MM/yyyy");
            project.UpdateDate = dateValue.ToString();
            _context.Update(project);
            await _context.SaveChangesAsync();

            var message = _localizer["ProjectUpdateSuccessMessage"];

            TempData["UpdateMessage"] = message.Value;
            return Redirect("/Project/Detail/" + project.Id);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddCategory(Category category)
        {
            var dateTime = DateTime.Now;
            var dateValue = dateTime.ToString("dd/MM/yyyy");
            category.CreateDate = dateValue.ToString();
            _context.Add(category);
            _context.SaveChanges();
            return View();
        }

        public IActionResult List(int page = 1, int pageSize = 9)
        {
            var keyword = Request.Query["keyword"].ToString();
            var projects = _context.Project.Where(p => (p.Title.Contains(keyword) || p.Category.Contains(keyword)) && (p.Status == 1)).OrderByDescending(p => p.CreateDate);
            PagedList<Project> model = new PagedList<Project>(projects, page, pageSize);
            ViewBag.keyword = keyword;
            return View("List", model);
        }

        public IActionResult Detail(int id)
        {
            var control = _context.Project.Find(id);

            if (control == null)
            {
                var message = _localizer["ProjectNotFoundMessage"];

                TempData["ErrorMessage"] = message.Value;
                return Redirect("/Error/Index");
            }
            return View(_context.Project.Find(id));
        }

    }
}
