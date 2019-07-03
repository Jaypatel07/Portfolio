using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using portfolio.Models;
using Microsoft.EntityFrameworkCore;

namespace portfolio.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("/")]
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet("/projects")]
        public IActionResult Projects()
        {
            return View("Projects");
        }
        [HttpGet("/about")]
        public IActionResult About()
        {
            return View("About");
        }
        [HttpGet("/contact")]
        public IActionResult Contact()
        {
            return View("Contact");
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
