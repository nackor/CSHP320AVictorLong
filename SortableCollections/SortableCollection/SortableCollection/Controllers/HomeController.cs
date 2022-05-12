using Microsoft.AspNetCore.Mvc;
using SortableCollection.Models;
using System.Diagnostics;
using Microsoft.EntityFrameworkCore;

namespace SortableCollection.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public async Task<IActionResult> Index(string sortOrder)
        {
            ViewData["IdSortParam"] = String.IsNullOrEmpty(sortOrder) ? "id" : "";
            ViewData["NameSortParam"] = String.IsNullOrEmpty(sortOrder) ? "name" : "";
            ViewData["CitySortParam"] = String.IsNullOrEmpty(sortOrder) ? "city" : "";
            ViewData["StateSortParam"] = String.IsNullOrEmpty(sortOrder) ? "state" : "";
            ViewData["PhoneSortParam"] = String.IsNullOrEmpty(sortOrder) ? "phone" : "";

            var contacts = new[]
            {
                new Contact{Id = 1, Name="dave", City="Seattle", State="WA", Phone="123"},
                new Contact{Id = 2, Name="mike", City="Spokane", State="WA", Phone="234"},
                new Contact{Id = 3, Name="lisa", City="San Jose", State="CA", Phone="345"},
                new Contact{Id = 4, Name="cathy", City="Dallas", State="TX", Phone="456"},
            };
            var queryContacts = from s in contacts
                           select s;

            if (sortOrder != null)
            {
                switch (sortOrder.ToLower())
                {
                    case "id":
                        {
                            //donors.Sort((a, b) => a.amount.CompareTo(b.amount));
                            queryContacts = queryContacts.OrderBy(s => s.Id);
                            break;
                        }
                    case "name":
                        {
                            queryContacts = queryContacts.OrderBy(s => s.Name);
                            break;
                        }
                    case "city":
                        {
                            queryContacts = queryContacts.OrderBy(s => s.City);
                            break;
                        }
                    case "state":
                        {
                            queryContacts = queryContacts.OrderBy(s => s.State);
                            break;
                        }
                    case "phone":
                        {
                            queryContacts = queryContacts.OrderBy(s => s.Phone);
                            break;
                        }
                    default:
                        queryContacts = queryContacts.OrderBy(s => s.Id);
                        break;
                }
            }
            

            return View(queryContacts);
         
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