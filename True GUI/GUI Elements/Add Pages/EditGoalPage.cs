using Plutus.Services;
using System;
using System.Drawing;
using System.Text.RegularExpressions;
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
        readonly GoalService goalService = new GoalService();

        private void InitializeEditGoalPage()
        {
            newGoalNameFieldLabel = CreateClassicLabel("newGoalNameFieldLabel", "Name:", Color.White, lilitaOne, 18F, 272, 40, 50, 100, 1, ContentAlignment.BottomLeft);
            newGoalAmountFieldLabel = CreateClassicLabel("newGoalAmountFieldLabel", "Amount you want to save:", Color.White, lilitaOne, 18F, 500, 40, 50, 260, 3, ContentAlignment.BottomLeft);
            newGoalDueDateFieldLabel = CreateClassicLabel("newGoalDueDateFieldLabel", "Set a due date:", Color.White, lilitaOne, 18F, 272, 40, 50, 420, 5, ContentAlignment.BottomLeft);
            errorMessage = CreateClassicLabel("errorLabel", "", Color.Red, lilitaOne, 13F, 272, 40, 50, 530, 1, ContentAlignment.MiddleCenter);

            changeGoalButton = CreateClassicButton("changeGoalButton", "change", Color.White, lilitaOne, 14F, firstColor, 272, 80, 50, 600, 7);
            changeGoalButton.Click += new EventHandler(ChangeGoalButton_Click);

            deleteGoalButton = CreateClassicButton("deleteGoalButton", "delete", Color.White, lilitaOne, 14F, Color.FromArgb(189, 183, 171), 272, 80, 50, 690, 7);
            deleteGoalButton.Click += new EventHandler(DeleteGoalButton_Click);

        }
        private void LoadEditGoalPage()
        {
            LoadEscapeButtonField();

            newGoalNameBox = CreateTextField("newGoalNameBox", "", 160, 2);
            newGoalNameBox.Text = _currentGoal.Name;

            newGoalAmountBox = CreateTextField("newGoalAmountBox", "", 320, 4);
            newGoalAmountBox.Text = _currentGoal.Amount.ToString();

            newGoalDueDateBox = new DateTimePicker()
            {
                Top = 480,
                Left = 50,
                Width = 272,
                Height = 80,
                Font = new Font(lilitaOne, 18F, FontStyle.Regular, GraphicsUnit.Point),
                Value = _currentGoal.DueDate
            };

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
            var verify = new VerificationService();
            var error = verify.VerifyData(name: newGoalNameBox.Text, amount: newGoalAmountBox.Text);
            if (error == "")
            {
                if (Regex.IsMatch(newGoalNameBox.Text, "^[a-zA-Z0-9ą-žĄ-Ž]{1,12}$"))
                {
                    goalService.EditGoal(_currentGoal, newGoalNameBox.Text, newGoalAmountBox.Text, newGoalDueDateBox.Value);
                    Controls.Clear();
                    LoadGoalsPage();
                }
                else
                {
                    errorMessage.Text = "Sorry, but name is too long.\n Max 12 characters";
                    Controls.Add(errorMessage);
                }
                if (newGoalNameBox.Text.Length < 13)
                {
                    errorMessage.Text = "Sorry, name must contain only\n letters and numbers";
                    Controls.Add(errorMessage);
                }
                
            }
            else
            {
                errorMessage.Text = error;
                Controls.Add(errorMessage);
            }

        }
        private void DeleteGoalButton_Click(object sender, EventArgs e)
        {

            goalService.DeleteGoal(_currentGoal);

            Controls.Clear();
            LoadGoalsPage();
        }



    }
}