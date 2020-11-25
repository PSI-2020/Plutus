using System;
using System.Drawing;
using System.Windows.Forms;

namespace Plutus
{
    public partial class TrueGUI : Form
    {
        private Button _menuButton;
        private void LoadMenuButton()
        {
            _menuButton = new Button
            {
                Name = "menuButton",
                Image = Properties.Resources.MenuButton,
                Location = new Point(18, 20),
                Size = new Size(34, 29),
                FlatStyle = FlatStyle.Flat
            };
            _menuButton.FlatAppearance.BorderSize = 0;
            _menuButton.Click += new EventHandler(MenuButton_Click);
            Controls.Add(_menuButton);
            ResumeLayout(false);
            PerformLayout();
        }

        private void MenuButton_Click(object sender, EventArgs e)
        {
            Controls.Clear();
            LoadMenuPage();
        }
    }
}
