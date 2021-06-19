using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eTopics.BusinessManager;
using eTopics.BusinessManager.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace eTopics.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {
        private readonly IAdminBusinessManager adminBusinessManager;

        public AdminController(IAdminBusinessManager adminBusinessManager)
        {
            this.adminBusinessManager = adminBusinessManager;
        }
        public async Task<IActionResult> Index()
        {
            
            return View(await adminBusinessManager.GetAdminDashBoard(User));

        }
    }
}
