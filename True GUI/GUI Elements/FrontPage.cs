using System;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Plutus
{
    public partial class TrueGUI : Form
    {
        PictureBox logoPicture;
        Button getStartedButton;
        Label loadingLabel;
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

            loadingLabel = CreateClassicLabel("loadingLabel", "Loading...", _firstColor, _lilitaOne, 18F, Width, 50, 0, (Bottom/2) - 25, 0);

            getStartedButton = CreateClassicButton("getStartedButton", "GET STARTED", Color.White, _lilitaOne, 18F, Color.FromArgb(163, 160, 154), 272, 77, 51, 524, 3);
            getStartedButton.Click += new EventHandler(GetStartedButton_ClickAsync);

            Controls.Add(logoPicture);
            Controls.Add(getStartedButton);
            ResumeLayout(false);
            PerformLayout();
        }
        private async void GetStartedButton_ClickAsync(object sender, EventArgs e)
        {
            Controls.Clear();
            Controls.Add(loadingLabel);
            var end = false;
            _ = Task.Run(() =>
              {
                  var dotstuf = "";
                  while (!end)
                  {
                      dotstuf = (dotstuf == "...") ? "." : dotstuf + ".";
                      BeginInvoke((Action)(() => loadingLabel.Text = "loading" + dotstuf));
                      Thread.Sleep(200);
                  }

              });
            await _plutusApiClient.CheckPaymentsAsync(); await Task.Run(() =>
            {
                Thread.Sleep(5000);

            });
            end = true;

            Controls.Clear();
            LoadMainPageAsync();
        }


    }
}
