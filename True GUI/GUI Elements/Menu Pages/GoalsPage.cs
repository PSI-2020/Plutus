using System;
using System.Drawing;
using System.Windows.Forms;

namespace Plutus
{
    public partial class TrueGUI : Form
    {
        private Label goalsPageName;
        private Label myGoalsTextLabel;
        private Button newGoalAddButton;
        private FlowLayoutPanel myGoalsPanel;

        private void LoadGoalsPage()
        {
            LoadMenuButton();
            LoadEscapeButtonCat();

            goalsPageName = CreatePageNameLabel("goalsPageNameLabel", "GOALS");
            myGoalsTextLabel = CreateClassicLabel("myGoalsTextLabel", "My Goals:", Color.White, lilitaOne, 24F, ClientSize.Width, 60, 0, 120, 1);
            newGoalAddButton = CreateClassicButton("newGoalAddButton", Properties.Resources.PlusButton, 150, ClientSize.Height - 100, 2);
            newGoalAddButton.Click += new EventHandler(AddNewGoalButton_Click);

            myGoalsPanel = new FlowLayoutPanel
            {
                //BackColor = secondColor,
                Width = ClientSize.Width - 70,
                Left = 35,
                Top = 200,
                Height = ClientSize.Height - 320,
                FlowDirection = FlowDirection.LeftToRight
            };

            Controls.Add(myGoalsPanel);
            Controls.Add(newGoalAddButton);
            Controls.Add(goalsPageName);
            Controls.Add(myGoalsTextLabel);
            LoadMyCurrentGoals();
            ResumeLayout(false);
            PerformLayout();
        }

        private void AddNewGoalButton_Click(object sender, EventArgs e)
        {
            Controls.Clear();
            LoadAddGoalPage();
        }

        private void LoadMyCurrentGoals()
        {
            var goalManager = new GoalManager();
            var list = goalManager.ReadGoals();

            foreach(var goal in list)
            {
                /* var button = CreateClassicButton("goal", goal.Name, Color.White, lilitaOne, 14F, firstColor, 145, 80, 50, 650, 3);
                 myGoalsPanel.Controls.Add(button);
                 button.Click += new EventHandler(CheckMyGoal);*/

                var button = new GoalButton(goal.Name, Color.White, lilitaOne, 14F, firstColor, 145, 80, goal);
                myGoalsPanel.Controls.Add(button);
                button.Click += new EventHandler(CheckMyGoal);
            }
        }

        private void CheckMyGoal(object sender, EventArgs e)
        {
            GoalButton button = (sender as GoalButton);
            Controls.Clear();
            LoadCheckGoalPage(button.Goal);

        }
    }
}
