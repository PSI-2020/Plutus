using System.Drawing;
using System.Windows.Forms;

namespace Plutus
{
    public partial class TrueGUI : Form
    {
        private Label CreateClassicLine(string name, int width, int height, int left, int top, Color color)
        {
            var classicLabel = new Label
            {
                AutoSize = false,
                Name = name,
                BackColor = color,
                Width = width,
                Height = height,
                Left = left,
                Top = top,
                Margin = new Padding(0)
            };
            return classicLabel;
        }
    }
}
