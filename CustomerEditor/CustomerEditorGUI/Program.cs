using System.ComponentModel.Design;
using System.ComponentModel;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace CustomerEditorGUI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            var host = CreateHostBuilder().Build();
            ServiceProvider = host.Services;

            Application.Run(ServiceProvider.GetRequiredService<Form1>());
        }


        public static IServiceProvider ServiceProvider { get; private set; }
       
        
        static IHostBuilder CreateHostBuilder()
        {
            return Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) => {
                    services.AddTransient<Abstractions.Interfaces.Services.ICustomerService, BusinessLogic.Services.CustomerService>();
                    services.AddSingleton<Abstractions.Interfaces.Repositories.ICustomerRepository, Repositories.Repositories.CustomerSqlRepository>();
                    services.AddTransient<Form1>();
                    services.AddTransient<FrmCustomerEdit>();
                });
        }

    }
}