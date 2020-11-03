using System.Drawing;
using System.Windows.Forms;

namespace Plutus
{
    public partial class TrueGUI : Form
    {
        Label schedulerPageName;


        private void LoadSchedulerPage()
        {
            LoadMenuButton();
            LoadEscapeButton();

            schedulerPageName = CreatePageNameLabel("schedulerPageNameLabel", "SCHEDULER");

            Controls.Add(schedulerPageName);
            ResumeLayout(false);
            PerformLayout();
        }

    }
}
