using System;
using System.Drawing;
using System.Windows.Forms;

namespace Plutus
{
    public partial class TrueGUI : Form
    {
        Label menuTextLabel;
        Button historyMenuButton;
        Button insightsMenuButton;
        Button schedulerMenuButton;
        Button goalsMenuButton;
        Button budgetsMenuButton;
        Button cartsMenuButton;

        private void LoadMenuPage()
        {
            LoadEscapeButton();

            menuTextLabel = CreateClassicLabel("menuTextLabel", "Menu:", firstColor, lilitaOne, 24F, ClientSize.Width, 40, 0, 120, 1);

            historyMenuButton = CreateMenuButton("historyMenuButton", "HISTRORY", 1);
            historyMenuButton.Click += new EventHandler(HistoryMenuButton_Click);

            insightsMenuButton = CreateMenuButton("insightsMenuButton", "INSIGHTS", 2);
            insightsMenuButton.Click += new EventHandler(InsightsMenuButton_Click);

            schedulerMenuButton = CreateMenuButton("schedulerMenuButton", "SCHEDULER", 3);
            schedulerMenuButton.Click += new EventHandler(SchedulerMenuButton_Click);

            goalsMenuButton = CreateMenuButton("goalsMenuButton", "GOALS", 4);
            goalsMenuButton.Click += new EventHandler(GoalsMenuButton_Click);

            budgetsMenuButton = CreateMenuButton("budgetsMenuButton", "BUDGETS", 5);
            budgetsMenuButton.Click += new EventHandler(BudgetsMenuButton_Click);

            cartsMenuButton = CreateMenuButton("cartsMenuButton", "CARTS", 6);
            cartsMenuButton.Click += new EventHandler(CartsMenuButton_Click);



            Controls.Add(menuTextLabel);
            Controls.Add(historyMenuButton);
            Controls.Add(insightsMenuButton);
            Controls.Add(schedulerMenuButton);
            Controls.Add(goalsMenuButton);
            Controls.Add(budgetsMenuButton);
            Controls.Add(cartsMenuButton);
            ResumeLayout(false);
            PerformLayout();
        }

        private Button CreateMenuButton(string name, string text, int eil)
        {
            var top = 214 + (82 * (eil - 1));
            var menuButton = new Button
            {
                Font = new Font(lilitaOne, 18F, FontStyle.Regular, GraphicsUnit.Point),
                Text = text,
                ForeColor = Color.White,
                TextAlign = ContentAlignment.MiddleCenter,
                BackColor = Color.FromArgb(163, 160, 154),
                Width = 300,
                Height = 77,
                Top = top,
                Left = 37,
                FlatStyle = FlatStyle.Flat,
                TabIndex = eil + 1
            };
            menuButton.FlatAppearance.BorderSize = 0;
            return menuButton;
        }

        private void HistoryMenuButton_Click(object sender, EventArgs e)
        {
            Controls.Clear();
            LoadHistoryPage();
        }

        private void InsightsMenuButton_Click(object sender, EventArgs e)
        {
            Controls.Clear();
             LoadInsightsPage();
        }

        private void SchedulerMenuButton_Click(object sender, EventArgs e)
        {
            Controls.Clear();
            LoadSchedulerPage();
        }

        private void GoalsMenuButton_Click(object sender, EventArgs e)
        {
            Controls.Clear();
            LoadGoalsPage();
        }

        private void BudgetsMenuButton_Click(object sender, EventArgs e)
        {
            Controls.Clear();
            LoadBudgetsPage();
        }

        private void CartsMenuButton_Click(object sender, EventArgs e)
        {
            Controls.Clear();
            LoadCartsPage();
        }



    }
}
