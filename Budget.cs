using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace Plutus
{ 
    [Serializable()]
    public class Budget : ISerializable
    {
        public string Name { get; set; }
        public string Category { get; set; }
        public double Sum { get; set; }
        public int From { get; set; }
        public int To { get; set; }
        public Budget(string name, string category, double sum, int from, int to)
        {
            Name = name;
            Category = category;
            Sum = sum;
            From = from;
            To = to;
        }

        public Budget()
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


        public Budget(SerializationInfo info, StreamingContext context)
        {
            From = (int)info.GetValue("From", typeof(int));
            To = (int)info.GetValue("To", typeof(int));
            Name = (string)info.GetValue("Name", typeof(string));
            Sum = (double)info.GetValue("Sum", typeof(double));
            Category = (string)info.GetValue("Category", typeof(string));
        }
    }


    public class BudgetsManager
    {
        private static readonly string _databaseFolder = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName, "db/");
        private readonly string _file = _databaseFolder + "budgets.xml";
        public void AddBudget(Budget budget)
        {
            var serializer = new XmlSerializer(typeof(List<Budget>));
            List<Budget> list = null;
            try
            {
                using Stream stream = File.OpenRead(_file);
                list = serializer.Deserialize(stream) as List<Budget>;
            }
            catch
            {
                list = new List<Budget>();
            }
            list.Add(budget);
            using (Stream stream = File.OpenWrite(_file)) //inconsistent kodas, be this
            {
                serializer.Serialize(stream, list);
            }
        }

        public List<Budget> LoadBudget()
        {
            var serializer = new XmlSerializer(typeof(List<Budget>));
            List<Budget> list = null;
            try
            {
                if (!File.Exists(_file)) return null;
                using Stream stream = File.OpenRead(_file);
                list = serializer.Deserialize(stream) as List<Budget>;
            }
            catch
            {
                list = new List<Budget>();
            }
            return list;
        }

        public void DeleteBudget(int index)
        {
            var list = LoadBudget();
            var array = list.ToArray();
            list.Remove(array[index]);
            UpdateBudgets(RenameBudgets(list));
        }
        public List<Budget> RenameBudgets(List<Budget> list)
        {
            foreach(var item in list)
            {
                item.Name = "budget" + list.IndexOf(item);
            }
            return list;
        }

        public void UpdateBudgets(List<Budget> list)
        {
            var serializer = new XmlSerializer(typeof(List<Budget>));
            File.WriteAllText(_file, "");
            using Stream stream = File.OpenWrite(_file);
            serializer.Serialize(stream, list);
        }
    }
}
