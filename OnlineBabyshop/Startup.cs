using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using OnlineBabyshop.Data;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Authorization;
<<<<<<< HEAD
=======
<<<<<<< HEAD
>>>>>>> 89dfc6c724e9a8493a70b7d55b5cf46b63d3eb62
using Microsoft.AspNetCore.Http;
using OnlineBabyshop.Models;
using OnlineBabyshop.Data.Repositories;
using OnlineBabyshop.Data.Interfaces;
<<<<<<< HEAD
=======
=======
using OnlineBabyshop.Data.Interfaces;
using OnlineBabyshop.Data.Repositories;
using Microsoft.AspNetCore.Http;
using OnlineBabyshop.Models;
>>>>>>> f59acac8d55b8772f369c689cbacb105318e8a3a
>>>>>>> 89dfc6c724e9a8493a70b7d55b5cf46b63d3eb62

namespace OnlineBabyshop
{
    public class Startup
    {
        //public Startup(IConfiguration configuration)
        //{
        //    Configuration = configuration;
        //}

        //public IConfiguration Configuration { get; }
        private IConfigurationRoot _configurationRoot;
        public Startup(Microsoft.AspNetCore.Hosting.IHostingEnvironment hostingEnvironment)
        {
            _configurationRoot = new ConfigurationBuilder()
                .SetBasePath(hostingEnvironment.ContentRootPath)
                .AddJsonFile("appsettings.json")
                .Build();
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
<<<<<<< HEAD
            //services.AddDbContext<ApplicationDbContext>(options =>
            //    options.UseSqlServer(
            //        Configuration.GetConnectionString("DefaultConnection")));
            //services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
            //    .AddEntityFrameworkStores<ApplicationDbContext>();
            //services.AddControllersWithViews();
            //services.AddRazorPages();

            services.AddDbContext<ApplicationDbContext>(options =>
              options.UseSqlServer(
                  Configuration.GetConnectionString("DefaultConnection")));


<<<<<<< HEAD
=======
=======
            //Server configuration
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(_configurationRoot.GetConnectionString("DefaultConnection")));
            //Authentication, Identity config
>>>>>>> f59acac8d55b8772f369c689cbacb105318e8a3a
>>>>>>> 89dfc6c724e9a8493a70b7d55b5cf46b63d3eb62
            services.AddIdentity<IdentityUser, IdentityRole>()
                .AddEntityFrameworkStores<ApplicationDbContext>();


            //services.AddIdentity<IdentityUser, IdentityRole>()
            //.AddRoleManager<RoleManager<IdentityRole>>()
            //.AddEntityFrameworkStores<ApplicationDbContext>()
            //.AddDefaultUI()
            //.AddDefaultTokenProviders();

            //services.AddTransient<ICategoryRepository, CategoryRepository>();
            services.AddTransient<IProductsRepository, ProductsRepository>();

            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddScoped(sp => ShoppingCart.GetCart(sp));
            services.AddTransient<IOrdersRepository, OrdersRepository>();
<<<<<<< HEAD
            services.AddMemoryCache();
            services.AddSession();

=======
<<<<<<< HEAD
            services.AddMemoryCache();
            services.AddSession();

=======
>>>>>>> f59acac8d55b8772f369c689cbacb105318e8a3a

            services.AddMvc();
            services.AddMemoryCache();
            services.AddSession();
>>>>>>> 89dfc6c724e9a8493a70b7d55b5cf46b63d3eb62


            //            services.AddMvc(options =>
            //            {
            //                var policy = new AuthorizationPolicyBuilder()
            //.RequireAuthenticatedUser()
            //.Build();
            //                options.Filters.Add(new AuthorizeFilter(policy));
            //            }).AddXmlSerializerFormatters();
            //            services.AddControllersWithViews();
            //            services.AddRazorPages();
            //        }

<<<<<<< HEAD
            //            services.AddMvc(options =>
            //            {
            //                var policy = new AuthorizationPolicyBuilder()
            //.RequireAuthenticatedUser()
            //.Build();
            //                options.Filters.Add(new AuthorizeFilter(policy));
            //            }).AddXmlSerializerFormatters();
            //            services.AddControllersWithViews();
            //            services.AddRazorPages();
            //        }

=======
>>>>>>> 89dfc6c724e9a8493a70b7d55b5cf46b63d3eb62
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, IServiceProvider serviceProvider)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseSession();
<<<<<<< HEAD
=======
<<<<<<< HEAD
=======
           
>>>>>>> f59acac8d55b8772f369c689cbacb105318e8a3a
>>>>>>> 89dfc6c724e9a8493a70b7d55b5cf46b63d3eb62

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Categories}/{action=ListOfCategories}/{id?}");
                endpoints.MapRazorPages();
            });
            CreateRoles(serviceProvider);

        }

        private async Task CreateRoles(IServiceProvider serviceProvider)
        {
            var RoleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();
            var UserManager = serviceProvider.GetRequiredService<UserManager<IdentityUser>>();

            //var db = new ApplicationDbContext();
            //var store = new RoleManager<IdentityRole>(db);
            //var roleManager = new RoleManager<IdentityRole>(store);
            //roleManager.Create(new IdentityRole("Admin"));
            //roleManager.Delete(roleManager.FindByName("Moderator"));

            IdentityResult roleResult;
            //here in this line we are adding Admin Role
            var roleCheck = await RoleManager.RoleExistsAsync("Admin");
            if (!roleCheck)
            {
                //here in this line we are creating admin role and seed it to the database
                roleResult = await RoleManager.CreateAsync(new IdentityRole("Admin"));
            }
            //here we are assigning the Admin role to the User that we have registered above 
            //Now, we are assinging admin role to this user("Ali@gmail.com"). When will we run this project then it will
            //be assigned to that user.
<<<<<<< HEAD
            IdentityUser user = await UserManager.FindByEmailAsync("admin@123.com");
=======
<<<<<<< HEAD
            IdentityUser user = await UserManager.FindByEmailAsync("admin@123.com");
=======
            IdentityUser user = await UserManager.FindByEmailAsync("arwa533@hotmail.com");
>>>>>>> f59acac8d55b8772f369c689cbacb105318e8a3a
>>>>>>> 89dfc6c724e9a8493a70b7d55b5cf46b63d3eb62
            var User = new IdentityUser();
            await UserManager.AddToRoleAsync(user, "Admin");
        }







    }
}
