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
        public Budget(string name, string category, double sum, DateTime from, DateTime to)
        {
            Name = name;
            Category = category;
            Sum = sum;
            From = (int)(from.Subtract(new DateTime(1970, 1, 1))).TotalSeconds;
            To = (int)(to.Subtract(new DateTime(1970, 1, 1))).TotalSeconds;
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
        private readonly FileManager _fileManager = new FileManager();
        readonly DateTime date = new DateTime(1970, 1, 1);
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
            list.Remove(list[index]);
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
        public string GenerateBudget(int index)
        {
            var data = "";
            var list = LoadBudget();

            var from = date.AddSeconds(list[index].From).ToLocalTime();
            var to = date.AddSeconds(list[index].To).ToLocalTime();


            var expenses = _fileManager.ReadPayments("Expense");
            if (expenses == null) return "";


            data = "Budget for " + list[index].Category;
            var total = 0.00;

            total = expenses
                .Where(x => x.Category == list[index].Category)
                .Where(x => x.Date >= list[index].From)
                .Where(x => x.Date <= list[index].To)
                .Sum(x => x.Amount);

            data += "\r\n" + total + "/" + list[index].Sum + " €" + "\r\n" + Math.Round((total * 100 / list[index].Sum), 2) + "%" + "\r\n" +
                from.ToString("yyyy/MM/dd") + " - " + to.ToString("yyyy/MM/dd");


            return data;
        }
        public object ShowStats(int index)
        {
            var budgets = LoadBudget();
            var expenses = _fileManager.ReadPayments("Expense");
            var result = expenses
                .Where(x => x.Category == budgets[index].Category)
                .Where(x => x.Date >= budgets[index].From)
                .Where(x => x.Date <= budgets[index].To)
                .ToList();
            var list = result
                .Select(x => new { DATE = date.AddSeconds(x.Date).ToLocalTime().ToString("yyyy-MM-dd HH:ss"), NAME = x.Name, AMOUNT = x.Amount, CATEGORY = x.Category })
                .OrderByDescending(x => x.DATE).ToList();
            return !list.Any() ? null : (object)list;
        }
        
    }
}
