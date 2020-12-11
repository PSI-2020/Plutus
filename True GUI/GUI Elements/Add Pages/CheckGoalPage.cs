using System;
using System.Drawing;
using System.Windows.Forms;

namespace Plutus
{
    public partial class TrueGUI : Form
    {
        Label myGoalNameLabel;
        Label myGoalAmountLabel;
        Label myGoalDueDateLabel;
        FlowLayoutPanel goalInsightsPanel;
        Label monthlySpendLabel;
        Label dailySpendLabel;
        Label daysLeftLabel;
        Label todaySpendLabel;
        Label thisMonthSpendLabel;
        Label daysLabel;
        Button editGoalButton;
        Button setAsMainGoalButton;

        private void InitializeCheckGoalPage()
        {
            editGoalButton = CreateClassicButton("editGoalButton", "edit", Color.White, _lilitaOne, 14F, Color.FromArgb(141, 139, 134), 100, 60, 50, 700, 10);
            editGoalButton.Click += new EventHandler(EditGoalButton_Click);

            setAsMainGoalButton = CreateClassicButton("setAsMainGoalButton", "set as main goal", Color.White, _lilitaOne, 14F, _firstColor, 150, 60, 170, 700, 10);
            setAsMainGoalButton.Click += new EventHandler(SetAsMainGoalButton_Click);
        }
        private async void LoadCheckGoalPage()
        {
            LoadEscapeButton();
            LoadMenuButton();
            var list = await _plutusApiClient.GetGoalsAsync();
            var id = 0;
            foreach (var i in list)
            {
                if (_currentGoal.Name == i.Name && _currentGoal.Amount == i.Amount && _currentGoal.DueDate == i.DueDate)
                    break;
                id++;
            }

            todaySpendLabel = CreateClassicLabel("todaySpendLabel", "\nYou can spend today: ", Color.FromArgb(126, 121, 112), _lilitaOne, 18F, 300, 80, 0, 190, 4);
            thisMonthSpendLabel = CreateClassicLabel("thisMonthSpendLabel", "\nYou can spend this month: ", Color.FromArgb(126, 121, 112), _lilitaOne, 18F, 300, 80, 0, 190, 6);
            daysLeftLabel = CreateClassicLabel("daysLeftLabel", "\nDays left: ", Color.FromArgb(126, 121, 112), _lilitaOne, 18F, 300, 80, 0, 190, 8);

            myGoalNameLabel = CreateClassicLabel("myGoalNameLabel", "Goal: " + _currentGoal.Name, Color.White, _lilitaOne, 25F, ClientSize.Width, 50, 0, 80, 1);
            myGoalNameLabel.BackColor = _firstColor;

            myGoalAmountLabel = CreateClassicLabel("myGoalAmountLabel", "Save: " + _currentGoal.Amount + "€", Color.FromArgb(161,156,146), _lilitaOne, 13F, ClientSize.Width, 20, 0, 130, 2);
            myGoalDueDateLabel = CreateClassicLabel("myGoalDueDateLabel", "until " + _currentGoal.DueDate.ToString("yyyy/MM/dd"), Color.FromArgb(161, 156, 146), _lilitaOne, 13F, ClientSize.Width, 20, 0, 151, 3);
            
            dailySpendLabel = CreateClassicLabel("dailySpendLabel", await _plutusApiClient.GetGoalInsightsAsync(id, "daily"), Color.White, _lilitaOne, 25F, 300, 80, 0, 190, 5);
            dailySpendLabel.BackColor = Color.FromArgb(126, 121, 112);

            monthlySpendLabel = CreateClassicLabel("monthlySpendLabel", await _plutusApiClient.GetGoalInsightsAsync(id, "monthly"), Color.White, _lilitaOne, 25F, 300, 80, 0, 190, 7);
            monthlySpendLabel.BackColor = Color.FromArgb(126, 121, 112);

            daysLabel = CreateClassicLabel("daysLabel", _currentGoal.CalculateDaysLeft(), Color.White, _lilitaOne, 25F, 300, 80, 0, 190, 9); ;
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
            Controls.Add(setAsMainGoalButton);

        }
        private void EditGoalButton_Click(object sender, EventArgs e)
        {
            Controls.Clear();
            LoadEditGoalPage();
        }

        private async void SetAsMainGoalButton_Click(object sender, EventArgs e)
        { 
            await _plutusApiClient.SetAsMainGoalAsync(_currentGoal);
            Controls.Clear();
            LoadMainPage();
        }



    }
}