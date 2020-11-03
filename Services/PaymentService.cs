using System;
using System.Collections.Generic;
using System.Text;

namespace Plutus.Services
{
    class PaymentService
    {
        private List<Payment> _paymentList;
        public PaymentService()
        {
            _paymentList = new List<Payment>();
        }

        public void AddPayment(CurrentInfoHolder cih, string name, string amount)
        {
            var date = (int)(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalSeconds;
            var newPayment = new Payment(date, cih.CurrentType, name, double.Parse(amount), cih.CurrentCategory);
            _paymentList.Add(newPayment);
        }

        public List<Payment> GivePayments()
        {
            return _paymentList;
        }




    }
}
