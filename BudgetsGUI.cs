using System;
using System.Windows.Forms;

namespace Plutus
{
    public partial class GUI : Form
    {
        readonly BudgetsManager budManager = new BudgetsManager();
        private void AddBudget_Click(object sender, EventArgs e)
        {
            budgetControl.Visible = true;
            addBudget.Visible = false;
        }
        private void BudgetAdd_Click(object sender, EventArgs e)
        {
            var verify = new InputVerification();
            errorLbl.Text = verify.VerifyData(amount: budgetSum.Text, category: budgetCat.Text);
            if (errorLbl.Text != "") return;

            var list = budManager.LoadBudget();
            budgetsFlow.Visible = true;

            var fromSec = (int)(dateFrom.Value.Subtract(new DateTime(1970, 1, 1))).TotalSeconds;
            var toSec = (int)(dateTo.Value.Subtract(new DateTime(1970, 1, 1))).TotalSeconds;
            budManager.AddBudget(new Budget("budget" + list.Count, budgetCat.SelectedItem.ToString(), double.Parse(budgetSum.Text), fromSec, toSec));
            
            budgetsFlow.Controls.Clear();
            DisplayBudgets();
            budgetCat.Text = null;
            dateFrom.ResetText();
            dateTo.ResetText();
            budgetSum.Clear();
            budgetControl.Visible = false;
            addBudget.Visible = true;
        }

        private void DisplayBudgets()
        {
            var list = budManager.LoadBudget();
            if (list == null) return;

            budgetsFlow.Visible = true;

            for(var x = 0; x < list.Count; x++)
            {
                var flow = new FlowLayoutPanel
                {
                    Height = 200,
                    Width = 210,
                    Name = "flow" + x
                };
                var Textbox = new TextBox
                {
                    Height = 140,
                    Width = 200,
                    Multiline = true,
                    ReadOnly = true,
                    Name = "budgetText" + x
                };
                var deleteButton = new Button
                {
                    Text = "Delete",
                    Height = 30,
                    Width = 80,
                    Name = "delBtn" + x
                };
                var showBtn = new Button
                {
                    Text = "Show Details",
                    Height = 30,
                    Width = 115,
                    Name = "show" + x
                };
                deleteButton.Click += new EventHandler(DeleteClick);
                showBtn.Click += new EventHandler(OpenStats);
                budgetsFlow.Controls.Add(flow);
                flow.Controls.Add(Textbox);
                flow.Controls.Add(deleteButton);
                flow.Controls.Add(showBtn);
                Textbox.Text = budManager.GenerateBudget(x);
            }
        }

        private void OpenStats(object sender, EventArgs e)
        {
            tabControl1.SelectTab("dataTab");
            var showButton = (Button)sender;
            var list = budManager.LoadBudget();
            var array = list.ToArray();

            var index = int.Parse(showButton.Name.Substring(4));
            searchCategoryBox.Text = array[index].Category;
            dataTypeBox.SelectedIndex = 1;
            searchDatePickerFrom.Value = new DateTime(1970, 1, 1).AddSeconds(array[index].From).ToLocalTime();
            searchDatePickerTo.Value = new DateTime(1970, 1, 1).AddSeconds(array[index].To).ToLocalTime();
            Search(sender, e);
        }

        private void DeleteClick(object sender, EventArgs e)
        {
            var delButton = (Button)sender;

            var index = int.Parse(delButton.Name.Substring(6));
            budManager.DeleteBudget(index);
            budgetsFlow.Controls.Clear();
            DisplayBudgets();
        }
    }
}
