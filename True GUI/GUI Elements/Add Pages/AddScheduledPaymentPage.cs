using System;
using System.Drawing;
using System.Windows.Forms;

namespace Plutus
{
    public partial class TrueGUI : Form
    {
        Label firstPaymentLabel;
        Label frequencyLabel;
        Label schedCategoryLabel;
        Label amountLabel;
        Label nameLabel;
        DateTimePicker firstPaymentBox;
        ComboBox frequencyBox;
        ComboBox categoryBox;
        Button addScheduledPaymentButton;
        Button backPageButton;
        TextBox amountTextBox;
        TextBox nameTextBox;


        private void InitializeScheduledPaymentPage()
        {


            schedCategoryLabel = CreateClassicLabel("schedCategoryLabel", "Choose Category:", _firstColor, _lilitaOne, 11F, 300, 25, 40, 130, 1);
            categoryBox = new ComboBox
            {
                Name = "schedCategoryBox",
                BackColor = _backgroundColor,
                ForeColor = Color.White,
                Font = new Font(_lilitaOne, 11F, FontStyle.Regular, GraphicsUnit.Point),
                Width = 120,
                Height = 20,
                Top = 160,
                Left = 132,
                DropDownStyle = ComboBoxStyle.DropDownList,
                FlatStyle = FlatStyle.Flat
            };

            amountLabel = CreateClassicLabel("amountLabel", "Enter Sum:", _firstColor, _lilitaOne, 11F, 300, 25, 40, 200, 1);
            amountTextBox = new TextBox
            {
                Name = "amountTextBox",
                BackColor = _backgroundColor,
                ForeColor = Color.White,
                Font = new Font(_lilitaOne, 11F, FontStyle.Regular, GraphicsUnit.Point),
                Width = 150,
                Height = 20,
                Top = 230,
                Left = 112
            };

            nameLabel = CreateClassicLabel("nameLabel", "Name of payment:", _firstColor, _lilitaOne, 11F, 300, 25, 40, 270, 1);
            nameTextBox = new TextBox
            {
                Name = "nameTextBox",
                BackColor = _backgroundColor,
                ForeColor = Color.White,
                Font = new Font(_lilitaOne, 11F, FontStyle.Regular, GraphicsUnit.Point),
                Width = 150,
                Height = 20,
                Top = 300,
                Left = 112
            };

            firstPaymentLabel = CreateClassicLabel("firstPaymentLabel", "First payment:", _firstColor, _lilitaOne, 11F, 272, 25, 50, 340, 1);
            firstPaymentBox = new DateTimePicker
            {
                Name = "firstPaymentBox",
                Left = 50,
                Top = 370,
                Height = 20,
                Width = 272,
                ForeColor = Color.White,
                BackColor = _backgroundColor,
                Font = new Font(_lilitaOne, 11F, FontStyle.Regular, GraphicsUnit.Point)
            };

            frequencyLabel = CreateClassicLabel("frequencyLabel", "Frequency:", _firstColor, _lilitaOne, 11F, 272, 25, 40, 410, 3);
            frequencyBox = new ComboBox
            {
                Name = "frequencyBox",
                ForeColor = Color.White,
                BackColor = _backgroundColor,
                Font = new Font(_lilitaOne, 11F, FontStyle.Regular, GraphicsUnit.Point),
                Width = 272,
                Height = 20,
                Top = 440,
                Left = 50,
                DropDownStyle = ComboBoxStyle.DropDownList,
                FlatStyle = FlatStyle.Flat
            };

            frequencyBox.Items.AddRange(new string[] { "Monthly", "Weekly" });
            frequencyBox.SelectedIndex = 0;

            backPageButton = CreateClassicButton("backButton", Properties.Resources.BackArrowButton, 20, 30, 1, true);
            backPageButton.Click += new EventHandler(backPageButtonClick);

        }

        private void backPageButtonClick(object sender, EventArgs e) => LoadSchedulerPage();

        private void LoadScheduledPaymentPage(string type)
        {
            LoadEscapeButton();
            categoryBox.Items.Clear();
            if (type == "MonthlyExpenses")
            {
                categoryBox.Items.AddRange(Enum.GetNames(typeof(ExpenseCategories)));
            }
            else if (type == "MonthlyIncome")
            {
                categoryBox.Items.AddRange(Enum.GetNames(typeof(IncomeCategories)));
            }
            categoryBox.SelectedIndex = 0;

            addScheduledPaymentButton = CreateClassicButton("addPaymentButton", "ADD", Color.White, _lilitaOne, 14F, _firstColor, 272, 80, 50, 650, 5);
            addScheduledPaymentButton.Click += (sender, e) => AddScheduledPaymentButton_Click(sender, e, type);

            firstPaymentBox.Value = DateTime.Now;

            Controls.Add(schedCategoryLabel);
            Controls.Add(categoryBox);
            Controls.Add(amountLabel);
            Controls.Add(amountTextBox);
            Controls.Add(nameLabel);
            Controls.Add(nameTextBox);
            Controls.Add(frequencyLabel);
            Controls.Add(frequencyBox);
            Controls.Add(firstPaymentLabel);
            Controls.Add(firstPaymentBox);
            Controls.Add(addScheduledPaymentButton);
            Controls.Add(backPageButton);
        }


        private async void AddScheduledPaymentButton_Click(object _, EventArgs __, string type)
        {
            Controls.Remove(errorLabel);
            var error = VerificationService.VerifyData(nameTextBox.Text, amountTextBox.Text, categoryBox.Text);
            if (error != "")
            {
                errorLabel = CreateClassicLabel("errorLabel", error, Color.Crimson, _lilitaOne, 18F, 300, 75, 40, 500, 1);
                Controls.Add(errorLabel);
                return;
            }


            var list = await _plutusApiClient.GetAllScheduledPaymentsAsync(type);

            await _plutusApiClient.PostScheduledPaymentAsync(new ScheduledPayment(firstPaymentBox.Value, nameTextBox.Text, double.Parse(amountTextBox.Text),
                categoryBox.SelectedItem.ToString(), type + list.Count, frequencyBox.SelectedItem.ToString(), true), type);
            LoadSchedulerPage();
            categoryBox.Text = null;
            nameTextBox.Clear();
            amountTextBox.Clear();
            firstPaymentBox.ResetText();

        }
    }
}