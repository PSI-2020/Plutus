using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Xml.Serialization;

namespace Plutus
{
    public class FileManager
    {
        private static readonly string databaseFolder = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName, "db/");
        public readonly string income = databaseFolder + "income.xml";
        public readonly string expenses = databaseFolder + "expenses.xml";
        private readonly string monthlyIncome = databaseFolder + "monthlyIncome.xml";
        private readonly string monthlyExpenses = databaseFolder + "monthylExpenses.xml";
        public readonly string goals = databaseFolder + "goals.xml";


        public string getFilePath(string type)
        {
            switch (type)
            {
                case "Income":
                    type = income;
                    break;
                case "Expense":
                    type = expenses;
                    break;
                case "MonthlyIncome":
                    type = monthlyIncome;
                    break;
                case "MonthlyExpenses":
                    type = monthlyExpenses;
                    break;
                default:
                    return null;
            }
            return type;
        }

        public List<Payment> ReadPayments(string type)
        {
            var serializer = new XmlSerializer(typeof(List<Payment>));

            try
            {
                using var stream = File.OpenRead(getFilePath(type));
                return serializer.Deserialize(stream) as List<Payment>;
            }
            catch
            {
                return new List<Payment>();
            }
        }

        public void AddPayment(Payment payment, string type)
        {
            var serializer = new XmlSerializer(typeof(List<Payment>));
            var list = ReadPayments(type);

            type = getFilePath(type);

            list.Add(payment);
            using Stream stream = File.OpenWrite(type);
            serializer.Serialize(stream, list);
        }
        public List<Goal> ReadGoals()
        {
            var serializer = new XmlSerializer(typeof(List<Goal>));

            try
            {
                using var stream = File.OpenRead(goals);
                return serializer.Deserialize(stream) as List<Goal>;
            }
            catch
            {
                return new List<Goal>();
            }
          
        }

        public void AddGoal(string name, string amount, DateTime dueDate)
        {
            var serializer = new XmlSerializer(typeof(List<Goal>));
            var list = ReadGoals();

            var newAmount = double.Parse(amount);
            var goal = new Goal(name, newAmount, dueDate);

            list.Add(goal);
            using Stream stream = File.OpenWrite(goals);
            serializer.Serialize(stream, list);

        }
    
        public void UpdateGoals(List<Goal> list)
        {
            var serializer = new XmlSerializer(typeof(List<Goal>));
            File.WriteAllText(goals, "");
            using Stream stream = File.OpenWrite(goals);
            serializer.Serialize(stream, list);
        }

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
