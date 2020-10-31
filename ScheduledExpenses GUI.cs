using System;
using System.Windows.Forms;

namespace Plutus
{
    public partial class GUI : Form
    {
        private void ButtonAddNewScheduledExpense_Click(object sender, EventArgs e)
        {
            panelMyScheduledExpenses.Visible = false;
            panelAddMonthlyExpenses.Visible = true;
            monthlyExpensesStatusLabel.Text = null;
        }

        private void ButtonAddMonthlyExpenses_Click(object sender, EventArgs e)
        {
            var verify = new InputVerification();
            var error = verify.VerifyData(name: monthlyExpensesName.Text, amount: monthlyExpensesAmount.Text, category: monthlyExpensesCategory.Text);
            if (error != "")
            {
                MessageBox.Show(error, "Something is missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            goalManager.AddMonthlyExpense(monthlyExpensesName.Text, monthlyExpensesAmount.Text, monthlyExpensesCategory.Text);
            comboBoxScheduledExpenses.Items.Add(monthlyExpensesName.Text);
            _ = new Scheduler(monthlyExpensesDate.Value, monthlyExpensesName.Text, monthlyExpensesAmount.Text, monthlyExpensesCategory.Text, fileManager, false);


            monthlyExpensesStatusLabel.Text = "Monthly expenses were successfully added!";
            monthlyExpensesAmount.Clear();
            monthlyExpensesCategory.Text = null;
            monthlyExpensesName.Text = null;
            monthlyExpensesDate.ResetText();
        }

        private void ButtonMyScheduledExpenses_Click(object sender, EventArgs e)
        {
            panelEditScheduledExpenses.Visible = false;
            panelMyScheduledExpenses.Visible = true;
            panelShowScheduledExpenses.Visible = true;
            panelAddMonthlyExpenses.Visible = false;

            textBoxScheduledExpenses.Text = goalManager.ShowMonthlyExpenses();
        }
        private void ButtonEditScheduledExpenses_Click(object sender, EventArgs e)
        {
            panelScheduledExpensesComment.Visible = false;
            panelShowScheduledExpenses.Visible = false;
            panelEditScheduledExpenses.Visible = true;
            panelChangeScheduledExpense.Visible = false;
            comboBoxScheduledExpenses.Text = null;

            var list = goalManager.ReadMonthlyExpenses();

            if (comboBoxScheduledExpenses.Items.Count == 0)
            {
                foreach (var expense in list)
                {
                    comboBoxScheduledExpenses.Items.Add(expense.Name);
                }
            }
        }

        private void ComboBoxScheduledExpenses_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxScheduledExpenses.SelectedIndex < 0) return;
            panelChangeScheduledExpense.Visible = true;
            panelScheduledExpensesComment.Visible = false;

            var list = goalManager.ReadMonthlyExpenses();
            var expense = list.ToArray();
            var index = comboBoxScheduledExpenses.SelectedIndex;

            scheduledExpenseNewName.Text = expense[index].Name;
            scheduledExpenseNewAmount.Text = expense[index].Price.ToString();
            scheduledExpenseNewFirstPay.Value = new DateTime(1970, 1, 1, 0, 0, 0).AddSeconds(expense[index].Date).ToLocalTime();
            scheduledExpenseNewCategory.Text = expense[index].Category;
        }

        private void ButtonChangeScheduledExpense_Click(object sender, EventArgs e)
        {
            var verify = new InputVerification();
            var error = verify.VerifyData(name: scheduledExpenseNewName.Text, amount: scheduledExpenseNewAmount.Text, category: scheduledExpenseNewCategory.Text);
            if (error != "")
            {
                MessageBox.Show(error, "Something is missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            goalManager.EditMonthlyExpense(comboBoxScheduledExpenses.SelectedIndex, scheduledExpenseNewName.Text, scheduledExpenseNewCategory.Text, scheduledExpenseNewAmount.Text, scheduledIncomeNewFirstPay.Value);
            panelScheduledExpensesComment.Visible = true;
            panelChangeScheduledExpense.Visible = false;
            comboBoxScheduledExpenses.Text = null;
            scheduledExpensesComment.Text = "Changed succesfully";
        }

        private void ButtonDeleteScheduledExpense_Click(object sender, EventArgs e)
        {
            var index = comboBoxScheduledIncome.SelectedIndex;
            goalManager.DeleteMonthlyExpenses(index);
            comboBoxScheduledExpenses.Items.RemoveAt(index);
            panelChangeScheduledExpense.Visible = false;
            panelScheduledExpensesComment.Visible = true;
            comboBoxScheduledExpenses.Text = null;
            scheduledExpensesComment.Text = "Monthly Expense was deleted.";

        }
    }
}
