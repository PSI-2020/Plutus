using System;
using System.Drawing;
using System.Windows.Forms;

namespace Plutus
{
    public partial class TrueGUI : Form
    {
        Label nameFieldLabel;
        Label amountFieldLabel;
        TextBox nameBox;
        TextBox amountBox;
        Button addPaymentButton;
        Label addFieldErrorLabel;
        
        private void InitializePaymentFieldPage()
        {
            nameFieldLabel = CreateClassicLabel("nameFieldLabel", "Name:", Color.White, _lilitaOne, 18F, 272, 40, 50, 170, 1, ContentAlignment.BottomLeft);
            amountFieldLabel = CreateClassicLabel("amountFieldLabel", "Amount:", Color.White, _lilitaOne, 18F, 272, 40, 50, 366, 3, ContentAlignment.BottomLeft);
            addPaymentButton = CreateClassicButton("addPaymentButton", "ADD", Color.White, _lilitaOne, 14F, _firstColor, 272, 80, 50, 650, 5);
            addPaymentButton.Click += new EventHandler(AddPaymentButton_Click);
            nameBox = CreateTextField("nameBox", "Enter Name", 230, 2);
            amountBox = CreateTextField("amountBox", "0", 415, 4);
            addFieldErrorLabel = CreateClassicLabel("addFieldErrorLabel", "", Color.Red, _lilitaOne, 14F, 272, 50, 50, 600, 45);

        }

        private void LoadPaymentFieldPage(string previous)
        {
            Controls.Clear();
            _previousPage = previous;
            LoadEscapeButton();
            nameBox.Text = "";
            amountBox.Text = "";



            Controls.Add(nameFieldLabel);
            Controls.Add(amountFieldLabel);
            Controls.Add(addPaymentButton);
            Controls.Add(addFieldErrorLabel);
            Controls.Add(nameBox);
            Controls.Add(amountBox);
        }

        private TextBox CreateTextField(string name, string text, int top, int tabIndex)
        {
            var inputTextBox = new TextBox
            {
                Name = name,
                Text = "",
                ForeColor = _firstColor,
                BackColor = Color.FromArgb(199, 193, 181),
                Left = 50,
                Top = top,
                Font = new Font(_lilitaOne, 18F, FontStyle.Regular, GraphicsUnit.Point),
                AutoSize = false,
                Width = 272,
                Height = 80,
                TabIndex = tabIndex,
                PlaceholderText = text,
                TextAlign = HorizontalAlignment.Center
            };
            return inputTextBox;
        }
        private void AddPaymentButton_Click(object sender, EventArgs e)
        {
            var name = nameBox.Text;
            var amount = amountBox.Text;
            addFieldErrorLabel.Text = _inputVerification.VerifyData(name: name, amount: amount);

            if (addFieldErrorLabel.Text != "") return;
            _currentInfo.CurrentName = name;
            _currentInfo.CurrentAmout = amount;

            Controls.Clear();
            LoadMainPage();
            Loadback();

        }
        private void Loadback()
        {
            switch (_previousPage)
            {
                case "newCart":
                    AddNewCartExpense();
                    break;
                default:
                    AddCurrentPayment();
                    break;
            }
        }

        private void NameBoxBad_Click(object sender, EventArgs e)
        {
            nameBox.Text = "";
            nameBox.ForeColor = _firstColor;
            nameBox.Click -= new EventHandler(NameBoxBad_Click);
        }
        private void AmountBoxBad_Click(object sender, EventArgs e)
        {
            amountBox.Text = "";
            amountBox.ForeColor = _firstColor;
            amountBox.Click -= new EventHandler(AmountBoxBad_Click);
        }
    }
}
