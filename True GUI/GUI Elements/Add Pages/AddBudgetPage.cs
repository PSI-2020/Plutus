﻿using System;
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
        Button InsertBudgetButton;
        Button backButton;
        ComboBox budgetCategoryBox;
        TextBox sumTextBox;
        DateTimePicker fromPicker;
        DateTimePicker toPicker;

        private void LoadAddBudgetPage()
        {
            Controls.Clear();
            LoadEscapeButtonCat();
            addBudgetPageName = CreatePageNameLabel("addBudgetPageNameLabel", "ADD BUDGET");
            categoryLabel = CreateClassicLabel("categoryLbl", "Choose Category:", firstColor, lilitaOne, 11F, 300, 25, 40, 125, 1);
            budgetCategoryBox = new ComboBox
            {
                Name = "budgetCategoryBox",
                BackColor = backgroundColor,
                ForeColor = firstColor,
                Font = new Font(lilitaOne, 11F, FontStyle.Regular, GraphicsUnit.Point),
                Width = 120,
                Height = 20,
                Top = 160,
                Left = 132,
                DropDownStyle = ComboBoxStyle.DropDownList,
                FlatStyle = FlatStyle.Flat
            };
            budgetCategoryBox.Items.AddRange(new string[] { "", "Groceries", "Restaurant", "Clothes", "Transport", "Health", "School", "Bills", "Other" });
            budgetCategoryBox.SelectedIndex = 0;

            sumLabel = CreateClassicLabel("sumLabel", "Enter Sum:", firstColor, lilitaOne, 11F, 300, 25, 40, 200, 1);
            sumTextBox = new TextBox
            {
                Name = "sumTextBox",
                BackColor = backgroundColor,
                ForeColor = firstColor,
                Font = new Font(lilitaOne, 11F, FontStyle.Regular, GraphicsUnit.Point),
                Width = 150,
                Height = 20,
                Top = 230,
                Left = 112
            };
            fromLabel = CreateClassicLabel("fromLabel", "From:", firstColor, lilitaOne, 11F, 100, 25, 140, 255, 1);
            fromPicker = new DateTimePicker
            {
                Top = 285,
                Left = 90,
                BackColor = backgroundColor,
                Font = new Font(lilitaOne, 10F, FontStyle.Regular, GraphicsUnit.Point),
                CalendarForeColor = firstColor
            };

            toLabel = CreateClassicLabel("toLabel", "To:", firstColor, lilitaOne, 11F, 100, 25, 140, 320, 1);
            toPicker = new DateTimePicker
            {
                Top = 350,
                Left = 90,
                BackColor = backgroundColor,
                Font = new Font(lilitaOne, 10F, FontStyle.Regular, GraphicsUnit.Point),
                CalendarForeColor = firstColor
            };

            InsertBudgetButton = new Button
            {
                Text = "Add",
                Top = 400,
                Left = 150,
                Height = 30,
                Font = new Font(lilitaOne, 11F, FontStyle.Regular, GraphicsUnit.Point),
                ForeColor = firstColor
            };
            InsertBudgetButton.Click += new EventHandler(InsertBudgetButtonClick);

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
            Controls.Add(InsertBudgetButton);
            Controls.Add(backButton);
            ResumeLayout(false);
            PerformLayout();
        }

        private void BackButtonClick(object sender, EventArgs e)
        {
            LoadBudgetsPage();
        }

        private void InsertBudgetButtonClick(object sender, EventArgs e)
        {
            Controls.Remove(errorLabel);
            var error = _inputVerification.VerifyData(amount: sumTextBox.Text, category: budgetCategoryBox.Text);
            if (error != "")
            {
                errorLabel = CreateClassicLabel("errorLabel", error, Color.Red, lilitaOne, 18F, 300, 75, 40, 500, 1);
                Controls.Add(errorLabel);
                return;
            }

            var list = fileManager.LoadBudget();
            budgetsFlow.Visible = true;

            fileManager.AddBudget(new Budget("budget" + list.Count, budgetCategoryBox.SelectedItem.ToString(), double.Parse(sumTextBox.Text), fromPicker.Value, toPicker.Value));

            budgetsFlow.Controls.Clear();
            LoadBudgetsPage();
            budgetCategoryBox.Text = null;
            fromPicker.ResetText();
            toPicker.ResetText();
            sumTextBox.Clear();
        }
    }
}
