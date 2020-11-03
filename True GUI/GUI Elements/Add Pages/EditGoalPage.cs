using System;
using System.Drawing;
using System.Windows.Forms;

namespace Plutus
{
    public partial class TrueGUI : Form
    {
        private Label newGoalNameFieldLabel;
        private Label newGoalAmountFieldLabel;
        private Label newGoalDueDateFieldLabel;
        private Button changeGoalButton;
        private TextBox newGoalNameBox;
        private TextBox newGoalAmountBox;
        private DateTimePicker newGoalDueDateBox;
        private Button deleteGoalButton;
        private Label errorMessage;

        private void LoadEditGoalPage()
        {
            LoadEscapeButtonField();

            newGoalNameFieldLabel = CreateClassicLabel("newGoalNameFieldLabel", "Name:", Color.White, lilitaOne, 18F, 272, 40, 50, 100, 1, ContentAlignment.BottomLeft);
            newGoalAmountFieldLabel = CreateClassicLabel("newGoalAmountFieldLabel", "Amount you want to save:", Color.White, lilitaOne, 18F, 500, 40, 50, 260, 3, ContentAlignment.BottomLeft);
            newGoalDueDateFieldLabel = CreateClassicLabel("newGoalDueDateFieldLabel", "Set a due date:", Color.White, lilitaOne, 18F, 272, 40, 50, 420, 5, ContentAlignment.BottomLeft);
            changeGoalButton = CreateClassicButton("changeGoalButton", "change", Color.White, lilitaOne, 14F, firstColor, 272, 80, 50, 600, 7);
            changeGoalButton.Click += new EventHandler(ChangeGoalButton_Click);
            newGoalNameBox = CreateTextField("newGoalNameBox", _goal.Name, 160, 2);
            newGoalNameBox.Text = _goal.Name;
            newGoalAmountBox = CreateTextField("newGoalAmountBox", _goal.Amount.ToString(), 320, 4);
            newGoalAmountBox.Text = _goal.Amount.ToString();
            newGoalDueDateBox = new DateTimePicker();
            newGoalDueDateBox.SetBounds(50, 480, 272, 80);
            newGoalDueDateBox.Font = new Font(lilitaOne, 18F, FontStyle.Regular, GraphicsUnit.Point);
            newGoalDueDateBox.Value = _goal.DueDate;
            deleteGoalButton = CreateClassicButton("deleteGoalButton", "delete", Color.White, lilitaOne, 14F, Color.FromArgb(189, 183, 171), 272, 80, 50, 690, 7);
            deleteGoalButton.Click += new EventHandler(DeleteGoalButton_Click);
            errorMessage = CreateClassicLabel("errorLabel", "", firstColor, lilitaOne, 13F, 272, 40, 50, 530, 1, ContentAlignment.MiddleCenter);

            Controls.Add(newGoalNameFieldLabel);
            Controls.Add(newGoalAmountFieldLabel);
            Controls.Add(changeGoalButton);
            Controls.Add(newGoalNameBox);
            Controls.Add(newGoalAmountBox);
            Controls.Add(newGoalDueDateFieldLabel);
            Controls.Add(newGoalDueDateBox);
            Controls.Add(deleteGoalButton);
        }

        private void ChangeGoalButton_Click(object sender, EventArgs e)
        {
            Controls.Remove(errorMessage);
            var goalManager = new GoalManager();
            var verify = new InputVerification();
            var error = verify.VerifyData(name:newGoalNameBox.Text, amount: newGoalAmountBox.Text);
            if (error != "")
            {
                errorMessage.Text = error;
                Controls.Add(errorMessage);
            }
            else
            {
                goalManager.EditGoal(_goal, newGoalNameBox.Text, newGoalAmountBox.Text, newGoalDueDateBox.Value);
                Controls.Clear();
                LoadGoalsPage();
            }
        }
        private void DeleteGoalButton_Click(object sender, EventArgs e)
        {
            var goalManager = new GoalManager();
            goalManager.DeleteGoal(_goal);
            Controls.Clear();
            LoadGoalsPage();
        }



}
}