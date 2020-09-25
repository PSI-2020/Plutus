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
            errorField.Text = nameP.Text + " was successfully added!";
            nameP.Text = null;
            priceP.Text = null;
            categoryP.Text = null;
            manager.Write(answer);
        }

        private void showData_Click(object sender, EventArgs e)
        {
            var data = manager.GiveData();
            var db = data.Split('$');

            data = "";
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
            var data = manager.GiveAnalisis();
            statScreen.Text = data;
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }
    }
}
