using System;
using System.Runtime.Serialization;

namespace Plutus
{
    [Serializable()]
    public class Expense : ISerializable
    {
        public int Date { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Category { get; set; }

        public Expense() { }

        public Expense(int date, string name, double price, string category)
        {
            Date = date;
            Name = name;
            Price = price;
            Category = category;
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Date", Date);
            info.AddValue("Name", Name);
            info.AddValue("Price", Price);
            info.AddValue("Category", Category);
        }

        public Expense(SerializationInfo info, StreamingContext context)
        {
            Date = (int)info.GetValue("Date", typeof(int));
            Name = (string)info.GetValue("Name", typeof(string));
            Price = (double)info.GetValue("Price", typeof(double));
            Category = (string)info.GetValue("Category", typeof(string));
        }
    }
}
