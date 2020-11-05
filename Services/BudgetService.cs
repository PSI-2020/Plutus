using System;
using System.Collections.Generic;
using System.Linq;

namespace Plutus
{
    public class BudgetService
    {
        private readonly FileManager _fileManager = new FileManager();
        readonly DateTime date = new DateTime(1970, 1, 1);

        public void DeleteBudget(int index)
        {
            var list = _fileManager.LoadBudget();
            list.Remove(list[index]);
            _fileManager.UpdateBudgets(RenameBudgets(list));
        }
        public List<Budget> RenameBudgets(List<Budget> list)
        {
            foreach (var item in list)
            {
                item.Name = "budget" + list.IndexOf(item);
            }
            return list;
        }

        public string GenerateBudget(int index)
        {
            var data = "";
            var list = _fileManager.LoadBudget();

            var from = date.AddSeconds(list[index].From).ToLocalTime();
            var to = date.AddSeconds(list[index].To).ToLocalTime();


            var expenses = _fileManager.ReadPayments("Expense");
            if (expenses == null) return "";


            data = "Budget for " + list[index].Category;
            var total = 0.00;

            total = expenses
                .Where(x => x.Category == list[index].Category)
                .Where(x => x.Date >= list[index].From)
                .Where(x => x.Date <= list[index].To)
                .Sum(x => x.Amount);

            data += "\r\n" + total + "/" + list[index].Sum + " €" + "\r\n" + Math.Round((total * 100 / list[index].Sum), 2) + "%" + "\r\n" +
                from.ToString("yyyy/MM/dd") + " - " + to.ToString("yyyy/MM/dd");


            return data;
        }
        public object ShowStats(int index)
        {
            var budgets = _fileManager.LoadBudget();
            var expenses = _fileManager.ReadPayments("Expense");
            var result = expenses
                .Where(x => x.Category == budgets[index].Category)
                .Where(x => x.Date >= budgets[index].From)
                .Where(x => x.Date <= budgets[index].To)
                .ToList();
            var list = result
                .Select(x => new { DATE = date.AddSeconds(x.Date).ToLocalTime().ToString("yyyy-MM-dd HH:ss"), NAME = x.Name, AMOUNT = x.Amount, CATEGORY = x.Category })
                .OrderByDescending(x => x.DATE).ToList();
            return !list.Any() ? null : (object)list;
        }

    }
}
