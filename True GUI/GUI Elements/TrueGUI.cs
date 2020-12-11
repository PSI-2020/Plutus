using Plutus.Interfaces;
using Plutus.Services;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Net.Http;
using System.Windows.Forms;

namespace Plutus
{
    enum ExpenseCategories
    {
        Groceries,
        Restaurant,
        Clothes,
        Transport,
        Health,
        School,
        Bills,
        Entertainment,
        Other
    }

    enum IncomeCategories
    {
        Salary,
        Gift,
        Investment,
        Sale,
        Rent,
        Other
    }


    public partial class TrueGUI : Form
    {
        private readonly PrivateFontCollection _privateFontCollection = new PrivateFontCollection();
        private readonly string _directoryPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
        private readonly FontFamily[] _fontFamilies;
        private readonly FontFamily _lilitaOne;
        private readonly Color _backgroundColor = Color.FromArgb(220, 213, 201);
        private readonly Color _firstColor = Color.FromArgb(111, 101, 88);
        private readonly Color _secondColor = Color.FromArgb(168, 163, 153);
        private readonly IInfoHolder _currentInfo;
        private readonly ICartFrontEndService _cartService;
        private readonly IShoppingFrontEndService _shoppingService;
        private readonly IPaymentFrontEndService _paymentService;
        private readonly PlutusApiClient _plutusApiClient;

        private string _previousPage;

        public TrueGUI(IShoppingFrontEndService shoppingService, ICartFrontEndService cartService, IPaymentFrontEndService paymentService, IInfoHolder currentInfo, PlutusApiClient plutusApi)
        {
            _plutusApiClient = plutusApi;
            _cartService = cartService;
            _shoppingService = shoppingService;
            _paymentService = paymentService;
            _currentInfo = currentInfo;
            _privateFontCollection.AddFontFile(_directoryPath + Properties.Settings.Default.MacondoPath);
            _privateFontCollection.AddFontFile(_directoryPath + Properties.Settings.Default.LilitiaPath);
            _fontFamilies = _privateFontCollection.Families;
            _lilitaOne = _fontFamilies[0];
            InitializeComponent();
            LoadFrontPage();
        }

        private void InitializeComponent()
        {
            ClientSize = new Size(375, 812);
            Name = "TrueGUI";
            BackColor = _backgroundColor;
            InitializeAllGUIComponents();
        }

        private Label CreatePageNameLabel(string name, string text)
        {
            var pageNameLabel = new Label
            {
                Name = name,
                Text = text,
                Font = new Font(_lilitaOne, 34F, FontStyle.Regular, GraphicsUnit.Point),
                AutoSize = false,
                Size = new Size(ClientSize.Width, 60),
                Location = new Point(0, 60),
                TextAlign = ContentAlignment.MiddleCenter,
                ForeColor = _firstColor,
            };
            return pageNameLabel;
        }
    }
}