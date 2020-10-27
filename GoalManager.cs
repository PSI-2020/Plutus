using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;

namespace Plutus
{
    public class GoalManager
    {
        private static readonly string _goalsFolder = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName, "Goals/");
        private static readonly string _databaseFolder = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName, "db/");
        private readonly string _monthlyIncome = _databaseFolder + "monthlyIncome.xml";
        private readonly string _monthlyExpenses = _databaseFolder + "monthylExpenses.xml";
        private readonly string _goals = _goalsFolder + "goals.xml";

        public List<Goal> ReadGoals()
        {
            var serializer = new XmlSerializer(typeof(List<Goal>));
            List<Goal> list = null;

            try
            {
                if (!File.Exists(_goals)) return null;
                using Stream stream = File.OpenRead(_goals);
                list = serializer.Deserialize(stream) as List<Goal>;
            }
            catch
            {
                list = new List<Goal>();
            }
            return list;

        }
        public string ShowGoals()
        {
            var goalList = ReadGoals();
            var text = "";

            foreach (var goal in goalList)
            {
                text += goal.Name + " | " + goal.Amount + "€ | " + goal.DueDate.ToString("yyyy/MM/dd") + System.Environment.NewLine;
            }

            return text;
        }

        public void AddGoal(Goal newGoal)
        {
            var serializer = new XmlSerializer(typeof(List<Goal>));
            List<Goal> list = null;

            try
            {
                using Stream stream = File.OpenRead(_goals);
                list = serializer.Deserialize(stream) as List<Goal>;
            }
            catch
            {
                list = new List<Goal>();
            }

            list.Add(newGoal);

            using (Stream stream = File.OpenWrite(_goals))
            {
                serializer.Serialize(stream, list);
            }
        }

        public void EditGoal(int index, string newName, string newAmount, DateTime newDueDate)
        {
            var amount = double.Parse(newAmount);
            var list = ReadGoals();
            var array = list.ToArray();

            list.Remove(array[index]);
            array[index] = new Goal(newName, amount, newDueDate);
            list.Insert(index, array[index]);
            UpdateGoals(list);

        }

        public void DeleteGoal(int index)
        {
            var list = ReadGoals();
            var array = list.ToArray();
            list.Remove(array[index]);
            UpdateGoals(list);
        }

        public void UpdateGoals(List<Goal> list)
        {
            var serializer = new XmlSerializer(typeof(List<Goal>));
            File.WriteAllText(_goals, "");
            using Stream stream = File.OpenWrite(_goals);
            serializer.Serialize(stream, list);
        }


        public List<Expense> ReadMonthlyExpenses()
        {
            var serializer = new XmlSerializer(typeof(List<Expense>));
            List<Expense> list = null;

            try
            {
                if (!File.Exists(_monthlyExpenses)) return null;
                using Stream stream = File.OpenRead(_monthlyExpenses);
                list = serializer.Deserialize(stream) as List<Expense>;
            }
            catch
            {
                list = new List<Expense>();
            }
            return list;
        }

        public List<Income> ReadMonthlyIncome()
        {
            var serializer = new XmlSerializer(typeof(List<Income>));
            List<Income> list = null;
            try
            {
                if (!File.Exists(_monthlyIncome)) return null;
                using Stream stream = File.OpenRead(_monthlyIncome);
                list = serializer.Deserialize(stream) as List<Income>;
            }
            catch
            {
                list = new List<Income>();
            }
            return list;
        }

        public void AddMonthlyExpense(string name, string price, string category)
        {
            var date = (int)(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalSeconds;
            var monthlyExpense = double.Parse(price);
            var expense = new Expense(date, name, monthlyExpense, category);

            var serializer = new XmlSerializer(typeof(List<Expense>));
            List<Expense> list = null;
            try
            {
                using Stream stream = File.OpenRead(_monthlyExpenses);
                list = serializer.Deserialize(stream) as List<Expense>;
            }
            catch
            {
                list = new List<Expense>();
            }
            list.Add(expense);
            using (Stream stream = File.OpenWrite(_monthlyExpenses))
            {
                serializer.Serialize(stream, list);
            }
        }

        public void AddMonthlyIncome(string monthlyIncomeAmount, string category)
        {

            var date = (int)(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalSeconds;
            var monthlyIncome = Convert.ToDouble(monthlyIncomeAmount);
            var income = new Income(date, monthlyIncome, category);

            var serializer = new XmlSerializer(typeof(List<Income>));
            List<Income> list = null;
            try
            {
                using Stream stream = File.OpenRead(this._monthlyIncome);
                list = serializer.Deserialize(stream) as List<Income>;
            }
            catch
            {
                list = new List<Income>();
            }
            list.Add(income);
            using (Stream stream = File.OpenWrite(this._monthlyIncome))
            {
                serializer.Serialize(stream, list);
            }
        }

        public string Insights(FileManager manager, Goal goal, bool dailyOrMonthly)
        {
            var monthlyIncome = ReadMonthlyIncome();
            var monthlyExpenses = ReadMonthlyExpenses();
            var allIncome = manager.readIncome();
            var allExpenses = manager.readExpenses();

            var months = goal.DueDate.Month - DateTime.Now.Month + (12 * (goal.DueDate.Year - DateTime.Now.Year));
            var income = monthlyIncome.Sum(x => x.Sum * months) + allIncome.Sum(x => x.Sum);
            var expenses = monthlyExpenses.Sum(x => x.Price * months) + allExpenses.Sum(x => x.Price);

            if (dailyOrMonthly)
            {
                return ((income - expenses - goal.Amount) / months).ToString("C2");
            }

            else if (!dailyOrMonthly)
            {
                return ((income - expenses - goal.Amount) / months / DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month)).ToString("C2");
            }

            return "";
        }

        public string DaysLeft(Goal goal)
        {
            var days = (goal.DueDate - DateTime.Now).TotalDays;

            return days.ToString("F0");
        }

    }
}
