using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;
using Shared.Interfaces;
using BeuticianBusiness;
using BeuticianData;

namespace BeuticianDesktop
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var services = new ServiceCollection();
            ConfigureServices(services);

            using (ServiceProvider serviceProvider = services.BuildServiceProvider())
            {
                var form = serviceProvider.GetRequiredService<AdminLoginForm>();
                Application.Run(form);

            }

        }

        private static void ConfigureServices(ServiceCollection services)
        {
            services.AddScoped<IAdminBusiness, AdminBusiness>();
            services.AddScoped<IAdminRepository, AdminRepository>();

            services.AddScoped<ICategoryBusiness, CategoryBusiness>();
            services.AddScoped<ICategoryRepository, CategoryRepository>();

            services.AddScoped<IManufacturerBusiness, ManufacturerBusiness>();
            services.AddScoped<IManufacturerRepository, ManufacturerRepository>();

            services.AddScoped<IProductBusiness, ProductBusiness>();
            services.AddScoped<IProductRepository, ProductRepository>();

            services.AddScoped<AdminLoginForm>();
        }
    }
}
