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
        private void InitializePaymentFieldPage()
        {
            nameFieldLabel = CreateClassicLabel("nameFieldLabel", "Name:", Color.White, lilitaOne, 18F, 272, 40, 50, 170, 1, ContentAlignment.BottomLeft);
            amountFieldLabel = CreateClassicLabel("amountFieldLabel", "Amount:", Color.White, lilitaOne, 18F, 272, 40, 50, 366, 3, ContentAlignment.BottomLeft);
            addPaymentButton = CreateClassicButton("addPaymentButton", "ADD", Color.White, lilitaOne, 14F, firstColor, 272, 80, 50, 650, 5);
            addPaymentButton.Click += new EventHandler(addPaymentButton_Click);
            nameBox = CreateTextField("nameBox", "Enter Name", 230, 2);
            amountBox = CreateTextField("amountBox", "0", 415, 4);

        }

        private void LoadPaymentFieldPage()
        {
            LoadEscapeButtonField();

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
                Height = 80,
                TabIndex = tabIndex,
                PlaceholderText = text,
                TextAlign = HorizontalAlignment.Center
            };
            return inputTextBox;
        }
        private void addPaymentButton_Click(object sender, EventArgs e)
        {
            // unimplemented Call to service
            Controls.Clear();
            LoadMainPage();
        }

    }
}
