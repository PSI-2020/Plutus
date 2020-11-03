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
        private string previousPage;
        
        private void InitializePaymentFieldPage()
        {
            nameFieldLabel = CreateClassicLabel("nameFieldLabel", "Name:", Color.White, lilitaOne, 18F, 272, 40, 50, 170, 1, ContentAlignment.BottomLeft);
            amountFieldLabel = CreateClassicLabel("amountFieldLabel", "Amount:", Color.White, lilitaOne, 18F, 272, 40, 50, 366, 3, ContentAlignment.BottomLeft);
            addPaymentButton = CreateClassicButton("addPaymentButton", "ADD", Color.White, lilitaOne, 14F, firstColor, 272, 80, 50, 650, 5);
            addPaymentButton.Click += new EventHandler(AddPaymentButton_Click);
            nameBox = CreateTextField("nameBox", "Enter Name", 230, 2);
            amountBox = CreateTextField("amountBox", "0", 415, 4);

        }

        private void LoadPaymentFieldPage(string previous)
        {
            Controls.Clear();
            previousPage = previous;
            LoadEscapeButton();
            nameBox.Text = "";
            amountBox.Text = "";
            


            Controls.Add(nameFieldLabel);
            Controls.Add(amountFieldLabel);
            Controls.Add(addPaymentButton);
            Controls.Add(nameBox);
            Controls.Add(amountBox);
        }

        private TextBox CreateTextField(string name, string text, int top, int tabIndex)
        {
            var inputTextBox = new TextBox
            {
                Name = name,
                Text = "",
                ForeColor = firstColor,
                BackColor = Color.FromArgb(199, 193, 181),
                Left = 50,
                Top = top,
                Font = new Font(lilitaOne, 18F, FontStyle.Regular, GraphicsUnit.Point),
                AutoSize = false,
                Width = 272,
                Multiline = true,
                Height = 80,
                TabIndex = tabIndex,
                PlaceholderText = text,
                TextAlign = HorizontalAlignment.Center,
                WordWrap = true,
            };
            return inputTextBox;
        }
        private void AddPaymentButton_Click(object sender, EventArgs e)
        {
            var name = nameBox.Text;
            var amount = amountBox.Text;
            nameBox.Text = _inputVerification.VerifyData(name: name);
            amountBox.Text = _inputVerification.VerifyData(amount: amount);
            if(nameBox.Text != "")
            {
                nameBox.ForeColor = Color.Red;
                nameBox.Click += new EventHandler(NameBoxBad_Click);
            }
            else
            {
                nameBox.Text = name;
            }
            if (amountBox.Text != "")
            {
                amountBox.ForeColor = Color.Red;
                amountBox.Click += new EventHandler(AmountBoxBad_Click);
            }
            else
            {
                amountBox.Text = amount;
            }
            if ((nameBox.Text == name) && (amountBox.Text == amount))
            {
                _currentInfo.CurrentName = name;
                _currentInfo.CurrentAmout = amount;
                Controls.Clear();
                Loadback();
            }
        }

        private void Loadback()
        {
            switch (previousPage)
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
            nameBox.ForeColor = firstColor;
            nameBox.Click -= new EventHandler(NameBoxBad_Click);
        }
        private void AmountBoxBad_Click(object sender, EventArgs e)
        {
            amountBox.Text = "";
            amountBox.ForeColor = firstColor;
            amountBox.Click -= new EventHandler(AmountBoxBad_Click);
        }
    }
}
