using System;
using System.Windows.Forms;
namespace Plutus
{
    public partial class GUI : Form
    {
        private void ButtonAddNewScheduledIncome_Click(object sender, EventArgs e)
        {
            panelMyScheduledIncome.Visible = false;
            panelAddMonthlyIncome.Visible = true;
            monthlyIncomeStatusLabel.Text = null;
        }

        private void ButtonMyScheduledIncome_Click(object sender, EventArgs e)
        {
            panelEditScheduledIncome.Visible = false;
            panelMyScheduledIncome.Visible = true;
            panelShowScheduledIncome.Visible = true;
            panelAddMonthlyIncome.Visible = false;

            textBoxScheduledIncome.Text = goalManager.ShowMonthlyIncome();
        }


        private void ButtonAddMonthlyIncome_Click(object sender, EventArgs e)
        { 
            var verify = new InputVerification();
            var error = verify.VerifyData(amount: monthlyIncomeAmount.Text, category: monthlyIncomeCategory.Text);
            if (error != "")
            {
                MessageBox.Show(error, "Something is missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            goalManager.AddMonthlyIncome(monthlyIncomeAmount.Text, monthlyIncomeCategory.Text);
            comboBoxScheduledIncome.Items.Add(monthlyIncomeCategory.Text);
            _ = new Scheduler(monthlyIncomeDate.Value, monthlyIncomeName.Text, monthlyIncomeAmount.Text, monthlyIncomeCategory.Text, fileManager, true);

            monthlyIncomeStatusLabel.Text = "Monthly income was added successfully!";
            monthlyIncomeAmount.Clear();
            monthlyIncomeCategory.Text = null;
            monthlyIncomeName.Text = null;
            monthlyIncomeDate.ResetText();
        }

        private void ButtonEditScheduledIncome_Click(object sender, EventArgs e)
        {
            panelScheduledIncomeComment.Visible = false;
            panelShowScheduledIncome.Visible = false;
            panelEditScheduledIncome.Visible = true;
            panelChangeScheduledIncome.Visible = false;
            comboBoxScheduledIncome.Text = null;

            var list = goalManager.ReadMonthlyIncome();

            if (comboBoxScheduledIncome.Items.Count == 0)
            {
                foreach (var income in list)
                {
                    comboBoxScheduledIncome.Items.Add(income.Category);
                }
            }
        }

        private void ComboBoxScheduledIncome_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxScheduledIncome.SelectedIndex < 0) return;
            panelChangeScheduledIncome.Visible = true;
            panelScheduledIncomeComment.Visible = false;

            var list = goalManager.ReadMonthlyIncome();
            var income = list.ToArray();
            var index = comboBoxScheduledIncome.SelectedIndex;

            //  scheduledIncomeNewName.Text = income[index].Name;
            scheduledIncomeNewAmount.Text = income[index].Sum.ToString();
            scheduledIncomeNewFirstPay.Value =  new DateTime(1970, 1, 1, 0, 0, 0).AddSeconds(income[index].Date).ToLocalTime();
            scheduledIncomeNewCategory.Text = income[index].Category;
        }

        private void ButtonChangeScheduledIncome_Click(object sender, EventArgs e)
        {
            var verify = new InputVerification();
            var error = verify.VerifyData(amount: scheduledIncomeNewAmount.Text, category: scheduledIncomeNewCategory.Text);
            if (error != "")
            {
                MessageBox.Show(error, "Something is missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            goalManager.EditMonthlyIncome(comboBoxScheduledIncome.SelectedIndex, scheduledIncomeNewCategory.Text, scheduledIncomeNewAmount.Text, scheduledIncomeNewFirstPay.Value);
            panelScheduledIncomeComment.Visible = true;
            panelChangeScheduledIncome.Visible = false;
            comboBoxScheduledIncome.Text = null;
            scheduledIncomeComment.Text = "Changed succesfully";

        }

        private void ButtonDeleteScheduledIncome_Click(object sender, EventArgs e)
        {
            var index = comboBoxScheduledIncome.SelectedIndex;
            goalManager.DeleteMonthlyIncome(index);
            comboBoxScheduledIncome.Items.RemoveAt(index);
            panelChangeScheduledIncome.Visible = false;
            panelScheduledIncomeComment.Visible = true;
            comboBoxScheduledIncome.Text = null;
            scheduledIncomeComment.Text = "Monthly Income was deleted.";

        }
    }
}
