using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plutus.Interfaces
{
    public interface IShoppingFrontEndService
    {
        public void InitializeShoppingService(Cart cart);
        public void ElementClicked(int index);
        public void ChargeShopping();
        public List<string> GiveExpenses(int state);
    }
}
