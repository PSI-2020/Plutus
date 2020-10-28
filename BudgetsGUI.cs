using System;
using System.Linq;
using System.Windows.Forms;

namespace Plutus
{
    public partial class GUI : Form
    {
        private void AddBudget_Click(object sender, EventArgs e) => budgetControl.Visible = true;
        private void BudgetAdd_Click(object sender, EventArgs e)
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
            budgetsFlow.Visible = true;
            errorLbl.Text = null;

            var fromSec = (int)(dateFrom.Value.Subtract(new DateTime(1970, 1, 1))).TotalSeconds;
            var toSec = (int)(dateTo.Value.Subtract(new DateTime(1970, 1, 1))).TotalSeconds;
            var budget = new Budget("budget" + list.Count, budgetCat.SelectedItem.ToString(), double.Parse(budgetSum.Text), fromSec, toSec);
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
            if (list == null) return;
            var manager = new DataManager();

            budgetsFlow.Visible = true;

            foreach (var item in list)
            {
                var from = new DateTime(1970, 1, 1).AddSeconds(item.From).ToLocalTime();
                var to = new DateTime(1970, 1, 1).AddSeconds(item.To).ToLocalTime();

                if (to < DateTime.Now)
                {
                    budManager.DeleteBudget(list.IndexOf(item));
                }

                var expenses = manager.readExpenses();
                if (expenses == null) return;


                var data = "Budget for " + item.Category;
                var total = 0.00;

                total = expenses
                    .Where(x => x.Category == item.Category)
                    .Where(x => x.Date >= item.From)
                    .Where(x => x.Date <= item.To)
                    .Sum(x => x.Price);

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
                but.Click += new EventHandler(DeleteClick);
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

            var index = int.Parse(delButton.Name.Substring(6));
            budManager.DeleteBudget(index);
            budgetsFlow.Controls.Clear();
            DisplayBudgets();
        }
    }
}
