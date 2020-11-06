using System;
using System.Drawing;
using System.Windows.Forms;

namespace Plutus
{
    public partial class TrueGUI : Form
    {
        Label schedulerPageName;

        private void LoadSchedulerPage()
        {
            LoadMenuButton();
            LoadEscapeButton();

            schedulerPageName = CreatePageNameLabel("schedulerPageNameLabel", "SCHEDULER");

            addTextLabel = CreateClassicLabel("addTextLabel", "ADD:", _firstColor, _lilitaOne, 32F, ClientSize.Width, 55, 0, ClientSize.Height - 500, 3);

            expenseAddButton = CreateClassicButton("expenseAddButton", Properties.Resources.AddExpenseButton, 50, ClientSize.Height - 440, 4);
            expenseAddButton.Click += new EventHandler(ScheduledExpenseAddButton_Click);

            expenseTextLabel = CreateClassicLabel("expenseTextLabel", "expense", _firstColor, _lilitaOne, 12F, 100, 30, expenseAddButton.Left + 15, ClientSize.Height - 320, 5);

            incomeAddButton = CreateClassicButton("incomeAddButton", Properties.Resources.AddIncomeButton, expenseAddButton.Left + 120 + 31, ClientSize.Height - 440, 6);
            incomeAddButton.Click += new EventHandler(ScheduledIncomeAddButton_Click);

            incomeTextLabel = CreateClassicLabel("incomeTextLabel", "income", _firstColor, _lilitaOne, 12F, 100, 30, incomeAddButton.Left + 16, ClientSize.Height - 320, 7);

            Controls.Add(addTextLabel);
            Controls.Add(expenseAddButton);
            Controls.Add(expenseTextLabel);
            Controls.Add(incomeAddButton);
            Controls.Add(incomeTextLabel);
            Controls.Add(schedulerPageName);
            ResumeLayout(false);
            PerformLayout();
        }

        private void ScheduledIncomeAddButton_Click(object sender, EventArgs e)
        {
            Controls.Clear();
            _currentInfo.CurrentType = "Income";
            LoadScheduledPaymentPage();
        }

        private void ScheduledExpenseAddButton_Click(object sender, EventArgs e)
        {
            Controls.Clear();
            _currentInfo.CurrentType = "Expense";
            LoadScheduledPaymentPage();
        }
    }
}

