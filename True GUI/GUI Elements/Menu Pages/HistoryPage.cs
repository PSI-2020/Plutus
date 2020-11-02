using System.Drawing;
using System.Windows.Forms;

namespace Plutus
{
    public partial class TrueGUI : Form
    {
        Label historyPageName;
        Button historyEditButton;
        Button historyFilterButton;
        ComboBox historyPaymentTypeBox;
        FlowLayoutPanel historyTableInfoPanel;
        FlowLayoutPanel historyPanel;
        Label historyTableInfoDate;
        Label historyTableInfoName;
        Label historyTableInfoAmount;
        Label historyTableInfoCategory;
        Label split1;
        Label split2;
        Label split3;


        private void InitializeHistoryPage()
        {
            historyPageName = CreatePageNameLabel("historyPageNameLabel", "HISTORY");
            historyEditButton = CreateClassicButton("historyEditButton", Properties.Resources.EditButton, 45, 160, 3, false, 30, 30);
            historyPaymentTypeBox = new ComboBox
            {
                Name = "historyPaymentTypeBox",
                BackColor = backgroundColor,
                ForeColor = Color.White,
                Font = new Font(lilitaOne, 11F, FontStyle.Regular, GraphicsUnit.Point),
                Width = 120,
                Height = 20,
                Top = 160,
                Left = 132,
                DropDownStyle = ComboBoxStyle.DropDownList,
                FlatStyle = FlatStyle.Flat
            };
            string[] elemRange = { "All", "Expense", "Income"};
            historyPaymentTypeBox.Items.AddRange(elemRange);
            historyPaymentTypeBox.SelectedIndex = 0;
            historyPanel = new FlowLayoutPanel
            {
                BackColor = secondColor,
                Width = ClientSize.Width - 4,
                Left = 2,
                Top = 260,
                Height = ClientSize.Height - 324,
                FlowDirection = FlowDirection.TopDown
            };
            historyTableInfoPanel = new FlowLayoutPanel
            {
                BackColor = secondColor,
                Width = ClientSize.Width - 4,
                Left = 2,
                Top = 220,
                Height = 40,
                FlowDirection = FlowDirection.LeftToRight
            };
            historyTableInfoDate = CreateClassicLabel("historyTableInfoDate", "DATE", Color.White, lilitaOne, 10F, 60, 40, 0, 0, 6);
            historyTableInfoName = CreateClassicLabel("historyTableInfoName", "NAME", Color.White, lilitaOne, 10F, 85, 40, 0, 0, 7);
            historyTableInfoAmount = CreateClassicLabel("historyTableInfoAmount", "AMOUNT", Color.White, lilitaOne, 10F, 85, 40, 0, 0, 8);
            historyTableInfoCategory = CreateClassicLabel("historyTableInfoCategory", "CATEGORY", Color.White, lilitaOne, 10F, 90, 40, 0, 0, 9);

            split1 = new Label
            {
                Name = "split1",
                Text = "",
                Height = 40,
                Width = 2,
                BackColor = firstColor
            };
            split2 = new Label
            {
                Name = "split2",
                Text = "",
                Height = 40,
                Width = 2,
                BackColor = firstColor
            };
            split3 = new Label
            {
                Name = "split3",
                Text = "",
                Height = 40,
                Width = 2,
                BackColor = firstColor
            };
            historyFilterButton = CreateClassicButton("historyFilterButton", Properties.Resources.FilterButton, historyEditButton.Right + 230, 160, 4, false, 30, 30);

        }
        private void LoadHistoryPage()
        {
            LoadMenuButton();
            LoadEscapeButton();


            historyTableInfoPanel.Controls.Add(historyTableInfoDate);
            historyTableInfoPanel.Controls.Add(split1);
            historyTableInfoPanel.Controls.Add(historyTableInfoName);
            historyTableInfoPanel.Controls.Add(split2);
            historyTableInfoPanel.Controls.Add(historyTableInfoAmount);
            historyTableInfoPanel.Controls.Add(split3);
            historyTableInfoPanel.Controls.Add(historyTableInfoCategory);
            Controls.Add(historyTableInfoPanel);
            Controls.Add(historyPageName);
            Controls.Add(historyEditButton);
            Controls.Add(historyFilterButton);
            Controls.Add(historyPaymentTypeBox);
            Controls.Add(historyPanel);
            ResumeLayout(false);
            PerformLayout();
        }

        private Label CreatePageNameLabel(string name, string text)
        {
            var pageNameLabel = new Label
            {
                Name = name,
                Text = text,
                Font = new Font(lilitaOne, 34F, FontStyle.Regular, GraphicsUnit.Point),
                AutoSize = false,
                Size = new Size(ClientSize.Width, 60),
                Location = new Point(0, 60),
                TextAlign = ContentAlignment.MiddleCenter,
                ForeColor = firstColor,
            };
            return pageNameLabel;
        }


    }
}
