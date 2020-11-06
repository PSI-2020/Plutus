using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Plutus
{
    class FilterService
    {
        public List<Payment> FilterPayment(FileManager manager, string name = "", string category = "", string amountFrom = "", string amountTo = "")
        {
            if ((amountFrom != "" && !double.TryParse(amountFrom, out _)) || (amountTo != "" && !double.TryParse(amountTo, out _)))
                return null;

            var parsedAmountFrom = amountFrom == "" ? 0 : double.Parse(amountFrom);
            var parsedAmountTo = amountTo == "" ? 0 : double.Parse(amountTo);
            var dateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0);
            //var searchDateValueFrom = searchDateFrom.Value - searchDateFrom.Value.TimeOfDay;
            //var searchDateValueTo = searchDateTo.Value.AddDays(1) - searchDateTo.Value.TimeOfDay;

            var list = manager.ReadPayments("Expense");

            list.AddRange(manager.ReadPayments("Income"));

            return list.Where(x => x.Name.ToLower().Contains(name.ToLower()) || name == "")
                .Where(x => x.Category == category)
                .Where(x => x.Amount > parsedAmountFrom || amountFrom == "")
                .Where(x => x.Amount < parsedAmountTo || amountTo == "").ToList();
            //.Where(x => dateTime.AddSeconds(x.Date) > searchDateValueFrom || !searchDateFrom.Enabled)
            //.Where(x => dateTime.AddSeconds(x.Date) < searchDateValueTo || !searchDateTo.Enabled);
        }
    }
}
