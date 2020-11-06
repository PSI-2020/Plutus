using Microsoft.VisualBasic;
using Plutus.Services;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Plutus
{
    class CartService
    {
        private Cart _currentCart;
        private readonly List<Cart> _carts;
        private FileManager _fm;

        public CartService(FileManager fm)
        {
            _carts = new List<Cart>();
            _fm = fm;
            LoadCarts();
        }

        public void NewCart() => _currentCart = new Cart();

        public void AddExpenseToCart(CurrentInfoHolder cih)
        {
            var expense = new CartExpense(cih.CurrentName, double.Parse(cih.CurrentAmout), cih.CurrentCategory);
            _currentCart.AddExpense(expense);
        }

        public int GiveCurrentCartElemCount() => _currentCart.GiveElementC();

        public CartExpense GiveCurrentElemAt(int i) => _currentCart.GiveExpense(i);

        public void RemoveExpenseCurrentAt(int i) => _currentCart.RemoveExpense(i);

        public void SetCurrentName(string name) => _currentCart.ChangeName(name);
        public void AddCurrentCart()
        {
            _carts.Add(_currentCart);
            SaveCarts();
        }

        public string GiveCurrentName() => _currentCart.GiveName();
        public int GiveCartCount() => _carts.Count;

        public string VerifyName(string name, string prevname)
        {
            var repeatName = false;
            foreach (var cart in _carts)
            {
                if ((cart.GiveName() == name) && (cart.GiveName() != prevname))
                {
                    repeatName = true;
                }
            }
            return repeatName ? "Cart name already taken" : "";
        }

        public string GiveCartNameAt(int i) => _carts[i].GiveName();

        public void CurrentCartSet(int i) => _currentCart = _carts[i];

        public void SaveCartChanges(int i)
        {
            _carts[i] = _currentCart;
            SaveCarts();
        }

        public void DeleteCurrent()
        {
            _carts.Remove(_currentCart);
            SaveCarts();
        }

        public void ChargeCart(PaymentService ps)
        {
            for(var i = 0; i < _currentCart.GiveElementC(); i++)
            {
                var expense = _currentCart.GiveExpense(i);
                ps.AddCartPayment(expense.Name, expense.Price, expense.Category);
            }
        }
        private void SaveCarts()
        {
            var cartsXml = new List<XElement>();
            var index = 0;
            foreach (var cart in _carts)
            {
                var expenseXml = new List<XElement>();
                for (var i = 0; i < cart.GiveElementC(); i++)
                {
                    var expense = cart.GiveExpense(i);
                    var expenseX = new XElement("Expense",
                        new XElement("Name", expense.Name),
                        new XElement("Amount", expense.Price),
                        new XElement("Category", expense.Category),
                        new XElement("Activity", expense.Active));

                    expenseXml.Add(expenseX);
                }
                var cartXml = new XElement("Cart" + index,
                    new XElement("CartName", cart.GiveName()),
                    new XElement("Expenses", expenseXml));
                cartsXml.Add(cartXml);
                index++;
            }
            var cartsStored = new XElement("carts", cartsXml);
            _fm.SaveCarts(cartsStored);
        }

        private void LoadCarts()
        {
            var cartsStored = _fm.LoadCarts();
            if (cartsStored == null) return;
            var cartsXml = cartsStored.Elements();
            foreach (var cart in cartsXml)
            {
                var specificCart = new Cart();
                var cartName = (string)cart.Element("CartName");
                specificCart.ChangeName(cartName);
                var expenses = cart.Element("Expenses");
                var allExpenses = expenses.Elements();
                foreach (var expense in allExpenses)
                {
                    var cartExpense = new CartExpense(
                        (string)expense.Element("Name"),
                        (double)expense.Element("Amount"),
                        (string)expense.Element("Category")                        
                        );
                    specificCart.AddExpense(cartExpense);
                }
                _carts.Add(specificCart);
            }
        }

    }
}
