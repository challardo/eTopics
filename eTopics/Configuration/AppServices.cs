using eTopics.BusinessManager.Interfaces;
using eTopics.Data;
using eTopics.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eTopics.Service.Interfaces;
using eTopics.Service;
using Microsoft.Extensions.FileProviders;
using System.IO;
using eTopics.BusinessManager;
using Microsoft.AspNetCore.Authorization;
using eTopics.Authorization;
using eTopics.BusinessManagers.Interfaces;
using eTopics.BusinessManagers;

namespace eTopics.Configuration
{
    public static class AppServices
    {
        public static void AddDefaultServices(this IServiceCollection servicesCollection, IConfiguration Configuration)
        {
            servicesCollection.AddDbContext<ApplicationDbContext>(options =>
              options.UseSqlServer(
                  Configuration.GetConnectionString("DefaultConnection")));
            servicesCollection.AddDefaultIdentity<ApplicationUsers>(options => options.SignIn.RequireConfirmedAccount = false)
                .AddEntityFrameworkStores<ApplicationDbContext>();
            servicesCollection.AddControllersWithViews().AddRazorRuntimeCompilation();
            servicesCollection.AddRazorPages();

            servicesCollection.AddSingleton<IFileProvider>(new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot")));
        }

        public static void AddCusomServices(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<IPostBusinessManager, PostBusinessManager>();
            serviceCollection.AddScoped<IAdminBusinessManager, AdminBusinessManager>();
           
            serviceCollection.AddScoped<IPostService, PostService>();


        }
        public static void AddCustomAuthorization(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<IAuthorizationHandler, PostAuthorizationHandler>();
        }
    }
}
