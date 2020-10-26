using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Plutus
{
    public partial class GUI : Form
    {
        private CartList _cL = new CartList();

        private void addCartButton_Click(object sender, EventArgs e)
        {
            var cartNumb = _cL.GiveCartCount() + 1;
            var name = "CartC" + cartNumb;
            var text = "Cart " + cartNumb;
            var myButton = CreateCartButton(name, text);
            cartPanel.Controls.Add(myButton);
            _cL.CartAdd(name);
            CartAmountCountUpdate();
            CShopLoad();

        }

        private Button CreateCartButton(string name, string text)
        {
            var but = new Button();
            but.Name = name;
            but.Text = text;
            but.Width = 210;
            but.Height = 45;
            but.Click += new System.EventHandler(this.Cart_Click);
            return but;
        }

        private Button currentCartBut = null;

        private void ChangeCartname()
        {
            var nameExists = false;
            Cart cart;
            var count = _cL.GiveCartCount();
            for(int i = 0; i < count; i++)
            {
                cart = _cL.GiveCart(i);
                if ((cart != null) && (cart.CartName == cartName.Text)) nameExists = true;
            }
            if (nameExists)
            {
                OpenElemAdd();
                cartAddErrorField.Text = "Name exists";
            }
            else
            {
                var name = cartName.Text;
                _cL.RenameCart(name);
                currentCartBut.Text = name;
                CShopLoad();
            }

        }
        private void Cart_Click(object sender, System.EventArgs e)
        {
            currentCartBut = (Button)sender;
            cartName.Text = currentCartBut.Text;
            var cName = currentCartBut.Name;
            _cL.CartSelect(cName);
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
            var cart = _cL.GiveCart();
            cartExpCount.Text = cart.GiveElementC().ToString();
        }


        private void AddExpenseBut_Click(object sender, EventArgs e)
        {
            OpenElemAdd();
        }


        private void DisplayCart()
        {
            var cart = _cL.GiveCart();
            if (cart == null) return;
            var elemSk = cart.GiveElementC();
            if (elemSk == 0) return;
            _cL.SaveCart();
            var currentCart = _cL.GiveCart();
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

        private void CartAmountCountUpdate()
        {
            CurrentCartCountNum.Text = _cL.GiveUsedCartCount().ToString();
        }

        private void ElemActivate_Click(object sender, EventArgs e)
        {
            var currentCart = _cL.GiveCart();
            currentElemBut = (Button)sender;
            var index = currentElemBut.Name.IndexOf('|') + 1;
            var indexOfExpense = int.Parse(currentElemBut.Name.Substring(index));
            currentCart.ChangeActivity(indexOfExpense);
            var currentElem = currentCart.GiveElement(indexOfExpense);
            ActivityButColorDecide(currentElem, currentElemBut);
            _cL.SaveCart();

        }
        private void ElemEdit_Click(object sender, EventArgs e)
        {
            var currentCart = _cL.GiveCart();
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
            var currentCart = _cL.GiveCart();
            var index = currentElemBut.Name.IndexOf('|') + 1;
            var indexOfExpense = int.Parse(currentElemBut.Name.Substring(index));
            currentElemToDel = currentCart.GiveElement(indexOfExpense);
            if (currentElemToDel == currentElem) CloseElemChange();
            currentCart.RemoveExpense(indexOfExpense);
            _cL.ChangeCart(currentCart);
            RefreshElemCount();
            cartInfoPanel.Controls.Clear();
            shoppingProductsPanel.Controls.Clear();
            CShopLoad();
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
            var cart = _cL.GiveCart();
            cart.AddExpense(newCartExpense);
            _cL.ChangeCart(cart);
            cartAddErrorField.Text = "Added";
            cartElemNameBox.Text = "";
            cartElemPriceBox.Text = "";
            cartElemCategoryBox.Text = "Other";
            RefreshElemCount();
            cartInfoPanel.Controls.Clear();
            DisplayCart();
            shoppingProductsPanel.Controls.Clear();
            CShopLoad();
        }

        private void CartCloseElemAddition_Click(object sender, EventArgs e)
        {
            CloseElemAdd();
        }

        private void delCartButton_Click(object sender, EventArgs e)
        {
            var currBut = (int.Parse(currentCartBut.Name.Substring(5)) - 1);
            _cL.DeleteCart();
            currentCartBut.Dispose();
            CShopLoad();
            CloseElemAdd();
            cartInfoPanel.Controls.Clear();
            cartName.Text = "";
            CartAmountCountUpdate();
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
            shoppingProductsPanel.Controls.Clear();
            CShopLoad();
            DisplayCart();
        }

        private void cartCloseElemChange_Click(object sender, EventArgs e)
        {
            CloseElemChange();
        }

        private void cartChargeBut_Click(object sender, EventArgs e)
        {
            OpenElemAdd();
            var cart = _cL.GiveCart();

            if (cart == null)
            {
                cartAddErrorField.Text = "Charge what?";
            }
            else
            {
                cartAddErrorField.Text = "Charged!";
                cart.Account(manager);

            }
        }

        private void CartNameSetter_Click(object sender, EventArgs e)
        {
            var cart = _cL.GiveCart();
            if ((cart != null) && (currentCartBut != null))
            {
                ChangeCartname();
            }
        }

        private void LoadCarts()
        {
            _cL.LoadCarts();
            Cart cart;
            var cartCount = _cL.GiveCartCount();
            if (cartCount > 0)
            {
                for (var i = 0; i < cartCount; i++)
                {
                    cart = _cL.GiveCart(i);
                    CreateCartButOnLoad(cart, i);
                }
            }
            CShopLoad();

        }

        private void CreateCartButOnLoad(Cart cart, int index)
        {
            index++;
            var name = "CartC" + index;
            var text = cart.CartName;
            var myButton = CreateCartButton(name, text);
            cartPanel.Controls.Add(myButton);
            CartAmountCountUpdate();
        }
    }
}
