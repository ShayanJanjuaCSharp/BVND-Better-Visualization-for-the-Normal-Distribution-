namespace BVND
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button5 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Times New Roman", 35F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(47, 50);
            label1.Name = "label1";
            label1.Size = new Size(149, 53);
            label1.TabIndex = 0;
            label1.Text = "Better";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Times New Roman", 35F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(182, 50);
            label2.Name = "label2";
            label2.Size = new Size(286, 53);
            label2.TabIndex = 1;
            label2.Text = "Visualization";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Times New Roman", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(456, 75);
            label3.Name = "label3";
            label3.Size = new Size(67, 23);
            label3.TabIndex = 2;
            label3.Text = "for the";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Times New Roman", 35F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(517, 50);
            label4.Name = "label4";
            label4.Size = new Size(436, 53);
            label4.TabIndex = 3;
            label4.Text = "Normal Distribution";
            // 
            // button1
            // 
            button1.BackColor = Color.Honeydew;
            button1.FlatAppearance.BorderColor = Color.DarkSlateGray;
            button1.Font = new Font("Times New Roman", 13F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.DarkSlateGray;
            button1.Location = new Point(47, 329);
            button1.Name = "button1";
            button1.Size = new Size(421, 64);
            button1.TabIndex = 4;
            button1.Text = "HYPOTHESIS TESTING FOR A CORRELATION";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Honeydew;
            button2.Font = new Font("Times New Roman", 13F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.DarkSlateGray;
            button2.Location = new Point(47, 191);
            button2.Name = "button2";
            button2.Size = new Size(279, 61);
            button2.TabIndex = 5;
            button2.Text = "BINOMIAL DISTRIBUTION PD";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.Honeydew;
            button3.Font = new Font("Times New Roman", 13F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.DarkSlateGray;
            button3.Location = new Point(47, 258);
            button3.Name = "button3";
            button3.Size = new Size(279, 65);
            button3.TabIndex = 8;
            button3.Text = "BINOMIAL DISTRIBUTION CD";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.Honeydew;
            button5.FlatAppearance.BorderColor = Color.DarkSlateGray;
            button5.Font = new Font("Times New Roman", 13F, FontStyle.Bold, GraphicsUnit.Point);
            button5.ForeColor = Color.DarkSlateGray;
            button5.Location = new Point(47, 399);
            button5.Name = "button5";
            button5.Size = new Size(525, 62);
            button5.TabIndex = 9;
            button5.Text = "HYPOTHESIS TESTING FOR THE NORMAL DISTRIBUTION";
            button5.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(1159, 570);
            Controls.Add(button5);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Cursor = Cursors.Default;
            ForeColor = SystemColors.ButtonHighlight;
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button5;
    }
}