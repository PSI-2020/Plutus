using System;
using System.Collections.Generic;
using System.Text;

namespace Plutus
{
    class CartList
    {
        private List<Cart> _cartList;
        private int _currentCart;
        private List<bool> _cUsed;
        private CartStorer _cartStore = new CartStorer();

        public CartList()
        {
            _cartList = new List<Cart>();
            _currentCart = -1;
            _cUsed = new List<bool>();
        }

        public int GiveCartCount()
        {
            var count = _cartList.Count;
            return count;
        }

        public int GiveUsedCartCount()
        {
            var count = 0;
            foreach (bool el in _cUsed)
            {
                if (el) count++;
            }
            return count;
        }

        public void CartSelect(string cartN)
        {
           _currentCart = (int.Parse(cartN.Substring(5)) - 1);
        }

        public void CartAdd(string cartN)
        {
            CartSelect(cartN);
            var cart = new Cart(cartN);
            _cartList.Add(cart);
            _cUsed.Add(true);
            SaveCart();
        }

        public void CartAdd(Cart cart)
        {
            _cartList.Add(cart);
            _cUsed.Add(true);
        }

        public Cart GiveCart()
        {
            if (_currentCart == -1) return null;
            return _cartList[_currentCart];
        }

        public Cart GiveCart(int index)
        {
            return _cartList[index];
        }

        public void ChangeCart(Cart cart)
        {
            _cartList[_currentCart] = cart;
        }

        public void RenameCart(string name)
        {
            _cartStore.RenameCart(_cartList[_currentCart], name);
            _cartList[_currentCart].CartName = name;
        }

        public void SaveCart()
        {
            _cartStore.StoreCart(_cartList[_currentCart]);
        }

        public void DeleteCart()
        {
            _cartStore.DeleteCart(_cartList[_currentCart].CartName);
            _cartList[_currentCart] = null;
            _cUsed[_currentCart] = false;
            _currentCart = -1;
        }

        public void LoadCarts()
        {
            Cart cart;
            var count = _cartStore.GiveCartCount();
            if (count > 0)
            {
                for (var i = 0; i < count; i++)
                {
                    cart = _cartStore.LoadCart(i);
                    CartAdd(cart);
                }
            }
        }




    }
}
