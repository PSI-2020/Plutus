using System.Linq;

namespace Plutus.Services
{
    public class HistoryService
    {
        public object LoadDataGrid(FileManager fileManager, int index)
        {
            switch (index)
            {
                case 0:
                    {  
                        var list = fileManager.ReadPayments("Expense")
                                                  .Select(x => new { DATE = x.Date.ConvertToDate(), NAME = x.Name, AMOUNT = x.Amount, CATEGORY = x.Category , TYPE = "Exp."})
                                                  .ToList();
                        var incomeList = fileManager.ReadPayments("Income")
                                                  .Select(x => new { DATE = x.Date.ConvertToDate(), NAME = x.Name, AMOUNT = x.Amount, CATEGORY = x.Category, TYPE = "Inc." })
                                                  .ToList();

                        list.AddRange(incomeList);

                        return !list.Any() ? null : (object)list.OrderByDescending(x => x.DATE).ToList();
                    }
                case 1:
                    {
                        var list = fileManager.ReadPayments("Expense")
                       .Select(x => new { DATE = x.Date.ConvertToDate(), NAME = x.Name, AMOUNT = x.Amount, CATEGORY = x.Category })
                       .OrderByDescending(x => x.DATE).ToList();

                        return !list.Any() ? null : (object)list;
                    }
                case 2:
                    {
                        var list = fileManager.ReadPayments("Income")
                       .Select(x => new { DATE = x.Date.ConvertToDate(), NAME = x.Name, AMOUNT = x.Amount, CATEGORY = x.Category })
                       .OrderByDescending(x => x.DATE).ToList();

                        return !list.Any() ? null : (object)list;
                    }
                default:
                    return null;
            }
        }

    }
}
