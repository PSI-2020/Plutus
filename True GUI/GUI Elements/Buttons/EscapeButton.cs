using System;
using System.Drawing;
using System.Windows.Forms;

namespace Plutus
{
    public partial class TrueGUI : Form
    {
        Button escapeButton;

       private void InitializeEscapeButton()
        {
            escapeButton = new Button
            {
                Name = "menuButton",
                Image = Properties.Resources.EscapeButton,
                Top = 20,
                Left = ClientSize.Width - 58,
                Size = new Size(40, 40),
                FlatStyle = FlatStyle.Flat
            };
            escapeButton.FlatAppearance.BorderSize = 0;
            escapeButton.Click += new EventHandler(EscapeButton_Click);
        }

        private void LoadEscapeButton()
        {
            Controls.Add(escapeButton);
            ResumeLayout(false);
            PerformLayout();
        }

        private void EscapeButton_Click(object sender, EventArgs e)
        {
            Controls.Clear();
            LoadMainPageAsync();
        }
    }
}

