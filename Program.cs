using Plutus.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;
using Plutus.Services;
using System.Drawing.Text;

namespace Plutus
{
    static class Program
    {

        [STAThread]
        public static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var services = new ServiceCollection();

            ConfigureServices(services);

            using (var serviceProvider = services.BuildServiceProvider())
            {
                var form1 = serviceProvider.GetRequiredService<TrueGUI>();
                Application.Run(form1);
            }
        }

        private static void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<ICartFrontEndService, CartFrontendService>();
            services.AddScoped<IPaymentFrontEndService, PaymentFrontendService>();
            services.AddScoped<IShoppingFrontEndService, ShoppingFrontEndService>();
            services.AddScoped<IInfoHolder, CurrentInfoHolder>();
            services.AddScoped<TrueGUI>();
            services.AddSingleton<PlutusApiClient>();
            services.AddSingleton<PrivateFontCollection>();
        }
    }
}
