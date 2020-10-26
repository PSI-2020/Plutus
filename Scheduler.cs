using System;
using System.Timers;

namespace Plutus
{
    public class Scheduler : IDisposable
    {
        public readonly Timer checkForTime;
        public string Name { get; set; }
        public DateTime Date;
        public double Amount { get; set; }
        public string Category { get; set; }

        private readonly DataManager Manager;
        private readonly bool IncomeOrExpense;

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
                if (IncomeOrExpense)
                    Manager.addIncome(new Income(time, Amount, Category));
                else if (!IncomeOrExpense) Manager.addExpense(new Expense(time, Name, Amount, Category));
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
}
