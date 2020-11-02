using System.Drawing;
using System.Windows.Forms;

namespace Plutus
{
    public partial class TrueGUI : Form
    {
        Label budgetsPageName;


        private void LoadBudgetsPage()
        {
            LoadMenuButton();
            LoadEscapeButtonCat();

            budgetsPageName = CreatePageNameLabel("budgetsPageNameLabel", "BUDGETS");

            Controls.Add(budgetsPageName);
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
