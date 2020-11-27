using Plutus.Controllers;
using Plutus.Services;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;

namespace Plutus
{
    public partial class TrueGUI : Form
    {
        private readonly PrivateFontCollection _privateFontCollection = new PrivateFontCollection();
        private readonly FontFamily[] _fontFamilies;
        private readonly FontFamily _lilitaOne;
        private readonly Color _backgroundColor = Color.FromArgb(220, 213, 201);
        private readonly Color _firstColor = Color.FromArgb(111, 101, 88);
        private readonly Color _secondColor = Color.FromArgb(168, 163, 153);
        private readonly CurrentInfoHolder _currentInfo = new CurrentInfoHolder();
        private readonly VerificationService _inputVerification = new VerificationService();
        private readonly FileManager _fileManager = new FileManager();
        private readonly CartService _cartService;
        private readonly PaymentService _paymentService;
        private readonly GoalService _goalService = new GoalService();
        private readonly BudgetService _budgetService = new BudgetService();
        private readonly SchedulerService _schedulerService = new SchedulerService();
        private readonly HistoryController _historyController = new HistoryController();
        private readonly StatisticsController _statisticsController = new StatisticsController();
        private readonly BudgetsController _budgetsController = new BudgetsController();
        private readonly SchedulerController _schedulerController = new SchedulerController();

        private string _previousPage;


        public TrueGUI()
        {
            _cartService = new CartService(_fileManager);
            _paymentService = new PaymentService(_fileManager);
            _privateFontCollection.AddFontFile(_fileManager.fontPathMaconodo);
            _privateFontCollection.AddFontFile(_fileManager.fontPathLilita);
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
