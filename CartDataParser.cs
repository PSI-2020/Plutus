using System;
using System.Collections.Generic;
using System.Text;

namespace Plutus
{ }
   /* class CartDataParser
    {
        public CartExpense LoadExpense(string data)
        {
            var exp = new CartExpense();
            var dataArray = data.Split('|');
            exp.Name = dataArray[0];
            //exp.Price = Convert.ToDouble(dataArray[1]);
            exp.Category = dataArray[2];
            var activity = dataArray[3];
            if (activity[0] == '0') exp.Active = false;
            else exp.Active = true;

            return exp;
        }

        public string SaveExpense(CartExpense expense)
        {
            var x = '0';
            if (expense.Active) x = '1';
            var data = expense.Name + "|" + expense.Price + "|" + expense.Category + "|" + x;
            return data;
        }

 

    }
}*/
