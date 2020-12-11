using Plutus.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;

namespace Plutus
{
    static class Program
    {
        public static TrueGUI trueGUI { get; private set; }

        static readonly HttpClient client = new HttpClient();

        static async Task<List<Payment>> GetProductAsync(string path)
        {
            var response = await client.GetAsync(path);
            return response.IsSuccessStatusCode ? await response.Content.ReadFromJsonAsync<List<Payment>>() : new List<Payment>();
        }

        /*static async Task<Product> UpdateProductAsync(Product product)
        {
            HttpResponseMessage response = await client.PutAsJsonAsync(
                $"api/products/{product.Id}", product);
            response.EnsureSuccessStatusCode();

            // Deserialize the updated product from the response body.
            product = await response.Content.ReadAsAsync<Product>();
            return product;
        }*/

        //static async Task<HttpStatusCode> DeleteProductAsync(string id)
        //{
        //    HttpResponseMessage response = await client.DeleteAsync(
        //        $"api/products/{id}");
        //    return response.StatusCode;
        //}

        static async Task RunAsync()
        {
            client.BaseAddress = new Uri("https://aspnet-ybkkj2yjkwqhk.azurewebsites.net/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            try
            {
                var list = await GetProductAsync("https://aspnet-ybkkj2yjkwqhk.azurewebsites.net/api/Payment");
                list.ForEach(x => Debug.Print(x.Name));
            }
            catch (Exception e)
            {
                Debug.Print(e.Message);
            }
        }

        [STAThread]
        public static void Main(IServiceCollection services)
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            services.AddScoped<ICartFrontEndService, CartFrontendService>();
            services.AddScoped<IShoppingFrontEndService, ShoppingFrontEndService>();
            trueGUI = new TrueGUI();
            Application.Run(trueGUI);
            /*var list = await GetProductAsync("https://aspnet-ybkkj2yjkwqhk.azurewebsites.net/api/Payment");
            list.ForEach(x => Debug.Print(x.Name));*/
            //RunAsync().GetAwaiter().GetResult();
        }
    }
}
