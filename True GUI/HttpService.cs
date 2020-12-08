using Plutus.WebService;
using System;
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

        public static async Task<List<Goal>> GetGoalsAsync()
        {
            var response = await _httpClient.GetAsync("https://aspnet-ybkkj2yjkwqhk.azurewebsites.net/api/Goals/");
            return response.IsSuccessStatusCode ? await response.Content.ReadFromJsonAsync<List<Goal>>() : null;
        }

        public static async Task PostGoalAsync(Goal goal) => await _httpClient.PostAsJsonAsync("https://aspnet-ybkkj2yjkwqhk.azurewebsites.net/api/Goals/", goal);

        public static async Task DeleteGoalAsync(int id) => await _httpClient.DeleteAsync("https://aspnet-ybkkj2yjkwqhk.azurewebsites.net/api/Goals/" + id);
        public static async Task SetAsMainGoalAsync(Goal goal) => await _httpClient.PutAsJsonAsync("https://aspnet-ybkkj2yjkwqhk.azurewebsites.net/api/Goals/", goal);
        public static async Task<string> GetGoalInsightsAsync(int index, string dailyOrMonthly)
        {
            var response = await _httpClient.GetAsync("https://aspnet-ybkkj2yjkwqhk.azurewebsites.net/api/Goals/" + index + "/" + dailyOrMonthly);
            return response.IsSuccessStatusCode ? await response.Content.ReadAsStringAsync() : null;
        }
        public static async Task<string> GetBudgetAsync(int index)
        {
            var response = await _httpClient.GetAsync("https://aspnet-ybkkj2yjkwqhk.azurewebsites.net/api/Budgets/" + index);
            return response.IsSuccessStatusCode ? await response.Content.ReadAsStringAsync() : null;
        }
        public static async Task<List<Budget>> GetBudgetsListAsync()
        {
            var response = await _httpClient.GetAsync("https://aspnet-ybkkj2yjkwqhk.azurewebsites.net/api/Budgets/list");
            return response.IsSuccessStatusCode ? await response.Content.ReadFromJsonAsync<List<Budget>>() : null;
        }
        public static async Task<List<Payment>> GetBudgetStatsAsync(int index)
        {
            var response = await _httpClient.GetAsync("https://aspnet-ybkkj2yjkwqhk.azurewebsites.net/api/Budgets/" + index + "/stats");
            return response.IsSuccessStatusCode ? await response.Content.ReadFromJsonAsync<List<Payment>>() : null;
        }
        public static async Task PostBudgetAsync(Budget budget) => await _httpClient.PostAsJsonAsync("https://aspnet-ybkkj2yjkwqhk.azurewebsites.net/api/Budgets/", budget);
        public static async Task DeleteBudgetAsync(int index) => await _httpClient.DeleteAsync("https://aspnet-ybkkj2yjkwqhk.azurewebsites.net/api/Budgets/" + index);
        public static async Task<string> GetScheduledPaymentAsync(int index, string type)
        {
            var response = await _httpClient.GetAsync("https://aspnet-ybkkj2yjkwqhk.azurewebsites.net/api/Scheduler/" + index + "/" + type);
            return response.IsSuccessStatusCode ? await response.Content.ReadAsStringAsync() : null;
        }
        public static async Task<List<ScheduledPayment>> GetAllScheduledPaymentsAsync(string type)
        {
            var response = await _httpClient.GetAsync("https://aspnet-ybkkj2yjkwqhk.azurewebsites.net/api/Scheduler/" + type);
            return response.IsSuccessStatusCode ? await response.Content.ReadFromJsonAsync<List<ScheduledPayment>>() : null;
        }
        public static async Task PostScheduledPaymentAsync(ScheduledPayment payment, string type) => await _httpClient.PostAsJsonAsync("https://aspnet-ybkkj2yjkwqhk.azurewebsites.net/api/Scheduler/" + type, payment);
        public static async Task DeleteScheduledPaymentAsync(int index, string type) => await _httpClient.DeleteAsync("https://aspnet-ybkkj2yjkwqhk.azurewebsites.net/api/Scheduler/" + index + "/" + type);
        public static async Task ChangeScheduledPaymentStatusAsync(int index, string type, bool status) => await _httpClient.PutAsJsonAsync("https://aspnet-ybkkj2yjkwqhk.azurewebsites.net/api/Scheduler/" + index + "/" + type + "/" + status, index);
        public static async Task CheckPaymentsAsync() => await _httpClient.PatchAsync("https://aspnet-ybkkj2yjkwqhk.azurewebsites.net/api/Scheduler/", null);

    }
}
