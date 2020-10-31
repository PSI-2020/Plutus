using System;
using System.Linq;
using System.Windows.Forms;

namespace Plutus
{
    class ManageExpenses
    {
        readonly InputVerification verification = new InputVerification();
        public string InputExpense(FileManager fileManager, string expenseName, string expensePrice, string expenseCategory)
        {
            var verify = verification.VerifyData(expenseName, expensePrice, expenseCategory);
            if (verify != "") return verify;

            var date = (int)(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalSeconds;
            var name = expenseName;
            var price = Convert.ToDouble(expensePrice);
            var category = expenseCategory;

            fileManager.AddExpense(new Expense(date, name, price, category));
            return name  + " was successfully added!";
        }

        public string ShowExpenses(FileManager fileManager)
        {
            var list = fileManager.ReadExpenses();
            if (list == null) return "No data found!";

            var data = "";
            foreach (var expense in list)
            {
                var date = new DateTime(1970, 1, 1, 0, 0, 0, 0).AddSeconds(expense.Date).ToLocalTime();
                data += date + " | " + expense.Name + " | " + expense.Price + "€ | " + expense.Category + System.Environment.NewLine;
            }
            return data;
        }

        public void LoadExpenses(FileManager fileManager, ComboBox expenseEditSelection)
        {
            var list = fileManager.ReadExpenses();
            if (!list.Any())
            {
                expenseEditSelection.Text = "No expense data found!";
                return;
            }

            expenseEditSelection.Text = "Select item to edit";
            foreach (var expense in list)
            {
                expenseEditSelection.Items.Add(expense.Name + " | " + expense.Price + "€ | " + expense.Category);
            }
        }

        public string DeleteExpense(FileManager fileManager, int index)
        {
            var list = fileManager.ReadExpenses();

            if (!list.Any()) return "Expense data is empty!";
            if (index < 0 || index > list.Count) return "Select an item to edit!";

            list.Remove(list[index]);
            fileManager.UpdateExpenses(list);
            return "Item deleted successfully!";
        }

        public string EditExpense(FileManager fileManager, int index, string expenseName, string expensePrice, string expenseCategory)
        {
            var list = fileManager.ReadExpenses();
            var verify = verification.VerifyData(expenseName, expensePrice, expenseCategory);

            if (!list.Any()) return "Expense data is empty!";
            if (verify != "") return verify;
            if (index < 0 || index > list.Count) return "Select an item to edit!";

            list[index].Date = (int)(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalSeconds;
            list[index].Name = expenseName;
            list[index].Price = Convert.ToDouble(expensePrice);
            list[index].Category = expenseCategory;

            fileManager.UpdateExpenses(list);
            return "Item edited successfully!";
        }
    }
}
