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
    public partial class PMCCGiven : UserControl
    {
        public PMCCGiven()
        {
            InitializeComponent();
            float[,] PMCCTable = new float[ 5,37];
        }

        private void back_Click(object sender, EventArgs e)
        {
            PMCCMenu pmccmenu = new PMCCMenu();
            this.Controls.Clear();
            this.Controls.Add(pmccmenu);
        }

        private void PMCCGiven_Load(object sender, EventArgs e)
        {

        }
    }
}
