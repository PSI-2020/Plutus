using System.Drawing;
using System.Windows.Forms;

namespace Plutus
{
    public partial class TrueGUI : Form
    {
        private Label CreateClassicLabel(string name, string text, Color fontColor, FontFamily fontFamily, float fontSize, int width, int height, int left, int top, int tabIndex, ContentAlignment contentAlignment = ContentAlignment.MiddleCenter)
        {
            var classicLabel = new Label
            {
                AutoSize = false,
                Name = name,
                Text = text,
                ForeColor = fontColor,
                Font = new Font(fontFamily, fontSize, FontStyle.Regular, GraphicsUnit.Point),
                TextAlign = contentAlignment,
                Width = width,
                Height = height,
                Left = left,
                Top = top,
                TabIndex = tabIndex
            };
            return classicLabel;
        }
    }
}
