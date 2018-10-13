using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TempleteMatchingTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void test()
        {
            Emgu.CV.Image<Emgu.CV.Structure.Bgr, byte> m_Image = new Emgu.CV.Image<Emgu.CV.Structure.Bgr, byte>(@"C:\Users\Public\Documents\MVTec\HALCON-13.0\examples\images\color\clamp_pile_03.png");

            //ZoomPanROIPictureBox_OriginalImage.Image

        }
    }
}
