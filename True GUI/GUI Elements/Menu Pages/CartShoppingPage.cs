using System;
using System.Drawing;
using System.Windows.Forms;

namespace Plutus
{
    public partial class TrueGUI : Form
    {
        Button endShoppingButton;
        Label toPickShoppingLabel;
        Label shoppingLineAfter1;
        Label pickedShoppingLabel;
        Label shoppingLineAfter2;
        Panel shoppingExpensePanel;
        Label shoppingLineAfter3;


        private void InitializeShoppingPage()
        {
            endShoppingButton = CreateClassicButton("endShoppingButton", "Done!", _firstColor, _lilitaOne, 9F, _secondColor, 250, 30, cartPageBackButton.Right + 10, cartPageLineAboveAddControls.Bottom + 5, 7);
            endShoppingButton.Click += new EventHandler(EndShopping_Click);
            toPickShoppingLabel = CreateClassicLabel("toPickShoppingLabel", "Left to pick up:", _firstColor, _lilitaOne, 10F, 300, 20, 5, 10, 0, ContentAlignment.MiddleLeft);
            pickedShoppingLabel = CreateClassicLabel("pickedShoppingLabel", "Picked up:", _firstColor, _lilitaOne, 10F, 300, 20, 5, 50, 0, ContentAlignment.MiddleLeft);
            shoppingLineAfter1 = CreateClassicLine("shoppingLine1", 310, 3, 0, toPickShoppingLabel.Bottom, _secondColor);
            shoppingLineAfter2 = CreateClassicLine("shoppingLine2", 310, 3, 0, pickedShoppingLabel.Bottom, _secondColor);
            shoppingLineAfter3 = CreateClassicLine("shoppingLine3", 310, 3, 0, pickedShoppingLabel.Bottom, _secondColor); ;
            shoppingExpensePanel = new Panel
            {
                Name = "cartPageWorkPanel",
                Width = 310,
                Height = 500,
                Left = 0,
                Top = 0,
                AutoScroll = false
            };
            shoppingExpensePanel.MouseEnter += new EventHandler(ControlSetFocus);
            shoppingExpensePanel.MouseLeave += new EventHandler(ControlLoseFocus);
            shoppingExpensePanel.MouseWheel += new MouseEventHandler(ScrollPanel);
        }

        public void ControlSetFocus(object sender, EventArgs e)
        {
            var control = (Control)sender;
            if (control.CanFocus)
            {
                control.Focus();
            }
        }

        public void ControlLoseFocus(object sender, EventArgs e) => ActiveControl = null;

        public void ScrollPanel(object sender, MouseEventArgs e)
        {
            var panel = (Panel)sender;
            var panelControls = panel.Controls;
            var count = panelControls.Count;
            var firstControl = (Label)panelControls[0];
            var lastControl = (Label)panelControls[count - 1];

            if ((e.Delta > 0) && (lastControl.Bottom > 500))
            {
                foreach (Control control in panel.Controls)
                {
                    control.Top -= e.Delta;
                }
            }
            if((e.Delta < 0) && (firstControl.Top < 0))
            {
                foreach (Control control in panel.Controls)
                {
                    control.Top -= e.Delta;
                }
            }
        }

        private void LoadShoppingPage(string info)
        {
            _shoppingService.InitializeShoppingService(_cartService.StartShopping());
            cartsPageWorkPanel.Controls.Clear();
            LoadShoppingExpensesPanel();
            cartsPageWorkPanel.Controls.Add(shoppingExpensePanel);
            cartsPageWorkPanel.Controls.Add(cartPageLineAboveAddControls);
            cartsPageWorkPanel.Controls.Add(cartPageBackButton); 
            cartsPageWorkPanel.Controls.Add(endShoppingButton);
            cartPageInfoLabel.Text = info;
        }

        private void LoadShoppingExpensesPanel()
        {
            shoppingExpensePanel.Controls.Clear();
            shoppingExpensePanel.Controls.Add(toPickShoppingLabel);
            var currtop = toPickShoppingLabel.Height;
            shoppingExpensePanel.Controls.Add(shoppingLineAfter1);
            currtop += shoppingLineAfter1.Height + 5;
            currtop = LoadToPickShopping(currtop);
            pickedShoppingLabel.Top = currtop;
            shoppingExpensePanel.Controls.Add(pickedShoppingLabel);
            currtop += pickedShoppingLabel.Height;
            shoppingLineAfter2.Top = currtop;
            shoppingExpensePanel.Controls.Add(shoppingLineAfter2);
            currtop += shoppingLineAfter2.Height + 5;
            currtop = LoadPickedShopping(currtop);
            shoppingLineAfter3.Top = currtop;
            shoppingExpensePanel.Controls.Add(shoppingLineAfter3);
        }

        private void EndShopping_Click(object sender, EventArgs e)
        {
            _shoppingService.ChargeShopping();
            GoBackCartMethod(_shoppingService.RetMess);
        }

        private int LoadToPickShopping(int top)
        {
            var listOfExpenses = _shoppingService.GiveExpenses(0);
            for(var i = 0; i < listOfExpenses.Count; i++)
            {
                var split = listOfExpenses[i].Split('|');
                var name = split[0];
                var index = split[1];
                var expButton = CreateExpensebutton(name, 0, top, int.Parse(index));
                shoppingExpensePanel.Controls.Add(expButton);
                top += 30;
            }
            return top;
        }
        private int LoadPickedShopping(int top)
        {
            var listOfExpenses = _shoppingService.GiveExpenses(1);
            for (var i = 0; i < listOfExpenses.Count; i++)
            {
                var split = listOfExpenses[i].Split('|');
                var name = split[0];
                var index = split[1];
                var expButton = CreateExpensebutton(name, 1, top, int.Parse(index));
                shoppingExpensePanel.Controls.Add(expButton);
                top += expButton.Height + 5;
            }
            return top;
        }


        private Button CreateExpensebutton(string expense, int state, int top, int index)
        {
            var color = state == 0 ? _secondColor : _firstColor;
            var button = CreateClassicButton("expenseShoppingButton|" + index, expense, Color.White, _lilitaOne, 10F, color, 300, 30, 5, top, 100 + index);
            button.Click += new EventHandler(Expense_Click);
            return button;
        }

        private void Expense_Click(object sender, EventArgs e)
        {
            var expenseBut = (Button)sender;
            var expNameAndIndex = expenseBut.Name.Split('|');
            var index = expNameAndIndex[1];
            _shoppingService.ElementClicked(int.Parse(index));
            LoadShoppingExpensesPanel();
        }
    }
}
