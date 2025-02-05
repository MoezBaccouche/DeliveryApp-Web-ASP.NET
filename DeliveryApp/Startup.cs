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
using DeliveryApp.Data;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using PFEGestionConges.Data.Repo;
using DeliveryApp.Services.Contracts;
using DeliveryApp.Services.Implementations;
using Microsoft.AspNetCore.Http;
using DeliveryApp.RazorHtmlEmails;

namespace DeliveryApp
{
    public class Startup
    {

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("DefaultConnection")));
            services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddEntityFrameworkStores<ApplicationDbContext>();

            services.Configure<IdentityOptions>(options =>
            {
                options.Password.RequireDigit = false;
                options.Password.RequireUppercase = false;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireLowercase = false;
                options.Password.RequiredLength = 4;
            });

            services.AddSession(options =>
            {
                options.Cookie.Name = ".AdventureWorks.Session";
                options.IdleTimeout = TimeSpan.FromDays(365);
                options.Cookie.IsEssential = true;
            });


            services.AddControllersWithViews();
            services.AddRazorPages();

            // Add application services.
            services.AddTransient<ICategoryService, CategoryService>();
            services.AddTransient<IProductService, ProductService>();
            services.AddTransient<IProductImageService, ProductImageService>();
            services.AddTransient<IDeliveryManService, DeliveryManService>();
            services.AddTransient<IOrderService, OrderService>();
            services.AddTransient<IClientService, ClientService>();
            services.AddTransient<IAdminService, AdminService>();
            services.AddTransient<ILocationService, LocationService>();
            services.AddTransient<IProductOrderService, ProductOrderService>();
            services.AddTransient<IFavoritesService, FavoritesService>();
            services.AddTransient<ICartProductService, CartProductService>();
            services.AddTransient<IDeliveryInfoService, DeliveryInfoService>();
            services.AddTransient<IRatingService, RatingService>();
            services.AddTransient<ICurrentLocationService, CurrentLocationService>();
            services.AddTransient<IEmailSenderService, EmailSenderService>();
            services.AddTransient<IRazorViewToStringRenderer, RazorViewToStringRenderer>();

            // Repository
            services.AddScoped(typeof(IRepository<>), typeof(RepositoryBase<>));

            // Data context
            var option = new DbContextOptions<ApplicationDbContext>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }

            app.UseStaticFiles();

            app.UseSession();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapRazorPages();
            });
        }
    }
}
