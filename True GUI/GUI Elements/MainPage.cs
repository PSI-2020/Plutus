using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Plutus
{
    public partial class TrueGUI : Form
    {
        Label goalNameLabel;
        Label goalAmountLabel;
        Label addTextLabel;
        Button expenseAddButton;
        public Label expenseTextLabel;
        Button incomeAddButton;
        Label incomeTextLabel;

        private async void LoadMainPage()
        {
            LoadMenuButton();

            var goalList = await PlutusApiClient.GetGoalsAsync();
            if (goalList.Any())
            {
                var mainGoal = goalList[0];

                goalNameLabel = CreateClassicLabel("goalNameLabel", "Goal: " + mainGoal.Name, _firstColor, _lilitaOne, 30F, ClientSize.Width, 50, 0, 120, 1);
                goalNameLabel.TextAlign = ContentAlignment.MiddleCenter;
                goalAmountLabel = CreateClassicLabel("goalLabel", "save " + mainGoal.Amount.ToString("C2") + " until " + mainGoal.DueDate.ToString("yyyy/MM/dd"), Color.FromArgb(161, 156, 146), _lilitaOne, 13F, ClientSize.Width, 20, 0, 175, 2);

                todaySpendLabel = CreateClassicLabel("todaySpendLabel", "You can spend today: ", Color.FromArgb(126, 121, 112), _lilitaOne, 18F, ClientSize.Width, 40, 0, 215, 3);
                todaySpendLabel.TextAlign = ContentAlignment.MiddleCenter;
                dailySpendLabel = CreateClassicLabel("dailySpendLabel", await PlutusApiClient.GetGoalInsightsAsync( 0, "daily"), Color.White, _lilitaOne, 25F, ClientSize.Width - 150, 80, 70, 255, 5);
                dailySpendLabel.BackColor = Color.FromArgb(126, 121, 112);
                dailySpendLabel.TextAlign = ContentAlignment.MiddleCenter;

                Controls.Add(goalAmountLabel);
                Controls.Add(todaySpendLabel);
                Controls.Add(dailySpendLabel);
            }
            else
            {
                goalNameLabel = CreateClassicLabel("goalNameLabel", "NO GOAL", _firstColor, _lilitaOne, 30F, ClientSize.Width, 40, 0, 120, 1);
            }
            addTextLabel = CreateClassicLabel("addTextLabel", "ADD:", _firstColor, _lilitaOne, 32F, ClientSize.Width, 55, 0, ClientSize.Height - 300, 3);

            expenseAddButton = CreateClassicButton("expenseAddButton", Properties.Resources.AddExpenseButton, 50, ClientSize.Height - 240, 4);
            expenseAddButton.Click += new EventHandler(ExpenseAddButton_Click);

            expenseTextLabel = CreateClassicLabel("expenseTextLabel", "expense", _firstColor, _lilitaOne, 12F, 100, 30, expenseAddButton.Left + 15, ClientSize.Height - 120, 5);


            incomeAddButton = CreateClassicButton("incomeAddButton", Properties.Resources.AddIncomeButton, expenseAddButton.Left + 120 + 31, ClientSize.Height - 240, 6);
            incomeAddButton.Click += new EventHandler(IncomeAddButton_Click);

            incomeTextLabel = CreateClassicLabel("incomeTextLabel", "income", _firstColor, _lilitaOne, 12F, 100, 30, incomeAddButton.Left + 16, ClientSize.Height - 120, 7);

            Controls.Add(goalNameLabel);
            Controls.Add(addTextLabel);
            Controls.Add(expenseAddButton);
            Controls.Add(expenseTextLabel);
            Controls.Add(incomeAddButton);
            Controls.Add(incomeTextLabel);

            ResumeLayout(false);
            PerformLayout();
        }

        private void IncomeAddButton_Click(object sender, EventArgs e)
        {
            Controls.Clear();
            _currentInfo.CurrentType = "Income";
            LoadIncomeCategoryPage("mainPage");
        }

        private void ExpenseAddButton_Click(object sender, EventArgs e)
        {
            Controls.Clear();
            _currentInfo.CurrentType = "Expense";
            LoadExpenseCategoryPage("mainPage");

        }

        private void AddFieldsToCurrentPayment() => LoadPaymentFieldPage("mainPage");

        private async void AddCurrentPayment()
        {
            await _paymentService.AddPaymentAsync(_currentInfo);
            LoadMainPage();
        }


    }
}
