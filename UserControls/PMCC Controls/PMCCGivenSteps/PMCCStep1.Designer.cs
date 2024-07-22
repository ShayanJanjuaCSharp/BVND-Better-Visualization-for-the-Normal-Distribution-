namespace BVND.UserControls.PMCC_Controls.PMCCGivenSteps
{
    partial class PMCCStep1
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
            PMCC_TITLE = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            Confirm_Button = new Button();
            back = new Button();
            button2 = new Button();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            SuspendLayout();
            // 
            // PMCC_TITLE
            // 
            PMCC_TITLE.AutoSize = true;
            PMCC_TITLE.Font = new Font("Times New Roman", 48F, FontStyle.Bold, GraphicsUnit.Point);
            PMCC_TITLE.ForeColor = Color.Honeydew;
            PMCC_TITLE.Location = new Point(14, 11);
            PMCC_TITLE.Name = "PMCC_TITLE";
            PMCC_TITLE.Size = new Size(914, 73);
            PMCC_TITLE.TabIndex = 3;
            PMCC_TITLE.Text = "Step 1 - Stating your Hypothesis";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Honeydew;
            label1.Location = new Point(239, 201);
            label1.Name = "label1";
            label1.Size = new Size(752, 210);
            label1.TabIndex = 4;
            label1.Text = "The first thing to do when presented with a\r\n hypothesis testing question with a PMCC \r\nis to state your base hypotheses.\r\n\r\nThese are your null and alternative hypothesis.\r\n";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 72F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Honeydew;
            label2.Location = new Point(323, 484);
            label2.Name = "label2";
            label2.Size = new Size(605, 109);
            label2.TabIndex = 5;
            label2.Text = "H                 H";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Honeydew;
            label3.Location = new Point(423, 551);
            label3.Name = "label3";
            label3.Size = new Size(37, 42);
            label3.TabIndex = 6;
            label3.Text = "0\r\n";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Honeydew;
            label4.Location = new Point(901, 551);
            label4.Name = "label4";
            label4.Size = new Size(37, 42);
            label4.TabIndex = 7;
            label4.Text = "1";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Confirm_Button
            // 
            Confirm_Button.BackColor = Color.Honeydew;
            Confirm_Button.FlatStyle = FlatStyle.Flat;
            Confirm_Button.Font = new Font("Times New Roman", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            Confirm_Button.ForeColor = Color.DarkSlateGray;
            Confirm_Button.Location = new Point(1015, 637);
            Confirm_Button.Name = "Confirm_Button";
            Confirm_Button.Size = new Size(173, 50);
            Confirm_Button.TabIndex = 17;
            Confirm_Button.Text = "Next";
            Confirm_Button.UseVisualStyleBackColor = false;
            // 
            // back
            // 
            back.BackColor = Color.Honeydew;
            back.FlatStyle = FlatStyle.Flat;
            back.Font = new Font("Times New Roman", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            back.ForeColor = Color.DarkSlateGray;
            back.Location = new Point(73, 637);
            back.Name = "back";
            back.Size = new Size(173, 50);
            back.TabIndex = 18;
            back.Text = "Back";
            back.UseVisualStyleBackColor = false;
            back.Click += back_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Honeydew;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Times New Roman", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.DarkSlateGray;
            button2.Location = new Point(1015, 119);
            button2.Name = "button2";
            button2.Size = new Size(173, 50);
            button2.TabIndex = 19;
            button2.Text = "Repeat";
            button2.UseVisualStyleBackColor = false;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(961, 230);
            chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chart1.Series.Add(series1);
            chart1.Size = new Size(300, 300);
            chart1.TabIndex = 20;
            chart1.Text = "chart1";
            // 
            // PMCCStep1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            Controls.Add(chart1);
            Controls.Add(button2);
            Controls.Add(back);
            Controls.Add(Confirm_Button);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(PMCC_TITLE);
            Name = "PMCCStep1";
            Size = new Size(1280, 720);
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label PMCC_TITLE;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button Confirm_Button;
        private Button back;
        private Button button2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}
