using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml;
using System.Xml.Serialization;

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
    class DataManager
    {
        private static readonly string databaseFolder = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName, "db/");
        public readonly string income = databaseFolder + "income.xml";
        public readonly string expenses = databaseFolder + "expenses.xml";

        public List<Expense> readExpenses()
        {
            var serializer = new XmlSerializer(typeof(List<Expense>));
            List<Expense> list = null;
            try
            {
                if (!File.Exists(expenses)) return null;
                using Stream stream = File.OpenRead(expenses);
                list = serializer.Deserialize(stream) as List<Expense>;
            }
            catch
            {
                list = new List<Expense>();
            }
            return list;
        }

        public List<Income> readIncome()
        {
            var serializer = new XmlSerializer(typeof(List<Income>));
            List<Income> list = null;
            try
            {
                if (!File.Exists(income)) return null;
                using Stream stream = File.OpenRead(income);
                list = serializer.Deserialize(stream) as List<Income>;
            }
            catch
            {
                list = new List<Income>();
            }
            return list;
        }

        public void addExpense(Expense expense)
        {
            var serializer = new XmlSerializer(typeof(List<Expense>));
            List<Expense> list = null;
            try
            {
                using Stream stream = File.OpenRead(expenses);
                list = serializer.Deserialize(stream) as List<Expense>;
            }
            catch
            {
                list = new List<Expense>();
            }
            list.Add(expense);
            using (Stream stream = File.OpenWrite(expenses))
            {
                serializer.Serialize(stream, list);
            }
        }

        public void addIncome(Income income)
        {
            var serializer = new XmlSerializer(typeof(List<Income>));
            List<Income> list = null;
            try
            {
                using Stream stream = File.OpenRead(this.income);
                list = serializer.Deserialize(stream) as List<Income>;
            }
            catch
            {
                list = new List<Income>();
            }
            list.Add(income);
            using (Stream stream = File.OpenWrite(this.income))
            {
                serializer.Serialize(stream, list);
            }
        }

        public void updateIncome(List<Income> income)
        {
            var serializer = new XmlSerializer(typeof(List<Income>));
            File.WriteAllText(this.income, "");
            using Stream stream = File.OpenWrite(this.income);
            serializer.Serialize(stream, income);
        }

        public void updateExpenses(List<Expense> expense)
        {
            var serializer = new XmlSerializer(typeof(List<Expense>));
            File.WriteAllText(expenses, "");
            using Stream stream = File.OpenWrite(expenses);
            serializer.Serialize(stream, expense);
        }
    }
}