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
            PMCC_TITLE = new Label();
            back = new Button();
            label1 = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            comboBox3 = new ComboBox();
            label4 = new Label();
            textBox1 = new TextBox();
            Confirm_Button = new Button();
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Honeydew;
            label1.Location = new Point(26, 184);
            label1.Name = "label1";
            label1.Size = new Size(182, 31);
            label1.TabIndex = 8;
            label1.Text = "Sample Size, n";
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.Honeydew;
            comboBox1.FlatStyle = FlatStyle.Flat;
            comboBox1.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            comboBox1.ForeColor = Color.DarkSlateGray;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "40", "50", "60", "70", "80", "90", "100" });
            comboBox1.Location = new Point(230, 181);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(80, 39);
            comboBox1.TabIndex = 9;
            // 
            // comboBox2
            // 
            comboBox2.BackColor = Color.Honeydew;
            comboBox2.FlatStyle = FlatStyle.Flat;
            comboBox2.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            comboBox2.ForeColor = Color.DarkSlateGray;
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "0.10", "0.05", "0.025", "0.01", "0.005" });
            comboBox2.Location = new Point(299, 248);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(80, 39);
            comboBox2.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Honeydew;
            label2.Location = new Point(26, 256);
            label2.Name = "label2";
            label2.Size = new Size(267, 31);
            label2.TabIndex = 10;
            label2.Text = "Siginificance Level, sl";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Honeydew;
            label3.Location = new Point(26, 340);
            label3.Name = "label3";
            label3.Size = new Size(421, 31);
            label3.TabIndex = 12;
            label3.Text = "Less than, Greater than or Change";
            // 
            // comboBox3
            // 
            comboBox3.BackColor = Color.Honeydew;
            comboBox3.FlatStyle = FlatStyle.Flat;
            comboBox3.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            comboBox3.ForeColor = Color.DarkSlateGray;
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "<0", ">0", "≠0" });
            comboBox3.Location = new Point(453, 340);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(80, 39);
            comboBox3.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Honeydew;
            label4.Location = new Point(26, 433);
            label4.Name = "label4";
            label4.Size = new Size(173, 31);
            label4.TabIndex = 14;
            label4.Text = "PMCC Given";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Honeydew;
            textBox1.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.ForeColor = Color.DarkSlateGray;
            textBox1.Location = new Point(230, 430);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(128, 39);
            textBox1.TabIndex = 15;
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
            // 
            // PMCCGiven
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            Controls.Add(Confirm_Button);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(comboBox3);
            Controls.Add(label3);
            Controls.Add(comboBox2);
            Controls.Add(label2);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Controls.Add(back);
            Controls.Add(PMCC_TITLE);
            Name = "PMCCGiven";
            Size = new Size(1280, 720);
            Load += PMCCGiven_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label PMCC_TITLE;
        private Button back;
        private Label label1;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Label label2;
        private Label label3;
        private ComboBox comboBox3;
        private Label label4;
        private TextBox textBox1;
        private Button Confirm_Button;
    }
}
