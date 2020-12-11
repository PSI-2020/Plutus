using System.Windows.Forms;

namespace Plutus
{
    public partial class TrueGUI : Form
    {
        private void InitializeAllGUIComponents()
        {
            InitializeEscapeButton();
            InitializePaymentFieldPage();
            InitializeHistoryPage();
            InitializeEditPage();
            InitializeCartPage();
            InitializeBudgetsPage();
            InitializeEditGoalPage();
            InitializeAddGoalPage();
            InitializeCheckGoalPage();
            InitializeSchedulerPage();
            InitializeScheduledPaymentPage();
            InitializeShoppingPage();
        }
    }
}
