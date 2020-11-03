using System;
using System.Drawing;
using System.Windows.Forms;

namespace Plutus
{
    public partial class TrueGUI : Form
    {
        readonly BudgetsManager budManager = new BudgetsManager();

        Label budgetsPageName;
        FlowLayoutPanel budgetsFlow;
        Button budgetAddButton;

        private void InitializeBudgetsPage()
        {
            budgetsPageName = CreatePageNameLabel("budgetsPageNameLabel", "BUDGETS");
            budgetsFlow = new FlowLayoutPanel
            {
                BackColor = secondColor,
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
            LoadEscapeButtonCat();
            var list = budManager.LoadBudget();
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

        private void InitializeBudgets(int index)
        {
            var flow = new FlowLayoutPanel
            {
                Height = 100,
                Width = ClientSize.Width - 4,
                Name = "flow" + index,
                FlowDirection = FlowDirection.LeftToRight
            };
            var Textbox = new TextBox
            {
                BackColor = secondColor,
                Font = new Font(lilitaOne, 11F, FontStyle.Regular, GraphicsUnit.Point),
                Height = 90,
                Width = 180,
                Multiline = true,
                ReadOnly = true,
                Name = "budgetText" + index
            };
            var deleteButton = new Button
            {
                Text = "Delete",
                Font = new Font(lilitaOne, 11F, FontStyle.Regular, GraphicsUnit.Point),
                Height = 30,
                Width = 80,
                Name = "delBtn" + index
            };
            var showBtn = new Button
            {
                Text = "Show Details",
                Font = new Font(lilitaOne, 11F, FontStyle.Regular, GraphicsUnit.Point),
                Height = 30,
                Width = 80,
                Name = "show" + index
            };
            deleteButton.Click += new EventHandler(DeleteClick);
            //showBtn.Click += new EventHandler(OpenStats);
            budgetsFlow.Controls.Add(flow);
            flow.Controls.Add(Textbox);
            flow.Controls.Add(deleteButton);
            flow.Controls.Add(showBtn);
            Textbox.Text = budManager.GenerateBudget(index);
        }

        /*private void OpenStats(object sender, EventArgs e)
        {
            tabControl1.SelectTab("dataTab");
            var showButton = (Button)sender;
            var list = budManager.LoadBudget();

            var index = int.Parse(showButton.Name.Substring(4));
            searchCategoryBox.Text = list[index].Category;
            dataTypeBox.SelectedIndex = 1;
            searchDatePickerFrom.Value = new DateTime(1970, 1, 1).AddSeconds(list[index].From).ToLocalTime();
            searchDatePickerTo.Value = new DateTime(1970, 1, 1).AddSeconds(list[index].To).ToLocalTime();
            Search(sender, e);
        }*/

        private void DeleteClick(object sender, EventArgs e)
        {
            var delButton = (Button)sender;

            var index = int.Parse(delButton.Name.Substring(6));
            budManager.DeleteBudget(index);
            budgetsFlow.Controls.Clear();
            LoadBudgetsPage();
        }
    }
}
