using System.Windows.Forms;

namespace Plutus
{


    public partial class TrueGUI : Form
    {
        Label chooseCategoryInTextLabel;
        Button categorySalaryButton;
        Label categorySalaryText;
        Button categoryGiftButton;
        Label categoryGiftText;
        Button categoryInvestmentButton;
        Label categoryInvestmentText;
        Button categorySaleButton;
        Label categorySaleText;
        Button categoryRentButton;
        Label categoryRentText;
        Button categoryOtherInButton;
        Label categoryOtherInText;

        private void LoadIncomeCategoryPage(string previous)
        {
            Controls.Clear();
            previousPage = previous;
            LoadEscapeButton();

            chooseCategoryInTextLabel = CreateClassicLabel("chooseCategoryInTextLabel", "Choose Category:", firstColor, lilitaOne, 24F, ClientSize.Width, 45, 0, 75, 1);
            var addGap = 80;

            categorySalaryButton = CreateCategoryButton("Salary", 1, 1, Properties.Resources.SalaryButton, addGap);
            categorySalaryText = CreateCategoryText("categorySalaryText", 1, 1, "salary", addGap);

            categoryGiftButton = CreateCategoryButton("Gift", 1, 2, Properties.Resources.GiftButton, addGap);
            categoryGiftText = CreateCategoryText("categoryGiftText", 1, 2, "gift", addGap);

            categoryInvestmentButton = CreateCategoryButton("Investment", 2, 1, Properties.Resources.InvestmentButton, addGap);
            categoryInvestmentText = CreateCategoryText("categoryInvestmentText", 2, 1, "investment", addGap);

            categorySaleButton = CreateCategoryButton("Sale", 2, 2, Properties.Resources.SaleButton, addGap);
            categorySaleText = CreateCategoryText("categorySaleText", 2, 2, "sale", addGap);

            categoryRentButton = CreateCategoryButton("Rent", 3, 1, Properties.Resources.RentButton, addGap);
            categoryRentText = CreateCategoryText("categoryRentText", 3, 1, "rent", addGap);

            categoryOtherInButton = CreateCategoryButton("Other", 3, 2, Properties.Resources.OtherIncomeButton, addGap);
            categoryOtherInText = CreateCategoryText("categoryOtherInText", 3, 2, "other", addGap);


            Controls.Add(chooseCategoryInTextLabel);

            Controls.Add(categorySalaryButton);
            Controls.Add(categorySalaryText);
            Controls.Add(categoryGiftButton);
            Controls.Add(categoryGiftText);
            Controls.Add(categoryInvestmentButton);
            Controls.Add(categoryInvestmentText);
            Controls.Add(categorySaleButton);
            Controls.Add(categorySaleText);
            Controls.Add(categoryRentButton);
            Controls.Add(categoryRentText);
            Controls.Add(categoryOtherInButton);
            Controls.Add(categoryOtherInText);
            ResumeLayout(false);
            PerformLayout();
        }

    }
}
