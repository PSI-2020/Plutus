using System;
using System.Collections.Generic;
using System.Linq;

namespace Plutus

{
    public class Cart
    {
        private readonly List<CartExpense> _cartParts;
        public string CartName { get; set; }


        public Cart() => _cartParts = new List<CartExpense>();
        public Cart(string name) : this() => CartName = name;

        public Cart(string name, List<CartExpense> list) : this(name)
        {
            foreach (var expense in list)
            {
                _cartParts.Add(expense);
            }
        }

        public CartExpense GiveElement(int index) => _cartParts.ElementAt(index);

        public void ChangeActivity(int index)
        {
            var i = 0;
            foreach (var expense in _cartParts)
            {
                if (i == index)
                {
                    expense.Active = !expense.Active;
                }
                i++;
            }
        }

        public int GiveElementC() => _cartParts.Count;

        public void AddExpense(Expense expense)
        {
            var cExpense = new CartExpense(date: expense.Date, category: expense.Category, name: expense.Name, price: expense.Price, active: true);
            _cartParts.Add(cExpense);
        }
        public void AddExpense(CartExpense expense)
        {
            var cExpense = new CartExpense(date: expense.Date, category: expense.Category, name: expense.Name, price: expense.Price, active: expense.Active);
            _cartParts.Add(cExpense);
        }

        public void RemoveExpense(int number) => _cartParts.RemoveAt(number);

        public void Account(DataManager dm)
        {
            foreach (var expense in _cartParts)
            {
                if (expense.Active)
                {
                    var charge = new Expense
                    {
                        Date = (int)DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1)).TotalSeconds,
                        Name = expense.Name,
                        Price = expense.Price,
                        Category = expense.Category
                    };
                    dm.addExpense(charge);
                }
            }
        }

    }
}
