using System.Collections.Generic;
using System.Linq;

namespace Plutus
{
    public class CartList
    {
        private readonly List<Cart> _cartList;
        private int _currentCart;
        private readonly List<bool> _cartsUsed;
        private readonly CartStorer _cartStore = new CartStorer(); // readonly

        public CartList()
        {
            _cartList = new List<Cart>();
            _currentCart = -1;
            _cartsUsed = new List<bool>();
        }

        public int GiveCartCount()
        {
            var count = _cartList.Count;
            return count;
        }

        public int GiveUsedCartCount()
        {
            var count = _cartsUsed.Count(x => x); // atkreipti demesi;
            return count;
        }

        public void CartSelect(string cartN) => _currentCart = int.Parse(cartN.Substring(5)) - 1;

        public void CartAdd(string cartN)
        {
            CartSelect(cartN);
            var cart = new Cart(cartN);
            _cartList.Add(cart);
            _cartsUsed.Add(true);
            SaveCart();
        }

        private void CartAdd(Cart cart)
        {
            _cartList.Add(cart);
            _cartsUsed.Add(true);
        }

        public Cart GiveCart() => _currentCart == -1 ? null : _cartList[_currentCart];

        public Cart GiveCart(int index) => _cartList[index];

        public void ChangeCart(Cart cart) => _cartList[_currentCart] = cart;

        public void RenameCart(string name)
        {
            _cartStore.RenameCart(_cartList[_currentCart], name);
            _cartList[_currentCart].CartName = name;
        }

        public void SaveCart() => _cartStore.StoreCart(_cartList[_currentCart]);

        public void DeleteCart()
        {
            _cartStore.DeleteCart(_cartList[_currentCart].CartName);
            _cartList[_currentCart] = null;
            _cartsUsed[_currentCart] = false;
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
