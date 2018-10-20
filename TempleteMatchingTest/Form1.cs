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
<<<<<<< HEAD
        Emgu.CV.Image<Emgu.CV.Structure.Bgr, byte> m_Image = new Emgu.CV.Image<Emgu.CV.Structure.Bgr, byte>(@"C:\Users\kchang\Desktop\temp.jpg");
=======
        Emgu.CV.Image<Emgu.CV.Structure.Bgr, byte> m_Image;
        Emgu.CV.Image<Emgu.CV.Structure.Bgr, byte> m_Templete;
        Emgu.CV.CvEnum.TemplateMatchingType m_TempleteMatchingType = Emgu.CV.CvEnum.TemplateMatchingType.CcoeffNormed;
>>>>>>> 91ee7e62267f407e02a0c61124d3020a66beca79
        public Form1()
        {
            InitializeComponent();
            
            ZoomPanROIPictureBox_OriginalImage.SetPictureBoxProperty(true, true, true, true);
            ZoomPanROIPictureBox_TempleteImage.SetPictureBoxProperty(false, false, false, false);

            RadioButton_CVTMCCOEFFNORMED.Checked = true;
            
            
            TextBox_TempleteMatchingThreadhold.Text = "0.9";
            TextBox_TempleteMatchingNumber.Text = "5";
            CheckBox_IsUsePyramidTempleteMatching.Checked = false;
            TextBox_TempleteMatchingPyramidLevel.Text = "5";

            ListView_TempleteMatchingResult.Columns.Add("Index", 100, HorizontalAlignment.Center);
            ListView_TempleteMatchingResult.Columns.Add("Score", 100, HorizontalAlignment.Center);
            ListView_TempleteMatchingResult.Columns.Add("X", 100, HorizontalAlignment.Center);
            ListView_TempleteMatchingResult.Columns.Add("Y", 100, HorizontalAlignment.Center);

            //List<Rectangle> t_Temp = ZoomPanROIPictureBox_OriginalImage.GetROI();
            //t_Temp.Add(new Rectangle(500, 100, 500, 100));
            //ZoomPanROIPictureBox_ProcessedImage.Image = m_Image.ToBitmap();
            //ZoomPanROIPictureBox_TempleteImage.Image = m_Image.ToBitmap();
        }

        private void TimerEventProcessor(Object MyObject, EventArgs MyEventArgs)
        {

            m_Image = new Emgu.CV.Image<Emgu.CV.Structure.Bgr, byte>(LibUtility.ClassUtility.GetImageFromURL());
            ZoomPanROIPictureBox_OriginalImage.Image = m_Image.ToBitmap();
        }
        
        private void Button_GetTempleteImageFromMemory_Click(object sender, EventArgs e)
        {
            
            List<Rectangle> t_Temp = ZoomPanROIPictureBox_OriginalImage.GetROI();
            m_Templete = m_Image.GetSubRect(t_Temp[0]).Clone();
            ZoomPanROIPictureBox_OriginalImage.ClearROI();
            ZoomPanROIPictureBox_TempleteImage.Image = m_Templete.ToBitmap();
            ZoomPanROIPictureBox_OriginalImage.ClearROI();
        }

        private void Button_StartVideoStream_Click(object sender, EventArgs e)
        {
            m_Timer.Tick += TimerEventProcessor;
            m_Timer.Interval = 100;
            m_Timer.Start();
        }

        private void Button_DoTempleteMatching_Click(object sender, EventArgs e)
        {
            ZoomPanROIPictureBox_OriginalImage.ClearROI();
            List<LibUtility.ClassUtility.TempleteMatchingBestOrder> t_SortBestOrder = LibUtility.ClassUtility.DoTempleteMatching(
                m_Image,
                m_Templete, 
                m_TempleteMatchingType,
                float.Parse(TextBox_TempleteMatchingThreadhold.Text),
                int.Parse(TextBox_TempleteMatchingNumber.Text),
                CheckBox_IsUsePyramidTempleteMatching.Checked,
                int.Parse(TextBox_TempleteMatchingPyramidLevel.Text)
                );
            ListView_TempleteMatchingResult.Items.Clear();
            for (int i = 0; i < t_SortBestOrder.Count; i++)
            {
                ZoomPanROIPictureBox_OriginalImage.SetROI(new Rectangle(t_SortBestOrder[i].s_Location, m_Templete.Size));
                ListViewItem t_Item = new ListViewItem(i.ToString());
                t_Item.SubItems.Add(t_SortBestOrder[i].s_Score.ToString());
                t_Item.SubItems.Add(t_SortBestOrder[i].s_Location.X.ToString());
                t_Item.SubItems.Add(t_SortBestOrder[i].s_Location.Y.ToString());
                ListView_TempleteMatchingResult.Items.Add(t_Item);
            }
            
            
            //if (t_SortBestOrder.Count == 0)
            //{
            //    MessageBox.Show("No Matching");
            //}
        }

        private void Button_ClearAllROI_Click(object sender, EventArgs e)
        {
            ZoomPanROIPictureBox_OriginalImage.ClearROI();
        }

        private void RadioButton_CVTMSQDIFF_CheckedChanged(object sender, EventArgs e)
        {
            m_TempleteMatchingType = Emgu.CV.CvEnum.TemplateMatchingType.Sqdiff;
        }

        private void RadioButton_CVTMCCORR_CheckedChanged(object sender, EventArgs e)
        {
            m_TempleteMatchingType = Emgu.CV.CvEnum.TemplateMatchingType.Ccorr;
        }

        private void RadioButton_CVTMCCOEFF_CheckedChanged(object sender, EventArgs e)
        {
            m_TempleteMatchingType = Emgu.CV.CvEnum.TemplateMatchingType.Ccoeff;
        }

        private void RadioButton_CVTMSQDIFFNORMED_CheckedChanged(object sender, EventArgs e)
        {
            m_TempleteMatchingType = Emgu.CV.CvEnum.TemplateMatchingType.SqdiffNormed;
        }

        private void RadioButton_CVTMCCORRNORMED_CheckedChanged(object sender, EventArgs e)
        {
            m_TempleteMatchingType = Emgu.CV.CvEnum.TemplateMatchingType.CcorrNormed;
        }
        
        private void RadioButton_CVTMCCOEFFNORMED_CheckedChanged(object sender, EventArgs e)
        {
            m_TempleteMatchingType = Emgu.CV.CvEnum.TemplateMatchingType.CcoeffNormed;
        }

        private void Button_StopVideoStream_Click(object sender, EventArgs e)
        {
            m_Timer.Stop();
        }

        private void Button_GetTempleteImageFromFile_Click(object sender, EventArgs e)
        {

        }

        private void Button_FitOriginalImage_Click(object sender, EventArgs e)
        {
            ZoomPanROIPictureBox_OriginalImage.FitImageToCenter();
        }

        private void Button_SaveTempleteImage_Click(object sender, EventArgs e)
        {
            string t_SaveImagePath = LibUtility.ClassUtility.SaveImageFile();
            this.m_Templete.Save(t_SaveImagePath);
        }
    }
}
