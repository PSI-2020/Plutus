using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Xml.Serialization;

namespace Plutus
{


    public class FileManager
    {
        private static readonly string databaseFolder = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName, "db/");
        public readonly string income = databaseFolder + "income.xml";
        public readonly string expenses = databaseFolder + "expenses.xml";

        public string getFilePath(string type)
        {
            return type switch
            {
                "Income" => income,
                "Expense" => expenses,
                "All" => "All",
                _ => null,
            };
        }

        public List<Payment> ReadPayments(string type)
        {
            var serializer = new XmlSerializer(typeof(List<Payment>));
            type = getFilePath(type);

            if (type == "All")
            {
                var list = ReadPayments("Expense");
                list.AddRange(ReadPayments("Income"));

                return list;
            }

            try
            {
                using (var stream = File.OpenRead(type))
                {
                    return serializer.Deserialize(stream) as List<Payment>;
                }
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
            using (Stream stream = File.OpenWrite(type))
            {
                serializer.Serialize(stream, list);
            }
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
