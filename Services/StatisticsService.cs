using System;
using System.Collections.Generic;
using System.Linq;

namespace Plutus
{
    enum ExpenseCategories
    {
        Groceries,
        Restaurant,
        Clothes,
        Transport,
        Health,
        School,
        Bills,
        Entertainment,
        Other
    }

    enum IncomeCategories
    {
        Salary,
        Gift,
        Investment,
        Sale,
        Rent,
        Other
    }

    class StatisticsService
    {
        public string GenerateExpenseStatistics(FileManager manager)
        {   
            var list = manager.ReadPayments("Expense");
            if (list == null) return "No expense data found!";

            var data = "Expense statistics: " + System.Environment.NewLine + System.Environment.NewLine;
            var total = list.Sum(x => x.Amount);
            var sums = new Dictionary<string, double>();

            foreach (var category in Enum.GetNames(typeof(ExpenseCategories)))
            {
                sums.Add(category, list.Where(x => x.Category == category).Sum(x => x.Amount));
            }

            foreach (var category in Enum.GetNames(typeof(ExpenseCategories)))
            {
                var percent = total == 0
                    ? " (" + String.Format("{0:0.00}", 0) + "%)"
                    : " (" + String.Format("{0:0.00}", sums[category] / total * 100) + "%)";
                data += category + " " + String.Format("{0:0.00}", sums[category]) + percent + System.Environment.NewLine;
            }
            return data;
        }

        public string GenerateIncomeStatistics(FileManager manager)
        {
            var list = manager.ReadPayments("Income");
            if (list == null) return "No income data found!";

            var data = "Income statistics: " + System.Environment.NewLine + System.Environment.NewLine;
            var total = list.Sum(x => x.Amount);
            var sums = new Dictionary<string, double>();

            foreach (var category in Enum.GetNames(typeof(IncomeCategories)))
            {
                sums.Add(category, list.Where(x => x.Category == category).Sum(x => x.Amount));
            }

            foreach (var category in Enum.GetNames(typeof(IncomeCategories)))
            {
                var percent = total == 0
                    ? " (" + String.Format("{0:0.00}", 0) + "%)"
                    : " (" + String.Format("{0:0.00}", sums[category] / total * 100) + "%)";
                data += category + " " + String.Format("{0:0.00}", sums[category]) + percent + System.Environment.NewLine;
            }
            return data;
        }
    }
}
