using System;
using System.Collections.Generic;
using System.Text;

namespace Plutus.Services
{
    class PaymentService
    {

        public void AddPayment(CurrentInfoHolder chi, FileManager fm)
        {
            var date = (int)(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalSeconds;

            var payment = new Payment
            {
                Date = date,
                Name = chi.CurrentName,
                Amount = double.Parse(chi.CurrentAmout),
                Category = chi.CurrentCategory
            };
            fm.AddPayment(payment, chi.CurrentType);
        }

        public void AddCartPayment(string name, double amount, string category, FileManager fm)
        {
            var date = (int)(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalSeconds;
            var payment = new Payment
            {
                Date = date,
                Name = name,
                Amount = amount,
                Category = category
            };
            fm.AddPayment(payment, "Expense");
        }
    }
}
