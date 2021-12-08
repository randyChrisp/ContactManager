using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContactManager.Models;

namespace ContactManager.Controllers
{
    public class HomeController : Controller
    {
        private IRepository<Contact> data { get; set; }

        public HomeController(IRepository<Contact> rep)
        {
            this.data = rep;
        }

        public ViewResult Index()
        {
            var options = new QueryOptions<Contact>
            {
                Includes = "Category",
                OrderBy = c => c.FirstName
            };

            var contacts = data.List(options);
                
            return View(contacts);
        }
    }
}
