using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Geoi.Data;

namespace Geoi.Controllers
{
    public class HomeController : Controller
    {
        public HomeController(ApplicationDbContext db)
        {
            var query = from user in db.Users
                        where user.AccessFailedCount > 1
                        select user;

            query.Where(x => x.Email.Length > 5);
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult AboutUs()
        {
            return View();
        }

        public IActionResult Instruction()
        {
            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
        
        public IActionResult GEOI2017()
        {
            return View();
        }
    }
}
