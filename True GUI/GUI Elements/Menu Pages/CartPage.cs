using System;
using System.Drawing;
using System.Windows.Forms;

namespace Plutus
{
    public partial class TrueGUI : Form
    {
        Label cartsPageName;
        Panel cartsPageWorkPanel;
        Button addCartButton;
        Label cartPageInfoLabel;
        Button cartPageBackButton;
        TextBox cartNameBox;
        Button cartNewExpenseButton;
        Button cartCreateButton;
        Label cartPageLineAboveAddControls;
        FlowLayoutPanel newCartExpensesPanel;
        FlowLayoutPanel newCartExpensesInfoPanel;
        private void InitializeCartPage()
        {
            InitializeCartMain();
            InitializeCartNew();
            newCartExpensesInfoPanel = new FlowLayoutPanel
            {
                Name = "newCartExpensesInfoPanel ",
                AutoScroll = true,
                FlowDirection = FlowDirection.RightToLeft,
                Width = 290,
                Left = 10,
                Height = 40,
                Top = cartNameBox.Bottom + 10,
                BackColor = secondColor
            };

            newCartExpensesPanel = new FlowLayoutPanel
            {
                Name = "newCartExpensesPanel",
                AutoScroll = true,
                FlowDirection = FlowDirection.TopDown,
                Width = 290,
                Left = 10,
                Height = (cartPageLineAboveAddControls.Top - 10) - (newCartExpensesInfoPanel.Bottom),
                Top = newCartExpensesInfoPanel.Bottom,
                BackColor = firstColor
            };

        }

        private void LoadCartsPage()
        {
            LoadMenuButton();
            LoadEscapeButton();
            cartsPageWorkPanel.Controls.Clear();
            cartPageInfoLabel.Text = "CARTS:";

            Controls.Add(cartsPageName);
            Controls.Add(cartPageInfoLabel);
            Controls.Add(cartsPageWorkPanel);
            Controls.Add(addCartButton);
            ResumeLayout(false);
            PerformLayout();
        }
        private void AddCartButton_Click(object sender, EventArgs e)
        {
            Controls.Clear();
            LoadMenuButton();
            LoadEscapeButton();
            cartPageInfoLabel.Text = "NEW CART:";
            cartsPageWorkPanel.Controls.Add(cartPageBackButton);
            cartsPageWorkPanel.Controls.Add(cartNameBox);
            cartsPageWorkPanel.Controls.Add(cartNewExpenseButton);
            cartsPageWorkPanel.Controls.Add(cartCreateButton);
            cartsPageWorkPanel.Controls.Add(cartPageLineAboveAddControls);
            cartsPageWorkPanel.Controls.Add(newCartExpensesPanel);
            Controls.Add(cartsPageName);
            Controls.Add(cartPageInfoLabel);
            Controls.Add(cartsPageWorkPanel);
            Controls.Add(addCartButton);

        }

        private void GoBackCartButton_Click(object sender, EventArgs e)
        {
            Controls.Clear();
            LoadCartsPage();
        }

        private void InitializeCartMain()
        {
            cartsPageName = CreatePageNameLabel("cartsPageNameLabel", "CARTS");
            cartPageInfoLabel = CreateClassicLabel("cartPageInfoLabel", "MY CARTS:", Color.White, lilitaOne, 18F, 310, 50, 32, cartsPageName.Bottom + 10, 0);
            cartsPageWorkPanel = new Panel
            {
                Name = "cartPageWorkPanel",
                Width = 310,
                Height = 550,
                Left = 32,
                Top = cartPageInfoLabel.Bottom,
                BorderStyle = BorderStyle.FixedSingle,
                AutoScroll = true
            };
            addCartButton = CreateClassicButton("addCartButton", Properties.Resources.AddCartButton, 162, cartsPageWorkPanel.Bottom + 10, 1, false, 56, 51);
            addCartButton.Click += new EventHandler(AddCartButton_Click);
            cartPageInfoLabel.BackColor = Color.FromArgb(114, 107, 96);
        }

        private void InitializeCartNew()
        {
            cartPageLineAboveAddControls = CreateClassicLine("cartPageLineAboveAddControls", 290, 5, 10, 480, secondColor);
            cartPageBackButton = CreateClassicButton("cartPageBackButton", Properties.Resources.BackArrowButton, 10, cartPageLineAboveAddControls.Bottom + 15, 1, false, 16, 21);
            cartPageBackButton.Click += new EventHandler(GoBackCartButton_Click);
            cartNameBox = new TextBox
            {
                Name = "cartNameBox",
                PlaceholderText = "Enter Cart Name...",
                Text = "",
                Width = 270,
                Height = 40,
                Top = 10,
                Left = 20,
                ForeColor = firstColor,
                BackColor = Color.FromArgb(199, 193, 181),
                Font = new Font(lilitaOne, 16F, FontStyle.Regular, GraphicsUnit.Point),
                TextAlign = HorizontalAlignment.Center,
                AutoSize = false,

            };
            cartCreateButton = CreateClassicButton("cartCreateButton", "Create cart", Color.White, lilitaOne, 9F, secondColor, 100, 30, cartPageBackButton.Right + 10, cartPageLineAboveAddControls.Bottom + 11, 7);
            cartNewExpenseButton = CreateClassicButton("cartNewExpenseButton", "Add new expense", Color.White, lilitaOne, 9F, secondColor, 140, 30, cartCreateButton.Right + 15, cartPageLineAboveAddControls.Bottom + 11, 7);

        }

    }
}
