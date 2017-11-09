using System.Drawing;
using System.Windows.Forms;

namespace Bartender
{
    public partial class ImageViewer : Form
    {
        public ImageViewer(string path)
        {
            InitializeComponent();

            if (path == null || path.Length == 0)
            {
                pictureBox1.Image = Image.FromFile("no_image_available.jpeg");
            }
            else
            {
                pictureBox1.Image = Image.FromFile(path);
            }
        }
    }
}
