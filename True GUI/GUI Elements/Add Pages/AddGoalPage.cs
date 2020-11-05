using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Plutus
{
    public partial class TrueGUI : Form
    {
        private Label goalNameFieldLabel;
        private Label goalAmountFieldLabel;
        private Label goalDueDateFieldLabel;
        private Button addGoalButton;
        private TextBox goalNameBox;
        private TextBox goalAmountBox;
        private DateTimePicker goalDueDateBox;

        private void InitializeAddGoalPage()
        {
            goalNameFieldLabel = CreateClassicLabel("goalNameFieldLabel", "Name:", Color.White, lilitaOne, 18F, 272, 40, 50, 100, 1, ContentAlignment.BottomLeft);
            goalAmountFieldLabel = CreateClassicLabel("goalAmountFieldLabel", "Amount you want to save:", Color.White, lilitaOne, 18F, 500, 40, 50, 260, 3, ContentAlignment.BottomLeft);
            goalDueDateFieldLabel = CreateClassicLabel("goalDueDateFieldLabel", "Set a due date:", Color.White, lilitaOne, 18F, 272, 40, 50, 420, 5, ContentAlignment.BottomLeft);

            addGoalButton = CreateClassicButton("addPaymentButton", "ADD", Color.White, lilitaOne, 14F, firstColor, 272, 80, 50, 650, 7);
            addGoalButton.Click += new EventHandler(AddGoalButton_Click);

            goalDueDateBox = new DateTimePicker()
            {
                Top = 480,
                Left = 50,
                Width = 272,
                Height = 80,
                Font = new Font(lilitaOne, 18F, FontStyle.Regular, GraphicsUnit.Point)
            };

        }
        private void LoadAddGoalPage()
        {
            LoadEscapeButtonField();

            goalNameBox = CreateTextField("goalNameBox", "Enter Name", 160, 2);
            goalAmountBox = CreateTextField("goalAmountBox", "0", 320, 4);
            goalDueDateBox.Value = DateTime.Now;

            Controls.Add(goalNameFieldLabel);
            Controls.Add(goalAmountFieldLabel);
            Controls.Add(addGoalButton);
            Controls.Add(goalNameBox);
            Controls.Add(goalAmountBox);
            Controls.Add(goalDueDateFieldLabel);
            Controls.Add(goalDueDateBox);
        }

        private void AddGoalButton_Click(object sender, EventArgs e)
        {
            Controls.Remove(errorMessage);
            var verify = new InputVerification();
            var error = verify.VerifyData(name: goalNameBox.Text, amount: goalAmountBox.Text);
            if (error == "")
            {
                if (Regex.IsMatch(goalNameBox.Text,"^[a-zA-Z0-9ą-žĄ-Ž]{1,12}$"))
                {
                    fileManager.AddGoal(goalNameBox.Text, goalAmountBox.Text, goalDueDateBox.Value);
                    Controls.Clear();
                    LoadGoalsPage();
                }

                errorMessage.Text = "Sorry, but name is too long.\n Max 12 characters";
                Controls.Add(errorMessage);
            }
            else
            {
                errorMessage.Text = error;
                Controls.Add(errorMessage);
            }
        }


    }
}