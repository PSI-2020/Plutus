using System;
using System.Drawing;
using System.Windows.Forms;

namespace Plutus
{
    public partial class TrueGUI : Form
    {
        Label editPageName;
        Label paymentName;
        Label editNameLabel;
        Label editAmountLabel;
        Label editFieldErrorLabel;
        Button editPaymentButton;
        Button deletePaymentButton;
        TextBox editNameBox;
        TextBox editAmountBox;
        ComboBox editCategoryBox;
        Payment currentPayment;
        DataType currentType;

        private void InitializeEditPage()
        {
            editPageName = new Label
            {
                Text = "Editing:",
                Font = new Font(_lilitaOne, 30F, FontStyle.Regular, GraphicsUnit.Point),
                AutoSize = false,
                Size = new Size(ClientSize.Width, 60),
                Location = new Point(0, 60),
                TextAlign = ContentAlignment.MiddleCenter,
                ForeColor = _firstColor,
            };

            paymentName = new Label
            {
                Font = new Font(_lilitaOne, 19F, FontStyle.Regular, GraphicsUnit.Point),
                AutoSize = false,
                Size = new Size(ClientSize.Width, 60),
                Location = new Point(0, 110),
                TextAlign = ContentAlignment.MiddleCenter,
                ForeColor = _secondColor,
            };

            editNameLabel = new Label
            {
                Text = "Name:",
                Font = new Font(_lilitaOne, 15F, FontStyle.Regular, GraphicsUnit.Point),
                AutoSize = false,
                Size = new Size(ClientSize.Width, 50),
                Location = new Point(0, 175),
                TextAlign = ContentAlignment.MiddleCenter,
                ForeColor = Color.White,
            };

            editNameBox = new TextBox
            {
                Text = "",
                ForeColor = _firstColor,
                BackColor = Color.FromArgb(199, 193, 181),
                Left = 50,
                Top = 225,
                Font = new Font(_lilitaOne, 18F, FontStyle.Regular, GraphicsUnit.Point),
                AutoSize = false,
                Width = 272,
                Height = 70,
                TabIndex = 4,
                TextAlign = HorizontalAlignment.Center
            };

            editAmountLabel = new Label
            {
                Text = "Amount:",
                Font = new Font(_lilitaOne, 16F, FontStyle.Regular, GraphicsUnit.Point),
                AutoSize = false,
                Size = new Size(ClientSize.Width, 50),
                Location = new Point(0, 325),
                TextAlign = ContentAlignment.MiddleCenter,
                ForeColor = Color.White,
            };

            editAmountBox = new TextBox
            {
                Text = "",
                ForeColor = _firstColor,
                BackColor = Color.FromArgb(199, 193, 181),
                Left = 50,
                Top = 375,
                Font = new Font(_lilitaOne, 18F, FontStyle.Regular, GraphicsUnit.Point),
                AutoSize = false,
                Width = 272,
                Height = 70,
                TabIndex = 2,
                TextAlign = HorizontalAlignment.Center
            };

            editCategoryBox = new ComboBox
            {
                BackColor = _backgroundColor,
                ForeColor = _firstColor,
                Font = new Font(_lilitaOne, 11F, FontStyle.Regular, GraphicsUnit.Point),
                Width = 272,
                Height = 70,
                Top = 500,
                Left = 50,
                DropDownStyle = ComboBoxStyle.DropDownList,
                FlatStyle = FlatStyle.Flat,
            };

            editPaymentButton = CreateClassicButton("", "Confirm", Color.White, _lilitaOne, 14F, _firstColor, 150, 80, ClientSize.Width - 175, 650, 5);
            editPaymentButton.Click += new EventHandler(EditPaymentButton_Click);
            deletePaymentButton = CreateClassicButton("", "Delete", Color.White, _lilitaOne, 14F, _firstColor, 150, 80, 25, 650, 5);
            deletePaymentButton.Click += new EventHandler(DeletePaymentButton_Click);
            editFieldErrorLabel = CreateClassicLabel("", "", Color.Red, _lilitaOne, 14F, 272, 50, 50, 550, 45);
        }

        private async void DeletePaymentButton_Click(object sender, EventArgs e)
        {
            await _plutusApiClient.DeletePaymentAsync(currentPayment, currentType);
            Controls.Clear();
            LoadHistoryPage();
        }

        private async void EditPaymentButton_Click(object sender, EventArgs e)
        {
            var name = editNameBox.Text;
            var amount = editAmountBox.Text;
            var category = editCategoryBox.SelectedItem.ToString();
            editFieldErrorLabel.Text = VerificationService.VerifyData(name: name, amount: amount, category: category);

            if (editFieldErrorLabel.Text != "") return;

            var newPayment = new Payment
            {
                Date = DateTime.UtcNow.ConvertToInt(),
                Name = name,
                Amount = double.Parse(amount),
                Category = category
            };

            var list = await _plutusApiClient.GetPaymentsAsync(currentType.ToString());
            await _plutusApiClient.EditPaymentAsync(newPayment, list.IndexOf(currentPayment), currentType);
            Controls.Clear();
            LoadHistoryPage();
        }

        private void LoadEditPage(Payment payment, string type)
        {
            Controls.Clear();
            LoadMenuButton();
            LoadEscapeButton();

            currentPayment = payment;
            editCategoryBox.Items.Clear();
            if (type == "Exp.")
            {
                editCategoryBox.Items.AddRange(Enum.GetNames(typeof(ExpenseCategories)));
                currentType = DataType.Expense;
            }
            else
            {
                editCategoryBox.Items.AddRange(Enum.GetNames(typeof(IncomeCategories)));
                currentType = DataType.Income;
            }

            paymentName.Text = editNameBox.Text = payment.Name;
            editAmountBox.Text = payment.Amount.ToString();
            editCategoryBox.SelectedItem = payment.Category;

            Controls.Add(editPageName);
            Controls.Add(editNameLabel);
            Controls.Add(editAmountLabel);
            Controls.Add(editPaymentButton);
            Controls.Add(deletePaymentButton);
            Controls.Add(editFieldErrorLabel);
            Controls.Add(editCategoryBox);
            Controls.Add(editNameBox);
            Controls.Add(editAmountBox);
            ResumeLayout(false);
            PerformLayout();
        }
    }
}