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
        readonly DataManager manager = new DataManager();
        readonly Statistics stats = new Statistics();
        public GUI() => InitializeComponent();

        private void buttonAddMonthlyExpenses_Click(object sender, EventArgs e)
        {
            if (monthlyExpensesName.Text.Length == 0 || monthlyExpensesName.Text == null)
            {
                errorLabel2.Text = "Name cannot be empty!";
                return;
            }
            if (monthlyExpensesAmount.Text.Length == 0 || monthlyExpensesAmount == null)
            {
                errorLabel2.Text = "Please enter amount!";
                return;
            }
            if (!Double.TryParse(monthlyExpensesAmount.Text, out _))
            {
                errorLabel2.Text = "Amount must be a number!";
                return;
            }
            if (monthlyExpensesCategory.Text.Length == 0 || monthlyExpensesCategory == null)
            {
                errorLabel2.Text = "Please choose a category!";
                return;
            }

            var name = monthlyExpensesName.Text;
            var date = monthlyExpensesDate.Value;
            var monthlyExpenses = Convert.ToDouble(monthlyExpensesAmount.Text);
            var category = monthlyExpensesCategory.Text;

            var scheduler = new Scheduler(date, name, monthlyExpenses, category, manager, false);
            scheduler.Start();

            errorLabel2.Text = "Monthly expenses were successfully added!";
            monthlyExpensesAmount.Clear();
            monthlyExpensesCategory.Text = null;
            monthlyExpensesName.Text = null;
            monthlyExpensesDate.ResetText();
        }

        private void buttonAddMonthlyIncome_Click(object sender, EventArgs e)
        {
            if (monthlyIncomeName.Text.Length == 0 || monthlyIncomeName.Text == null)
            {
                errorLabel.Text = "Name cannot be empty!";
                return;
            }
            if (monthlyIncomeAmount.Text.Length == 0 || monthlyIncomeAmount.Text == null)
            {
                errorLabel.Text = "Please enter amount!";
                return;
            }
            if (!Double.TryParse(monthlyIncomeAmount.Text, out _))
            {
                errorLabel.Text = "Amount must be a number!";
                return;
            }
            if (monthlyIncomeCategory.Text.Length == 0 || monthlyIncomeCategory == null)
            {
                errorLabel.Text = "Please choose a category!";
                return;
            }

            var name = monthlyIncomeName.Text;
            var date = monthlyIncomeDate.Value;
            var monthlyIncome = Convert.ToDouble(monthlyIncomeAmount.Text);
            var category = monthlyIncomeCategory.Text;

            var scheduler = new Scheduler(date, name, monthlyIncome, category, manager, true);
            scheduler.Start();

            errorLabel.Text = "Monthly income was added successfully!";
            monthlyIncomeAmount.Clear();
            monthlyIncomeCategory.Text = null;
            monthlyIncomeName.Text = null;
            monthlyIncomeDate.ResetText();
        }

        private void inputExpense(object sender, EventArgs e)
        {
            if (nameP.Text.Length == 0 || nameP.Text == null)
            {
                errorField.Text = "Name cannot be empty!";
                return;
            }
            if (!Double.TryParse(priceP.Text, out _))
            {
                errorField.Text = "Price must be a number!";
                return;
            }
            if (categoryP.Text.Length == 0 || categoryP == null)
            {
                errorField.Text = "Please choose a category!";
                return;
            }

            var date = (int)(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalSeconds;
            var name = nameP.Text;
            var price = Convert.ToDouble(priceP.Text);
            var category = categoryP.Text;

            manager.addExpense(new Expense(date, name, price, category));
            errorField.Text = nameP.Text + " was successfully added!";
            nameP.Text = null;
            priceP.Text = null;
            categoryP.Text = null;
        }

        private void inputIncome(object sender, EventArgs e)
        {
            if (incomeSum.Text.Length == 0 || incomeSum == null)
            {
                errorField2.Text = "Please enter a sum!";
                return;
            }
            if (!Double.TryParse(incomeSum.Text, out _))
            {
                errorField2.Text = "Price must be a number!";
                return;
            }
            if (incomeCat.Text.Length == 0 || incomeCat == null)
            {
                errorField2.Text = "Please choose a category!";
                return;
            }
            var date = (int)(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalSeconds;
            var sum = Convert.ToDouble(incomeSum.Text);
            var category = incomeCat.Text;

            manager.addIncome(new Income(date, sum, category));

            errorField2.Text = "Sum was added successfully!";
            incomeSum.Clear();
            incomeCat.Text = null;
        }

        private void showExpenses(object sender, EventArgs e)
        {
            var list = manager.readExpenses();
            if (list == null)
            {
                statScreen.Text = "No data found!";
                return;
            }
            statScreen.Text = "";
            foreach (var expense in list)
            {
                var date = new DateTime(1970, 1, 1, 0, 0, 0, 0).AddSeconds(expense.Date).ToLocalTime();
                statScreen.Text += date + " | " + expense.Name + " | " + expense.Price + "€ | " + expense.Category + System.Environment.NewLine;
            }
        }

        private void showIncome(object sender, EventArgs e)
        {
            var list = manager.readIncome();
            if (list == null)
            {
                statScreen.Text = "No data found!";
                return;
            }
            statScreen.Text = "";
            foreach (var income in list)
            {
                var date = new DateTime(1970, 1, 1, 0, 0, 0, 0).AddSeconds(income.Date).ToLocalTime();
                statScreen.Text += date + " | " + income.Sum + "€ | " + income.Category + System.Environment.NewLine;
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabControl1.SelectedIndex)
            {
                case 3:
                    editIncome();
                    label8.Text = "";
                    break;
                case 4:
                    editExpenses();
                    label9.Text = "";
                    break;
                default:
                    break;

            }
        }

        private void showStatistics(object sender, EventArgs e) => statScreen.Text = stats.generateExpenseStatistics(manager) + stats.generateIncomeStatistics(manager);

        private void editIncome()
        {
            comboBox1.Items.Clear();
            textBox1.Text = null;
            comboBox2.Text = null;
            var list = manager.readIncome();
            if (list.Count == 0)
            {
                comboBox1.Text = "No income data found!";
                return;
            }

            comboBox1.Text = "Select item to edit";
            foreach (var income in list)
            {
                //var date = new DateTime(1970, 1, 1, 0, 0, 0, 0).AddSeconds(income.Date).ToLocalTime();
                comboBox1.Items.Add(income.Sum + "€ | " + income.Category);
            }
        }

        private void onEditIncomeChange(object sender, EventArgs e)
        {
            var list = manager.readIncome();
            var array = list.ToArray();
            var index = comboBox1.SelectedIndex;
            textBox1.Text = array[index].Sum + "";
            comboBox2.SelectedItem = array[index].Category;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var list = manager.readIncome();
            if (list.Count == 0)
            {
                label8.Text = "Income data is empty!";
                return;
            }
            var array = list.ToArray();
            var index = comboBox1.SelectedIndex;
            if (index < 0 || index > array.Length)
            {
                label8.Text = "Select an item to edit!";
                return;
            }
            list.Remove(array[index]);
            manager.updateIncome(list);
            label8.Text = "Item deleted successfully!";
            editIncome();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var list = manager.readIncome();
            if (list.Count == 0)
            {
                label8.Text = "Income data is empty!";
                return;
            }
            if (!Double.TryParse(textBox1.Text, out _))
            {
                label8.Text = "Sum must be a number!";
                return;
            }

            if (comboBox2.Text.Length == 0 || comboBox2 == null)
            {
                label8.Text = "Please choose a category!";
                return;
            }

            var array = list.ToArray();
            var index = comboBox1.SelectedIndex;
            if (index < 0 || index > array.Length)
            {
                label8.Text = "Select an item to edit!";
                return;
            }
            list.Remove(array[index]);
            array[index].Date = (int)(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalSeconds;
            array[index].Sum = Convert.ToDouble(textBox1.Text);
            array[index].Category = comboBox2.SelectedItem.ToString();
            list.Add(array[index]);
            manager.updateIncome(list);
            label8.Text = "Item edited successfully!";
            editIncome();
        }

        private void editExpenses()
        {
            comboBox5.Items.Clear();
            textBox3.Text = null;
            textBox2.Text = null;
            comboBox3.Text = null;
            var list = manager.readExpenses();
            if (list.Count == 0)
            {
                comboBox5.Text = "No expense data found!";
                return;
            }

            comboBox5.Text = "Select item to edit";
            foreach (var expense in list)
            {
                comboBox5.Items.Add(expense.Name + " | " + expense.Price + "€ | " + expense.Category);
            }
        }

        private void onEditExpenseChange(object sender, EventArgs e)
        {
            var list = manager.readExpenses();
            var array = list.ToArray();
            var index = comboBox5.SelectedIndex;
            textBox3.Text = array[index].Name;
            textBox2.Text = array[index].Price + "";
            comboBox3.SelectedItem = array[index].Category;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var list = manager.readExpenses();
            if (list.Count == 0)
            {
                label9.Text = "Expense data is empty!";
                return;
            }
            var array = list.ToArray();
            var index = comboBox5.SelectedIndex;
            if (index < 0 || index > array.Length)
            {
                label9.Text = "Select an item to edit!";
                return;
            }
            list.Remove(array[index]);
            manager.updateExpenses(list);
            label9.Text = "Item deleted successfully!";
            editExpenses();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var list = manager.readExpenses();
            if (list.Count == 0)
            {
                label9.Text = "Expense data is empty!";
                return;
            }
            if (textBox3.Text.Length == 0 || textBox3.Text == null)
            {
                label9.Text = "Name cannot be empty!";
                return;
            }
            if (!Double.TryParse(textBox2.Text, out _))
            {
                label9.Text = "Price must be a number!";
                return;
            }
            if (comboBox3.Text.Length == 0 || comboBox3 == null)
            {
                label9.Text = "Please choose a category!";
                return;
            }

            var array = list.ToArray();
            var index = comboBox5.SelectedIndex;
            if (index < 0 || index > array.Length)
            {
                label9.Text = "Select an item to edit!";
                return;
            }
            list.Remove(array[index]);
            array[index].Date = (int)(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalSeconds;
            array[index].Name = textBox3.Text;
            array[index].Price = Convert.ToDouble(textBox2.Text);
            array[index].Category = comboBox3.SelectedItem.ToString();
            list.Add(array[index]);
            manager.updateExpenses(list);
            label9.Text = "Item edited successfully!";
            editExpenses();
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
            if (!Double.TryParse(cartElemPriceBox.Text, out _))
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
            if (!Double.TryParse(cartElemChangePri.Text, out _))
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
                currentCart.Account(manager);

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
    }
}
