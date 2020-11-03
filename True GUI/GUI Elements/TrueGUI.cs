using Plutus.Services;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Windows.Forms;

namespace Plutus
{
    public partial class TrueGUI : Form
    {
        readonly PrivateFontCollection privateFontCollection = new PrivateFontCollection();
        private static readonly string fontPathMaconodo = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName, "True GUI/GUI resources/Macondo.ttf"); // move to File manager
        private static readonly string fontPathLilita = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName, "True GUI/GUI resources/LilitaOne.ttf"); // move to File manager
        readonly FontFamily[] fontFamilies;
        readonly FontFamily maconda;
        readonly FontFamily lilitaOne;
        private readonly Color backgroundColor = Color.FromArgb(220, 213, 201);
        private readonly Color firstColor = Color.FromArgb(111, 101, 88);
        private readonly Color secondColor = Color.FromArgb(168, 163, 153);
        private CurrentInfoHolder _currentInfo = new CurrentInfoHolder();
        private readonly InputVerification _inputVerification = new InputVerification();
        private PaymentService _paymentService = new PaymentService();


        public TrueGUI()
        {
            privateFontCollection.AddFontFile(fontPathMaconodo);
            privateFontCollection.AddFontFile(fontPathLilita);
            fontFamilies = privateFontCollection.Families;
            maconda = fontFamilies[1];
            lilitaOne = fontFamilies[0];
            InitializeComponent();
            LoadFrontPage();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // TrueGUI
            // 
            ClientSize = new System.Drawing.Size(375, 812);
            Name = "TrueGUI";
            BackColor = backgroundColor;
            ResumeLayout(false);
            InitializeAllGUIComponents();
        }
    }
}
