using System;
using System.Linq;

namespace Plutus.Services
{
    class GoalService
    {
        private readonly FileManager fileManager = new FileManager();
        public void EditGoal(Goal goal, string newName, string newAmount, DateTime newDueDate)
        {
            var amount = double.Parse(newAmount);
            var list = fileManager.ReadGoals();
            var array = list.ToArray();
            var index = 0;

            foreach (var i in list)
            {
                if (goal.Name == i.Name && goal.Amount == i.Amount && goal.DueDate == i.DueDate)
                {
                    break;
                }
                else
                {
                    index++;
                }
            }

            list.Remove(array[index]);
            array[index] = new Goal(newName, amount, newDueDate);
            list.Insert(index, array[index]);
            fileManager.UpdateGoals(list);

        }

        public void DeleteGoal(Goal goal)
        {
            var list = fileManager.ReadGoals();
            var array = list.ToArray();
            var index = 0;
            foreach (var i in list)
            {
                if (goal.Name == i.Name && goal.Amount == i.Amount && goal.DueDate == i.DueDate)
                {
                    break;
                }
                else
                {
                    index++;
                }
            }
            list.Remove(array[index]);
            fileManager.UpdateGoals(list);
        }

        public string Insights(FileManager manager, Goal goal, string dailyOrMonthly)
        {
            var monthlyIncome = manager.ReadPayments("MonthlyIncome");
            var monthlyExpenses = manager.ReadPayments("MonthlyExpenses");
            var allIncome = manager.ReadPayments("Income");
            var allExpenses = manager.ReadPayments("Expense");

            var months = goal.DueDate.Month - DateTime.Now.Month + (12 * (goal.DueDate.Year - DateTime.Now.Year));
            var income = monthlyIncome.Sum(x => x.Amount * months) + allIncome.Sum(x => x.Amount);
            var expenses = monthlyExpenses.Sum(x => x.Amount * months) + allExpenses.Sum(x => x.Amount);

            double todaySpent = 0;

            foreach (var expense in allExpenses)
            {
                var date = new DateTime(1970, 1, 1, 0, 0, 0).AddSeconds(expense.Date).ToLocalTime();
                if (date.ToString("yyyy/MM/dd") == DateTime.Now.ToString("yyyy/MM/dd"))
                {
                    todaySpent += expense.Amount;
                }

            }

            switch (dailyOrMonthly)
            {
                case "monthly":
                    return ((income - expenses - goal.Amount + todaySpent) / months).ToString("C2");
                case "daily":
                    return ((((income - expenses - goal.Amount + todaySpent) / months) / DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month) - todaySpent)).ToString("C2");
                default:
                    return "";

            }
        }

        public string DaysLeft(Goal goal)
        {
            var days = (goal.DueDate - DateTime.Now).TotalDays;

            return days.ToString("F0");
        }

    }
}
