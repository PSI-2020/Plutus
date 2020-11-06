﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Plutus
{


    public class FileManager
    {
        private static readonly string _databaseFolder = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName, "db/");
        private readonly string _income = _databaseFolder + "income.xml";
        private readonly string _expenses = _databaseFolder + "expenses.xml";
        private readonly string _monthlyIncome = _databaseFolder + "monthlyIncome.xml";
        private readonly string _monthlyExpenses = _databaseFolder + "monthylExpenses.xml";
        private readonly string _goals = _databaseFolder + "goals.xml";
        private readonly string _budgets = _databaseFolder + "budgets.xml";
        private readonly string _carts = _databaseFolder + "carts.xml";

        public string GetFilePath(string type)
        {
            return type switch
            {
                "Income" => _income,
                "Expense" => _expenses,
                "All" => "All",
                "MonthlyIncome" => _monthlyIncome,
                "MonthlyExpenses" => _monthlyExpenses,
                _ => null,
            };

        }

        public List<Payment> ReadPayments(string type)
        {
            var serializer = new XmlSerializer(typeof(List<Payment>));
            type = GetFilePath(type);

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

            type = GetFilePath(type);

            list.Add(payment);
            using Stream stream = File.OpenWrite(type);
            serializer.Serialize(stream, list);
        }
        public List<Goal> ReadGoals()
        {
            var serializer = new XmlSerializer(typeof(List<Goal>));

            try
            {
                using var stream = File.OpenRead(_goals);
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
            using Stream stream = File.OpenWrite(_goals);
            serializer.Serialize(stream, list);

        }

        public void UpdateGoals(List<Goal> list)
        {
            var serializer = new XmlSerializer(typeof(List<Goal>));
            File.WriteAllText(_goals, "");
            using Stream stream = File.OpenWrite(_goals);
            serializer.Serialize(stream, list);
        }

        public List<Expense> ReadExpenses()
        {
            var serializer = new XmlSerializer(typeof(List<Expense>));
            List<Expense> list = null;

            try
            {
                if (!File.Exists(_expenses)) return null;
                using Stream stream = File.OpenRead(_expenses);
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
                if (!File.Exists(_income)) return null;
                using Stream stream = File.OpenRead(_income);
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
                using Stream stream = File.OpenRead(_expenses);
                list = serializer.Deserialize(stream) as List<Expense>;
            }
            catch
            {
                list = new List<Expense>();
            }
            list.Add(expense);
            using (Stream stream = File.OpenWrite(_expenses))
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
                using Stream stream = File.OpenRead(this._income);
                list = serializer.Deserialize(stream) as List<Income>;
            }
            catch
            {
                list = new List<Income>();
            }
            list.Add(income);
            using (Stream stream = File.OpenWrite(this._income))
            {
                serializer.Serialize(stream, list);
            }
        }

        public void UpdateIncome(List<Income> income)
        {
            var serializer = new XmlSerializer(typeof(List<Income>));
            File.WriteAllText(this._income, "");
            using Stream stream = File.OpenWrite(this._income);
            serializer.Serialize(stream, income);
        }

        public void UpdateExpenses(List<Expense> expense)
        {
            var serializer = new XmlSerializer(typeof(List<Expense>));
            File.WriteAllText(_expenses, "");
            using Stream stream = File.OpenWrite(_expenses);
            serializer.Serialize(stream, expense);
        }

        public void AddBudget(Budget budget)
        {
            var serializer = new XmlSerializer(typeof(List<Budget>));
            var list = LoadBudget();

            list.Add(budget);
            using Stream stream = File.OpenWrite(_budgets);
            serializer.Serialize(stream, list);
        }

        public List<Budget> LoadBudget()
        {
            var serializer = new XmlSerializer(typeof(List<Budget>));

            try
            {
                using var stream = File.OpenRead(_budgets);
                return serializer.Deserialize(stream) as List<Budget>;
            }
            catch
            {
                return new List<Budget>();
            }
        }

        public void UpdateBudgets(List<Budget> list)
        {
            var serializer = new XmlSerializer(typeof(List<Budget>));
            File.WriteAllText(_budgets, "");
            using Stream stream = File.OpenWrite(_budgets);
            serializer.Serialize(stream, list);
        }

        public void SaveCarts(XElement carts)
        {
            carts.Save(_carts);
        }

        public XElement LoadCarts()
        {
            if (File.Exists(_carts))
            {
                var carts = XElement.Load(_carts);
                return carts;
            }
            else return null;

        }
    }
}
