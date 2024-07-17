namespace BVND.UserControls
{
    partial class PMCCMenu
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
            PMCC_Given = new Button();
            button1 = new Button();
            back = new Button();
            SuspendLayout();
            // 
            // PMCC_TITLE
            // 
            PMCC_TITLE.AutoSize = true;
            PMCC_TITLE.Font = new Font("Times New Roman", 48F, FontStyle.Bold, GraphicsUnit.Point);
            PMCC_TITLE.ForeColor = Color.Honeydew;
            PMCC_TITLE.Location = new Point(113, 16);
            PMCC_TITLE.Name = "PMCC_TITLE";
            PMCC_TITLE.Size = new Size(1027, 73);
            PMCC_TITLE.TabIndex = 1;
            PMCC_TITLE.Text = "Hypothesis Testing for a Correlation";
            // 
            // PMCC_Given
            // 
            PMCC_Given.BackColor = Color.Honeydew;
            PMCC_Given.FlatStyle = FlatStyle.Flat;
            PMCC_Given.Font = new Font("Times New Roman", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            PMCC_Given.ForeColor = Color.DarkSlateGray;
            PMCC_Given.Location = new Point(172, 223);
            PMCC_Given.Name = "PMCC_Given";
            PMCC_Given.Size = new Size(294, 261);
            PMCC_Given.TabIndex = 4;
            PMCC_Given.Text = "PMCC Given";
            PMCC_Given.UseVisualStyleBackColor = false;
            PMCC_Given.Click += PMCC_Given_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Honeydew;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.DarkSlateGray;
            button1.Location = new Point(765, 223);
            button1.Name = "button1";
            button1.Size = new Size(294, 261);
            button1.TabIndex = 5;
            button1.Text = "Data Given";
            button1.UseVisualStyleBackColor = false;
            // 
            // back
            // 
            back.BackColor = Color.Honeydew;
            back.FlatStyle = FlatStyle.Flat;
            back.Font = new Font("Times New Roman", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            back.ForeColor = Color.DarkSlateGray;
            back.Location = new Point(457, 574);
            back.Name = "back";
            back.Size = new Size(294, 83);
            back.TabIndex = 6;
            back.Text = "Back";
            back.UseVisualStyleBackColor = false;
            back.Click += back_Click;
            // 
            // PMCCMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            Controls.Add(back);
            Controls.Add(button1);
            Controls.Add(PMCC_Given);
            Controls.Add(PMCC_TITLE);
            Name = "PMCCMenu";
            Size = new Size(1280, 720);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label PMCC_TITLE;
        private Button PMCC_Given;
        private Button button1;
        private Button back;
    }
}
