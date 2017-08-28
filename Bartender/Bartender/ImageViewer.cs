using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bartender
{
    public partial class ImageViewer : Form
    {
        public ImageViewer(string path)
        {
            InitializeComponent();

            pictureBox1.Image = Image.FromFile(path);


        }
    }
}
