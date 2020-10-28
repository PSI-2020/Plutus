using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Plutus
{
    public partial class GUI : Form
    {

        private List<ShopCartManager> _shopCartManagers;
        private Button _currShopingCartBut;
        private void CShopLoad()
        {
            Cart cart;
            chargeShopping.Visible = false;
            _shopCartManagers = new List<ShopCartManager>();
            var cartAmount = _cL.GiveUsedCartCount();
            var cartCount = _cL.GiveCartCount();
            shoppingCarts.Controls.Clear();
            if (cartAmount > 0)
            {
                for (var i = 0; i < cartCount; i++)
                {
                    cart = _cL.GiveCart(i);
                    if (cart != null) CShopCartLoad(cart);
                }
            }
        }

        private void CShopCartLoad(Cart cart)
        {
            var index = _shopCartManagers.Count + 1;
            var name = "CartS" + index;
            var myButton = new Button
            {
                Name = name,
                Text = cart.CartName,
                Width = 210,
                Height = 45
            };
            myButton.Click += new EventHandler(ShopCart_Click);
            shoppingCarts.Controls.Add(myButton);
            var sCM = new ShopCartManager(cart);
            _shopCartManagers.Add(sCM);
        }



        private void ShopCart_Click(object sender, EventArgs e)
        {
            _currShopingCartBut = (Button)sender;
            chargeShopping.Visible = true;
            var index = int.Parse(_currShopingCartBut.Name.Substring(5)) - 1;
            shoppingProductsPanel.Controls.Clear();
            DisplayShoppingCart(index);
        }
        private void DisplayShoppingCart(int index)
        {
            var currSCM = _shopCartManagers[index];
            var currShoppingCart = _cL.GiveCart(index);
            if (currShoppingCart == null) return;

            var toPickLabel = CreateNewShoppingLabel("To Pick");
            var toPickLine = CreateNewShoppingLine();
            var pickedLine = CreateNewShoppingLine();
            var pickedLabel = CreateNewShoppingLabel("Picked");

            shoppingProductsPanel.Controls.Add(toPickLabel);
            shoppingProductsPanel.Controls.Add(toPickLine);

            var state0List = currSCM.GiveStateIndex(0);
            var state1List = currSCM.GiveStateIndex(1);
            var state0Count = currSCM.GiveSCount(0);
            var state1Count = currSCM.GiveSCount(1);


            for (var i = 0; i < state0Count; i++)
            {
                var indexList = state0List.Split('|');
                var indexx = int.Parse(indexList[i]);
                var currExpense = currShoppingCart.GiveElement(indexx);
                var expenseButton = CreateNewShoppingExpenseBut(currExpense.Name, null, indexx);
                shoppingProductsPanel.Controls.Add(expenseButton);
            }


            shoppingProductsPanel.Controls.Add(pickedLabel);
            shoppingProductsPanel.Controls.Add(pickedLine);

            for (var i = 0; i < state1Count; i++)
            {
                var indexList = state1List.Split('|');
                var indexx = int.Parse(indexList[i]);
                var currExpense = currShoppingCart.GiveElement(indexx);
                var expenseButton = CreateNewShoppingExpenseBut(currExpense.Name, "gray", indexx);
                shoppingProductsPanel.Controls.Add(expenseButton);
            }
        }

        private Button CreateNewShoppingExpenseBut(string name, string color, int count)
        {
            var newColor = new Color();
            newColor = color != null ? Color.FromName(color) : Color.FromName("white");
            var but = new Button
            {
                Size = new Size(628, 40),
                Text = name,
                Name = "ElemButton" + "|" + count,
                BackColor = newColor
            };
            but.Click += new EventHandler(ShopElem_Click);
            return but;
        }

        private void ShopElem_Click(object sender, EventArgs e)
        {
            currentElemBut = (Button)sender;
            var index = currentElemBut.Name.IndexOf('|') + 1;
            var indexOfExpense = int.Parse(currentElemBut.Name.Substring(index));
            var i = int.Parse(_currShopingCartBut.Name.Substring(5)) - 1;
            _shopCartManagers[i].ChangeState(indexOfExpense);
            shoppingProductsPanel.Controls.Clear();
            DisplayShoppingCart(i);
        }

        private Label CreateNewShoppingLabel(string value)
        {
            var label = new Label
            {
                Size = new Size(628, 20),
                Text = value
            };
            return label;
        }
        private Label CreateNewShoppingLine()
        {
            var label = new Label
            {
                Size = new Size(628, 2),
                BackColor = Color.FromName("black")
            };
            return label;
        }

        private void ChargeShopping_Click(object sender, EventArgs e)
        {
            var index = int.Parse(_currShopingCartBut.Name.Substring(5)) - 1;
            var cart = _shopCartManagers[index];
            cart.Account(manager);
            shoppingProductsPanel.Controls.Clear();
            DisplayShoppingCart(index);
        }
    }
}
