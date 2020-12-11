using System;
using System.Drawing;
using System.Windows.Forms;

namespace Plutus
{
    public partial class TrueGUI : Form
    {
        Label goalsPageName;
        Label myGoalsTextLabel;
        Button newGoalAddButton;
        FlowLayoutPanel myGoalsPanel;
        Goal _currentGoal;

        private void LoadGoalsPage()
        {
            LoadMenuButton();
            LoadEscapeButton();

            goalsPageName = CreatePageNameLabel("goalsPageNameLabel", "GOALS");
            myGoalsTextLabel = CreateClassicLabel("myGoalsTextLabel", "My Goals:", Color.White, _lilitaOne, 24F, ClientSize.Width, 60, 0, 120, 1);

            newGoalAddButton = CreateClassicButton("newGoalAddButton", Properties.Resources.PlusButton, 150, ClientSize.Height - 90, 2);
            newGoalAddButton.Click += new EventHandler(AddNewGoalButton_Click);

            myGoalsPanel = new FlowLayoutPanel
            {
                Width = ClientSize.Width - 70,
                Left = 35,
                Top = 190,
                Height = ClientSize.Height - 300,
                FlowDirection = FlowDirection.LeftToRight
            };

            Controls.Add(myGoalsPanel);
            Controls.Add(newGoalAddButton);
            Controls.Add(goalsPageName);
            Controls.Add(myGoalsTextLabel);

            LoadMyCurrentGoalsAsync();

            ResumeLayout(false);
            PerformLayout();
        }

        private void AddNewGoalButton_Click(object sender, EventArgs e)
        {
            Controls.Clear();
            LoadAddGoalPage();
        }

        private async void LoadMyCurrentGoalsAsync()
        {
            var list = await _plutusApiClient.GetGoalsAsync();

            var i = 0;
            foreach(var goal in list)
            {
                var button = new GoalButton(goal.Name, Color.White, _lilitaOne, 14F, _firstColor, 145, 80, goal);
                if(i == 0)
                {
                    button.FlatAppearance.BorderColor = _secondColor;
                    button.FlatAppearance.BorderSize = 5;
                }
                i++;
                myGoalsPanel.Controls.Add(button);
                button.Click += new EventHandler(CheckMyGoal);
            }
        }

        private void CheckMyGoal(object sender, EventArgs e)
        {
            var button = (sender as GoalButton);
            _currentGoal = button.Goal;

            Controls.Clear();
            LoadCheckGoalPageAsync();

        }
    }
}
