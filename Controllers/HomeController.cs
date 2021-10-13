using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using FinalBeltExam.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;

namespace FinalBeltExam.Controllers
{
    public class HomeController : Controller
    {
        private MyContext _context;

        public HomeController(MyContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost("register")]
        public IActionResult Register(User newUser)
        {
            if(ModelState.IsValid)
            {
                if(_context.Users.Any(user => user.Email == newUser.Email))
                {
                    ModelState.AddModelError("Email", "This Email is already in use");
                    return View("Index");
                }

                PasswordHasher<User> Hasher = new PasswordHasher<User>();
                newUser.Password = Hasher.HashPassword(newUser, newUser.Password);
                _context.Users.Add(newUser);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View("Index");
        }

        [HttpPost("loggingIn")]
        public IActionResult LoggingIn(LoginUser login)
        {
            if(ModelState.IsValid)
            {
                User userInDb = _context.Users.FirstOrDefault(user => user.Email == login.LoginEmail);
                if(userInDb == null)
                {
                    ModelState.AddModelError("LoginEmail", "Invalid Login");

                    return View("Index");
                }
                PasswordHasher<LoginUser> hasher = new PasswordHasher<LoginUser>();

                var result = hasher.VerifyHashedPassword(login, userInDb.Password, login.LoginPassword);

                if(result == 0)
                {
                    ModelState.AddModelError("LoginEmail", "Invalid Login");

                    return View("Index");
                }

                HttpContext.Session.SetInt32("userId", userInDb.UserId);
                return RedirectToAction("IdeaFeed");
            }
            return View("Index");
        }

        [HttpGet("IdeaFeed")]
        public IActionResult IdeaFeed(int UserId)
        {
            int? loggedUserId = HttpContext.Session.GetInt32("userId");
            if(loggedUserId == null) return RedirectToAction("Index");

            ViewBag.LoggedUser = _context.Users.FirstOrDefault(user => user.UserId == loggedUserId);
            ViewBag.AllIdeas = _context.Ideas.Include(u => u.Likes)
            .Include(idea => idea.Creator)
            .ToList();

            ViewBag.User = loggedUserId;
            return View();
        }

        [HttpPost("addidea")]
            public IActionResult AddIdea(Idea newIdea)
        {
            int? loggedUserId = HttpContext.Session.GetInt32("userId");
            if(loggedUserId == null) return RedirectToAction("Index");

            if(ModelState.IsValid)
            {
                ViewBag.LoggedUser = _context.Users.FirstOrDefault(user => user.UserId == loggedUserId);
                newIdea.UserId = (int)loggedUserId;
                _context.Add(newIdea);
                _context.SaveChanges();
                return RedirectToAction("IdeaFeed");
            }
            ViewBag.LoggedUser = _context.Users.FirstOrDefault(user => user.UserId == loggedUserId);
            ViewBag.AllIdeas = _context.Ideas.Include(u => u.Likes)
            .Include(idea => idea.Creator)
            .ToList();

            ViewBag.User = loggedUserId;

        return View("IdeaFeed");
        }

        [HttpGet("/users/{id}")]
        public IActionResult OneUser(int id)
        {
            int? loggedUserId = HttpContext.Session.GetInt32("userId");
            if(loggedUserId == null) return RedirectToAction("Index");

            ViewBag.OneUse = _context.Users
            .FirstOrDefault(u => u.UserId == id);
            return View();
        }

        [HttpGet("/idea/{id}")]
        public IActionResult OneIdea(int id)
        {
            int? loggedUserId = HttpContext.Session.GetInt32("userId");
            if(loggedUserId == null) return RedirectToAction("Index");

            ViewBag.LoggedUser = _context.Users.FirstOrDefault(user => user.UserId == loggedUserId);
            ViewBag.OneIdea = _context.Ideas
                .Include(i => i.Likes)
                .ThenInclude(r => r.User)
                .FirstOrDefault(i => i.IdeaId == id);
            ViewBag.AllIdeas = _context.Ideas
            // .Include(idea => idea.Creator)
            .ToList();

            return View();
        }

        [HttpGet("/idea/{id}/like")]
        public IActionResult AddLike(int id)
        {
            int loggedUserId = (int) HttpContext.Session.GetInt32("userId");

            Like like = new Like();
            like.UserId = loggedUserId;
            like.IdeaId = id;
            _context.Likes.Add(like);
            _context.SaveChanges();
            return RedirectToAction("IdeaFeed");
        }

        [HttpGet("/idea/{id}/delete")]
        public IActionResult DeleteIdea(int id)
        {
            Idea delete = _context.Ideas
            .FirstOrDefault(b => b.IdeaId == id);

            _context.Ideas.Remove(delete);
            _context.SaveChanges();
            return RedirectToAction("IdeaFeed");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
