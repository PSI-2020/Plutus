using System;
using System.Linq;

namespace Plutus.Services
{
    class HistoryService
    {
        public object LoadDataGrid(FileManager fileManager, int index)
        {
            var date = new DateTime(1970, 1, 1, 0, 0, 0, 0);

            switch (index)
            {
                case 0:
                    {
                        var list = fileManager.ReadPayments("Expense")
                                                  .Select(x => new { DATE = date.AddSeconds(x.Date).ToLocalTime().ToString("yyyy-MM-dd HH:ss"), NAME = x.Name, AMOUNT = x.Amount, CAT = x.Category , TYPE = "Expense"})
                                                  .ToList();
                        var incomeList = fileManager.ReadPayments("Income")
                                                  .Select(x => new { DATE = date.AddSeconds(x.Date).ToLocalTime().ToString("yyyy-MM-dd HH:ss"), NAME = x.Name, AMOUNT = x.Amount, CAT = x.Category, TYPE = "Income" })
                                                  .ToList();

                        list.AddRange(incomeList);

                        return !list.Any() ? null : (object)list.OrderByDescending(x => x.DATE).ToList();
                    }
                case 1:
                    {
                        var list = fileManager.ReadPayments("Expense")
                       .Select(x => new { DATE = date.AddSeconds(x.Date).ToLocalTime().ToString("yyyy-MM-dd HH:ss"), NAME = x.Name, AMOUNT = x.Amount, CATEGORY = x.Category })
                       .OrderByDescending(x => x.DATE).ToList();

                        return !list.Any() ? null : (object)list;
                    }
                case 2:
                    {
                        var list = fileManager.ReadPayments("Income")
                       .Select(x => new { DATE = date.AddSeconds(x.Date).ToLocalTime().ToString("yyyy-MM-dd HH:ss"), NAME = x.Name, AMOUNT = x.Amount, CATEGORY = x.Category })
                       .OrderByDescending(x => x.DATE).ToList();

                        return !list.Any() ? null : (object)list;
                    }
                default:
                    return null;
            }
        }

    }
}
