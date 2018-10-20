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
        Timer m_Timer = new Timer();
        Emgu.CV.Image<Emgu.CV.Structure.Bgr, byte> m_Image = new Emgu.CV.Image<Emgu.CV.Structure.Bgr, byte>(@"C:\Users\kchang\Desktop\temp.jpg");
        public Form1()
        {
            InitializeComponent();

            ZoomPanROIPictureBox_OriginalImage.SetPictureBoxProperty(true, true, true, true);
            ZoomPanROIPictureBox_ProcessedImage.SetPictureBoxProperty(true, true, true, true);
            ZoomPanROIPictureBox_TempleteImage.SetPictureBoxProperty(false, false, false, false);

            ZoomPanROIPictureBox_OriginalImage.Image = m_Image.ToBitmap();
            //List<Rectangle> t_Temp = ZoomPanROIPictureBox_OriginalImage.GetROI();
            //t_Temp.Add(new Rectangle(500, 100, 500, 100));
            ZoomPanROIPictureBox_ProcessedImage.Image = m_Image.ToBitmap();
            ZoomPanROIPictureBox_TempleteImage.Image = m_Image.ToBitmap();

            m_Timer.Tick += TimerEventProcessor;
            m_Timer.Interval = 1000;
            m_Timer.Start();
        }
        private void TimerEventProcessor(Object MyObject, EventArgs MyEventArgs)
        {

            List<Rectangle> t_Temp = ZoomPanROIPictureBox_OriginalImage.GetROI();
            if (t_Temp.Count != 0)
            {
                ZoomPanROIPictureBox_TempleteImage.Image = m_Image.GetSubRect(t_Temp[0]).ToBitmap();
                List<LibUtility.ClassUtility.TempleteMatchingBestOrder> t_SortBestOrder = LibUtility.ClassUtility.DoTempleteMatching(m_Image.Convert<Emgu.CV.Structure.Gray, byte>(), m_Image.GetSubRect(t_Temp[0]).Clone().Convert<Emgu.CV.Structure.Gray, Byte>(), Emgu.CV.CvEnum.TemplateMatchingType.CcoeffNormed, 0.9F,10);
                for (int i = 0; i < t_SortBestOrder.Count; i++)
                {
                    ZoomPanROIPictureBox_ProcessedImage.SetROI(new Rectangle(t_SortBestOrder[i].s_Location, new Size(10, 10)));
                }
            }

        }
      
    }
}
