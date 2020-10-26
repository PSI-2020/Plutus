using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Plutus
{ 
    [Serializable()]
    public class Budgets : ISerializable
    {
        public string Name { get; set; }
        public string Category { get; set; }
        public double Sum { get; set; }
        public int From { get; set; }

        public int To { get; set; }
        public Budgets(string name, string category, double sum, int from, int to)
        {
            Name = name;
            Category = category;
            Sum = sum;
            From = from;
            To = to;
        }

        public Budgets()
        {

        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("From", From);
            info.AddValue("To", To);
            info.AddValue("Name", Name);
            info.AddValue("Sum", Sum);
            info.AddValue("Category", Category);
        }


        public Budgets(SerializationInfo info, StreamingContext context)
        {
            From = (int)info.GetValue("From", typeof(int));
            To = (int)info.GetValue("To", typeof(int));
            Name = (string)info.GetValue("Name", typeof(string));
            Sum = (double)info.GetValue("Sum", typeof(double));
            Category = (string)info.GetValue("Category", typeof(string));
        }
    }

    public class SaveAndLoadBudget
    {
        private static readonly string databaseFolder = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName, "db/");
        public readonly string file = databaseFolder + "budgets.xml";
        public void addBudget(Budgets budget)
        {
            var serializer = new XmlSerializer(typeof(List<Budgets>));
            List<Budgets> list = null;
            try
            {
                using Stream stream = File.OpenRead(this.file);
                list = serializer.Deserialize(stream) as List<Budgets>;
            }
            catch
            {
                list = new List<Budgets>();
            }
            list.Add(budget);
            using (Stream stream = File.OpenWrite(this.file))
            {
                serializer.Serialize(stream, list);
            }
        }

        public List<Budgets> loadBudget()
        {
            var serializer = new XmlSerializer(typeof(List<Budgets>));
            List<Budgets> list = null;
            try
            {
                if (!File.Exists(file)) return null;
                using Stream stream = File.OpenRead(file);
                list = serializer.Deserialize(stream) as List<Budgets>;
            }
            catch
            {
                list = new List<Budgets>();
            }
            return list;
        }
    }
}
