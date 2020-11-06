using System.Drawing;
using System.Windows.Forms;

namespace Plutus
{
    public partial class TrueGUI : Form
    {
        Label insightsPageName;
        TextBox statistics;



        private void LoadInsightsPage()
        {
            LoadMenuButton();
            LoadEscapeButton();

            insightsPageName = CreatePageNameLabel("insightsPageNameLabel", "INSIGHTS");
            statistics = new TextBox
            {
                Name = "Statistics",
                Text = _stats.GenerateExpenseStatistics(_fileManager) + "\r\n" + _stats.GenerateIncomeStatistics(_fileManager),
                Font = new Font(_lilitaOne, 16F, FontStyle.Regular, GraphicsUnit.Point),
                BackColor = _backgroundColor,
                ForeColor = _secondColor,
                BorderStyle = BorderStyle.None,
                AutoSize = true,
                Width = ClientSize.Width - 15,
                Top = 150,
                Left = 15,
                Height = ClientSize.Height - 220,
                TextAlign = HorizontalAlignment.Center,
                Multiline = true,
                ReadOnly = true,
            };

            Controls.Add(insightsPageName);
            Controls.Add(statistics);
            ResumeLayout(false);
            PerformLayout();
        }

    }
}
