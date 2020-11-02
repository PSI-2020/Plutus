using System.Drawing;
using System.Windows.Forms;

namespace Plutus
{
    public partial class TrueGUI : Form
    {
        Label cartsPageName;


        private void LoadCartsPage()
        {
            LoadMenuButton();
            LoadEscapeButtonCat();

            cartsPageName = CreatePageNameLabel("cartsPageNameLabel", "CARTS");

            Controls.Add(cartsPageName);
            ResumeLayout(false);
            PerformLayout();
        }

    }
}
