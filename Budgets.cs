using System;


namespace Plutus
{ 
public class Budgets
{
    public Budgets()
    {
    }

    public string ShowBudget(DataManager manager, string category, double sum)
        {
            var list = manager.readExpenses();
            if (list == null) return "No data found!";

            var data = "Budget for " + category;
            var total = 0.00;

            foreach (var expense in list)
            {
                if(expense.Category == category)
                {
                    total += expense.Price;
                }
            }

            data += "\r\n" + total + "/" + sum + "\r\n" + Math.Round((total*100/sum),2) + "%";

            return data;
        }
}
}
