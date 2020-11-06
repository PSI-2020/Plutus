using System;
using System.Drawing;
using System.Windows.Forms;

namespace Plutus
{  
    public partial class TrueGUI : Form
    {
        private Button CreateCategoryButton(string category, int eil, int stu, Image image, int addTop = 0)
        {
            var left = (stu == 1) ? 53 : 198;
            var top = 140 + (135 * (eil - 1));
            var tabIndex =  1 + (eil * 2) + stu;
            top += addTop;

            var categoryButton = new Button
            {
                Name = "categoryButton" + '|' + category,
                Width = 108,
                Height = 94,
                FlatStyle = FlatStyle.Flat,
                Left = left,
                Top = top,
                Image = image,
                TabIndex = tabIndex,
                BackgroundImage = Properties.Resources.ButtonBackground
            };
            categoryButton.FlatAppearance.BorderSize = 0;
            categoryButton.Click += new EventHandler(CategoryButton_Click);
            return categoryButton;
        }

        private Label CreateCategoryText(string name, int eil, int stu, string text, int addTop = 0)
        {
            var left = (stu == 1) ? 48 : 193;
            var top = 235 + (135 * (eil - 1));
            top += addTop;

            var categoryLabel = new Label
            {
                Name = name,
                Size = new Size(123, 30),
                Text = text,
                TextAlign = ContentAlignment.MiddleCenter,
                ForeColor = firstColor,
                Font = new Font(lilitaOne, 12F, FontStyle.Regular, GraphicsUnit.Point),
                Location = new Point(left, top)
            };
            return categoryLabel;
        }


        private void CategoryButton_Click(object sender, EventArgs e)
        {
            var catButton = (Button)sender;
            var name = catButton.Name;
            var nameParts = name.Split('|');
            var category = nameParts[1];
            _currentInfo.CurrentCategory = category;
            Controls.Clear();
            LoadCategoryBack();
        }

        private void LoadCategoryBack()
        {
            switch (_previousPage)
            {
                case "newCart":
                    CartNewExpenseFields();
                    break;
                default:
                    AddFieldsToCurrentPayment();
                    break;
            }
        }
    }
}
