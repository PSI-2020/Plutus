using System.Drawing;
using System.Windows.Forms;

namespace Plutus
{
    public partial class TrueGUI : Form
    {
        Label insightsPageName;
        TextBox statistics;
        StatisticsService stats = new StatisticsService();


        private void LoadInsightsPage()
        {
            LoadMenuButton();
            LoadEscapeButtonCat();

            insightsPageName = CreatePageNameLabel("insightsPageNameLabel", "INSIGHTS");
            statistics = new TextBox
            {
                Name = "Statistics",
                Text = stats.GenerateExpenseStatistics(fileManager) + System.Environment.NewLine + stats.GenerateIncomeStatistics(fileManager),
                Font = new Font(lilitaOne, 16F, FontStyle.Regular, GraphicsUnit.Point),
                BackColor = backgroundColor,
                ForeColor = secondColor,
                BorderStyle = BorderStyle.None,
                AutoSize = true,
                Width = ClientSize.Width - 15,
                Top = 150,
                Left = 15,
                Height = ClientSize.Height - 220,
                TextAlign = HorizontalAlignment.Center,
                Multiline = true,
                ReadOnly = true,
                Enabled = false
            };

            Controls.Add(insightsPageName);
            Controls.Add(statistics);
            ResumeLayout(false);
            PerformLayout();
        }

    }
}
