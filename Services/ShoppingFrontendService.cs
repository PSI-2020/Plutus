using Plutus.Interfaces;
using System.Collections.Generic;

namespace Plutus
{
    class ShoppingFrontEndService : IShoppingFrontEndService
    {
        private List<ShoppingExpense> _shoppingBag;
        private readonly PlutusApiClient _plutusApiClient;

        public ShoppingFrontEndService(PlutusApiClient plutusApi) => _plutusApiClient = plutusApi;

        public void InitializeShoppingService(Cart cart)
        {
            _shoppingBag = new List<ShoppingExpense>();
            for (var i = 0; i < cart.GiveElementC(); i++){
                var expense = new ShoppingExpense(cart.GiveExpense(i), 0);
                _shoppingBag.Add(expense);
            }
        }

        public void ElementClicked(int index) => _shoppingBag[index].State = _shoppingBag[index].State == 0 ? 1 : 0;

        public async void ChargeShopping() => await _plutusApiClient.PostChargeShopping(_shoppingBag);


        public List<string> GiveExpenses(int state)
        {
            var list = new List<string>();
            for(var i = 0; i < _shoppingBag.Count; i++)
            {
                if (_shoppingBag[i].State == state) list.Add(_shoppingBag[i].Name + '|' + i);
            }
            return list;
        }

    }
}
