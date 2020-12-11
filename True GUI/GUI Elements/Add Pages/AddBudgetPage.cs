using System;
using System.Drawing;
using System.Windows.Forms;

namespace Plutus
{
    public partial class TrueGUI : Form
    {
        Label addBudgetPageName;
        Label categoryLabel;
        Label sumLabel;
        Label fromLabel;
        Label toLabel;
        Label errorLabel;
        Button insertBudgetButton;
        Button backButton;
        ComboBox budgetCategoryBox;
        TextBox sumTextBox;
        DateTimePicker fromPicker;
        DateTimePicker toPicker;

        private void LoadAddBudgetPage()
        {
            Controls.Clear();
            LoadEscapeButton();
            addBudgetPageName = CreatePageNameLabel("addBudgetPageNameLabel", "ADD BUDGET");
            categoryLabel = CreateClassicLabel("categoryLbl", "Choose Category:", _firstColor, _lilitaOne, 11F, 300, 25, 40, 125, 1);
            budgetCategoryBox = new ComboBox
            {
                Name = "budgetCategoryBox",
                BackColor = _backgroundColor,
                ForeColor = _firstColor,
                Font = new Font(_lilitaOne, 11F, FontStyle.Regular, GraphicsUnit.Point),
                Width = 120,
                Height = 20,
                Top = 160,
                Left = 132,
                DropDownStyle = ComboBoxStyle.DropDownList,
                FlatStyle = FlatStyle.Flat
            };
            budgetCategoryBox.Items.AddRange(Enum.GetNames(typeof(ExpenseCategories)));
            budgetCategoryBox.SelectedIndex = 0;

            sumLabel = CreateClassicLabel("sumLabel", "Enter Sum:", _firstColor, _lilitaOne, 11F, 300, 25, 40, 200, 1);
            sumTextBox = new TextBox
            {
                Name = "sumTextBox",
                BackColor = _backgroundColor,
                ForeColor = _firstColor,
                Font = new Font(_lilitaOne, 11F, FontStyle.Regular, GraphicsUnit.Point),
                Width = 150,
                Height = 20,
                Top = 230,
                Left = 112
            };
            fromLabel = CreateClassicLabel("fromLabel", "From:", _firstColor, _lilitaOne, 11F, 100, 25, 140, 255, 1);
            fromPicker = new DateTimePicker
            {
                Top = 285,
                Left = 90,
                BackColor = _backgroundColor,
                Font = new Font(_lilitaOne, 10F, FontStyle.Regular, GraphicsUnit.Point),
                CalendarForeColor = _firstColor
            };

            toLabel = CreateClassicLabel("toLabel", "To:", _firstColor, _lilitaOne, 11F, 100, 25, 140, 320, 1);
            toPicker = new DateTimePicker
            {
                Top = 350,
                Left = 90,
                BackColor = _backgroundColor,
                Font = new Font(_lilitaOne, 10F, FontStyle.Regular, GraphicsUnit.Point),
                CalendarForeColor = _firstColor
            };

            insertBudgetButton = new Button
            {
                Text = "Add",
                Top = 400,
                Left = 150,
                Height = 30,
                Font = new Font(_lilitaOne, 11F, FontStyle.Regular, GraphicsUnit.Point),
                ForeColor = _firstColor
            };
            insertBudgetButton.Click += new EventHandler(InsertBudgetButtonClickAsync);
            backButton = CreateClassicButton("backButton", Properties.Resources.BackArrowButton, 20, 30, 1, true);
            backButton.Click += new EventHandler(BackButtonClick);


            Controls.Add(addBudgetPageName);
            Controls.Add(categoryLabel);
            Controls.Add(budgetCategoryBox);
            Controls.Add(sumLabel);
            Controls.Add(sumTextBox);
            Controls.Add(fromLabel);
            Controls.Add(fromPicker);
            Controls.Add(toLabel);
            Controls.Add(toPicker);
            Controls.Add(insertBudgetButton);
            Controls.Add(backButton);
            ResumeLayout(false);
            PerformLayout();
        }

        private void BackButtonClick(object sender, EventArgs e) => LoadBudgetsPageAsync();

        private async void InsertBudgetButtonClickAsync(object sender, EventArgs e)
        {
            Controls.Remove(errorLabel);
            var error = VerificationService.VerifyData(amount: sumTextBox.Text, category: budgetCategoryBox.Text);
            if (error != "")
            {
                errorLabel = CreateClassicLabel("errorLabel", error, Color.Red, _lilitaOne, 18F, 300, 75, 40, 500, 1);
                Controls.Add(errorLabel);
                return;
            }

            var list = await _plutusApiClient.GetBudgetsListAsync();
            budgetsFlow.Visible = true;

            await _plutusApiClient.PostBudgetAsync(new Budget("budget" + list.Count, budgetCategoryBox.SelectedItem.ToString(), double.Parse(sumTextBox.Text), fromPicker.Value, toPicker.Value));

            budgetsFlow.Controls.Clear();
            LoadBudgetsPageAsync();
            budgetCategoryBox.Text = null;
            fromPicker.ResetText();
            toPicker.ResetText();
            sumTextBox.Clear();
        }
    }
}