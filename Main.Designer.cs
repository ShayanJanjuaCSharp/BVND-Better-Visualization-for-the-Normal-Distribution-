namespace BVND
{
    partial class Main
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
            mainMenu1 = new UserControls.MainMenu();
            SuspendLayout();
            // 
            // mainMenu1
            // 
            mainMenu1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            mainMenu1.BackColor = Color.DarkSlateGray;
            mainMenu1.Location = new Point(-4, -1);
            mainMenu1.Name = "mainMenu1";
            mainMenu1.Size = new Size(1280, 720);
            mainMenu1.TabIndex = 0;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(1264, 681);
            Controls.Add(mainMenu1);
            ForeColor = SystemColors.ButtonHighlight;
            Name = "Main";
            Text = "BVND(Better Visualization for the Normal Distribution)";
            ResumeLayout(false);
        }

        #endregion

        private UserControls.MainMenu mainMenu1;
    }
}