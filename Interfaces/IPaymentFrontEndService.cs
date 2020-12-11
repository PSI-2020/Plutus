using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plutus.Interfaces
{
    public interface IPaymentFrontEndService
    {
        public Task AddPaymentAsync(CurrentInfoHolder chi);
        public void AddCartPayment(string name, double amount, string category);
    }
}
