namespace BVND.UserControls
{
    partial class PMCCGiven
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, "0,-0.56");
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint2 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, "-0.56,-1");
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint3 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, "-0.24,-0.26,0,0,0,0");
            PMCC_TITLE = new Label();
            back = new Button();
            SampleSizeText = new Label();
            SampleBox = new ComboBox();
            slBox = new ComboBox();
            Significanceleveltext = new Label();
            Lessthanorgreatertext = new Label();
            LGCBox = new ComboBox();
            PMCCGivenrtext = new Label();
            RBox = new TextBox();
            Confirm_Button = new Button();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            SuspendLayout();
            // 
            // PMCC_TITLE
            // 
            PMCC_TITLE.AutoSize = true;
            PMCC_TITLE.Font = new Font("Times New Roman", 48F, FontStyle.Bold, GraphicsUnit.Point);
            PMCC_TITLE.ForeColor = Color.Honeydew;
            PMCC_TITLE.Location = new Point(3, 18);
            PMCC_TITLE.Name = "PMCC_TITLE";
            PMCC_TITLE.Size = new Size(1027, 73);
            PMCC_TITLE.TabIndex = 2;
            PMCC_TITLE.Text = "Hypothesis Testing for a Correlation";
            // 
            // back
            // 
            back.BackColor = Color.Honeydew;
            back.FlatStyle = FlatStyle.Flat;
            back.Font = new Font("Times New Roman", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            back.ForeColor = Color.DarkSlateGray;
            back.Location = new Point(1141, 18);
            back.Name = "back";
            back.Size = new Size(112, 50);
            back.TabIndex = 7;
            back.Text = "Back";
            back.UseVisualStyleBackColor = false;
            back.Click += back_Click;
            // 
            // SampleSizeText
            // 
            SampleSizeText.AutoSize = true;
            SampleSizeText.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            SampleSizeText.ForeColor = Color.Honeydew;
            SampleSizeText.Location = new Point(26, 184);
            SampleSizeText.Name = "SampleSizeText";
            SampleSizeText.Size = new Size(182, 31);
            SampleSizeText.TabIndex = 8;
            SampleSizeText.Text = "Sample Size, n";
            // 
            // SampleBox
            // 
            SampleBox.BackColor = Color.Honeydew;
            SampleBox.FlatStyle = FlatStyle.Flat;
            SampleBox.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            SampleBox.ForeColor = Color.DarkSlateGray;
            SampleBox.FormattingEnabled = true;
            SampleBox.Items.AddRange(new object[] { "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "40", "50", "60", "70", "80", "90", "100" });
            SampleBox.Location = new Point(230, 181);
            SampleBox.Name = "SampleBox";
            SampleBox.Size = new Size(80, 39);
            SampleBox.TabIndex = 9;
            // 
            // slBox
            // 
            slBox.BackColor = Color.Honeydew;
            slBox.FlatStyle = FlatStyle.Flat;
            slBox.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            slBox.ForeColor = Color.DarkSlateGray;
            slBox.FormattingEnabled = true;
            slBox.Items.AddRange(new object[] { "0.10", "0.05", "0.025", "0.01", "0.005" });
            slBox.Location = new Point(299, 248);
            slBox.Name = "slBox";
            slBox.Size = new Size(80, 39);
            slBox.TabIndex = 11;
            // 
            // Significanceleveltext
            // 
            Significanceleveltext.AutoSize = true;
            Significanceleveltext.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            Significanceleveltext.ForeColor = Color.Honeydew;
            Significanceleveltext.Location = new Point(26, 256);
            Significanceleveltext.Name = "Significanceleveltext";
            Significanceleveltext.Size = new Size(267, 31);
            Significanceleveltext.TabIndex = 10;
            Significanceleveltext.Text = "Siginificance Level, sl";
            // 
            // Lessthanorgreatertext
            // 
            Lessthanorgreatertext.AutoSize = true;
            Lessthanorgreatertext.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            Lessthanorgreatertext.ForeColor = Color.Honeydew;
            Lessthanorgreatertext.Location = new Point(26, 340);
            Lessthanorgreatertext.Name = "Lessthanorgreatertext";
            Lessthanorgreatertext.Size = new Size(421, 31);
            Lessthanorgreatertext.TabIndex = 12;
            Lessthanorgreatertext.Text = "Less than, Greater than or Change";
            // 
            // LGCBox
            // 
            LGCBox.BackColor = Color.Honeydew;
            LGCBox.FlatStyle = FlatStyle.Flat;
            LGCBox.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            LGCBox.ForeColor = Color.DarkSlateGray;
            LGCBox.FormattingEnabled = true;
            LGCBox.Items.AddRange(new object[] { "<0", ">0", "≠0" });
            LGCBox.Location = new Point(453, 340);
            LGCBox.Name = "LGCBox";
            LGCBox.Size = new Size(80, 39);
            LGCBox.TabIndex = 13;
            // 
            // PMCCGivenrtext
            // 
            PMCCGivenrtext.AutoSize = true;
            PMCCGivenrtext.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            PMCCGivenrtext.ForeColor = Color.Honeydew;
            PMCCGivenrtext.Location = new Point(26, 433);
            PMCCGivenrtext.Name = "PMCCGivenrtext";
            PMCCGivenrtext.Size = new Size(199, 31);
            PMCCGivenrtext.TabIndex = 14;
            PMCCGivenrtext.Text = "PMCC Given, r";
            // 
            // RBox
            // 
            RBox.BackColor = Color.Honeydew;
            RBox.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            RBox.ForeColor = Color.DarkSlateGray;
            RBox.Location = new Point(230, 430);
            RBox.Name = "RBox";
            RBox.Size = new Size(128, 39);
            RBox.TabIndex = 15;
            // 
            // Confirm_Button
            // 
            Confirm_Button.BackColor = Color.Honeydew;
            Confirm_Button.FlatStyle = FlatStyle.Flat;
            Confirm_Button.Font = new Font("Times New Roman", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            Confirm_Button.ForeColor = Color.DarkSlateGray;
            Confirm_Button.Location = new Point(26, 554);
            Confirm_Button.Name = "Confirm_Button";
            Confirm_Button.Size = new Size(173, 50);
            Confirm_Button.TabIndex = 16;
            Confirm_Button.Text = "Confirm";
            Confirm_Button.UseVisualStyleBackColor = false;
            Confirm_Button.Click += Confirm_Button_Click;
            // 
            // chart1
            // 
            chart1.BackColor = Color.DarkSlateGray;
            chart1.BorderlineColor = Color.Honeydew;
            chartArea1.AxisX.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Triangle;
            chartArea1.AxisX.InterlacedColor = Color.DarkGray;
            chartArea1.AxisX.LabelStyle.ForeColor = Color.MintCream;
            chartArea1.AxisX.LineColor = Color.Honeydew;
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisX.MajorGrid.LineColor = Color.Honeydew;
            chartArea1.AxisX.ScaleBreakStyle.LineColor = Color.MintCream;
            chartArea1.AxisX.TitleForeColor = Color.Honeydew;
            chartArea1.AxisX2.LineColor = Color.Honeydew;
            chartArea1.AxisY.LabelStyle.ForeColor = Color.Honeydew;
            chartArea1.AxisY.LineColor = Color.Honeydew;
            chartArea1.AxisY.MajorGrid.LineColor = Color.Honeydew;
            chartArea1.AxisY.MinorGrid.Enabled = true;
            chartArea1.AxisY.MinorGrid.LineColor = Color.PowderBlue;
            chartArea1.AxisY2.LineColor = Color.Honeydew;
            chartArea1.BackColor = Color.DarkSlateGray;
            chartArea1.BorderColor = Color.Honeydew;
            chartArea1.Name = "ChartArea1";
            chartArea1.ShadowColor = Color.White;
            chart1.ChartAreas.Add(chartArea1);
            legend1.BackColor = Color.Honeydew;
            legend1.Font = new Font("Times New Roman", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            legend1.ForeColor = Color.DarkSlateGray;
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(614, 204);
            chart1.Name = "chart1";
            chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            series1.BackSecondaryColor = Color.DarkSlateGray;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.RangeBar;
            series1.Color = Color.Wheat;
            series1.LabelForeColor = Color.Honeydew;
            series1.Legend = "Legend1";
            series1.Name = "Non Critical Reqion";
            series1.Points.Add(dataPoint1);
            series1.YValuesPerPoint = 2;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.RangeBar;
            series2.Color = Color.Peru;
            series2.Legend = "Legend1";
            series2.Name = "Critical Region";
            series2.Points.Add(dataPoint2);
            series2.YValuesPerPoint = 2;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.RangeBar;
            series3.Color = Color.Yellow;
            series3.Legend = "Legend1";
            series3.Name = "PMCC Given";
            series3.Points.Add(dataPoint3);
            series3.YValuesPerPoint = 6;
            chart1.Series.Add(series1);
            chart1.Series.Add(series2);
            chart1.Series.Add(series3);
            chart1.Size = new Size(591, 260);
            chart1.TabIndex = 17;
            chart1.Text = "chart1";
            // 
            // PMCCGiven
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            Controls.Add(chart1);
            Controls.Add(Confirm_Button);
            Controls.Add(RBox);
            Controls.Add(PMCCGivenrtext);
            Controls.Add(LGCBox);
            Controls.Add(Lessthanorgreatertext);
            Controls.Add(slBox);
            Controls.Add(Significanceleveltext);
            Controls.Add(SampleBox);
            Controls.Add(SampleSizeText);
            Controls.Add(back);
            Controls.Add(PMCC_TITLE);
            Name = "PMCCGiven";
            Size = new Size(1280, 720);
            Load += PMCCGiven_Load;
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label PMCC_TITLE;
        private Button back;
        private Label SampleSizeText;
        private ComboBox SampleBox;
        private ComboBox slBox;
        private Label Significanceleveltext;
        private Label Lessthanorgreatertext;
        private ComboBox LGCBox;
        private Label PMCCGivenrtext;
        private TextBox RBox;
        private Button Confirm_Button;
        public System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}
