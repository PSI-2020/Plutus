using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Plutus
{
    enum ExpenseCategories
    {
        Food,
        Clothes,
        Bills,
        Other
    }

    enum IncomeCategories
    {
        Salary,
        Other
    }

    public partial class GUI : Form
    {
        readonly FileManager fileManager = new FileManager();
        readonly GoalManager goalManager = new GoalManager();
        readonly Statistics stats = new Statistics();
        readonly Filtering filter = new Filtering();
        readonly ManageExpenses expenseManager = new ManageExpenses();
        readonly ManageIncome incomeManager = new ManageIncome();

        public GUI() => InitializeComponent();

        private void ShowExpensesButton(object sender, EventArgs e) => output.Text = expenseManager.ShowExpenses(fileManager);

        private void InputExpenseButton(object sender, EventArgs e)
        {
            expenseStatusField.Text = expenseManager.InputExpense(fileManager, expenseNameText.Text, expensePriceText.Text, expenseCategorySelection.Text);
            if (!expenseStatusField.Text.Contains("was successfully added!")) return;

            expenseNameText.Text = null;
            expensePriceText.Text = null;
            expenseCategorySelection.Text = null;
        }

        private void LoadExpensesGUI()
        {
            expenseEditSelection.Items.Clear();
            expenseEditName.Text = null;
            expenseEditPrice.Text = null;
            expenseEditCategory.Text = null;
            expenseManager.LoadExpenses(fileManager, expenseEditSelection);
        }

        private void OnExpenseSelect(object sender, EventArgs e)
        {
            var list = fileManager.ReadExpenses();
            expenseEditName.Text = list[expenseEditSelection.SelectedIndex].Name;
            expenseEditPrice.Text = list[expenseEditSelection.SelectedIndex].Price + "";
            expenseEditCategory.SelectedItem = list[expenseEditSelection.SelectedIndex].Category;
        }

        private void EditExpenseButton(object sender, EventArgs e)
        {
            expenseStatusMessage.Text = expenseManager.EditExpense(fileManager, expenseEditSelection.SelectedIndex, expenseEditName.Text, expenseEditPrice.Text, expenseEditCategory.Text);
            if (expenseStatusMessage.Text == "Item edited successfully!") LoadExpensesGUI();
        }

        private void DeleteExpenseButton(object sender, EventArgs e)
        {
            expenseStatusMessage.Text = expenseManager.DeleteExpense(fileManager, expenseEditSelection.SelectedIndex);
            LoadExpensesGUI();
        }

        private void ShowIncomeButton(object sender, EventArgs e) => output.Text = incomeManager.ShowIncome(fileManager);

        private void InputIncomeButton(object sender, EventArgs e)
        {
            incomeStatusField.Text = incomeManager.InputIncome(fileManager, incomeSum.Text, incomeCategory.Text);
            if (incomeStatusField.Text != "Sum was added successfully!") return;

            incomeSum.Clear();
            incomeCategory.Text = null;
        }

        private void LoadIncomeGUI()
        {
            incomeEditSelection.Items.Clear();
            incomeEditSum.Text = null;
            incomeEditCategory.Text = null;
            incomeManager.LoadIncome(fileManager, incomeEditSelection);
        }

        private void OnIncomeSelect(object sender, EventArgs e)
        {
            var list = fileManager.ReadIncome();
            incomeEditSum.Text = list[incomeEditSelection.SelectedIndex].Sum + "";
            incomeEditCategory.SelectedItem = list[incomeEditSelection.SelectedIndex].Category;
        }

        private void DeleteIncomeButton(object sender, EventArgs e)
        {
            incomeStatusMessage.Text = incomeManager.DeleteIncome(fileManager, incomeEditSelection.SelectedIndex);
            LoadIncomeGUI();
        }

        private void EditIncomeButton(object sender, EventArgs e)
        {
            incomeStatusMessage.Text = incomeManager.EditIncome(fileManager, incomeEditSelection.SelectedIndex, incomeEditSum.Text, incomeEditCategory.Text);
            if (incomeStatusMessage.Text == "Item edited successfully!") LoadIncomeGUI();
        }

        private void showStatistics(object sender, EventArgs e) => output.Text = stats.GenerateExpenseStatistics(fileManager) + stats.GenerateIncomeStatistics(fileManager);


        private void TabChange(object sender, EventArgs e)
        {
            switch (tabControl1.SelectedTab.Text)
            {
                case "Edit Income":
                    LoadIncomeGUI();
                    incomeStatusMessage.Text = "";
                    break;
                case "Edit Expenses":
                    LoadExpensesGUI();
                    expenseStatusMessage.Text = "";
                    break;
                case "Budgets":
                    budgetsFlow.Controls.Clear();
                    DisplayBudgets();
                    break;
                default:
                    break;
            }
        }

        private int cartCounter = 0;
        private void addCartButton_Click(object sender, EventArgs e)
        {
            cartCounter += 1;
            var myButton = new Button();
            myButton.Name = "Cart" + cartCounter;
            myButton.Text = "Cart " + cartCounter;
            myButton.Width = 210;
            myButton.Height = 45;
            cartPanel.Controls.Add(myButton);
            myButton.Click += new System.EventHandler(this.Cart_Click);
            currentCart = new Cart(myButton.Name);
            cartList.Add(currentCart);
            cartStore.StoreCart(currentCart);
            CartAmountCount();

        }

        private List<Cart> cartList = new List<Cart>();
        private Button currentCartBut = null;
        private Cart currentCart = null;

        private void ChangeCartname()
        {
            var nameExists = false;
            foreach (var c in cartList)
            {
                if (string.Equals(cartName.Text, c.GiveName())) nameExists = true;
            }
            if (nameExists)
            {
                OpenElemAdd();
                cartAddErrorField.Text = "Name exists";
            }
            else
            {
                cartStore.RenameCart(currentCart, cartName.Text);
                currentCart.ChangeName(cartName.Text);
                currentCartBut.Text = cartName.Text;
            }

        }
        private void Cart_Click(object sender, System.EventArgs e)
        {
            currentCartBut = (Button)sender;
            cartName.Text = currentCartBut.Text;
            currentCart = cartList.ElementAt(int.Parse(currentCartBut.Name.Substring(4)) - 1);
            RefreshElemCount();
            cartInfoPanel.Controls.Clear();
            DisplayCart();
            CloseElemAdd();
            CloseElemChange();

        }

        private void OpenElemAdd()
        {
            if (cartElemEditPanel.Visible) cartInfoPanel.Height = 300;
            else cartInfoPanel.Height = 350;
            cartInfoPanel.Top = 150;
            cartNewElemControlPanel.Visible = true;
        }

        private void CloseElemAdd()
        {
            if (cartElemEditPanel.Visible) cartInfoPanel.Height = 350;
            else cartInfoPanel.Height = 400;
            cartInfoPanel.Top = 100;
            cartNewElemControlPanel.Visible = false;
        }

        private void OpenElemChange()
        {
            if (cartNewElemControlPanel.Visible) cartInfoPanel.Height = 300;
            else cartInfoPanel.Height = 350;
            cartElemEditPanel.Visible = true;
        }

        private void CloseElemChange()
        {
            if (cartNewElemControlPanel.Visible) cartInfoPanel.Height = 350;
            else cartInfoPanel.Height = 400;
            cartElemEditPanel.Visible = false;
        }


        private void RefreshElemCount()
        {
            cartExpCount.Text = currentCart.GiveElementC().ToString();
        }


        private void AddExpenseBut_Click(object sender, EventArgs e)
        {
            OpenElemAdd();
        }


        private void DisplayCart()
        {
            if (currentCart == null) return;

            var elemSk = currentCart.GiveElementC();
            if (elemSk == 0) return;
            SaveCart();
            for (var i = (elemSk - 1); i >= 0; i--)
            {
                var currExpense = currentCart.GiveElement(i);

                var elemPanel = new FlowLayoutPanel();
                elemPanel = CreateNewElemPanel(elemPanel, i);

                var elemName = new Label();
                elemName = CreateNewElemName(elemName, i, currExpense.Name);

                var elemPrice = new Label();
                elemPrice = CreateNewElemPrice(elemPrice, i, currExpense.Price.ToString());

                var elemCategory = new Label();
                elemCategory = CreateNewElemCategory(elemCategory, i, currExpense.Category);

                var gapLabel = new Label();
                gapLabel = CreateGapLabel(gapLabel, i);

                var elemActivate = new Button();
                elemActivate = CreateNewElemButton(elemActivate, i, "A");
                ActivityButColorDecide(currExpense, elemActivate);

                var elemEdit = new Button();
                elemEdit = CreateNewElemButton(elemEdit, i, "E");

                var elemDelete = new Button();
                elemDelete = CreateNewElemButton(elemDelete, i, "X");

                elemPanel.Controls.Add(elemName);
                elemPanel.Controls.Add(elemPrice);
                elemPanel.Controls.Add(elemCategory);
                elemPanel.Controls.Add(gapLabel);
                elemPanel.Controls.Add(elemActivate);
                elemPanel.Controls.Add(elemEdit);
                elemPanel.Controls.Add(elemDelete);
                cartInfoPanel.Controls.Add(elemPanel);
            }
        }

        private Button CreateNewElemButton(Button button, int count, string type)
        {
            button.Name = currentCartBut.Name + "ElemButton" + type + "|" + count;
            button.Size = new Size(30, 30);
            button.Text = type;
            switch (type)
            {
                case "E":
                    {
                        button.Click += new EventHandler(this.ElemEdit_Click);
                        break;
                    }
                case "X":
                    {
                        button.Click += new EventHandler(this.ElemDel_Click);
                        break;
                    }
                case "A":
                    {
                        button.Click += new EventHandler(this.ElemActivate_Click);
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
            return button;
        }

        private Button currentElemBut;
        private CartExpense currentElem;
        private CartExpense currentElemToDel;

        private void ActivityButColorDecide(CartExpense e, Button b)
        {
            if (e.Active)
            {
                b.BackColor = Color.FromName("green");
            }
            else
            {
                b.BackColor = Color.FromName("red");
            }
        }

        private CartStorer cartStore = new CartStorer();
        private void CartAmountCount()
        {
            CurrentCartCountNum.Text = cartStore.GiveCartCount().ToString();
        }

        private void ElemActivate_Click(object sender, EventArgs e)
        {
            currentElemBut = (Button)sender;
            var index = currentElemBut.Name.IndexOf('|') + 1;
            var indexOfExpense = int.Parse(currentElemBut.Name.Substring(index));
            currentCart.ChangeActivity(indexOfExpense);
            currentElem = currentCart.GiveElement(indexOfExpense);
            ActivityButColorDecide(currentElem, currentElemBut);
            SaveCart();
            /* OpenElemChange();
             cartElemChangeName.Text = currentElem.Name;
             cartElemChangePri.Text = currentElem.Price.ToString();
             cartElemChangeCat.Text = currentElem.Category;*/

        }
        private void ElemEdit_Click(object sender, EventArgs e)
        {
            currentElemBut = (Button)sender;
            var index = currentElemBut.Name.IndexOf('|') + 1;
            var indexOfExpense = int.Parse(currentElemBut.Name.Substring(index));
            currentElem = currentCart.GiveElement(indexOfExpense);
            OpenElemChange();
            cartElemChangeName.Text = currentElem.Name;
            cartElemChangePri.Text = currentElem.Price.ToString();
            cartElemChangeCat.Text = currentElem.Category;

        }
        private void ElemDel_Click(object sender, EventArgs e)
        {
            currentElemBut = (Button)sender;
            var index = currentElemBut.Name.IndexOf('|') + 1;
            var indexOfExpense = int.Parse(currentElemBut.Name.Substring(index));
            currentElemToDel = currentCart.GiveElement(indexOfExpense);
            if (currentElemToDel == currentElem) CloseElemChange();
            currentCart.RemoveExpense(indexOfExpense);

            RefreshElemCount();
            cartInfoPanel.Controls.Clear();
            DisplayCart();
        }
        private Label CreateGapLabel(Label label, int count)
        {
            label.Name = currentCartBut.Name + "Gap" + count;
            label.Size = new System.Drawing.Size(170, 30);
            return label;
        }

        private FlowLayoutPanel CreateNewElemPanel(FlowLayoutPanel panel, int count)
        {
            panel.Name = currentCartBut.Name + "elem" + count;
            panel.Size = new System.Drawing.Size(620, 40);
            panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            return panel;
        }

        private Label CreateNewElemName(Label label, int count, string value)
        {
            label.Name = currentCartBut.Name + "NameOfElem" + count;
            label.Size = new System.Drawing.Size(100, 40);
            label.TextAlign = ContentAlignment.MiddleCenter;
            label.Text = value;
            return label;
        }
        private Label CreateNewElemPrice(Label label, int count, string value)
        {
            label.Name = currentCartBut.Name + "PriceOfElem" + count;
            label.Size = new System.Drawing.Size(100, 40);
            label.TextAlign = ContentAlignment.MiddleCenter;
            label.Text = value;
            return label;
        }
        private Label CreateNewElemCategory(Label label, int count, string value)
        {
            label.Name = currentCartBut.Name + "CategoryOfElem" + count;
            label.Size = new System.Drawing.Size(100, 40);
            label.TextAlign = ContentAlignment.MiddleCenter;
            label.Text = value;
            return label;
        }

        private void CartElemAddBut_Click(object sender, EventArgs e)
        {

            if (cartElemNameBox.Text.Length == 0 || cartElemNameBox.Text == null)
            {
                cartAddErrorField.Text = "No Name";
                return;
            }
            if (cartElemPriceBox.Text.Length == 0 || cartElemPriceBox.Text == null)
            {
                cartAddErrorField.Text = "No Price";
                return;
            }
            if (!double.TryParse(cartElemPriceBox.Text, out _))
            {
                cartAddErrorField.Text = "Not a price";
                return;
            }
            if (cartElemCategoryBox.Text.Length == 0 || cartElemCategoryBox == null)
            {
                cartAddErrorField.Text = "No Categ";
                return;
            }

            var date = (int)(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalSeconds;
            var name = cartElemNameBox.Text;
            var price = Convert.ToDouble(cartElemPriceBox.Text);
            var category = cartElemCategoryBox.Text;
            var newCartExpense = new Expense(date, name, price, category);
            currentCart.AddExpense(newCartExpense);
            cartAddErrorField.Text = "Added";
            cartElemNameBox.Text = "";
            cartElemPriceBox.Text = "";
            cartElemCategoryBox.Text = "Other";
            RefreshElemCount();
            cartInfoPanel.Controls.Clear();
            DisplayCart();
        }

        private void CartCloseElemAddition_Click(object sender, EventArgs e)
        {
            CloseElemAdd();
        }

        private void delCartButton_Click(object sender, EventArgs e)
        {
            currentCartBut.Dispose();
            cartStore.DeleteCart(currentCart.GiveName());
            currentCart = null;
            CloseElemAdd();
            cartInfoPanel.Controls.Clear();
            cartName.Text = "";
            CartAmountCount();
        }

        private void elemChangeSave_Click(object sender, EventArgs e)
        {
            if (cartElemChangeName.Text.Length == 0 || cartElemChangeName.Text == null)
            {
                cartElemChangeErorr.Text = "No Name";
                return;
            }
            if (cartElemChangePri.Text.Length == 0 || cartElemChangePri.Text == null)
            {
                cartElemChangeErorr.Text = "No Price";
                return;
            }
            if (!double.TryParse(cartElemChangePri.Text, out _))
            {
                cartElemChangeErorr.Text = "Not a price";
                return;
            }
            if (cartElemChangeCat.Text.Length == 0 || cartElemChangeCat == null)
            {
                cartElemChangeErorr.Text = "No Categ";
                return;
            }
            currentElem.Name = cartElemChangeName.Text;
            currentElem.Price = Convert.ToDouble(cartElemChangePri.Text);
            currentElem.Category = cartElemChangeCat.Text;

            cartElemChangeErorr.Text = "Changed";
            cartElemChangeName.Text = "";
            cartElemChangePri.Text = "";
            cartElemChangeCat.Text = "Other";
            cartInfoPanel.Controls.Clear();
            DisplayCart();
        }

        private void cartCloseElemChange_Click(object sender, EventArgs e)
        {
            CloseElemChange();
        }

        private void cartChargeBut_Click(object sender, EventArgs e)
        {
            OpenElemAdd();

            if (currentCart == null)
            {
                cartAddErrorField.Text = "Charge what?";
            }
            else
            {
                cartAddErrorField.Text = "Charged!";
                currentCart.Account(fileManager);

            }
        }

        private void CartNameSetter_Click(object sender, EventArgs e)
        {
            if ((currentCart != null) && (currentCartBut != null))
            {
                ChangeCartname();
            }
        }

        private void LoadCarts()
        {
            Cart cart;
            var cartCount = cartStore.GiveCartCount();
            if (cartCount > 0)
            {
                for (var i = 0; i < cartCount; i++)
                {
                    cart = cartStore.LoadCart(i);
                    cartList.Add(cart);
                    CreateCartButOnLoad(cart);
                }
            }

        }

        private void CreateCartButOnLoad(Cart cart)
        {
            cartCounter += 1;
            var myButton = new Button();
            myButton.Name = "Cart" + cartCounter;
            myButton.Text = cart.GiveName();
            myButton.Width = 210;
            myButton.Height = 45;
            cartPanel.Controls.Add(myButton);
            myButton.Click += new System.EventHandler(this.Cart_Click);
            CartAmountCount();
        }

        private void SaveCart()
        {
            cartStore.StoreCart(currentCart);
        }

        private void EnableSearchDataPicker(object sender, EventArgs e)
        {
            searchDatePickerFrom.Enabled = enableDatePickerFrom.Checked;
            searchDatePickerTo.Enabled = enableDatePickerTo.Checked;
        }

        public void Search(object sender, EventArgs e) => output.Text = filter.SearchData(fileManager, searchNameText.Text, searchCategoryBox.Text, searchNumberFromText.Text, searchNumberToText.Text, dataTypeBox.SelectedIndex, searchCategoryBox.SelectedIndex, searchDatePickerFrom, searchDatePickerTo);


    }
}
