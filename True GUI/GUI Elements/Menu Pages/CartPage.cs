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
        Button cartSaveButton;
        Label cartPageLineAboveAddControls;
        FlowLayoutPanel newCartExpensesPanel;
        FlowLayoutPanel newCartExpensesInfoPanel;
        Label cartNewName;
        Label cartNewAmount;
        Label cartNewCategory;
        Label cartNewEditCol;
        Label cartNewSplitLine1;
        Label cartNewSplitLine2;
        Label cartNewSplitLine3;
        Panel cartNavigationErorrPanel;
        Button cartNavigationUp;
        Button cartNavigationDown;
        Label cartNavigationLabel;
        Label cartErrorLabel;
        FlowLayoutPanel oldCartExpensesPanel;
        FlowLayoutPanel oldCartExpensesInfoPanel;
        Label cartOldName;
        Label cartOldAmount;
        Label cartOldCategory;
        Label cartOldSplitLine1;
        Label cartOldSplitLine2;
        Button cartEditButton;
        Button cartDeleteButton;
        Button cartChargeButton;
        Button cartShoppingButton;

        private int _cartNavigationStart;
        private string _previousCartPage;
        private int _previousCartIndex;
        private string _cartNavigationPage;
        private void InitializeCartPage()
        {
            InitializeCartMain();
            InitializeCartNew();
            InitializeCartSpecific();
        }

        private void LoadCartsPage()
        {
            Controls.Clear();
            LoadMenuButton();
            LoadEscapeButton();
            cartsPageWorkPanel.Controls.Clear();
            cartPageInfoLabel.Text = "CARTS:";
            cartsPageWorkPanel.Controls.Add(cartErrorLabel);
            Controls.Add(cartsPageName);
            Controls.Add(cartPageInfoLabel);
            Controls.Add(cartsPageWorkPanel);
            Controls.Add(addCartButton);

            var count = _cartService.GiveCartCount();
            for (var i = 0; i < count; i++)
            {
                LoadCart(i);
            }

            ResumeLayout(false);
            PerformLayout();
        }


        private void LoadCart(int index)
        {
            var top = 55 + (index * 50);
            var newCart = CreateClassicButton(index + "|CartButton", _cartService.GiveCartNameAt(index), Color.White, _lilitaOne, 14F, _firstColor, 270, 40, 20, top, 9);
            newCart.Click += new EventHandler(CartClick);
            cartsPageWorkPanel.Controls.Add(newCart);
        }

        private void CartClick(object sender, EventArgs e)
        {
            var cartButton = (Button)sender;
            _cartNavigationStart = 0;
            cartPageInfoLabel.Text = "CART: " + cartButton.Text;
            var name = cartButton.Name;
            var nameSplit = name.Split('|');
            var index = int.Parse(nameSplit[0]);
            _cartService.CurrentCartSet(index);
            LoadSpecificCart(index, "");
        }

        private void LoadSpecificCart(int index, string info)
        {
            _cartNavigationPage = "OldCart";
            _previousCartPage = "MainPage";
            _previousCartIndex = index;
            _cartNavigationStart = 0;
            Controls.Clear();
            LoadMenuButton();
            LoadEscapeButton();
            LoadOldCartExpensePanel();
            cartsPageWorkPanel.Controls.Clear();
            cartsPageWorkPanel.Controls.Add(cartDeleteButton);
            cartsPageWorkPanel.Controls.Add(cartEditButton);
            oldCartExpensesInfoPanel.Controls.Add(cartOldName);
            oldCartExpensesInfoPanel.Controls.Add(cartOldSplitLine1);
            oldCartExpensesInfoPanel.Controls.Add(cartOldAmount);
            oldCartExpensesInfoPanel.Controls.Add(cartOldSplitLine2);
            oldCartExpensesInfoPanel.Controls.Add(cartOldCategory);
            cartsPageWorkPanel.Controls.Add(oldCartExpensesInfoPanel);
            cartsPageWorkPanel.Controls.Add(oldCartExpensesPanel);
            cartNavigationLabel.Text = info;
            cartsPageWorkPanel.Controls.Add(cartNavigationErorrPanel);
            cartsPageWorkPanel.Controls.Add(cartPageLineAboveAddControls);
            cartsPageWorkPanel.Controls.Add(cartChargeButton);
            cartsPageWorkPanel.Controls.Add(cartShoppingButton);         
            cartsPageWorkPanel.Controls.Add(cartPageBackButton);
            Controls.Add(cartsPageName);
            Controls.Add(cartPageInfoLabel);
            Controls.Add(cartsPageWorkPanel);

        }
        private void AddCartButton_Click(object sender, EventArgs e)
        {
            if (_cartService.GiveCartCount() == 9)
            {
                cartErrorLabel.Text = "You can only have 9 Carts!";
                return;
            }
            cartCreateButton.Text = "Create Cart";
            cartCreateButton.Click += new EventHandler(CartCreateButton_Click);
            cartCreateButton.Visible = true;
            cartSaveButton.Visible = false;
            _cartNavigationStart = 0;
            _cartService.NewCart();
            _previousCartPage = "NewCart";
            LoadNewCartPage("", "NEW CART:");
        }
        private void LoadNewCartPage(string name, string info)
        {
            _cartNavigationPage = "NewCart";
            Controls.Clear();
            cartsPageWorkPanel.Controls.Clear();
            LoadMenuButton();
            LoadEscapeButton();
            cartPageInfoLabel.Text = info;
            cartNameBox.Text = name;
            LoadCartExpensePanel();

            newCartExpensesInfoPanel.Controls.Add(cartNewName);
            newCartExpensesInfoPanel.Controls.Add(cartNewSplitLine1);
            newCartExpensesInfoPanel.Controls.Add(cartNewAmount);
            newCartExpensesInfoPanel.Controls.Add(cartNewSplitLine2);
            newCartExpensesInfoPanel.Controls.Add(cartNewCategory);
            newCartExpensesInfoPanel.Controls.Add(cartNewSplitLine3);
            newCartExpensesInfoPanel.Controls.Add(cartNewEditCol);
            cartsPageWorkPanel.Controls.Add(newCartExpensesInfoPanel);
            cartsPageWorkPanel.Controls.Add(cartNavigationErorrPanel);

            cartsPageWorkPanel.Controls.Add(cartPageBackButton);
            cartsPageWorkPanel.Controls.Add(cartNameBox);
            cartsPageWorkPanel.Controls.Add(cartNewExpenseButton);
            cartsPageWorkPanel.Controls.Add(cartCreateButton);
            cartsPageWorkPanel.Controls.Add(cartSaveButton);
            cartsPageWorkPanel.Controls.Add(cartPageLineAboveAddControls);
            cartsPageWorkPanel.Controls.Add(newCartExpensesPanel);
            Controls.Add(cartsPageName);
            Controls.Add(cartPageInfoLabel);
            Controls.Add(cartsPageWorkPanel);
            Controls.Add(addCartButton);
        }

        private void LoadCartExpensePanel()
        {
            newCartExpensesPanel.Controls.Clear();
            var count = _cartService.GiveCurrentCartElemCount();
            cartNavigationLabel.Text = (count > 11) ? _cartNavigationStart + 1 + "->" + (_cartNavigationStart + 11) + "(" + count + ")" : "";
            cartNavigationLabel.ForeColor = _firstColor;
            var trueCount = (count > 11) ? _cartNavigationStart + 11 : count;
            for (var i = _cartNavigationStart; i < trueCount; i++)
            {
                LoadNewCartExpense(i);
            }
        }
        private void LoadOldCartExpensePanel()
        {
            oldCartExpensesPanel.Controls.Clear();
            var count = _cartService.GiveCurrentCartElemCount();
            cartNavigationLabel.Text = (count > 11) ? _cartNavigationStart + 1 + "->" + (_cartNavigationStart + 11) + "(" + count + ")" : "";
            cartNavigationLabel.ForeColor = _firstColor;
            var trueCount = (count > 11) ? _cartNavigationStart + 11 : count;
            for (var i = _cartNavigationStart; i < trueCount; i++)
            {
                LoadOldCartExpense(i);
            }
        }

        private void LoadOldCartExpense(int i)
        {
            var color = ((i % 2) == 0) ? _backgroundColor : Color.FromArgb(205, 199, 188);
            var expense = _cartService.GiveCurrentElemAt(i);
            var expenseName = CreateNewCartElement("cartExpenseName" + i, expense.Name, 83, 30, color, _firstColor);
            var expenseAmount = CreateNewCartElement("cartNewAmount" + i, expense.Price.ToString(), 93, 30, color, _firstColor);
            var expenseCategory = CreateNewCartElement("cartNewCategory" + i, expense.Category, 108, 30, color, _firstColor);
            var expenseSplitLine1 = CreateClassicLine("cartNewSplitLine1" + i, 2, 40, 0, 0, Color.Black);
            var expenseSplitLine2 = CreateClassicLine("cartNewSplitLine2" + i, 2, 40, 0, 0, Color.Black);
            var expensePanel = new FlowLayoutPanel
            {
                Name = "oldCartExpensesInfoPanel",
                AutoScroll = false,
                FlowDirection = FlowDirection.LeftToRight,
                Width = 290,
                Left = 10,
                Height = 30,
                Top = 10,
                BackColor = _secondColor,
                Margin = new Padding(0)
            };
            expensePanel.Controls.Add(expenseName);
            expensePanel.Controls.Add(expenseSplitLine1);
            expensePanel.Controls.Add(expenseAmount);
            expensePanel.Controls.Add(expenseSplitLine2);
            expensePanel.Controls.Add(expenseCategory);
            oldCartExpensesPanel.Controls.Add(expensePanel);
        }

        private void LoadNewCartExpense(int i)
        {
            var color = ((i % 2) == 0) ? _backgroundColor : Color.FromArgb(205, 199, 188);
            var expense = _cartService.GiveCurrentElemAt(i);
            var expenseName = CreateNewCartElement("cartExpenseName" + i, expense.Name, 68, 30, color, _firstColor);
            var expenseAmount = CreateNewCartElement("cartNewAmount" + i, expense.Price.ToString(), 78, 30, color, _firstColor);
            var expenseCategory = CreateNewCartElement("cartNewCategory" + i, expense.Category, 108, 30, color, _firstColor);
            var deleteButton = CreateClassicButton("deleteButton|" + i, Properties.Resources.EscapeButton, 0, 0, 0, false, 30, 30);
            deleteButton.BackColor = _backgroundColor;
            deleteButton.Click += new EventHandler(DeleteExpense_Click);
            var expenseSplitLine1 = CreateClassicLine("cartNewSplitLine1" + i, 2, 40, 0, 0, Color.Black);
            var expenseSplitLine2 = CreateClassicLine("cartNewSplitLine2" + i, 2, 40, 0, 0, Color.Black);
            var expenseSplitLine3 = CreateClassicLine("cartNewSplitLine3" + i, 2, 40, 0, 0, Color.Black);
            var expensePanel = new FlowLayoutPanel
            {
                Name = "newCartExpensesInfoPanel",
                AutoScroll = false,
                FlowDirection = FlowDirection.LeftToRight,
                Width = 290,
                Left = 10,
                Height = 30,
                Top = cartNameBox.Bottom + 10,
                BackColor = _secondColor,
                Margin = new Padding(0)
            };
            expensePanel.Controls.Add(expenseName);
            expensePanel.Controls.Add(expenseSplitLine1);
            expensePanel.Controls.Add(expenseAmount);
            expensePanel.Controls.Add(expenseSplitLine2);
            expensePanel.Controls.Add(expenseCategory);
            expensePanel.Controls.Add(expenseSplitLine3);
            expensePanel.Controls.Add(deleteButton);
            newCartExpensesPanel.Controls.Add(expensePanel);
        }
        private void DeleteExpense_Click(object sender, EventArgs e)
        {
            var button = (Button)sender;
            var name = button.Name;
            var splitName = name.Split('|');
            var index = int.Parse(splitName[1]);
            _cartService.RemoveExpenseCurrentAt(index);
            LoadCartExpensePanel();
        }

        private void GoBackCartButton_Click(object sender, EventArgs e)
        {
            GoBackCartMethod("");
        }

        private void GoBackCartMethod(string info)
        {
            switch (_previousCartPage)
            {
                case "OldCart":
                    cartPageInfoLabel.Text = "CART: " + _cartService.GiveCurrentName();
                    LoadSpecificCart(_previousCartIndex, info);
                    break;
                default:
                    LoadCartsPage();
                    break;
            }
        }

        private void InitializeCartMain()
        {
            cartsPageName = CreatePageNameLabel("cartsPageNameLabel", "CARTS");
            cartPageInfoLabel = CreateClassicLabel("cartPageInfoLabel", "MY CARTS:", Color.White, _lilitaOne, 18F, 310, 50, 32, cartsPageName.Bottom + 10, 0);
            cartsPageWorkPanel = new Panel
            {
                Name = "cartPageWorkPanel",
                Width = 310,
                Height = 550,
                Left = 32,
                Top = cartPageInfoLabel.Bottom,
                BorderStyle = BorderStyle.FixedSingle,
                AutoScroll = false
            };
            addCartButton = CreateClassicButton("addCartButton", Properties.Resources.AddCartButton, 162, cartsPageWorkPanel.Bottom + 10, 1, false, 56, 51);
            addCartButton.Click += new EventHandler(AddCartButton_Click);
            cartPageInfoLabel.BackColor = Color.FromArgb(114, 107, 96);
            cartErrorLabel = CreateClassicLabel("cartErrorLabel", "", Color.Red, _lilitaOne, 10F, 310, 50, 0, 500, 0);
        }

        private void InitializeCartNew()
        {
            cartPageLineAboveAddControls = CreateClassicLine("cartPageLineAboveAddControls", 290, 5, 10, 500, _secondColor);
            cartPageBackButton = CreateClassicButton("cartPageBackButton", Properties.Resources.BackArrowButton, 10, cartPageLineAboveAddControls.Bottom + 9, 1, false, 16, 21);
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
                ForeColor = _firstColor,
                BackColor = Color.FromArgb(199, 193, 181),
                Font = new Font(_lilitaOne, 16F, FontStyle.Regular, GraphicsUnit.Point),
                TextAlign = HorizontalAlignment.Center,
                AutoSize = false,
            };
            cartCreateButton = CreateClassicButton("cartCreateButton", "Create cart", Color.White, _lilitaOne, 9F, _secondColor, 100, 30, cartPageBackButton.Right + 10, cartPageLineAboveAddControls.Bottom + 5, 7);
            cartCreateButton.Click += new EventHandler(CartCreateButton_Click);
            cartSaveButton = CreateClassicButton("cartSaveButton", "Save cart", Color.White, _lilitaOne, 9F, _secondColor, 100, 30, cartPageBackButton.Right + 10, cartPageLineAboveAddControls.Bottom + 5, 7);
            cartSaveButton.Click += new EventHandler(CartSaveButton_Click);
            cartSaveButton.Visible = false;
            cartNewExpenseButton = CreateClassicButton("cartNewExpenseButton", "Add new expense", Color.White, _lilitaOne, 9F, _secondColor, 140, 30, cartCreateButton.Right + 15, cartPageLineAboveAddControls.Bottom + 5, 7);
            cartNewExpenseButton.Click += new EventHandler(CartNewExpenseButton_Click);

            cartNewName = CreateNewCartElement("cartNewName", "NAME", 68, 30, _firstColor, Color.White);
            cartNewAmount = CreateNewCartElement("cartNewAmount", "AMOUNT", 78, 30, _firstColor, Color.White);
            cartNewCategory = CreateNewCartElement("cartNewCategory", "CATEGORY", 108, 30, _firstColor, Color.White);
            cartNewEditCol = CreateNewCartElement("cartNewEditCol", "", 30, 30, _firstColor, Color.White);
            cartNewSplitLine1 = CreateClassicLine("cartNewSplitLine1", 2, 40, 0, 0, Color.Black);
            cartNewSplitLine2 = CreateClassicLine("cartNewSplitLine2", 2, 40, 0, 0, Color.Black);
            cartNewSplitLine3 = CreateClassicLine("cartNewSplitLine3", 2, 40, 0, 0, Color.Black);

            newCartExpensesInfoPanel = new FlowLayoutPanel
            {
                Name = "newCartExpensesInfoPanel",
                AutoScroll = false,
                FlowDirection = FlowDirection.LeftToRight,
                Width = 290,
                Left = 10,
                Height = 30,
                Top = cartNameBox.Bottom + 10,
                BackColor = _secondColor
            };

            newCartExpensesPanel = new FlowLayoutPanel
            {
                Name = "newCartExpensesPanel",
                AutoScroll = false,
                FlowDirection = FlowDirection.TopDown,
                Width = 290,
                Left = 10,
                Height = 330,
                Top = newCartExpensesInfoPanel.Bottom,
                BackColor = Color.FromArgb(199, 193, 181)
            };

            cartNavigationUp = CreateClassicButton("cartNavigationUp", Properties.Resources.UpArrowButton, 25, 0, 0, false, 30, 30);
            cartNavigationUp.Click += new EventHandler(CartNavigateUp);
            cartNavigationLabel = CreateClassicLabel("cartNavigationLabel", "", _firstColor, _lilitaOne, 10F, 200, 30, 55, 0, 0);
            cartNavigationDown = CreateClassicButton("cartNavigationDown", Properties.Resources.DownArrowButton, cartNavigationLabel.Right, 0, 0, false, 30, 30);
            cartNavigationDown.Click += new EventHandler(CartNavigateDown);
            cartNavigationErorrPanel = new Panel
            {
                Name = "cartNavigationErorrPanel",
                Width = 310,
                Height = 30,
                Left = 0,
                Top = newCartExpensesPanel.Bottom + 15,
                AutoScroll = false
            };
            cartNavigationErorrPanel.Controls.Add(cartNavigationUp);
            cartNavigationErorrPanel.Controls.Add(cartNavigationLabel);
            cartNavigationErorrPanel.Controls.Add(cartNavigationDown);
        }

        private void InitializeCartSpecific()
        {
            cartOldName = CreateNewCartElement("cartOldName", "NAME", 83, 30, _firstColor, Color.White);
            cartOldAmount = CreateNewCartElement("cartOldAmount", "AMOUNT", 93, 30, _firstColor, Color.White);
            cartOldCategory = CreateNewCartElement("cartOldCategory", "CATEGORY", 108, 30, _firstColor, Color.White);
            cartOldSplitLine1 = CreateClassicLine("cartOldSplitLine1", 2, 40, 0, 0, Color.Black);
            cartOldSplitLine2 = CreateClassicLine("cartOldSplitLine2", 2, 40, 0, 0, Color.Black);
            cartDeleteButton = CreateClassicButton("cartDeleteButton", "Delete Cart", Color.White, _lilitaOne, 10F, _firstColor, 120, 40, 170, 10, 124);
            cartDeleteButton.Click += new EventHandler(DeleteCart_Click);
            cartEditButton = CreateClassicButton("cartEditButton", "Edit Cart", Color.White, _lilitaOne, 10F, _firstColor, 120, 40, 20, 10, 124);
            cartEditButton.Click += new EventHandler(EditCart_Click);
            oldCartExpensesInfoPanel = new FlowLayoutPanel
            {
                Name = "oldCartExpensesInfoPanel",
                AutoScroll = false,
                FlowDirection = FlowDirection.LeftToRight,
                Width = 290,
                Left = 10,
                Height = 30,
                Top = cartDeleteButton.Bottom + 10,
                BackColor = _secondColor
            };
            cartChargeButton = CreateClassicButton("cartChargeButton", "Charge Cart", _firstColor, _lilitaOne, 9F, _secondColor, 125, 30, cartPageBackButton.Right + 10, cartPageLineAboveAddControls.Bottom + 5, 7);
            cartChargeButton.Click += new EventHandler(ChargeCart_Click);
            cartShoppingButton = CreateClassicButton("cartShoppingButton", "Go Shopping", _firstColor, _lilitaOne, 9F, _secondColor, 125, 30, cartChargeButton.Right + 10, cartPageLineAboveAddControls.Bottom + 5, 7);
            cartShoppingButton.Click += new EventHandler(ShopCart_Click);
            oldCartExpensesPanel = new FlowLayoutPanel
            {
                Name = "oldCartExpensesPanel",
                AutoScroll = false,
                FlowDirection = FlowDirection.TopDown,
                Width = 290,
                Left = 10,
                Height = 330,
                Top = oldCartExpensesInfoPanel.Bottom,
                BackColor = Color.FromArgb(199, 193, 181)
            };
        }
        private void ShopCart_Click(object sender, EventArgs e)
        {
            _previousCartPage = "OldCart";
            LoadShoppingPage("Shop With: " + _cartService.GiveCurrentName());
        }

        private void EditCart_Click(object sender, EventArgs e)
        {
            cartCreateButton.Text = "Save Cart";
            cartCreateButton.Visible = false;
            cartSaveButton.Visible = true;
            _previousCartPage = "OldCart";
            LoadNewCartPage(_cartService.GiveCurrentName(), "Edit Cart: " + _cartService.GiveCurrentName());
        }
        private void CartSaveButton_Click(object sender, EventArgs e)
        {
            var ver1 = cartNameBox.Text;
            var ver2 = cartNameBox.Text;
            ver1 = _inputVerification.VerifyData(name: ver1);
            if (ver1 != "")
            {
                cartNavigationLabel.Text = ver1;
                cartNavigationLabel.ForeColor = Color.Red;
                return;
            }
            ver2 = _cartService.VerifyName(ver2, _cartService.GiveCurrentName());
            if (ver2 != "")
            {
                cartNavigationLabel.Text = ver2;
                cartNavigationLabel.ForeColor = Color.Red;
                return;
            }
            var cartName = cartNameBox.Text;
            _cartService.SetCurrentName(cartName);
            _cartService.SaveCartChanges(_previousCartIndex);
            cartPageInfoLabel.Text = "CART: " + _cartService.GiveCurrentName();
            cartCreateButton.Click -= new EventHandler(CartSaveButton_Click);
            LoadSpecificCart(_previousCartIndex, "");
        }
        private void ChargeCart_Click(object sender, EventArgs e)
        {
            _cartService.ChargeCart();
            cartNavigationLabel.Text = "Charged";
        }

        private void DeleteCart_Click(object sender, EventArgs e)
        {
            _cartService.DeleteCurrent();
            LoadCartsPage();
        }
        private void CartNavigateUp(object sender, EventArgs e)
        {
            if (_cartService.GiveCurrentCartElemCount() <= 11) return;
            if (_cartNavigationStart == 0) return;
            _cartNavigationStart--;
            LoadNewCartNavigationPoint();
        }

        private void CartNavigateDown(object sender, EventArgs e)
        {
            if (_cartService.GiveCurrentCartElemCount() <= 11) return;
            if (_cartNavigationStart + 12 > _cartService.GiveCurrentCartElemCount()) return;
            _cartNavigationStart++;
            LoadNewCartNavigationPoint();
        }


        private void LoadNewCartNavigationPoint()
        {
            switch (_cartNavigationPage)
            {
                case "OldCart":
                    LoadOldCartExpensePanel();
                    break;
                default:
                    LoadCartExpensePanel();
                    break;
            }

        }

        private Label CreateNewCartElement(string name, string text, int width, int height, Color backColor, Color fontColor)
        {
            var newElement = new Label
            {
                Name = name,
                Text = text,
                Width = width,
                Height = height,
                Font = new Font(_lilitaOne, 9F, Font.Style, GraphicsUnit.Point),
                ForeColor = fontColor,
                BackColor = backColor,
                Margin = new Padding(0),
                TextAlign = ContentAlignment.MiddleCenter
            };
            return newElement;
        }

        private void CartCreateButton_Click(object sender, EventArgs e)
        {
            var ver1 = cartNameBox.Text;
            var ver2 = cartNameBox.Text;
            ver1 = _inputVerification.VerifyData(name: ver1);
            if (ver1 != "")
            {
                cartNavigationLabel.Text = ver1;
                cartNavigationLabel.ForeColor = Color.Red;
                return;
            }
            ver2 = _cartService.VerifyName(ver2, "");
            if (ver2 != "")
            {
                cartNavigationLabel.Text = ver2;
                cartNavigationLabel.ForeColor = Color.Red;
                return;
            }
            var cartName = cartNameBox.Text;
            _cartService.SetCurrentName(cartName);
            _cartService.AddCurrentCart();
            LoadCartsPage();
        }
        private void CartNewExpenseButton_Click(object sender, EventArgs e) => LoadExpenseCategoryPage("newCart");

        private void CartNewExpenseFields() => LoadPaymentFieldPage("newCart");

        private void AddNewCartExpense()
        {
            _cartService.AddExpenseToCart(_currentInfo);
            LoadNewCartPage(cartNameBox.Text, "NEW CART:");
        }

    }
}
