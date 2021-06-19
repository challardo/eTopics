using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using eTopics.Models;
using eTopics.BusinessManager.Interfaces;
using eTopics.BusinessManagers.Interfaces;

namespace eTopics.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPostBusinessManager postBusinessManager;

        public HomeController(IPostBusinessManager postBusinessManager)
        {
            this.postBusinessManager = postBusinessManager;
        }

        public IActionResult Index(string searchstring, int? page)
        {
            return View(postBusinessManager.GetIndexViewModel(searchstring,page));
        }

        public IActionResult Privacy()
        {
            return View();
        }

    }
}
