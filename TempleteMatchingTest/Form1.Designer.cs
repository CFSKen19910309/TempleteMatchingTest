namespace TempleteMatchingTest
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.ZoomPanROIPictureBox_OriginalImage = new LibUtility.ZoomPanROIPictureBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.ListView_TempleteMatchingResult = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.Button_ClearAllROI = new System.Windows.Forms.Button();
            this.Button_SaveTempleteImage = new System.Windows.Forms.Button();
            this.Button_DoTempleteMatching = new System.Windows.Forms.Button();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.Button_StartVideoStream = new System.Windows.Forms.Button();
            this.button_StopVideoStream = new System.Windows.Forms.Button();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.Button_GetTempleteImageFromMemory = new System.Windows.Forms.Button();
            this.Button_GetTempleteImageFromFile = new System.Windows.Forms.Button();
            this.Button_FitOriginalImage = new System.Windows.Forms.Button();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.ZoomPanROIPictureBox_TempleteImage = new LibUtility.ZoomPanROIPictureBox();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.TabPage_TempleteMatchingSettingPage = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.GroupBox_TempleteMatchingMode = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.RadioButton_CVTMSQDIFF = new System.Windows.Forms.RadioButton();
            this.RadioButton_CVTMCCORR = new System.Windows.Forms.RadioButton();
            this.RadioButton_CVTMCCOEFF = new System.Windows.Forms.RadioButton();
            this.RadioButton_CVTMSQDIFFNORMED = new System.Windows.Forms.RadioButton();
            this.RadioButton_CVTMCCORRNORMED = new System.Windows.Forms.RadioButton();
            this.RadioButton_CVTMCCOEFFNORMED = new System.Windows.Forms.RadioButton();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.TextBox_TempleteMatchingThreadhold = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TextBox_TempleteMatchingNumber = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.CheckBox_IsUsePyramidTempleteMatching = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TextBox_TempleteMatchingPyramidLevel = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ZoomPanROIPictureBox_OriginalImage)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ZoomPanROIPictureBox_TempleteImage)).BeginInit();
            this.TabControl.SuspendLayout();
            this.TabPage_TempleteMatchingSettingPage.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.GroupBox_TempleteMatchingMode.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.1709F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.51501F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.TabControl, 2, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.4411F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 73.5589F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1732, 798);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.ZoomPanROIPictureBox_OriginalImage, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel1.SetRowSpan(this.tableLayoutPanel2, 2);
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.319149F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 94.68085F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(569, 790);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(4, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(561, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Original Image :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ZoomPanROIPictureBox_OriginalImage
            // 
            this.ZoomPanROIPictureBox_OriginalImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ZoomPanROIPictureBox_OriginalImage.Location = new System.Drawing.Point(4, 44);
            this.ZoomPanROIPictureBox_OriginalImage.Margin = new System.Windows.Forms.Padding(4);
            this.ZoomPanROIPictureBox_OriginalImage.Name = "ZoomPanROIPictureBox_OriginalImage";
            this.tableLayoutPanel2.SetRowSpan(this.ZoomPanROIPictureBox_OriginalImage, 2);
            this.ZoomPanROIPictureBox_OriginalImage.Size = new System.Drawing.Size(561, 742);
            this.ZoomPanROIPictureBox_OriginalImage.TabIndex = 1;
            this.ZoomPanROIPictureBox_OriginalImage.TabStop = false;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.ListView_TempleteMatchingResult, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(1397, 4);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(331, 202);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // ListView_TempleteMatchingResult
            // 
            this.ListView_TempleteMatchingResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListView_TempleteMatchingResult.Location = new System.Drawing.Point(3, 23);
            this.ListView_TempleteMatchingResult.MultiSelect = false;
            this.ListView_TempleteMatchingResult.Name = "ListView_TempleteMatchingResult";
            this.ListView_TempleteMatchingResult.Size = new System.Drawing.Size(325, 176);
            this.ListView_TempleteMatchingResult.TabIndex = 0;
            this.ListView_TempleteMatchingResult.UseCompatibleStateImageBehavior = false;
            this.ListView_TempleteMatchingResult.View = System.Windows.Forms.View.Details;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(4, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(323, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Templete Matching Result";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.Button_ClearAllROI, 1, 4);
            this.tableLayoutPanel4.Controls.Add(this.Button_SaveTempleteImage, 1, 3);
            this.tableLayoutPanel4.Controls.Add(this.Button_DoTempleteMatching, 1, 2);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel6, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel7, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.Button_FitOriginalImage, 0, 3);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel8, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(581, 4);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 5;
            this.tableLayoutPanel1.SetRowSpan(this.tableLayoutPanel4, 2);
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(808, 790);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // Button_ClearAllROI
            // 
            this.Button_ClearAllROI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Button_ClearAllROI.Location = new System.Drawing.Point(407, 635);
            this.Button_ClearAllROI.Name = "Button_ClearAllROI";
            this.Button_ClearAllROI.Size = new System.Drawing.Size(398, 152);
            this.Button_ClearAllROI.TabIndex = 6;
            this.Button_ClearAllROI.Text = "Clear All ROI";
            this.Button_ClearAllROI.UseVisualStyleBackColor = true;
            this.Button_ClearAllROI.Click += new System.EventHandler(this.Button_ClearAllROI_Click);
            // 
            // Button_SaveTempleteImage
            // 
            this.Button_SaveTempleteImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Button_SaveTempleteImage.Location = new System.Drawing.Point(407, 477);
            this.Button_SaveTempleteImage.Name = "Button_SaveTempleteImage";
            this.Button_SaveTempleteImage.Size = new System.Drawing.Size(398, 152);
            this.Button_SaveTempleteImage.TabIndex = 7;
            this.Button_SaveTempleteImage.Text = "Save Templete Image";
            this.Button_SaveTempleteImage.UseVisualStyleBackColor = true;
            this.Button_SaveTempleteImage.Click += new System.EventHandler(this.Button_SaveTempleteImage_Click);
            // 
            // Button_DoTempleteMatching
            // 
            this.Button_DoTempleteMatching.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Button_DoTempleteMatching.Location = new System.Drawing.Point(407, 319);
            this.Button_DoTempleteMatching.Name = "Button_DoTempleteMatching";
            this.Button_DoTempleteMatching.Size = new System.Drawing.Size(398, 152);
            this.Button_DoTempleteMatching.TabIndex = 5;
            this.Button_DoTempleteMatching.Text = "Do Templete Matching";
            this.Button_DoTempleteMatching.UseVisualStyleBackColor = true;
            this.Button_DoTempleteMatching.Click += new System.EventHandler(this.Button_DoTempleteMatching_Click);
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Controls.Add(this.Button_StartVideoStream, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.button_StopVideoStream, 1, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(407, 3);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(398, 152);
            this.tableLayoutPanel6.TabIndex = 8;
            // 
            // Button_StartVideoStream
            // 
            this.Button_StartVideoStream.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Button_StartVideoStream.Location = new System.Drawing.Point(3, 3);
            this.Button_StartVideoStream.Name = "Button_StartVideoStream";
            this.Button_StartVideoStream.Size = new System.Drawing.Size(193, 146);
            this.Button_StartVideoStream.TabIndex = 6;
            this.Button_StartVideoStream.Text = "Start Video Stream";
            this.Button_StartVideoStream.UseVisualStyleBackColor = true;
            this.Button_StartVideoStream.Click += new System.EventHandler(this.Button_StartVideoStream_Click);
            // 
            // button_StopVideoStream
            // 
            this.button_StopVideoStream.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_StopVideoStream.Location = new System.Drawing.Point(202, 3);
            this.button_StopVideoStream.Name = "button_StopVideoStream";
            this.button_StopVideoStream.Size = new System.Drawing.Size(193, 146);
            this.button_StopVideoStream.TabIndex = 6;
            this.button_StopVideoStream.Text = "Stop Video Stream";
            this.button_StopVideoStream.UseVisualStyleBackColor = true;
            this.button_StopVideoStream.Click += new System.EventHandler(this.Button_StopVideoStream_Click);
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 2;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Controls.Add(this.Button_GetTempleteImageFromMemory, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.Button_GetTempleteImageFromFile, 1, 0);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(407, 161);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 1;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(398, 152);
            this.tableLayoutPanel7.TabIndex = 8;
            // 
            // Button_GetTempleteImageFromMemory
            // 
            this.Button_GetTempleteImageFromMemory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Button_GetTempleteImageFromMemory.Location = new System.Drawing.Point(3, 3);
            this.Button_GetTempleteImageFromMemory.Name = "Button_GetTempleteImageFromMemory";
            this.Button_GetTempleteImageFromMemory.Size = new System.Drawing.Size(193, 146);
            this.Button_GetTempleteImageFromMemory.TabIndex = 4;
            this.Button_GetTempleteImageFromMemory.Text = "Get Templete Image From Memory";
            this.Button_GetTempleteImageFromMemory.UseVisualStyleBackColor = true;
            this.Button_GetTempleteImageFromMemory.Click += new System.EventHandler(this.Button_GetTempleteImageFromMemory_Click);
            // 
            // Button_GetTempleteImageFromFile
            // 
            this.Button_GetTempleteImageFromFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Button_GetTempleteImageFromFile.Location = new System.Drawing.Point(202, 3);
            this.Button_GetTempleteImageFromFile.Name = "Button_GetTempleteImageFromFile";
            this.Button_GetTempleteImageFromFile.Size = new System.Drawing.Size(193, 146);
            this.Button_GetTempleteImageFromFile.TabIndex = 4;
            this.Button_GetTempleteImageFromFile.Text = "Get Templete Image From File";
            this.Button_GetTempleteImageFromFile.UseVisualStyleBackColor = true;
            this.Button_GetTempleteImageFromFile.Click += new System.EventHandler(this.Button_GetTempleteImageFromFile_Click);
            // 
            // Button_FitOriginalImage
            // 
            this.Button_FitOriginalImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Button_FitOriginalImage.Location = new System.Drawing.Point(3, 477);
            this.Button_FitOriginalImage.Name = "Button_FitOriginalImage";
            this.Button_FitOriginalImage.Size = new System.Drawing.Size(398, 152);
            this.Button_FitOriginalImage.TabIndex = 9;
            this.Button_FitOriginalImage.Text = "Fit Original Image";
            this.Button_FitOriginalImage.UseVisualStyleBackColor = true;
            this.Button_FitOriginalImage.Click += new System.EventHandler(this.Button_FitOriginalImage_Click);
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 1;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel8.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel8.Controls.Add(this.ZoomPanROIPictureBox_TempleteImage, 0, 1);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 2;
            this.tableLayoutPanel4.SetRowSpan(this.tableLayoutPanel8, 3);
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(398, 468);
            this.tableLayoutPanel8.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(4, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(390, 46);
            this.label3.TabIndex = 2;
            this.label3.Text = "Templete Image";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ZoomPanROIPictureBox_TempleteImage
            // 
            this.ZoomPanROIPictureBox_TempleteImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ZoomPanROIPictureBox_TempleteImage.Location = new System.Drawing.Point(4, 50);
            this.ZoomPanROIPictureBox_TempleteImage.Margin = new System.Windows.Forms.Padding(4);
            this.ZoomPanROIPictureBox_TempleteImage.Name = "ZoomPanROIPictureBox_TempleteImage";
            this.ZoomPanROIPictureBox_TempleteImage.Size = new System.Drawing.Size(390, 414);
            this.ZoomPanROIPictureBox_TempleteImage.TabIndex = 3;
            this.ZoomPanROIPictureBox_TempleteImage.TabStop = false;
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.TabPage_TempleteMatchingSettingPage);
            this.TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl.Location = new System.Drawing.Point(1396, 213);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(333, 582);
            this.TabControl.TabIndex = 2;
            // 
            // TabPage_TempleteMatchingSettingPage
            // 
            this.TabPage_TempleteMatchingSettingPage.Controls.Add(this.tableLayoutPanel5);
            this.TabPage_TempleteMatchingSettingPage.Location = new System.Drawing.Point(4, 28);
            this.TabPage_TempleteMatchingSettingPage.Name = "TabPage_TempleteMatchingSettingPage";
            this.TabPage_TempleteMatchingSettingPage.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage_TempleteMatchingSettingPage.Size = new System.Drawing.Size(325, 550);
            this.TabPage_TempleteMatchingSettingPage.TabIndex = 0;
            this.TabPage_TempleteMatchingSettingPage.Text = "Templete Matching Setting Page";
            this.TabPage_TempleteMatchingSettingPage.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.GroupBox_TempleteMatchingMode, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.flowLayoutPanel3, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.flowLayoutPanel4, 0, 2);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 3;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(319, 544);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // GroupBox_TempleteMatchingMode
            // 
            this.GroupBox_TempleteMatchingMode.Controls.Add(this.flowLayoutPanel1);
            this.GroupBox_TempleteMatchingMode.Controls.Add(this.flowLayoutPanel2);
            this.GroupBox_TempleteMatchingMode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroupBox_TempleteMatchingMode.Location = new System.Drawing.Point(3, 3);
            this.GroupBox_TempleteMatchingMode.Name = "GroupBox_TempleteMatchingMode";
            this.GroupBox_TempleteMatchingMode.Size = new System.Drawing.Size(313, 266);
            this.GroupBox_TempleteMatchingMode.TabIndex = 0;
            this.GroupBox_TempleteMatchingMode.TabStop = false;
            this.GroupBox_TempleteMatchingMode.Text = "Templete Matching Mode";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.RadioButton_CVTMSQDIFF);
            this.flowLayoutPanel1.Controls.Add(this.RadioButton_CVTMCCORR);
            this.flowLayoutPanel1.Controls.Add(this.RadioButton_CVTMCCOEFF);
            this.flowLayoutPanel1.Controls.Add(this.RadioButton_CVTMSQDIFFNORMED);
            this.flowLayoutPanel1.Controls.Add(this.RadioButton_CVTMCCORRNORMED);
            this.flowLayoutPanel1.Controls.Add(this.RadioButton_CVTMCCOEFFNORMED);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 25);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(307, 238);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // RadioButton_CVTMSQDIFF
            // 
            this.RadioButton_CVTMSQDIFF.AutoSize = true;
            this.RadioButton_CVTMSQDIFF.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RadioButton_CVTMSQDIFF.Location = new System.Drawing.Point(3, 3);
            this.RadioButton_CVTMSQDIFF.Name = "RadioButton_CVTMSQDIFF";
            this.RadioButton_CVTMSQDIFF.Size = new System.Drawing.Size(159, 22);
            this.RadioButton_CVTMSQDIFF.TabIndex = 0;
            this.RadioButton_CVTMSQDIFF.TabStop = true;
            this.RadioButton_CVTMSQDIFF.Text = "CV_TM_SQDIFF ";
            this.RadioButton_CVTMSQDIFF.UseVisualStyleBackColor = true;
            this.RadioButton_CVTMSQDIFF.CheckedChanged += new System.EventHandler(this.RadioButton_CVTMSQDIFF_CheckedChanged);
            // 
            // RadioButton_CVTMCCORR
            // 
            this.RadioButton_CVTMCCORR.AutoSize = true;
            this.RadioButton_CVTMCCORR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RadioButton_CVTMCCORR.Location = new System.Drawing.Point(3, 31);
            this.RadioButton_CVTMCCORR.Name = "RadioButton_CVTMCCORR";
            this.RadioButton_CVTMCCORR.Size = new System.Drawing.Size(158, 22);
            this.RadioButton_CVTMCCORR.TabIndex = 0;
            this.RadioButton_CVTMCCORR.TabStop = true;
            this.RadioButton_CVTMCCORR.Text = "CV_TM_CCORR ";
            this.RadioButton_CVTMCCORR.UseVisualStyleBackColor = true;
            this.RadioButton_CVTMCCORR.CheckedChanged += new System.EventHandler(this.RadioButton_CVTMCCORR_CheckedChanged);
            // 
            // RadioButton_CVTMCCOEFF
            // 
            this.RadioButton_CVTMCCOEFF.AutoSize = true;
            this.RadioButton_CVTMCCOEFF.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RadioButton_CVTMCCOEFF.Location = new System.Drawing.Point(3, 59);
            this.RadioButton_CVTMCCOEFF.Name = "RadioButton_CVTMCCOEFF";
            this.RadioButton_CVTMCCOEFF.Size = new System.Drawing.Size(159, 22);
            this.RadioButton_CVTMCCOEFF.TabIndex = 0;
            this.RadioButton_CVTMCCOEFF.TabStop = true;
            this.RadioButton_CVTMCCOEFF.Text = "CV_TM_CCOEFF";
            this.RadioButton_CVTMCCOEFF.UseVisualStyleBackColor = true;
            this.RadioButton_CVTMCCOEFF.CheckedChanged += new System.EventHandler(this.RadioButton_CVTMCCOEFF_CheckedChanged);
            // 
            // RadioButton_CVTMSQDIFFNORMED
            // 
            this.RadioButton_CVTMSQDIFFNORMED.AutoSize = true;
            this.RadioButton_CVTMSQDIFFNORMED.Location = new System.Drawing.Point(3, 87);
            this.RadioButton_CVTMSQDIFFNORMED.Name = "RadioButton_CVTMSQDIFFNORMED";
            this.RadioButton_CVTMSQDIFFNORMED.Size = new System.Drawing.Size(239, 22);
            this.RadioButton_CVTMSQDIFFNORMED.TabIndex = 0;
            this.RadioButton_CVTMSQDIFFNORMED.TabStop = true;
            this.RadioButton_CVTMSQDIFFNORMED.Text = "CV_TM_SQDIFF_NORMED ";
            this.RadioButton_CVTMSQDIFFNORMED.UseVisualStyleBackColor = true;
            this.RadioButton_CVTMSQDIFFNORMED.CheckedChanged += new System.EventHandler(this.RadioButton_CVTMSQDIFFNORMED_CheckedChanged);
            // 
            // RadioButton_CVTMCCORRNORMED
            // 
            this.RadioButton_CVTMCCORRNORMED.AutoSize = true;
            this.RadioButton_CVTMCCORRNORMED.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RadioButton_CVTMCCORRNORMED.Location = new System.Drawing.Point(3, 115);
            this.RadioButton_CVTMCCORRNORMED.Name = "RadioButton_CVTMCCORRNORMED";
            this.RadioButton_CVTMCCORRNORMED.Size = new System.Drawing.Size(238, 22);
            this.RadioButton_CVTMCCORRNORMED.TabIndex = 0;
            this.RadioButton_CVTMCCORRNORMED.TabStop = true;
            this.RadioButton_CVTMCCORRNORMED.Text = "CV_TM_CCORR_NORMED ";
            this.RadioButton_CVTMCCORRNORMED.UseVisualStyleBackColor = true;
            this.RadioButton_CVTMCCORRNORMED.CheckedChanged += new System.EventHandler(this.RadioButton_CVTMCCORRNORMED_CheckedChanged);
            // 
            // RadioButton_CVTMCCOEFFNORMED
            // 
            this.RadioButton_CVTMCCOEFFNORMED.AutoSize = true;
            this.RadioButton_CVTMCCOEFFNORMED.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RadioButton_CVTMCCOEFFNORMED.Location = new System.Drawing.Point(3, 143);
            this.RadioButton_CVTMCCOEFFNORMED.Name = "RadioButton_CVTMCCOEFFNORMED";
            this.RadioButton_CVTMCCOEFFNORMED.Size = new System.Drawing.Size(244, 22);
            this.RadioButton_CVTMCCOEFFNORMED.TabIndex = 1;
            this.RadioButton_CVTMCCOEFFNORMED.TabStop = true;
            this.RadioButton_CVTMCCOEFFNORMED.Text = "CV_TM_CCOEFF_NORMED ";
            this.RadioButton_CVTMCCOEFFNORMED.UseVisualStyleBackColor = true;
            this.RadioButton_CVTMCCOEFFNORMED.CheckedChanged += new System.EventHandler(this.RadioButton_CVTMCCOEFFNORMED_CheckedChanged);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 25);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(307, 238);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.label4);
            this.flowLayoutPanel3.Controls.Add(this.TextBox_TempleteMatchingThreadhold);
            this.flowLayoutPanel3.Controls.Add(this.label5);
            this.flowLayoutPanel3.Controls.Add(this.TextBox_TempleteMatchingNumber);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel3.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 275);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(313, 130);
            this.flowLayoutPanel3.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(229, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Templete Matching Threashold:";
            // 
            // TextBox_TempleteMatchingThreadhold
            // 
            this.TextBox_TempleteMatchingThreadhold.Location = new System.Drawing.Point(3, 21);
            this.TextBox_TempleteMatchingThreadhold.Name = "TextBox_TempleteMatchingThreadhold";
            this.TextBox_TempleteMatchingThreadhold.Size = new System.Drawing.Size(220, 29);
            this.TextBox_TempleteMatchingThreadhold.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(208, 18);
            this.label5.TabIndex = 2;
            this.label5.Text = "Templete Matching Number:";
            // 
            // TextBox_TempleteMatchingNumber
            // 
            this.TextBox_TempleteMatchingNumber.Location = new System.Drawing.Point(3, 74);
            this.TextBox_TempleteMatchingNumber.Name = "TextBox_TempleteMatchingNumber";
            this.TextBox_TempleteMatchingNumber.Size = new System.Drawing.Size(218, 29);
            this.TextBox_TempleteMatchingNumber.TabIndex = 1;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Controls.Add(this.CheckBox_IsUsePyramidTempleteMatching);
            this.flowLayoutPanel4.Controls.Add(this.label6);
            this.flowLayoutPanel4.Controls.Add(this.TextBox_TempleteMatchingPyramidLevel);
            this.flowLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel4.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(3, 411);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(313, 130);
            this.flowLayoutPanel4.TabIndex = 2;
            // 
            // CheckBox_IsUsePyramidTempleteMatching
            // 
            this.CheckBox_IsUsePyramidTempleteMatching.Appearance = System.Windows.Forms.Appearance.Button;
            this.CheckBox_IsUsePyramidTempleteMatching.AutoSize = true;
            this.CheckBox_IsUsePyramidTempleteMatching.Location = new System.Drawing.Point(3, 3);
            this.CheckBox_IsUsePyramidTempleteMatching.Name = "CheckBox_IsUsePyramidTempleteMatching";
            this.CheckBox_IsUsePyramidTempleteMatching.Size = new System.Drawing.Size(265, 28);
            this.CheckBox_IsUsePyramidTempleteMatching.TabIndex = 0;
            this.CheckBox_IsUsePyramidTempleteMatching.Text = "Is Use Pyramid Templete Matching";
            this.CheckBox_IsUsePyramidTempleteMatching.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(254, 18);
            this.label6.TabIndex = 0;
            this.label6.Text = "Templete Matching Pyramid Level:";
            // 
            // TextBox_TempleteMatchingPyramidLevel
            // 
            this.TextBox_TempleteMatchingPyramidLevel.Location = new System.Drawing.Point(3, 55);
            this.TextBox_TempleteMatchingPyramidLevel.Name = "TextBox_TempleteMatchingPyramidLevel";
            this.TextBox_TempleteMatchingPyramidLevel.Size = new System.Drawing.Size(216, 29);
            this.TextBox_TempleteMatchingPyramidLevel.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1732, 798);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ZoomPanROIPictureBox_OriginalImage)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ZoomPanROIPictureBox_TempleteImage)).EndInit();
            this.TabControl.ResumeLayout(false);
            this.TabPage_TempleteMatchingSettingPage.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.GroupBox_TempleteMatchingMode.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label3;
        private LibUtility.ZoomPanROIPictureBox ZoomPanROIPictureBox_OriginalImage;
        private LibUtility.ZoomPanROIPictureBox ZoomPanROIPictureBox_TempleteImage;
        private System.Windows.Forms.Button Button_GetTempleteImageFromMemory;
        private System.Windows.Forms.Button Button_DoTempleteMatching;
        private System.Windows.Forms.Button Button_StartVideoStream;
        private System.Windows.Forms.Button Button_ClearAllROI;
        private System.Windows.Forms.Button Button_SaveTempleteImage;
        private System.Windows.Forms.ListView ListView_TempleteMatchingResult;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Button button_StopVideoStream;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.Button Button_GetTempleteImageFromFile;
        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage TabPage_TempleteMatchingSettingPage;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.GroupBox GroupBox_TempleteMatchingMode;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.RadioButton RadioButton_CVTMSQDIFF;
        private System.Windows.Forms.RadioButton RadioButton_CVTMCCORR;
        private System.Windows.Forms.RadioButton RadioButton_CVTMCCOEFF;
        private System.Windows.Forms.RadioButton RadioButton_CVTMSQDIFFNORMED;
        private System.Windows.Forms.RadioButton RadioButton_CVTMCCORRNORMED;
        private System.Windows.Forms.RadioButton RadioButton_CVTMCCOEFFNORMED;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TextBox_TempleteMatchingThreadhold;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TextBox_TempleteMatchingNumber;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.CheckBox CheckBox_IsUsePyramidTempleteMatching;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TextBox_TempleteMatchingPyramidLevel;
        private System.Windows.Forms.Button Button_FitOriginalImage;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
    }
}

