using System.Collections.Generic;
using System.Linq;

namespace Plutus
{
    class CartFrontendService
    {
        private Cart _currentCart;
        private List<Cart> _carts;

        public CartFrontendService() => LoadCarts();

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

        public string VerifyName(string name, string prevname) => _carts.Where(x => ((x.GiveName() == name) && (x.GiveName() != prevname))).Any() ? "Cart name already taken" : "";

        public string GiveCartNameAt(int i) => _carts[i].GiveName();

        public void CurrentCartSet(int i) => _currentCart = _carts[i];

        public void SaveCartChanges(int i)
        {
            _carts[i] = _currentCart;
            SaveCarts();
        }

        public async void DeleteCurrent()
        {
            var index = _carts.IndexOf(_currentCart);
            _carts.Remove(_currentCart);
            await HttpService.DeleteCart(index);
        }

        public async void ChargeCart()
        {
            var index = _carts.IndexOf(_currentCart);
            await HttpService.PostCartCharge(index);
        }
        private async void SaveCarts()
        {
            var index = _carts.IndexOf(_currentCart);
            var name = _currentCart.GiveName();
            var cartexpenses = new List<CartExpense>();
            for (var i = 0; i < _currentCart.GiveElementC(); i++)
            {
                cartexpenses.Add(_currentCart.GiveExpense(i));
            }
            await HttpService.PostCart(index, name, cartexpenses);
        }

        private async void LoadCarts()
        {
            var carts = new List<Cart>();
            var names = (await HttpService.GetCartNamesAsync());
            for(var i = 0; i < names.Count; i++)
            {
                var expenses = (await HttpService.GetCartExpensesAsync(i));
                var cart = new Cart(names[i]);
                for (var y = 0; y < expenses.Count; y++)
                {
                    cart.AddExpense(expenses[y]);
                }
                carts.Add(cart);
            }
            _carts = carts;
        }

        public Cart StartShopping() => _currentCart;

    }
}
