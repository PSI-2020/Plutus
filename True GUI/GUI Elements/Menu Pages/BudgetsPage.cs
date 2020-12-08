using System;
using System.Drawing;
using System.Windows.Forms;

namespace Plutus
{
    public partial class TrueGUI : Form
    {

        Label budgetsPageName;
        FlowLayoutPanel budgetsFlow;
        Button budgetAddButton;

        private void InitializeBudgetsPage()
        {
            budgetsPageName = CreatePageNameLabel("budgetsPageNameLabel", "BUDGETS");
            budgetsFlow = new FlowLayoutPanel
            {
                BackColor = _secondColor,
                Width = ClientSize.Width - 4,
                Left = 2,
                Top = 220,
                Height = 500,
                FlowDirection = FlowDirection.TopDown,
                AutoScroll = true,
                WrapContents = false
            };
            budgetAddButton = CreateClassicButton("budgetAddButton", Properties.Resources.PlusButton, (ClientSize.Width / 2) - 30, 720, 3, true);
            budgetAddButton.Click += new EventHandler(BudgetAddButtonClick);
        }
        private void BudgetAddButtonClick(object sender, EventArgs e) => LoadAddBudgetPage();

        private void LoadBudgetsPage()
        {
            Controls.Clear();
            budgetsFlow.Controls.Clear();
            LoadMenuButton();
            LoadEscapeButton();
            var list = _fileManager.LoadBudget();
            if (list == null) return;


            for (var x = 0; x < list.Count; x++)
            {
                InitializeBudgets(x);
            }

            Controls.Add(budgetsPageName);
            Controls.Add(budgetAddButton);
            Controls.Add(budgetsFlow);
            ResumeLayout(false);
            PerformLayout();
        }

        private async void InitializeBudgets(int index)
        {
            var flow = new FlowLayoutPanel
            {
                Height = 150,
                Width = ClientSize.Width - 4,
                Name = "flow" + index,
                FlowDirection = FlowDirection.LeftToRight
            };
            var label = new Label
            {
                BackColor = _secondColor,
                Font = new Font(_lilitaOne, 11F, FontStyle.Regular, GraphicsUnit.Point),
                Height = 90,
                Width = ClientSize.Width - 40,
                Name = "budgetLabel" + index
            };
            var deleteButton = new Button
            {
                Text = "Delete",
                Font = new Font(_lilitaOne, 11F, FontStyle.Regular, GraphicsUnit.Point),
                Height = 30,
                Width = 80,
                Name = "delBtn" + index
            };
            var showBtn = new Button
            {
                Text = "Show Details",
                Font = new Font(_lilitaOne, 11F, FontStyle.Regular, GraphicsUnit.Point),
                Height = 30,
                Width = 140,
                Name = "show" + index
            };
            deleteButton.Click += new EventHandler(DeleteClick);
            showBtn.Click += new EventHandler(OpenStats);
            budgetsFlow.Controls.Add(flow);
            flow.Controls.Add(label);
            flow.Controls.Add(deleteButton);
            flow.Controls.Add(showBtn);
            label.Text = await HttpService.GetBudgetAsync(index);
        }

        private void OpenStats(object sender, EventArgs e)
        {
            Controls.Clear();
            LoadHistoryPage();

            var showButton = (Button)sender;
            var index = int.Parse(showButton.Name.Substring(4));
            //historyDataGrid.DataSource = _budgetsController.GetStats(index);
        }

        private async void DeleteClick(object sender, EventArgs e)
        {
            var delButton = (Button)sender;
            var index = int.Parse(delButton.Name.Substring(6));
            await HttpService.DeleteBudgetAsync(index);

            budgetsFlow.Controls.Clear();
            LoadBudgetsPage();
        }
    }
}
