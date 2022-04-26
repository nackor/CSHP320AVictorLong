using BirthdayMessage.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BirthdayMessage.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
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

        [HttpGet]
        public IActionResult MessageForm()
        {
            return View();


        }

        [HttpPost]
        public IActionResult MessageForm(Message message)
        {
            if (ModelState.IsValid)
            {
                return View("Thanks", message);
            }
            else
            {
                return View();
            }


        }
    }
}