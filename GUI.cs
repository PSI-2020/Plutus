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
        DataManager manager = new DataManager();
        public GUI()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String answer = ">" + DateTime.Now + "$" + nameP.Text + "$" + priceP.Text + "$" + categoryP.Text + "$";
            if (nameP.Text.Length == 0 || nameP.Text == null)
            {
                statScreen.Text = "Name cannot be empty!";
                return;
            }
            if (!System.Text.RegularExpressions.Regex.IsMatch(priceP.Text, @"\d."))
            {
                statScreen.Text = "Price must be a number!";
                return;
            }
            if (categoryP.Text.Length == 0 || categoryP == null)
            {
                statScreen.Text = "Please choose a category!";
                return;
            }
            statScreen.Text = nameP.Text + " was successfully added!";
            nameP.Text = null;
            priceP.Text = null;
            categoryP.Text = null;
            manager.Write(answer);
        }

        private void showData_Click(object sender, EventArgs e)
        {
            String data = manager.GiveData();
            string[] db = data.Split('$');

            data = "";
            for (int i = 0; i < db.Length - 4; i += 4)
            {
                string date = db[i].Replace(">", "");
                string name = db[i + 1];
                double price = Convert.ToDouble(db[i + 2]);
                string category = db[i + 3];

                data += date + " | " + name + " | " + price + "€ | " + category;
            }
            statScreen.Text = data;
        }

        private void showStat_Click(object sender, EventArgs e)
        {
            String data = manager.GiveAnalisis();
            statScreen.Text = data;
        }

    }
}
