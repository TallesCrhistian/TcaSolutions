using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using TcaSolutions.Business;
using TcaSolutions.Business.Interfaces;
using TcaSolutions.Data;
using TcaSolutions.Data.Interfaces;
using TcaSolutions.Data.Repository;
using TcaSolutions.Data.Seeds;
using TcaSolutions.Data.WorkUnit;
using TcaSolutions.Services.Interfaces;
using TcaSolutions.Services.Login;
using TcaSolutions.Services.Products;
using TcaSolutions.Shared.ServiceProvider;
using TcaSolutions.Utils.Mapper;

namespace TcaSolutions.Forms
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var services = new ServiceCollection();

            services.AddDbContext<AppDbContext>(options =>
             options.UseNpgsql("Server=localhost;Port=5432;Database=tca_solutions;User Id=tca_solutions;Password=tca_solutions;Pooling=true;MinPoolSize=1;MaxPoolSize=20")
              );

            IMapper mapper = MappingProfile.InitializeAutoMapper();
            services.AddSingleton<IMapper>(mapper);
            services.AddSingleton<IWorkUnit, WorkUnit>();
            services.AddTransient<ILoginDefault, LoginDefault>();
            services.AddTransient<IProductServices, ProductServices>();
            services.AddTransient<IProductBusiness, ProductBusiness>();
            services.AddTransient<IAuthenticationServices, AuthenticationServices>();
            services.AddTransient<IAuthenticationBusiness, AuthenticationBusiness>();
            services.AddTransient<IAuthenticationRepository, AuthenticationRepository>();
            services.AddTransient<IBaseRepository, BaseRepository>();
            services.AddTransient<IProductRepository, ProductRepository>(); 



            var serviceProvider = services.BuildServiceProvider();
            ServiceProviderHolder.ServiceProvider = serviceProvider;
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new LoginForms(serviceProvider.GetRequiredService<IAuthenticationServices>(), serviceProvider.GetRequiredService<ILoginDefault>()));
        }
    }
}