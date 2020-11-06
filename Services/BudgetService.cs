using System;
using System.Collections.Generic;
using System.Linq;

namespace Plutus
{
    public class BudgetService
    {
        private readonly FileManager _fileManager = new FileManager();
        private readonly DateTime _date = new DateTime(1970, 1, 1);

        public void DeleteBudget(int index)
        {
            var list = _fileManager.LoadBudget();
            list.Remove(list[index]);
            _fileManager.UpdateBudgets(RenameBudgets(list));
        }
        public List<Budget> RenameBudgets(List<Budget> list)
        {
            list.ForEach(x => x.Name = "budget" + list.IndexOf(x));
            return list;
        }

        public string GenerateBudget(int index)
        {
            var data = "";
            var list = _fileManager.LoadBudget();

            var from = _date.AddSeconds(list[index].From).ToLocalTime();
            var to = _date.AddSeconds(list[index].To).ToLocalTime();


            var expenses = _fileManager.ReadPayments("Expense");
            if (!expenses.Any()) return "";


            data = "Budget for " + list[index].Category;
            var total = 0.00;

            total = expenses
                .Where(x => x.Category == list[index].Category)
                .Where(x => x.Date >= list[index].From)
                .Where(x => x.Date <= list[index].To)
                .Sum(x => x.Amount);

            data += "\r\n" + total + "/" + list[index].Sum + " €" + "\r\n" + Math.Round(total * 100 / list[index].Sum, 2) + "%" + "\r\n" +
                from.ToString("yyyy/MM/dd") + " - " + to.ToString("yyyy/MM/dd");

            return data;
        }
        public object ShowStats(int index)
        {
            var budgets = _fileManager.LoadBudget();
            var expenses = _fileManager.ReadPayments("Expense");

            var resQuery =
                (from exp in expenses
                 where exp.Category == budgets[index].Category
                 where exp.Date >= budgets[index].From
                 where exp.Date <= budgets[index].To
                 select exp).ToList();
            var list = resQuery
                .Select(x => new { DATE = _date.AddSeconds(x.Date).ToLocalTime(), NAME = x.Name, AMOUNT = x.Amount, CATEGORY = x.Category })
                .OrderByDescending(x => x.DATE).ToList();
            return !list.Any() ? null : (object)list;
        }

    }
}
