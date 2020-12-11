using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Plutus
{
    public partial class TrueGUI : Form
    {
        //Label nameLabel;
        //Label subNameLabel;
        PictureBox logoPicture;
        Button getStartedButton;
        private void LoadFrontPage()
        {
            logoPicture = new PictureBox
            {
                Image = Properties.Resources.PlutusLogo,
                Location = new Point(0, 98),
                Left = 15,
                Name = "logoPicture",
                SizeMode = PictureBoxSizeMode.Zoom,
                Size = new Size(350, 400)
            };
            SuspendLayout();

            getStartedButton = CreateClassicButton("getStartedButton", "GET STARTED", Color.White, _lilitaOne, 18F, Color.FromArgb(163, 160, 154), 272, 77, 51, 524, 3);
            getStartedButton.Click += new EventHandler(GetStartedButton_Click);

            Controls.Add(logoPicture);
            Controls.Add(getStartedButton);
            ResumeLayout(false);
            PerformLayout();
        }
        private async void GetStartedButton_Click(object sender, EventArgs e)
        {
            Controls.Clear();
            await _plutusApiClient.CheckPaymentsAsync();
            LoadMainPage();
        }


    }
}
