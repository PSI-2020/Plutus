using System;
using System.Drawing;
using System.Linq;
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

        private async void LoadBudgetsPageAsync()
        {
            Controls.Clear();
            budgetsFlow.Controls.Clear();
            LoadMenuButton();
            LoadEscapeButton();
            var list = await _plutusApiClient.GetBudgetsListAsync();
            if (list == null) return;


            for (var x = 0; x < list.Count; x++)
            {
                InitializeBudgetsAsync(x);
            }

            Controls.Add(budgetsPageName);
            Controls.Add(budgetAddButton);
            Controls.Add(budgetsFlow);
            ResumeLayout(false);
            PerformLayout();
        }

        private async void InitializeBudgetsAsync(int index)
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
            deleteButton.Click += new EventHandler(DeleteClickAsync);
            showBtn.Click += new EventHandler(OpenStatsAsync);
            budgetsFlow.Controls.Add(flow);
            flow.Controls.Add(label);
            flow.Controls.Add(deleteButton);
            flow.Controls.Add(showBtn);
            label.Text = await _plutusApiClient.GetBudgetAsync(index);
        }

        private async void OpenStatsAsync(object sender, EventArgs e)
        {
            Controls.Clear();
            LoadBudgetHistoryPage();

            var showButton = (Button)sender;
            var index = int.Parse(showButton.Name[4..]);
            var list = (await _plutusApiClient.GetBudgetStatsAsync(index)).Select(x => new { DATE = x.Date.ConvertToDate(), NAME = x.Name, AMOUNT = x.Amount, CATEGORY = x.Category })
                .OrderByDescending(x => x.DATE).ToList();
            historyDataGrid.DataSource = !list.Any() ? null : list;
        }

        private async void DeleteClickAsync(object sender, EventArgs e)
        {
            var delButton = (Button)sender;
            var index = int.Parse(delButton.Name[6..]);
            await _plutusApiClient.DeleteBudgetAsync(index);

            budgetsFlow.Controls.Clear();
            LoadBudgetsPageAsync();
        }
    }
}