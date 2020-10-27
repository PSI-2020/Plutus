using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace Plutus
{  
    public class FileManager
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