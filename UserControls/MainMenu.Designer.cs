namespace BVND.UserControls
{
    partial class MainMenu
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
            Better_Visualization = new Label();
            for_the = new Label();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // Better_Visualization
            // 
            Better_Visualization.AutoSize = true;
            Better_Visualization.Font = new Font("Times New Roman", 48F, FontStyle.Bold, GraphicsUnit.Point);
            Better_Visualization.ForeColor = Color.Honeydew;
            Better_Visualization.Location = new Point(3, 23);
            Better_Visualization.Name = "Better_Visualization";
            Better_Visualization.Size = new Size(574, 73);
            Better_Visualization.TabIndex = 0;
            Better_Visualization.Text = "Better Visualization";
            // 
            // for_the
            // 
            for_the.AutoSize = true;
            for_the.Font = new Font("Times New Roman", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            for_the.ForeColor = Color.Honeydew;
            for_the.Location = new Point(560, 50);
            for_the.Name = "for_the";
            for_the.Size = new Size(117, 40);
            for_the.TabIndex = 1;
            for_the.Text = "for the";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 48F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Honeydew;
            label1.Location = new Point(667, 23);
            label1.Name = "label1";
            label1.Size = new Size(593, 73);
            label1.TabIndex = 2;
            label1.Text = "Normal Distribution";
            // 
            // button1
            // 
            button1.BackColor = Color.Honeydew;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Times New Roman", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.DarkSlateGray;
            button1.Location = new Point(19, 173);
            button1.Name = "button1";
            button1.Size = new Size(479, 64);
            button1.TabIndex = 3;
            button1.Text = "Hypothesis Testing for a Correlation";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Honeydew;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Times New Roman", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.DarkSlateGray;
            button2.Location = new Point(19, 273);
            button2.Name = "button2";
            button2.Size = new Size(479, 64);
            button2.TabIndex = 4;
            button2.Text = "Hypothesis Testing for Binomial PD";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.Honeydew;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Times New Roman", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.DarkSlateGray;
            button3.Location = new Point(19, 380);
            button3.Name = "button3";
            button3.Size = new Size(479, 64);
            button3.TabIndex = 5;
            button3.Text = "Hypothesis Testing for Binomial CD";
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.Honeydew;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Times New Roman", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = Color.DarkSlateGray;
            button4.Location = new Point(19, 486);
            button4.Name = "button4";
            button4.Size = new Size(617, 64);
            button4.TabIndex = 6;
            button4.Text = "Hypothesis Testing for the Normal Distribution";
            button4.UseVisualStyleBackColor = false;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(for_the);
            Controls.Add(Better_Visualization);
            Name = "MainMenu";
            Size = new Size(1280, 720);
            Load += MainMenu_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Better_Visualization;
        private Label for_the;
        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}
