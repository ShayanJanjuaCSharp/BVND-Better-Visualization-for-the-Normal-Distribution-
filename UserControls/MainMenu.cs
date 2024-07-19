using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BVND.UserControls
{
    public partial class MainMenu : UserControl
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            AutoScaleMode = AutoScaleMode.Dpi;
            string dir = @"C:\BVNDDataFiles";

            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }
            File.Create(@"c:\BVNDDataFiles\PMCCGivenData.json");
            File.Create(@"c:\BVNDDataFiles\DataGivenData.json");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PMCCMenu next = new PMCCMenu();
            this.Controls.Clear();
            this.Controls.Add(next);
        }
    }
}
