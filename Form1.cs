using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartSaver
{
    public partial class Form1 : Form
    {
        string[] categories = {
            "Food",
            "Clothes",
            "Bills",
            "Other"};
        DataManager man;
        public Form1()
        {
            InitializeComponent();
            man = new DataManager();
        }

        public string giveCategories()
        {
            string allcat = "";
            foreach (string element in categories)
            {
                allcat = allcat + "$" + element;
            }
            return allcat;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String answer = ">" + DateTime.Now + "$" + nameP.Text + "$" + priceP.Text + "$" + categoryP.Text + "$";
            if (!System.Text.RegularExpressions.Regex.IsMatch(priceP.Text, @"\d.")) {
                statScreen.Text = "Price must be a number!";
                return;
            }
            statScreen.Text = nameP.Text + " was successfully added!";
            nameP.Text = " ";
            priceP.Text = " ";
            categoryP.Text = "Other";
            man.write(answer);
        }

        private void showData_Click(object sender, EventArgs e)
        {
            String data = man.giveData();
            statScreen.Text = data;
        }

        private void showStat_Click(object sender, EventArgs e)
        {
            String data = man.giveAnalisis();
            statScreen.Text = data;
        }

    }
}
