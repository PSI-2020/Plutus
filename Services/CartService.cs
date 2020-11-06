using Plutus.Services;
using System.Collections.Generic;

namespace Plutus
{
    class CartService
    {
        private Cart _currentCart;
        private readonly List<Cart> _carts;

        public CartService() => _carts = new List<Cart>();

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
        public void AddCurrentCart() => _carts.Add(_currentCart);

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

        public void SaveCartChanges(int i) => _carts[i] = _currentCart;

        public void DeleteCurrent() => _carts.Remove(_currentCart);

        public void ChargeCart(PaymentService ps, FileManager fm)
        {
            for(var i = 0; i < _currentCart.GiveElementC(); i++)
            {
                var expense = _currentCart.GiveExpense(i);
                ps.AddCartPayment(expense.Name, expense.Price, expense.Category, fm);
            }
        }

    }
}
