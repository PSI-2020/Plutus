using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Plutus
{
    public class Payment
    {
        public int Date { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Category { get; set; }

        public Payment() { }

        public Payment(int date, string type, string name, double price, string category)
        {
            Date = date;
            Type = type;
            Name = name;
            Price = price;
            Category = category;
        }
    }
}
