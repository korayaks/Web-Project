using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
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
    public class QuestionController : Controller
    {
        private readonly ApplicationDbContext _context;
        public QuestionController(ApplicationDbContext context)
        {
            _context = context;
        }
        [Authorize]
        public IActionResult Send()
        {

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Send(Question question)
        {
            var dateTime = DateTime.Now;
            var dateValue = dateTime.ToString("dd/MM/yyyy");
            question.SendingDate = dateValue.ToString();
            User user = _context.Users.Find(User.FindFirst(ClaimTypes.NameIdentifier).Value);
            question.UserId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            question.UserName = user.Name;
            _context.Add(question);
            _context.SaveChanges();
            return Redirect("/Home/Index");
        }
    }
}
