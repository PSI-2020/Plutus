using System;
using System.Windows.Forms;

namespace Plutus
{
    public partial class GUI : Form
    {
        private void addBudget_Click(object sender, EventArgs e) => budgetControl.Visible = true;
        private void budgetAdd_Click(object sender, EventArgs e)
        {
            if (!Double.TryParse(budgetSum.Text, out _))
            {
                errorLbl.Text = "Price must be a number!";
                return;
            }
            if (budgetCat.Text.Length == 0 || budgetCat == null)
            {
                errorLbl.Text = "Please choose a category!";
                return;
            }
            if (budgetSum.Text.Length == 0 || budgetSum == null)
            {
                errorLbl.Text = "Please enter a sum!";
                return;
            }
            var budManager = new BudgetsManager();
            var list = budManager.LoadBudget();
            var count = list.Count;
            budgetsFlow.Visible = true;
            errorLbl.Text = null;
            var category = budgetCat.SelectedItem.ToString();
            var sum = Convert.ToDouble(budgetSum.Text);
            var from = dateFrom.Value;
            var to = dateTo.Value;
            var fromSec = (int)(from.Subtract(new DateTime(1970, 1, 1))).TotalSeconds;
            var toSec = (int)(to.Subtract(new DateTime(1970, 1, 1))).TotalSeconds;
            var name = "budget" + count;
            var budget = new Budget(name, category, sum, fromSec, toSec);
            budManager.AddBudget(budget);
            budgetsFlow.Controls.Clear();
            DisplayBudgets();
            budgetCat.Text = null;
            dateFrom.ResetText();
            dateTo.ResetText();
            budgetSum.Clear();
            budgetControl.Visible = false;
        }

        private void DisplayBudgets()
        {
            var budManager = new BudgetsManager();
            var list = budManager.LoadBudget();
            var manager = new DataManager();

            budgetsFlow.Visible = true;

            if (list == null) return;

            foreach (var item in list)
            {
                var from = new DateTime(1970, 1, 1, 0, 0, 0, 0).AddSeconds(item.From).ToLocalTime();
                var to = new DateTime(1970, 1, 1, 0, 0, 0, 0).AddSeconds(item.To).ToLocalTime();

                if (to < DateTime.Now)
                {
                    budManager.DeleteBudget(list.IndexOf(item));
                }

                var expenses = manager.readExpenses();
                if (expenses == null) return;


                var data = "Budget for " + item.Category;
                var total = 0.00;

                foreach (var expense in expenses)
                {
                    if (expense.Category == item.Category && expense.Date >= item.From && expense.Date <= item.To)
                    {
                        total += expense.Price;
                    }
                }

                data += "\r\n" + total + "/" + item.Sum + " €" + "\r\n" + Math.Round((total * 100 / item.Sum), 2) + "%" + "\r\n" +
                    from.ToString("yyyy/MM/dd") + " - " + to.ToString("yyyy/MM/dd");
                var flow = new FlowLayoutPanel
                {
                    Height = 200,
                    Width = 210,
                    Name = "flow" + list.IndexOf(item)
                };
                var Textbox = new TextBox
                {
                    Height = 140,
                    Width = 200,
                    Multiline = true,
                    ReadOnly = true,
                    Name = "budgetText" + list.IndexOf(item)
                };
                var but = new Button
                {
                    Text = "Delete",
                    Height = 30,
                    Width = 80,
                    Name = "button" + list.IndexOf(item)
                };
                but.Click += new System.EventHandler(this.DeleteClick);
                budgetsFlow.Controls.Add(flow);
                flow.Controls.Add(Textbox);
                flow.Controls.Add(but);
                Textbox.Text = data;
            }
        }

        private void DeleteClick(object sender, EventArgs e)
        {
            var budManager = new BudgetsManager();
            var delButton = (Button)sender;

            var index = Convert.ToInt32(delButton.Name.Substring(6));
            budManager.DeleteBudget(index);
            budgetsFlow.Controls.Clear();
            DisplayBudgets();
        }
    }
}
