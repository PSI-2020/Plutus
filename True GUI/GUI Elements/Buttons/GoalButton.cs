using System.Drawing;
using System.Windows.Forms;

namespace Plutus
{
    public class GoalButton : Button
    {
        public Goal Goal { get; set; }

        public GoalButton(string text, Color fontColor, FontFamily fontFamily, float fontSize, Color backColor, int width, int height, Goal goal)
        {
            Text = text;
            ForeColor = fontColor;
            Font = new Font(fontFamily, fontSize, FontStyle.Regular, GraphicsUnit.Point);
            BackColor = backColor;
            Width = width;
            Height = height;
            Goal = goal;
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;
        }


    }
}
