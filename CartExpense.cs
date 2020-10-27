using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Plutus
{
    public class CartExpense : Expense, ISerializable
    {
        public bool Active { get; set; }

        public CartExpense()
        {

        }

        public CartExpense(int date, string name, double price, string category, bool active) : base(date, name, price, category)
        {
            Active = active;
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            base.GetObjectData(info, context);
            info.AddValue("Active", Active);
        }

        public CartExpense(SerializationInfo info, StreamingContext context) : base(info, context)
        {
            Active = (bool)info.GetValue("Active", typeof(bool));
        }
    }
}
