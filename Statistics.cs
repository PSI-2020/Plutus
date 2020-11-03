using System;
using System.Collections.Generic;

namespace Plutus
{
   /* class Statistics
    {
        public string GenerateExpenseStatistics(FileManager manager)
        {   
            var list = manager.ReadExpenses();
            if (list == null) return "No data found!";

            var data = "Expense statistics: " + System.Environment.NewLine;
            var total = 0.0;
            var sums = new Dictionary<string, double>();

            foreach (var category in Enum.GetNames(typeof(ExpenseCategories)))
            {
                sums.Add(category, 0);
            }

            foreach (var expense in list)
            {
                sums[expense.Category] += expense.Price;
                total += expense.Price;
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
            var list = manager.ReadIncome();
            if (list == null) return "No data found!";

            var data = System.Environment.NewLine + "Income statistics: " + System.Environment.NewLine;
            var total = 0.0;
            var sums = new Dictionary<string, double>();

            foreach (var category in Enum.GetNames(typeof(IncomeCategories)))
            {
                sums.Add(category, 0);
            }

            foreach (var income in list)
            {
                sums[income.Category] += income.Sum;
                total += income.Sum;
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
    }*/
}
