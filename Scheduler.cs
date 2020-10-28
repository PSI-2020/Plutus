using System;
using System.Timers;

namespace Plutus
{
    public class Scheduler : IDisposable
    {
        private readonly Timer _checkForTime;
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public double Amount { get; set; }
        public string Category { get; set; }

        private readonly FileManager _manager;
        private readonly bool _incomeOrExpense;

        public Scheduler(DateTime date, string name, string amount, string category, FileManager manager, bool incomeOrExpense)
        {
            Date = date;
            Name = name;
            Amount = double.Parse(amount);
            Category = category;
            _manager = manager;
            _incomeOrExpense = incomeOrExpense;
            _checkForTime = new Timer(5000);
            Start();
        }

        public void Start()
        {
            _checkForTime.Elapsed += new ElapsedEventHandler(TimeElapsed);
            _checkForTime.Start();
        }

        public void Stop()
        {
            _checkForTime.Elapsed -= TimeElapsed;
            _checkForTime.Stop();
        }

        private void TimeElapsed(object sender, ElapsedEventArgs e)
        {

            if (DateTime.Now.ToString("dd/MM/yyyy") == Date.ToString("dd/MM/yyyy"))
            {
                var time = (int)(Date.Subtract(new DateTime(1970, 1, 1))).TotalSeconds;
                if (_incomeOrExpense)
                {
                    _manager.addIncome(new Income(time, Amount, Category));
                }
                else if (!_incomeOrExpense)
                {
                    _manager.addExpense(new Expense(time, Name, Amount, Category));
                }
                Date = Date.AddMonths(1);
                _checkForTime.Interval = 86400000;
            }


        }

        public void Dispose()
        {
            if (_checkForTime != null)
            {
                _checkForTime.Dispose();
            }
        }
    }
}
