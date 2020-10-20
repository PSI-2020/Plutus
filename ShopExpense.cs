using System;
using System.Collections.Generic;
using System.Text;

namespace Plutus
{
    class ShopExpense : Expense
    {
        public int State { get; set; }

        public ShopExpense(int date, string name, double price, string category, int state) : base(date, name, price, category)
        {
            State = state;
        }
        public ShopExpense(Expense expense)
        {
            Date = expense.Date;
            Name = expense.Name;
            Price = expense.Price;
            Category = expense.Category;
            State = 0;
        }
    }
}
