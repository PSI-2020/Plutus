using System.Drawing;
using System.Windows.Forms;

namespace Plutus
{

    public partial class TrueGUI : Form
    {
        Label chooseCategoryTextLabel;
        Button categoryGroceriesButton;
        Label categoryGroceriesText;
        Button categoryRestaurantButton;
        Label categoryRestaurantText;
        Button categoryClothesButton;
        Label categoryClothesText;
        Button categoryTransportButton;
        Label categoryTransportText;
        Button categoryHealthButton;
        Label categoryHealthText;
        Button categorySchoolButton;
        Label categorySchoolText;
        Button categoryBillsButton;
        Label categoryBillsText;
        Button categoryEntertainmentButton;
        Label categoryEntertainmentText;
        Button categoryOtherButton;
        Label categoryOtherText;

        private void LoadExpenseCategoryPage(string previous)
        {
            Controls.Clear();
            LoadEscapeButton();
            _previousPage = previous;

            chooseCategoryTextLabel = CreateClassicLabel("chooseCategoryTextLabel", "Choose Category:", firstColor, lilitaOne, 24F, ClientSize.Width, 45, 0, 75, 1);

            categoryGroceriesButton = CreateCategoryButton("Groceries", 1, 1, Properties.Resources.GroceriesButton);
            categoryGroceriesText = CreateCategoryText("categoryGroceriesText", 1, 1, "groceries");

            categoryRestaurantButton = CreateCategoryButton("Restaurant", 1, 2, Properties.Resources.RestaurantButton);
            categoryRestaurantText = CreateCategoryText("categoryRestaurantText", 1, 2, "restaurant");

            categoryClothesButton = CreateCategoryButton("Clothes", 2, 1, Properties.Resources.ClothesButton);
            categoryClothesText = CreateCategoryText("categoryClothesText", 2, 1, "clothes");

            categoryTransportButton = CreateCategoryButton("Transport", 2, 2, Properties.Resources.TransportButton);
            categoryTransportText = CreateCategoryText("categoryTransportText", 2, 2, "transport");

            categoryHealthButton = CreateCategoryButton("Health", 3, 1, Properties.Resources.HealthButton);
            categoryHealthText = CreateCategoryText("categoryHealthText", 3, 1, "health");

            categorySchoolButton = CreateCategoryButton("School", 3, 2, Properties.Resources.SchoolButton);
            categorySchoolText = CreateCategoryText("categorySchoolText", 3, 2, "school");

            categoryBillsButton = CreateCategoryButton("Bills", 4, 1, Properties.Resources.BillsButton);
            categoryBillsText = CreateCategoryText("categoryBillsText", 4, 1, "bills");

            categoryEntertainmentButton = CreateCategoryButton("Entertainment", 4, 2, Properties.Resources.EntertainmentButton);
            categoryEntertainmentText = CreateCategoryText("categoryEntertainmentText", 4, 2, "entertainment");

            categoryOtherButton = CreateCategoryButton("Other", 5, 1, Properties.Resources.OtherExpenseButton);
            categoryOtherButton.Left = 125;

            categoryOtherText = CreateCategoryText("categoryOtherText", 5, 1, "other");
            categoryOtherText.Left = 120;



            Controls.Add(chooseCategoryTextLabel);

            Controls.Add(categoryGroceriesButton);
            Controls.Add(categoryRestaurantButton);
            Controls.Add(categoryClothesButton);
            Controls.Add(categoryTransportButton);
            Controls.Add(categoryHealthButton);
            Controls.Add(categorySchoolButton);
            Controls.Add(categoryBillsButton);
            Controls.Add(categoryEntertainmentButton);
            Controls.Add(categoryOtherButton);

            Controls.Add(categoryGroceriesText);
            Controls.Add(categoryRestaurantText);
            Controls.Add(categoryClothesText);
            Controls.Add(categoryTransportText);
            Controls.Add(categoryHealthText);
            Controls.Add(categorySchoolText);
            Controls.Add(categoryBillsText);
            Controls.Add(categoryEntertainmentText);
            Controls.Add(categoryOtherText);
            ResumeLayout(false);
            PerformLayout();
        }

    }
}
