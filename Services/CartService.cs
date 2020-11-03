using System;
using System.Collections.Generic;
using System.Text;

namespace Plutus
{
    class CartService
    {
        private Cart _currentCart;
        private List<Cart> _carts;

        public CartService()
        {
            _carts = new List<Cart>();
        }

        public void NewCart()
        {
            _currentCart = new Cart();
        }

        public void AddExpenseToCart(CurrentInfoHolder cih)
        {
            var expense = new CartExpense(cih.CurrentName, double.Parse(cih.CurrentAmout), cih.CurrentCategory);
            _currentCart.AddExpense(expense);
        }

        public int GiveCurrentCartElemCount()
        {
            return _currentCart.GiveElementC();
        }

        public CartExpense GiveCurrentElemAt(int i)
        {
            return _currentCart.GiveExpense(i);
        }

        public void RemoveRemoveCurrentAt(int i)
        {
            _currentCart.RemoveExpense(i);
        }
        public void AddCurrentCart(string name)
        {
            _currentCart.ChangeName(name);
            _carts.Add(_currentCart);
        }

        public string GiveCurrentName()
        {
            return _currentCart.GiveName();
        }
        public int GiveCartCount()
        {
            return _carts.Count;
        }

        public string VerifyName(string name)
        {
            bool repeatName = false;
            foreach (Cart cart in _carts)
            {
                if(cart.GiveName() == name)
                {
                    repeatName = true;
                }
            }
            return (repeatName) ? "Cart name already taken" : ""; 
        }

        public string GiveCartNameAt(int i)
        {
            return _carts[i].GiveName();
        }

        public void CurrentCartSet(int i)
        {
            _currentCart = _carts[i];
        }
        public void DeleteCurrent()
        {
            _carts.Remove(_currentCart);
        }



    }
}
