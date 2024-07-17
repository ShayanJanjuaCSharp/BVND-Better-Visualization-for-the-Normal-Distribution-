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
    public partial class PMCCMenu : UserControl
    {
        public PMCCMenu()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            this.Controls.Clear(); 
            this.Controls.Add(mainMenu);
        }
    }
}
