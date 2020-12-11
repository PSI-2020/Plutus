﻿using Plutus.Interfaces;
using System.Collections.Generic;

namespace Plutus
{
    class ShoppingFrontEndService : IShoppingFrontEndService
    {
        private List<ShoppingExpense> _shoppingBag;
        public string RetMess { get; set; }
        
        public void InitializeShoppingService(Cart cart)
        {
            RetMess = "Shopping Done";
            _shoppingBag = new List<ShoppingExpense>();
            for (var i = 0; i < cart.GiveElementC(); i++){
                var expense = new ShoppingExpense(cart.GiveExpense(i), 0);
                _shoppingBag.Add(expense);
            }
        }

        public void ElementClicked(int index) => _shoppingBag[index].State = _shoppingBag[index].State == 0 ? 1 : 0;

        public async void ChargeShopping() => await PlutusApiClient.PostChargeShopping(_shoppingBag);


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