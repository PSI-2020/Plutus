using System.Drawing;
using System.Windows.Forms;

namespace Plutus
{
    public partial class TrueGUI : Form
    {
        Label insightsPageName;


        private void LoadInsightsPage()
        {
            LoadMenuButton();
            LoadEscapeButtonCat();

            insightsPageName = CreatePageNameLabel("insightsPageNameLabel", "INSIGHTS");

            Controls.Add(insightsPageName);
            ResumeLayout(false);
            PerformLayout();
        }

    }
}
