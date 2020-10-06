using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Plutus

{
    class Cart
    {
        private List<CartExpense> cartParts;
        private string cartName;

        public Cart()
        {
            cartParts = new List<CartExpense>();
        }
        public Cart(string name) : this()
        {
            cartName = name;
        }

        public string GiveName()
        {
            return cartName;
        }

        public CartExpense GiveElement(int index)
        {
            return cartParts.ElementAt(index);
        }

        public void ChangeActivity(int index)
        {
            int i = 0;
            foreach (CartExpense expense in cartParts)
            {
                if(i == index)
                {
                    expense.Active = !expense.Active;
                }
                i++;
            }
        }

        public int GiveElementC()
        {
            return cartParts.Count;
        }

        public void ChangeName(string newName)
        {
            cartName = newName;
        }

        public void AddExpense(Expense expense)
        {
            CartExpense cExpense = new CartExpense(date: expense.Date, category: expense.Category, name: expense.Name, price: expense.Price, active: true);
            cartParts.Add(cExpense);
        }
        public void AddExpense(CartExpense expense)
        {
            CartExpense cExpense = new CartExpense(date: expense.Date, category: expense.Category, name: expense.Name, price: expense.Price, active: expense.Active);
            cartParts.Add(cExpense);
        }

        public void RemoveExpense(int number)
        {
            cartParts.RemoveAt(number);
        }

        public void Account(DataManager dm)
        {
            foreach (CartExpense expense in cartParts)
            {
                if (expense.Active)
                {
                    Expense charge = new Expense();
                    charge.Date = (int)(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalSeconds;
                    charge.Name = expense.Name;
                    charge.Price = expense.Price;
                    charge.Category = expense.Category;
                    dm.addExpense(charge);
                }
            }
        }

    }
}
