using System;
using System.Drawing;
using System.Windows.Forms;

namespace Plutus
{
    public partial class TrueGUI : Form
    {
        private Label myGoalNameLabel;
        private Label myGoalAmountLabel;
        private Label myGoalDueDateLabel;
        private FlowLayoutPanel goalInsightsPanel;
        private Label monthlySpendLabel;
        private Label dailySpendLabel;
        private Label daysLeftLabel;
        private Label todaySpendLabel;
        private Label thisMonthSpendLabel;
        private Label daysLabel;
        private Button editGoalButton;
        

        private void InitializeCheckGoalPage()
        {
            todaySpendLabel = CreateClassicLabel("todaySpendLabel", "\nYou can spend today: ", Color.FromArgb(126, 121, 112), lilitaOne, 18F, 300, 80, 0, 190, 4);
            thisMonthSpendLabel = CreateClassicLabel("thisMonthSpendLabel", "\nYou can spend this month: ", Color.FromArgb(126, 121, 112), lilitaOne, 18F, 300, 80, 0, 190, 6);
            daysLeftLabel = CreateClassicLabel("daysLeftLabel", "\nDays left: ", Color.FromArgb(126, 121, 112), lilitaOne, 18F, 300, 80, 0, 190, 8);
            
            editGoalButton = CreateClassicButton("editGoalButton", "edit", Color.White, lilitaOne, 14F, Color.FromArgb(141, 139, 134), 100, 60, 135, 700, 10);
            editGoalButton.Click += new EventHandler(EditGoalButton_Click);
        }
        private void LoadCheckGoalPage()
        {
            LoadEscapeButtonField();
            LoadMenuButton();

            myGoalNameLabel = CreateClassicLabel("myGoalNameLabel", "Goal: " + _currentGoal.Name, Color.White, lilitaOne, 25F, ClientSize.Width, 50, 0, 80, 1);
            myGoalNameLabel.BackColor = firstColor;

            myGoalAmountLabel = CreateClassicLabel("myGoalAmountLabel", "Save: " + _currentGoal.Amount + "€", Color.FromArgb(161,156,146), lilitaOne, 13F, ClientSize.Width, 18, 0, 130, 2);
            myGoalDueDateLabel = CreateClassicLabel("myGoalDueDateLabel", "until " + _currentGoal.DueDate.ToString("yyyy/MM/dd"), Color.FromArgb(161, 156, 146), lilitaOne, 13F, ClientSize.Width, 18, 0, 148, 3);

            dailySpendLabel = CreateClassicLabel("dailySpendLabel", goalService.Insights(fileManager, _currentGoal, "daily"), Color.White, lilitaOne, 25F, 300, 80, 0, 190, 5);
            dailySpendLabel.BackColor = Color.FromArgb(126, 121, 112);

            monthlySpendLabel = CreateClassicLabel("monthlySpendLabel", goalService.Insights(fileManager, _currentGoal, "monthly"), Color.White, lilitaOne, 25F, 300, 80, 0, 190, 7);
            monthlySpendLabel.BackColor = Color.FromArgb(126, 121, 112);

            daysLabel = CreateClassicLabel("daysLabel", goalService.DaysLeft(_currentGoal), Color.White, lilitaOne, 25F, 300, 80, 0, 190, 9);
            daysLabel.BackColor = Color.FromArgb(126, 121, 112);

            goalInsightsPanel = new FlowLayoutPanel
            {
                Width = ClientSize.Width - 70,
                Left = 35,
                Top = 150,
                Height = ClientSize.Height - 300,
                FlowDirection = FlowDirection.TopDown
            };
  
            goalInsightsPanel.Controls.Add(todaySpendLabel);
            goalInsightsPanel.Controls.Add(dailySpendLabel);
            goalInsightsPanel.Controls.Add(thisMonthSpendLabel);
            goalInsightsPanel.Controls.Add(monthlySpendLabel);
            goalInsightsPanel.Controls.Add(daysLeftLabel);
            goalInsightsPanel.Controls.Add(daysLabel);

            Controls.Add(myGoalNameLabel);
            Controls.Add(myGoalAmountLabel);
            Controls.Add(myGoalDueDateLabel);
            Controls.Add(goalInsightsPanel);
            Controls.Add(editGoalButton);

        }
        private void EditGoalButton_Click(object sender, EventArgs e)
        {
            Controls.Clear();
            LoadEditGoalPage();
        }


    }
}