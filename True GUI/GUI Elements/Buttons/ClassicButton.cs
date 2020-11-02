using System.Drawing;
using System.Windows.Forms;

namespace Plutus
{
    public partial class TrueGUI : Form
    {
        private Button CreateClassicButton(string name, string text, Color fontColor, FontFamily fontFamily, float fontSize, Color backColor, int width, int height, int left, int top, int tabIndex, ContentAlignment contentAlignment = ContentAlignment.MiddleCenter)
        {
            var classicButton = new Button
            {
                Name = name,
                Text = text,
                ForeColor = fontColor,
                Font = new Font(fontFamily, fontSize, FontStyle.Regular, GraphicsUnit.Point),
                TextAlign = contentAlignment,
                BackColor = backColor,
                Width = width,
                Height = height,
                Left = left,
                Top = top,
                TabIndex = tabIndex,
                FlatStyle = FlatStyle.Flat
            };
            classicButton.FlatAppearance.BorderSize = 0;
            return classicButton;
        }

        private Button CreateClassicButton(string name, Image image, int left, int top, int tabIndex, bool autoSize = true, int width = 0, int height = 0)
        {
            var classicButton = new Button
            {
                Name = name,
                Image = image,
                AutoSize = autoSize,
                Width = width,
                Height = height,
                Left = left,
                Top = top,
                TabIndex = tabIndex,
                FlatStyle = FlatStyle.Flat
            };
            classicButton.FlatAppearance.BorderSize = 0;
            return classicButton;
        }


    }
}
