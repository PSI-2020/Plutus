using System;


namespace Plutus
{ 
public class Budgets
{
    private string Category { get; set; }
    private double Sum { get; set; }
    private DateTime From, To;
    private readonly DataManager Manager;
    public Budgets(DataManager manager, string category, double sum, DateTime from, DateTime to)
    {
            Manager = manager;
            Category = category;
            Sum = sum;
            From = from;
            To = to;
    }

    public string ShowBudget()
        {
            var list = Manager.readExpenses();
            if (list == null) return "No data found!";

            var fromSec = (int)(From.Subtract(new DateTime(1970, 1, 1))).TotalSeconds;
            var toSec = (int)(To.Subtract(new DateTime(1970, 1, 1))).TotalSeconds;
            var data = "Budget for " + Category;
            var total = 0.00;

            foreach (var expense in list)
            {
                if(expense.Category == Category && expense.Date >= fromSec && expense.Date <= toSec)
                {
                    total += expense.Price;
                }
            }

            data += "\r\n" + total + "/" + Sum + "\r\n" + Math.Round((total*100/Sum),2) + "%";

            return data;
        }
}
}
