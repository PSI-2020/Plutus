using Plutus.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Plutus
{
    class CartFrontendService : ICartFrontEndService
    {
        private Cart _currentCart;
        private List<Cart> _carts;
        private readonly PlutusApiClient _plutusApiClient;

        public CartFrontendService(PlutusApiClient plutusApi)
        {
            _plutusApiClient = plutusApi;
            _carts = LoadCartsAsync().Result;
        }

        public void NewCart() => _currentCart = new Cart();
        public void AddExpenseToCart(IInfoHolder cih)
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
            SaveCartsAsync();
        }

        public string GiveCurrentName() => _currentCart.GiveName();
        public int GiveCartCount() => _carts.Count;

        public string VerifyName(string name, string prevname) => _carts.Where(x => ((x.GiveName() == name) && (x.GiveName() != prevname))).Any() ? "Cart name already taken" : "";

        public string GiveCartNameAt(int i) => _carts[i].GiveName();

        public void CurrentCartSet(int i) => _currentCart = _carts[i];

        public void SaveCartChanges(int i)
        {
            _carts[i] = _currentCart;
            SaveCartsAsync();
        }

        public async void DeleteCurrentAsync()
        {
            var index = _carts.IndexOf(_currentCart);
            _carts.Remove(_currentCart);
            await _plutusApiClient.DeleteCartAsync(index);
        }

        public async void ChargeCartAsync()
        {
            var index = _carts.IndexOf(_currentCart);
            await _plutusApiClient.PostCartChargeAsync(index);
        }
        private async void SaveCartsAsync()
        {
            var index = _carts.IndexOf(_currentCart);
            var name = _currentCart.GiveName();
            var cartexpenses = new List<CartExpense>();
            for (var i = 0; i < _currentCart.GiveElementC(); i++)
            {
                cartexpenses.Add(_currentCart.GiveExpense(i));
            }
            await _plutusApiClient.PostCartAsync(index, name, cartexpenses);
        }

        private async Task<List<Cart>> LoadCartsAsync()
        {
            var carts = new List<Cart>();
            var names = (await _plutusApiClient.GetCartNamesAsync());
            for(var i = 0; i < names.Count; i++)
            {
                var expenses = (await _plutusApiClient.GetCartExpensesAsync(i));
                var cart = new Cart(names[i]);
                for (var y = 0; y < expenses.Count; y++)
                {
                    cart.AddExpense(expenses[y]);
                }
                carts.Add(cart);
            }
            return carts;
        }

        public Cart StartShopping() => _currentCart;

    }
}
