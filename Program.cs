using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using System;
using System.Windows.Forms;

namespace Plutus
{
    static class Program
    {
        public static TrueGUI trueGUI { get; private set; }

        [STAThread]
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().RunAsync();

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            trueGUI = new TrueGUI();
            Application.Run(trueGUI);
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
