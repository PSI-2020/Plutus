using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Timers;
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

    public class Scheduler : IDisposable
    {
        public readonly Timer checkForTime;
        public string Name { get; set; }
        public DateTime Date;
        public double Amount { get; set; }
        public string Category { get; set; }

        private readonly DataManager Manager;
        private bool IncomeOrExpense;

        public Scheduler(DateTime date, string name, double amount, string category, DataManager manager, bool incomeOrExpense)
        {
            Date = date;
            Name = name;
            Amount = amount;
            Category = category;
            Manager = manager;
            IncomeOrExpense = incomeOrExpense;
            checkForTime = new Timer(5000);
        }
      
        public void Start()
        {
            checkForTime.Elapsed += new ElapsedEventHandler(TimeElapsed);
            checkForTime.Start();
        }

        public void Stop()
        {
            checkForTime.Elapsed -= TimeElapsed;
            checkForTime.Stop();
        }
      
        private void TimeElapsed(object sender, ElapsedEventArgs e)
        {

            if (DateTime.Now.ToString("dd/MM/yyyy") == Date.ToString("dd/MM/yyyy"))
            {
                var time = (int)(Date.Subtract(new DateTime(1970, 1, 1))).TotalSeconds;
                if(IncomeOrExpense)
                Manager.addIncome(new Income(time, Amount, Category));
                else if(!IncomeOrExpense) Manager.addExpense(new Expense(time, Name, Amount, Category));
                Date = Date.AddMonths(1);
                checkForTime.Interval = 86400000;
            }


        }

        public void Dispose()
        {
            if (checkForTime != null)
            {
                checkForTime.Dispose();
            }
        }
    }

   
    public class DataManager
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