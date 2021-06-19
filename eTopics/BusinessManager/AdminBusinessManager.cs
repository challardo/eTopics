using eTopics.BusinessManager.Interfaces;
using eTopics.Data.Models;
using eTopics.Models.AdminViewModels;
using eTopics.Service.Interfaces;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace eTopics.BusinessManager
{
    public class AdminBusinessManager: IAdminBusinessManager
    {
        private readonly UserManager<ApplicationUsers> userManager;
        private readonly IPostService postService;
        public AdminBusinessManager(
            UserManager<ApplicationUsers> userManager,
           IPostService postService)
        {
            this.userManager = userManager;
            this.postService = postService;
        }
        

        public async Task<IndexViewModel> GetAdminDashBoard(ClaimsPrincipal claimsPrincipal)
        {
            var applicationUser = await userManager.GetUserAsync(claimsPrincipal);
            return new IndexViewModel {

                Posts = postService.GetPosts(applicationUser)
            };
        }
    }
}
