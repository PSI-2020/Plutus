using System;
using System.Collections.Generic;
using System.IO;
using System.Timers;
using System.Xml.Serialization;

namespace Plutus
{
    public class Scheduler : IDisposable
    {
        public readonly Timer checkForTime;
        public string Name { get; set; }
        public DateTime Date;
        public double Amount { get; set; }
        public string Category { get; set; }

        private readonly FileManager Manager;
        private bool IncomeOrExpense;

        public Scheduler(DateTime date, string name, double amount, string category, FileManager manager, bool incomeOrExpense)
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
                Manager.AddIncome(new Income(time, Amount, Category));
                else if(!IncomeOrExpense) Manager.AddExpense(new Expense(time, Name, Amount, Category));
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

   
    public class FileManager
    {
        private static readonly string databaseFolder = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName, "db/");
        public readonly string income = databaseFolder + "income.xml";
        public readonly string expenses = databaseFolder + "expenses.xml";

        public List<Expense> ReadExpenses()
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

        public List<Income> ReadIncome()
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

        public void AddExpense(Expense expense)
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

        public void AddIncome(Income income)
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

        public void UpdateIncome(List<Income> income)
        {
            var serializer = new XmlSerializer(typeof(List<Income>));
            File.WriteAllText(this.income, "");
            using Stream stream = File.OpenWrite(this.income);
            serializer.Serialize(stream, income);
        }

        public void UpdateExpenses(List<Expense> expense)
        {
            var serializer = new XmlSerializer(typeof(List<Expense>));
            File.WriteAllText(expenses, "");
            using Stream stream = File.OpenWrite(expenses);
            serializer.Serialize(stream, expense);
        }
    }
}