using System;
using System.Windows.Forms;

namespace Plutus
{
    enum Categories
    {
        Food,
        Clothes,
        Bills,
        Other
    }
    public partial class GUI : Form
    {
        readonly DataManager manager = new DataManager();
        public GUI() => InitializeComponent();

        private void Button1_Click(object sender, EventArgs e)
        {
            var answer = ">" + DateTime.Now + "$" + nameP.Text + "$" + priceP.Text + "$" + categoryP.Text + "$";
            if (nameP.Text.Length == 0 || nameP.Text == null)
            {
                errorField.Text = "Name cannot be empty!";
                return;
            }

            if (!Double.TryParse(priceP.Text, out _))
            {
                errorField.Text = "Price must be a number!";
                return;
            }
            if (categoryP.Text.Length == 0 || categoryP == null)
            {
                errorField.Text = "Please choose a category!";
                return;
            }
            manager.WriteFile(manager.expenses, answer);
            errorField.Text = nameP.Text + " was successfully added!";
            nameP.Text = null;
            priceP.Text = null;
            categoryP.Text = null;
        }

        private void ShowData_Click(object sender, EventArgs e)
        {
            var db = manager.ReadData(manager.expenses);
            var data = "";

            for (var i = 0; i < db.Length - 4; i += 4)
            {
                var date = db[i].Replace(">", "");
                var name = db[i + 1];
                var price = db[i + 2];
                var category = db[i + 3];

                data += date + " | " + name + " | " + price + "€ | " + category;
            }
            statScreen.Text = data;
        }

        private void ShowStat_Click(object sender, EventArgs e)
        {
            var data = manager.GiveAnalisis(manager.expenses);
            statScreen.Text = data;
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void incomeAdd_Click(object sender, EventArgs e)
        {
            var answer = ">" + DateTime.Now + "$" + incomeSum.Text + "$" + incomeCat.Text + "$";
            if (incomeCat.Text.Length == 0 || incomeCat == null)
            {
                errorField2.Text = "Please choose a category!";
                return;
            }
            if (incomeSum.Text.Length == 0 || incomeSum == null)
            {
                errorField2.Text = "Please enter a sum!";
                return;
            }
            if (!Double.TryParse(incomeSum.Text, out _))
            {
                errorField2.Text = "Price must be a number!";
                return;
            }
            manager.WriteFile(manager.income, answer);
            errorField2.Text = "Sum was added successfully!";
            incomeSum.Clear();
            incomeCat.Text = null;
        }

        private void incomeShow_Click(object sender, EventArgs e)
        {
            var db = manager.ReadData(manager.income);
            var data = "";

            for (var i = 0; i < db.Length - 3; i += 3)
            {
                var date = db[i].Replace(">", "");
                var sum = db[i + 1];
                var category = db[i + 2];

                data += date  + " | " + sum + "€ | " + category;
            }
            statScreen.Text = data;
        }
    }
}
