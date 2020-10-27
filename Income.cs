using System;
using System.Runtime.Serialization;

namespace Plutus
{
    [Serializable()]
    public class Income : ISerializable
    {
        public int Date { get; set; }
        public double Sum { get; set; }
        public string Category { get; set; }

        public Income() { }

        public Income(int date, double sum, string category)
        {
            Date = date;
            Sum = sum;
            Category = category;
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Date", Date);
            info.AddValue("Sum", Sum);
            info.AddValue("Category", Category);
        }

        public Income(SerializationInfo info, StreamingContext context)
        {
            Date = (int)info.GetValue("Date", typeof(int));
            Sum = (double)info.GetValue("Sum", typeof(double));
            Category = (string)info.GetValue("Category", typeof(string));
        }
    }
}
