using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Plutus
{
    class Filtering
    {
        public string SearchData(FileManager manager, string name, string category, string searchNumberFromText, string searchNumberToText, int dataType, int categoryItem, DateTimePicker searchDateFrom, DateTimePicker searchDateTo)
        {
            if ((searchNumberFromText != "" && !double.TryParse(searchNumberFromText, out _)) || (searchNumberToText != "" && !double.TryParse(searchNumberToText, out _)))
                return "Incorrect amount format!";

            var data = "";
            List<Income> incomeList = null;
            List<Expense> expenseList = null;

            switch (dataType)
            {
                case 0:
                    incomeList = manager.ReadIncome();
                    expenseList = manager.ReadExpenses();
                    break;
                case 1:
                    expenseList = manager.ReadExpenses();
                    break;
                case 2:
                    incomeList = manager.ReadIncome();
                    break;
                default:
                    return "Error determining data type!";
            }

            var parsedNumberFrom = searchNumberFromText == "" ? 0 : double.Parse(searchNumberFromText);
            var parsedNumberTo = searchNumberToText == "" ? 0 : double.Parse(searchNumberToText);
            var dateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0);
            var searchDateValueFrom = searchDateFrom.Value - searchDateFrom.Value.TimeOfDay;
            var searchDateValueTo = searchDateTo.Value.AddDays(1) - searchDateTo.Value.TimeOfDay;

            if (expenseList != null)
            {
                var filteredExpenses = expenseList
                    .Where(x => x.Name.ToLower().Contains(name.ToLower()) || name == "")
                    .Where(x => x.Category == category || categoryItem == 0)
                    .Where(x => x.Price > parsedNumberFrom || searchNumberFromText == "")
                    .Where(x => x.Price < parsedNumberTo || searchNumberToText == "")
                    .Where(x => dateTime.AddSeconds(x.Date) > searchDateValueFrom || !searchDateFrom.Enabled)
                    .Where(x => dateTime.AddSeconds(x.Date) < searchDateValueTo || !searchDateTo.Enabled);

                if (filteredExpenses.Any())
                {
                    data += "Found expenses: " + System.Environment.NewLine;
                    foreach (var expense in filteredExpenses)
                    {
                        var date = dateTime.AddSeconds(expense.Date).ToLocalTime();
                        data += date + " | " + expense.Name + " | " + expense.Price + "€ | " + expense.Category + System.Environment.NewLine;
                    }
                }
            }

            if (incomeList != null && name == "")
            {
                var filteredIncome = incomeList
                    .Where(x => x.Category == category || categoryItem == 0)
                    .Where(x => x.Sum > parsedNumberFrom || searchNumberFromText == "")
                    .Where(x => x.Sum < parsedNumberTo || searchNumberToText == "")
                    .Where(x => dateTime.AddSeconds(x.Date) > searchDateValueFrom || !searchDateFrom.Enabled)
                    .Where(x => dateTime.AddSeconds(x.Date) < searchDateValueTo || !searchDateTo.Enabled);

                if (filteredIncome.Any())
                {
                    data += "Found income: " + System.Environment.NewLine;

                    foreach (var income in filteredIncome)
                    {
                        var date = dateTime.AddSeconds(income.Date).ToLocalTime();
                        data += date + " | " + income.Sum + "€ | " + income.Category + System.Environment.NewLine;
                    }
                }
            }

            if (data == "") data = "No data matching search criteria!";

            return data;
        }
    }
}
