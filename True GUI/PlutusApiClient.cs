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

    public class PlutusApiClient
    {
        private static readonly HttpClient _httpClient = new HttpClient();
        private static readonly string _path = Properties.Settings.Default.WebServicePath;

        public static async Task PostPaymentAsync(Payment payment, string type) => await _httpClient.PostAsJsonAsync(_path + "/api/Payment/" + type, payment);
        public static async Task PostGoalAsync(Goal goal) => await _httpClient.PostAsJsonAsync(_path + "/api/Goals/", goal);
        public static async Task DeleteGoalAsync(int id) => await _httpClient.DeleteAsync(_path + "/api/Goals/" + id);
        public static async Task SetAsMainGoalAsync(Goal goal) => await _httpClient.PutAsJsonAsync(_path + "/api/Goals/", goal);
        public static async Task PostBudgetAsync(Budget budget) => await _httpClient.PostAsJsonAsync(_path + "/api/Budgets/", budget);
        public static async Task DeleteBudgetAsync(int index) => await _httpClient.DeleteAsync(_path + "/api/Budgets/" + index);
        public static async Task PostScheduledPaymentAsync(ScheduledPayment payment, string type) => await _httpClient.PostAsJsonAsync(_path + "/api/Scheduler/" + type, payment);
        public static async Task DeleteScheduledPaymentAsync(int index, string type) => await _httpClient.DeleteAsync(_path + "/api/Scheduler/" + index + "/" + type);
        public static async Task ChangeScheduledPaymentStatusAsync(int index, string type, bool status) => await _httpClient.PutAsJsonAsync(_path + "/api/Scheduler/" + index + "/" + type + "/" + status, index);
        public static async Task CheckPaymentsAsync() => await _httpClient.PatchAsync(_path + "/api/Scheduler/", null);
        public static async Task EditGoalAsync(int id, Goal newGoal) => await _httpClient.PutAsJsonAsync(_path + "/api/Goals/edit/" + id, newGoal);
        public static async Task EditPayment(Payment payment, int index, DataType type) => await _httpClient.PutAsJsonAsync(_path + "/api/Payment/" + type + "/" + index, payment);
        public static async Task DeletePayment(Payment payment, DataType type) => await _httpClient.PutAsJsonAsync(_path + "/api/Payment/" + type, payment);


        public static async Task<List<History>> GetHistoryAsync(int index)
        {
            var response = await _httpClient.GetAsync(_path + "/api/History/" + index);
            return response.IsSuccessStatusCode ? await response.Content.ReadFromJsonAsync<List<History>>() : null;
        }

        public static async Task<List<Payment>> GetPaymentsAsync(string type)
        {
            var response = await _httpClient.GetAsync(_path + "/api/Payment/" + type);
            return response.IsSuccessStatusCode ? await response.Content.ReadFromJsonAsync<List<Payment>>() : null;
        }

        public static async Task<string> GetStatisticsAsync()
        {
            var response = await _httpClient.GetAsync(_path + "/api/Statistics");
            return response.IsSuccessStatusCode ? await response.Content.ReadAsStringAsync() : null;
        }
        public static async Task<List<Goal>> GetGoalsAsync()
        {
            var response = await _httpClient.GetAsync(_path + "/api/Goals/");
            return response.IsSuccessStatusCode ? await response.Content.ReadFromJsonAsync<List<Goal>>() : null;
        }
        public static async Task<string> GetGoalInsightsAsync(int index, string dailyOrMonthly)
        {
            var response = await _httpClient.GetAsync(_path + "/api/Goals/" + index + "/" + dailyOrMonthly);
            return response.IsSuccessStatusCode ? await response.Content.ReadAsStringAsync() : null;
        }

        public static async Task<string> GetBudgetAsync(int index)
        {
            var response = await _httpClient.GetAsync(_path + "/api/Budgets/" + index);
            return response.IsSuccessStatusCode ? await response.Content.ReadAsStringAsync() : null;
        }
        public static async Task<List<Budget>> GetBudgetsListAsync()
        {
            var response = await _httpClient.GetAsync(_path + "/api/Budgets/list");
            return response.IsSuccessStatusCode ? await response.Content.ReadFromJsonAsync<List<Budget>>() : null;
        }
        public static async Task<List<Payment>> GetBudgetStatsAsync(int index)
        {
            var response = await _httpClient.GetAsync(_path + "/api/Budgets/" + index + "/stats");
            return response.IsSuccessStatusCode ? await response.Content.ReadFromJsonAsync<List<Payment>>() : null;
        }
        public static async Task<string> GetScheduledPaymentAsync(int index, string type)
        {
            var response = await _httpClient.GetAsync(_path + "/api/Scheduler/" + index + "/" + type);
            return response.IsSuccessStatusCode ? await response.Content.ReadAsStringAsync() : null;
        }
        public static async Task<List<ScheduledPayment>> GetAllScheduledPaymentsAsync(string type)
        {
            var response = await _httpClient.GetAsync(_path + "/api/Scheduler/" + type);
            return response.IsSuccessStatusCode ? await response.Content.ReadFromJsonAsync<List<ScheduledPayment>>() : null;
        }
        public static async Task<List<string>> GetCartNamesAsync()
        {
            var response = await _httpClient.GetAsync(_path + "/api/Carts/");
            return response.IsSuccessStatusCode ? await response.Content.ReadFromJsonAsync<List<string>>() : null;
        }

        public static async Task<List<CartExpense>> GetCartExpensesAsync(int index)
        {
            var response = await _httpClient.GetAsync(_path + "/api/Carts/Payments/" + index);
            return response.IsSuccessStatusCode ? await response.Content.ReadFromJsonAsync<List<CartExpense>>() : null;
        }

        public static async Task PostCart(int index, string name, List<CartExpense> cart) => await _httpClient.PostAsJsonAsync(_path + "/api/Carts/" + index + "/" + name, cart);
        public static async Task DeleteCart(int index) => await _httpClient.DeleteAsync(_path + "/api/Carts/" + index);

        public static async Task PostCartCharge(int index) => await _httpClient.PostAsync(_path + "/api/Carts/Charge/" + index, null);
        public static async Task PostChargeShopping(List<ShoppingExpense> bag) => await _httpClient.PostAsJsonAsync(_path + "/api/Shopping", bag);
    }
}
