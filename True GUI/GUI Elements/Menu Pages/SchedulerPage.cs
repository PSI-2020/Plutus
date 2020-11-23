using System;
using System.Drawing;
using System.Windows.Forms;

namespace Plutus
{
    public partial class TrueGUI : Form
    {
        Label schedulerPageName;
        Label scheduledIncomeLabel;
        Label scheduledExpenseLabel;
        FlowLayoutPanel expensesFlow;
        FlowLayoutPanel incomesFlow;

        private void InitializeSchedulerPage()
        {
            
        }

        private void LoadSchedulerPage()
        {
            Controls.Clear();
            LoadMenuButton();
            LoadEscapeButton();

            schedulerPageName = CreatePageNameLabel("schedulerPageNameLabel", "SCHEDULER");
            scheduledIncomeLabel = CreateClassicLabel("scheduledIncomeLabel", "Scheduled Incomes", _firstColor, _lilitaOne, 14F, ClientSize.Width, 30, 10, 120, 1);
            incomesFlow = new FlowLayoutPanel
            {
                BackColor = _secondColor,
                Width = ClientSize.Width - 4,
                Left = 2,
                Top = 155,
                Height = 170,
                FlowDirection = FlowDirection.TopDown,
                AutoScroll = true,
                WrapContents = false
            };

            scheduledExpenseLabel = CreateClassicLabel("scheduledExpenseLabel", "Scheduled Expenses", _firstColor, _lilitaOne, 14F, ClientSize.Width, 30, 10, 330, 1);
            expensesFlow = new FlowLayoutPanel
            {
                BackColor = _secondColor,
                Width = ClientSize.Width - 4,
                Left = 2,
                Top = 365,
                Height = 170,
                FlowDirection = FlowDirection.TopDown,
                AutoScroll = true,
                WrapContents = false
            };

            addTextLabel = CreateClassicLabel("addTextLabel", "ADD:", _firstColor, _lilitaOne, 24F, ClientSize.Width, 40, 0, ClientSize.Height - 220, 3);

            expenseAddButton = CreateClassicButton("expenseAddButton", Properties.Resources.AddExpenseButton, 50, ClientSize.Height - 175, 4);
            expenseAddButton.Click += new EventHandler(ScheduledExpenseAddButton_Click);

            expenseTextLabel = CreateClassicLabel("expenseTextLabel", "expense", _firstColor, _lilitaOne, 12F, 100, 30, expenseAddButton.Left + 15, ClientSize.Height - 50, 5);

            incomeAddButton = CreateClassicButton("incomeAddButton", Properties.Resources.AddIncomeButton, expenseAddButton.Left + 120 + 31, ClientSize.Height - 175, 6);
            incomeAddButton.Click += new EventHandler(ScheduledIncomeAddButton_Click);

            incomeTextLabel = CreateClassicLabel("incomeTextLabel", "income", _firstColor, _lilitaOne, 12F, 100, 30, incomeAddButton.Left + 16, ClientSize.Height - 50, 7);

            var incomesList = _fileManager.LoadScheduledPayments("MonthlyIncome");
            var expensesList = _fileManager.LoadScheduledPayments("MonthlyExpenses");

            for(var x = 0; x < incomesList.Count; x++)
            {
                incomesFlow.Controls.Add(InitializePayments(x, "MonthlyIncome"));
            }
            for(var x = 0; x < expensesList.Count; x++)
            {
                expensesFlow.Controls.Add(InitializePayments(x, "MonthlyExpenses"));
            }

            Controls.Add(scheduledExpenseLabel);
            Controls.Add(expensesFlow);
            Controls.Add(scheduledIncomeLabel);
            Controls.Add(incomesFlow);
            Controls.Add(addTextLabel);
            Controls.Add(expenseAddButton);
            Controls.Add(expenseTextLabel);
            Controls.Add(incomeAddButton);
            Controls.Add(incomeTextLabel);
            Controls.Add(schedulerPageName);
            ResumeLayout(false);
            PerformLayout();
        }

        private FlowLayoutPanel InitializePayments(int index, string type)
        {
            var flow = new FlowLayoutPanel
            {
                Height = 50,
                Width = ClientSize.Width,
                Name = "flow" + index,
                FlowDirection = FlowDirection.LeftToRight
            };
            var label = new Label
            {
                BackColor = _secondColor,
                Font = new Font(_lilitaOne, 11F, FontStyle.Regular, GraphicsUnit.Point),
                Height = 48,
                Width = ClientSize.Width - 140,
                Name = "paymentLabel" + index
            };
            var deleteButton = new Button
            {
                Text = "Del",
                Font = new Font(_lilitaOne, 8F, FontStyle.Regular, GraphicsUnit.Point),
                Height = 40,
                Width = 40,
                Name = "delBtn" + index
            };
            var activateButton = new Button
            {
                Text = "+",
                Font = new Font(_lilitaOne, 10F, FontStyle.Regular, GraphicsUnit.Point),
                ForeColor = Color.Green,
                Height = 40,
                Width = 35,
                Name = "actBtn" + index
            };
            var deactivateButton = new Button
            {
                Text = "X",
                Font = new Font(_lilitaOne, 8F, FontStyle.Regular, GraphicsUnit.Point),
                ForeColor = Color.Red,
                Height = 40,
                Width = 35,
                Name = "deactBtn" + index
            };
            deleteButton.Click += (sender, e) => DelButtonClick(sender, e, type);
            activateButton.Click += (sender, e) => StatusChangeClick(sender, e, type, int.Parse(activateButton.Name.Substring(6)), "Active");
            deactivateButton.Click += (sender, e) => StatusChangeClick(sender, e, type, int.Parse(deactivateButton.Name.Substring(8)), "Inactive");
            label.Text = _schedulerService.ShowPayment(index, type);
            flow.Controls.Add(label);
            flow.Controls.Add(activateButton);
            flow.Controls.Add(deactivateButton);
            flow.Controls.Add(deleteButton);
            return flow;
        }

        private void StatusChangeClick(object sender, EventArgs e, string type, int index, string status)
        {
            _schedulerService.ChangeStatus(index, type, status);
            incomesFlow.Controls.Clear();
            expensesFlow.Controls.Clear();
            LoadSchedulerPage();
        }

        private void DelButtonClick(object sender, EventArgs e, string type)
        {
            var delButton = (Button)sender;
            var index = int.Parse(delButton.Name.Substring(6));
            _schedulerService.DeletePayment(index, type);

            incomesFlow.Controls.Clear();
            expensesFlow.Controls.Clear();
            LoadSchedulerPage();
        }

        private void ScheduledIncomeAddButton_Click(object sender, EventArgs e)
        {
            Controls.Clear();
            LoadScheduledPaymentPage("MonthlyIncome");
        }

        private void ScheduledExpenseAddButton_Click(object sender, EventArgs e)
        {
            Controls.Clear();
            LoadScheduledPaymentPage("MonthlyExpenses");
        }
    }
}

