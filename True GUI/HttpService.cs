using Plutus.WebService;
using System.Collections.Generic;
using System.ComponentModel;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace Plutus
{
    public enum DataType
    {
        [Description("Storage/income.xml")]
        Income,
        [Description("Storage/expenses.xml")]
        Expense,
        [Description("Storage/monthlyIncome.xml")]
        MonthlyIncome,
        [Description("Storage/monthylExpenses.xml")]
        MonthlyExpenses,
        [Description("Storage/goals.xml")]
        Goals,
        [Description("Storage/budgets.xml")]
        Budgets,
        [Description("Storage/carts.xml")]
        Carts
    }

    public class HttpService
    {
        private static readonly HttpClient _httpClient = new HttpClient();

        public static async Task<List<All>> GetHistoryAsync(int index)
        {
            var response = await _httpClient.GetAsync("https://aspnet-ybkkj2yjkwqhk.azurewebsites.net/api/History/" + index);
            return response.IsSuccessStatusCode ? await response.Content.ReadFromJsonAsync<List<All>>() : null;
        }

        public static async Task<string> GetStatisticsAsync()
        {
            var response = await _httpClient.GetAsync("https://aspnet-ybkkj2yjkwqhk.azurewebsites.net/api/Statistics");
            return response.IsSuccessStatusCode ? await response.Content.ReadAsStringAsync() : null;
        }

        public static async Task PostPaymentAsync(Payment payment, string type) => await _httpClient.PostAsJsonAsync("https://aspnet-ybkkj2yjkwqhk.azurewebsites.net/api/Payment/" + type, payment);

        public static async Task<List<string>> GetCartNamesAsync()
        {
            var response = await _httpClient.GetAsync("https://localhost:44301/api/Carts/");
            return response.IsSuccessStatusCode ? await response.Content.ReadFromJsonAsync<List<string>>() : null;
        }

        public static async Task<List<CartExpense>> GetCartExpensesAsync(int index)
        {
            var response = await _httpClient.GetAsync("https://localhost:44301/api/Carts/Payments/" + index);
            return response.IsSuccessStatusCode ? await response.Content.ReadFromJsonAsync<List<CartExpense>>() : null;
        }

        public static async Task PostCart(int index, string name, List<CartExpense> cart) => await _httpClient.PostAsJsonAsync("https://localhost:44301/api/Carts/" + index + "/" + name, cart);
        public static async Task DeleteCart(int index) => await _httpClient.DeleteAsync("https://localhost:44301/api/Carts/" + index);
        
        public static async Task PostCartCharge(int index) => await _httpClient.PostAsync("https://localhost:44301/api/Carts/Charge/" + index, null);
        public static async Task PostChargeShopping(List<ShoppingExpense> bag) => await _httpClient.PostAsJsonAsync("https://localhost:44301/api/Shopping", bag);
        public static async Task<string> GetShoppingResult()
        {
            var response = await _httpClient.GetAsync("https://localhost:44301/api/Shopping/");
            return response.IsSuccessStatusCode ? await response.Content.ReadAsStringAsync() : null;
        }
    }
}
