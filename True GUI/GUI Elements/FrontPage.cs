using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Plutus
{
    public partial class TrueGUI : Form
    {
        Label nameLabel;
        Label subNameLabel;
        PictureBox logoPicture;
        Button getStartedButton;
        private void LoadFrontPage()
        {
            logoPicture = new PictureBox
            {
                Image = Properties.Resources.PlutusLogoTrue,
                Location = new Point(87, 98),
                Name = "logoPicture",
                Size = new Size(200, 230)
            };
            SuspendLayout();

            nameLabel = CreateClassicLabel(name: "nameLabel", text:  "PLUTUS", fontColor: _firstColor, fontFamily: _maconda, fontSize: 32F, width: 222, height: 50, left: 81, top: 328, tabIndex: 1);
            subNameLabel = CreateClassicLabel(name: "subNameLabel", text: "Virtual Finance Assistant", fontColor: _firstColor, fontFamily: _maconda, fontSize: 10F, width: 222, height: 40, left: 78, top: 370, tabIndex: 2);

            getStartedButton = CreateClassicButton("getStartedButton", "GET STARTED", Color.White, _lilitaOne, 18F, Color.FromArgb(163, 160, 154), 272, 77, 51, 524, 3);
            getStartedButton.Click += new EventHandler(GetStartedButton_Click);

            Controls.Add(logoPicture);
            Controls.Add(nameLabel);
            Controls.Add(subNameLabel);
            Controls.Add(getStartedButton);
            ResumeLayout(false);
            PerformLayout();
        }
        private void GetStartedButton_Click(object sender, EventArgs e)
        {
            Controls.Clear();
            LoadMainPage();
        }


    }
}
