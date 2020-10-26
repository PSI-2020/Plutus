using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Timers;
using System.Xml;
using System.Xml.Serialization;

namespace Plutus
{
    public class GoalManager 
    {
        private static readonly string goalsFolder = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName, "Goals/"); 
        private static readonly string databaseFolder = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName, "db/");
        public readonly string monthlyIncome = databaseFolder + "monthlyIncome.xml";
        public readonly string monthlyExpenses = databaseFolder + "monthylExpenses.xml";
        public readonly string goals = goalsFolder + "goals.xml";

        public List<Goal> ReadGoals()
        {
            var serializer = new XmlSerializer(typeof(List<Goal>));
            List<Goal> list = null;

            try
            {
                if (!File.Exists(goals)) return null;
                using Stream stream = File.OpenRead(goals);
                list = serializer.Deserialize(stream) as List<Goal>;
            }
            catch
            {
                list = new List<Goal>();
            }
            return list;

        }

        public void AddGoal(Goal newGoal)
        {
            var serializer = new XmlSerializer(typeof(List<Goal>));
            List<Goal> list = null;

            try
            {
                using Stream stream = File.OpenRead(goals);
                list = serializer.Deserialize(stream) as List<Goal>;
            }
            catch
            {
                list = new List<Goal>();
            }

            list.Add(newGoal);

            using (Stream stream = File.OpenWrite(goals))
            {
                serializer.Serialize(stream, list);
            }
        }

        public void EditGoal(int index, string newName, double newAmount, DateTime newDueDate)
        {
            var list = ReadGoals();
            var array = list.ToArray();

            list.Remove(array[index]);
            array[index] = new Goal(newName, newAmount, newDueDate);
            list.Insert(index,array[index]);
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
            File.WriteAllText(goals, "");
            using Stream stream = File.OpenWrite(goals);
            serializer.Serialize(stream, list);
        }


        public List<Expense> ReadMonthlyExpenses()
        {
            var serializer = new XmlSerializer(typeof(List<Expense>));
            List<Expense> list = null;

            try
            {
                if (!File.Exists(monthlyExpenses)) return null;
                using Stream stream = File.OpenRead(monthlyExpenses);
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
                if (!File.Exists(monthlyIncome)) return null;
                using Stream stream = File.OpenRead(monthlyIncome);
                list = serializer.Deserialize(stream) as List<Income>;
            }
            catch
            {
                list = new List<Income>();
            }
            return list;
        }

        public void AddMonthlyExpense(Expense expense)
        {
            var serializer = new XmlSerializer(typeof(List<Expense>));
            List<Expense> list = null;
            try
            {
                using Stream stream = File.OpenRead(monthlyExpenses);
                list = serializer.Deserialize(stream) as List<Expense>;
            }
            catch
            {
                list = new List<Expense>();
            }
            list.Add(expense);
            using (Stream stream = File.OpenWrite(monthlyExpenses))
            {
                serializer.Serialize(stream, list);
            }
        }

        public void AddMonthlyIncome(Income income)
        {
            var serializer = new XmlSerializer(typeof(List<Income>));
            List<Income> list = null;
            try
            {
                using Stream stream = File.OpenRead(this.monthlyIncome);
                list = serializer.Deserialize(stream) as List<Income>;
            }
            catch
            {
                list = new List<Income>();
            }
            list.Add(income);
            using (Stream stream = File.OpenWrite(this.monthlyIncome))
            {
                serializer.Serialize(stream, list);
            }
        }

        public double Insights (DataManager manager, Goal goal)
        {
            var monthlyIncome = ReadMonthlyIncome();
            var monthlyExpenses = ReadMonthlyExpenses();
            var allIncome = manager.readIncome();
            var allExpenses = manager.readExpenses();

            double income = 0;
            double expenses = 0;
            int months;
            
            months = goal.DueDate.Month - DateTime.Now.Month + (12 * (goal.DueDate.Year - DateTime.Now.Year));
        
            foreach(var monthly in monthlyIncome)
            {
                income += monthly.Sum * months;
            }
            foreach (var monthly in monthlyExpenses)
            {
                expenses += monthly.Price * months;
            }
            foreach (var i in allIncome)
            {
                income += i.Sum;
            }
            foreach (var i in allExpenses)
            {
                expenses += i.Price;
            }

            return ((income-expenses-goal.Amount)/ months);
        }

    }
}
