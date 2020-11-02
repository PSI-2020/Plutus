using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Plutus
{
    public partial class TrueGUI : Form
    {
        Label balanceTextLabel;
        Label balanceLabel;
        Label addTextLabel;
        Button expenseAddButton;
        Label expenseTextLabel;
        Button incomeAddButton;
        Label incomeTextLabel;

        private void LoadMainPage()
        {
            LoadMenuButton();
            balanceTextLabel = CreateClassicLabel("balanceTextLabel", "BALANCE:", firstColor, lilitaOne, 24F, ClientSize.Width, 40, 0, 120, 1);
            balanceLabel = CreateClassicLabel("balanceLabel", "450000", firstColor, lilitaOne, 32F, ClientSize.Width, 55, 0, 160, 2); 
            addTextLabel = CreateClassicLabel("addTextLabel", "ADD:", firstColor, lilitaOne, 32F, ClientSize.Width, 55, 0, ClientSize.Height - 300, 3);

            expenseAddButton = CreateClassicButton("expenseAddButton", Properties.Resources.AddExpenseButton, 50, ClientSize.Height - 240, 4);
            expenseAddButton.Click += new EventHandler(ExpenseAddButton_Click);

            expenseTextLabel = CreateClassicLabel("expenseTextLabel", "expense", firstColor, lilitaOne, 12F, 100, 30, expenseAddButton.Left + 15, ClientSize.Height - 120, 5);


            incomeAddButton = CreateClassicButton("incomeAddButton", Properties.Resources.AddIncomeButton, expenseAddButton.Left + 120 + 31, ClientSize.Height - 240, 6);
            incomeAddButton.Click += new EventHandler(IncomeAddButton_Click);

            incomeTextLabel = CreateClassicLabel("incomeTextLabel", "income", firstColor, lilitaOne, 12F, 100, 30, incomeAddButton.Left + 16, ClientSize.Height - 120, 7);

            // 
            // TrueGUI
            // 
           // var balance = BalanceService.GiveBalance();
          //  blaanceLabel.Text = balance;

            Controls.Add(balanceTextLabel);
            Controls.Add(balanceLabel);
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
            LoadIncomeCategoryPage();
        }

        private void ExpenseAddButton_Click(object sender, EventArgs e)
        {
            Controls.Clear();
            LoadExpenseCategoryPage();
        }


    }
}
