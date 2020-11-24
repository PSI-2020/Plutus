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
            InitializeCartPage();
            InitializeBudgetsPage();
            InitializeEditGoalPage();
            InitializeAddGoalPage();
            InitializeCheckGoalPage();
            InitializeScheduledPaymentPage();
            InitializeShoppingPage();
        }
    }
}
