using System.Drawing;
using System.Windows.Forms;

namespace Plutus
{
    public partial class TrueGUI : Form
    {
        Label goalsPageName;


        private void LoadGoalsPage()
        {
            LoadMenuButton();
            LoadEscapeButtonCat();

            goalsPageName = CreatePageNameLabel("goalsPageNameLabel", "GOALS");

            Controls.Add(goalsPageName);
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
