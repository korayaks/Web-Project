using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Localization;
using PagedList.Core;
using Proje.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Web_Project.Data;
using Web_Project.Models;

namespace Web_Project.Controllers
{
    public class AccountController : Controller
    {
        private readonly IHtmlLocalizer<AccountController> _localizer;
        private readonly ApplicationDbContext _context;

        public AccountController(ApplicationDbContext context,IHtmlLocalizer<AccountController> localizer)
        {
            _context = context;
            _localizer = localizer;
        }


        public IActionResult Profile(string id)
        {
            ViewModel viewModel = new ViewModel();

            List<User> profile = new List<User>();
            var user = _context.Users.Where(p => p.Id == id);
            profile = user.ToList();
            viewModel.User = profile;
            var project = _context.Project.Where(x => x.UserId == id);
            viewModel.Project = project.ToList();
            if (profile.Count == 0)
            {
                var message = _localizer["ProfileNotFoundMessage"];
                TempData["ErrorMessage"] = message.Value;
                return Redirect("/Error/Index");
            }
            return View(viewModel);
        }

        [Authorize]
        public IActionResult ListProject(int page = 1, int pageSize = 5)
        {
            var keyword = Request.Query["keyword"].ToString();
            var projects = _context.Project.Where(p => (p.Title.Contains(keyword) || p.Category.Contains(keyword) || p.UserName.Contains(keyword) || p.CreateDate.Contains(keyword)) && p.UserId == User.FindFirst(ClaimTypes.NameIdentifier).Value);
            PagedList<Project> model = new PagedList<Project>(projects, page, pageSize);
            ViewBag.keyword = keyword;
            return View("ListProject", model);
        }

        public async Task<IActionResult> DeleteProject(int id)
        {
            var project = await _context.Project.FindAsync(id);
            _context.Remove(project);
            await _context.SaveChangesAsync();

            var message = _localizer["DeleteProjectMessage"];
            TempData["DeleteMessage"] = message.Value;
            return Redirect("/Account/ListProject");
        }

        [Authorize]
        public IActionResult Settings(string id)
        {
            var control = _context.Users.Find(id);
            var adminControl = _context.UserRoles.FirstOrDefault(p => p.UserId == User.FindFirst(ClaimTypes.NameIdentifier).Value);
            if (control == null)
            {
                var message = _localizer["ProfileNotFoundMessage"];
                TempData["ErrorMessage"] = message.Value;
                return Redirect("/Error/Index");
            }
            if(adminControl!=null)
            {
                if ((adminControl.RoleId == 1.ToString()))
                {
                    return View(_context.Users.Find(id));
                }
            }
            
            if (control.Id != User.FindFirst(ClaimTypes.NameIdentifier).Value)
            {
                var message = _localizer["ErrorProfileUpdate"];
                TempData["ErrorMessage"] = message.Value;
                return Redirect("/Error/Index");
            }
            return View(_context.Users.Find(id));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Settings(string id, User settings)
        {
            User pastuser = new User();
            pastuser = _context.Users.Find(id);
            pastuser.Name = settings.Name;
            pastuser.Status = settings.Status;
            pastuser.School = settings.School;
            pastuser.Department = settings.Department;
            pastuser.Summary = settings.Summary;
            pastuser.Interest = settings.Interest;
            pastuser.BirthdayDate = settings.BirthdayDate;
            pastuser.Website = settings.Website;
            pastuser.Github = settings.Github;
            pastuser.Facebook = settings.Facebook;
            pastuser.Instagram = settings.Instagram;
            pastuser.Twitter = settings.Twitter;
            _context.Update(pastuser);
            await _context.SaveChangesAsync();
            var message = _localizer["UpdateUserProfile"];
            TempData["SuccessMessage"] = message.Value;
            return Redirect("/Account/Profile/" + pastuser.Id);
        }
    }
}
