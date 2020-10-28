using System;
using System.Linq;
using System.Windows.Forms;

namespace Plutus
{
    class ManageIncome
    {
        readonly InputVerification verification = new InputVerification();

        public string ShowIncome(FileManager fileManager)
        {
            var list = fileManager.ReadIncome();
            if (list == null) return "No data found!";

            var data = "";

            foreach (var income in list)
            {
                var date = new DateTime(1970, 1, 1, 0, 0, 0, 0).AddSeconds(income.Date).ToLocalTime();
                data += date + " | " + income.Sum + "€ | " + income.Category + System.Environment.NewLine;
            }

            return data;
        }

        public string InputIncome(FileManager fileManager, string incomeSum, string incomeCategory)
        {
            var verify = verification.VerifyData(amount: incomeSum, category: incomeCategory);
            if (verify != "") return verify;

            var date = (int)(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalSeconds;
            var sum = Convert.ToDouble(incomeSum);
            var category = incomeCategory;

            fileManager.AddIncome(new Income(date, sum, category));
            return "Sum was added successfully!";
        }

        public void LoadIncome(FileManager fileManager, ComboBox incomeEditSelection)
        {
            var list = fileManager.ReadIncome();

            if (!list.Any())
            {
                incomeEditSelection.Text = "No income data found!";
                return;
            }

            incomeEditSelection.Text = "Select item to edit";

            foreach (var income in list)
            {
                incomeEditSelection.Items.Add(income.Sum + "€ | " + income.Category);
            }
        }

        public string DeleteIncome(FileManager fileManager, int index)
        {
            var list = fileManager.ReadIncome();

            if (!list.Any()) return "Income data is empty!";
            if (index < 0 || index > list.Count) return "Select an item to edit!";

            list.Remove(list[index]);
            fileManager.UpdateIncome(list);
            return "Item deleted successfully!";
        }

        public string EditIncome(FileManager fileManager, int index, string incomeSum, string incomeCategory)
        {
            var list = fileManager.ReadIncome();
            var verify = verification.VerifyData(amount: incomeSum, category: incomeCategory);

            if (!list.Any()) return "Income data is empty!";
            if (verify != "") return verify;
            if (index < 0 || index > list.Count) return "Select an item to edit!";

            list[index].Date = (int)(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalSeconds;
            list[index].Sum = Convert.ToDouble(incomeSum);
            list[index].Category = incomeCategory;

            fileManager.UpdateIncome(list);
            return "Item edited successfully!";
        }
    }
}
