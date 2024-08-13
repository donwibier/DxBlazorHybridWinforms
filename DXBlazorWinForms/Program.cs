using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.UserSkins;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Configuration;
using DxBlazorApplication.Data;

namespace DXBlazorWinForms
{
    internal static class Program
    {
        public static IServiceProvider ServiceProvider { get; private set; }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var host = CreateHostBuilder().Build();
            ServiceProvider = host.Services;


            Application.Run(ServiceProvider.GetRequiredService<FrmMain>());
        }

        static IHostBuilder CreateHostBuilder()
        {
            var result = Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) =>
                {
                    services.AddWindowsFormsBlazorWebView();
                    services.AddTransient<FrmMain>();
                    services.AddDevExpressBlazor(options => {
                        options.BootstrapVersion = DevExpress.Blazor.BootstrapVersion.v5;
                        options.SizeMode = DevExpress.Blazor.SizeMode.Medium;
                    });
                    services.AddSingleton<WeatherForecastService>();

                    services.AddSingleton<CustomerStore>();
                    services.AddSingleton<AppBridge>();
                });

            return result;
        }


    }
}
