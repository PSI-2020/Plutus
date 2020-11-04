using System;
using System.Drawing;
using System.Windows.Forms;

namespace Plutus
{
    public partial class TrueGUI : Form
    {
        Label firstPaymentLabel;
        Label frequencyLabel;
        DateTimePicker firstPaymentBox;
        ComboBox frequencyBox;
        Button addScheduledPaymentButton;

        private void InitializeScheduledPaymentPage()
        {
            firstPaymentLabel = CreateClassicLabel("firstPaymentLabel", "First payment:", Color.White, lilitaOne, 18F, 272, 40, 50, 170, 1, ContentAlignment.BottomLeft);
            frequencyLabel = CreateClassicLabel("frequencyLabel", "Frequency:", Color.White, lilitaOne, 18F, 272, 40, 50, 366, 3, ContentAlignment.BottomLeft);
            addScheduledPaymentButton = CreateClassicButton("addPaymentButton", "NEXT", Color.White, lilitaOne, 14F, firstColor, 272, 80, 50, 650, 5);
            addScheduledPaymentButton.Click += new EventHandler(AddScheduledPaymentButton_Click);

            firstPaymentBox = new DateTimePicker
            {
                Name = "firstPaymentBox",
                Left = 50,
                Top = 230,
                Height = 80,
                Width = 272,
                ForeColor = firstColor,
                BackColor = Color.FromArgb(199, 193, 181),
                Font = new Font(lilitaOne, 18F, FontStyle.Regular, GraphicsUnit.Point)
            };

            frequencyBox = new ComboBox
            {
                Name = "frequencyBox",
                ForeColor = firstColor,
                BackColor = Color.FromArgb(199, 193, 181),
                Font = new Font(lilitaOne, 18F, FontStyle.Regular, GraphicsUnit.Point),
                Width = 272,
                Height = 80,
                Top = 415,
                Left = 50,
                DropDownStyle = ComboBoxStyle.DropDownList,
                FlatStyle = FlatStyle.Flat
            };

            frequencyBox.Items.Add("Monthly");
            frequencyBox.SelectedIndex = 0;

        }

        private void LoadScheduledPaymentPage()
        {
            LoadEscapeButtonField();

            firstPaymentBox.Value = DateTime.Now;

            Controls.Add(frequencyLabel);
            Controls.Add(firstPaymentLabel);
            Controls.Add(addScheduledPaymentButton);
            Controls.Add(frequencyBox);
            Controls.Add(firstPaymentBox);
        }


        private void AddScheduledPaymentButton_Click(object sender, EventArgs e)
        {
            Controls.Clear();

            if(_currentInfo.CurrentType == "Income")
            {
                LoadIncomeCategoryPage();
            }
            else if(_currentInfo.CurrentType == "Expense")
            {
                LoadExpenseCategoryPage();
            }
        }
    }
}
