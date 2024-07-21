using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BVND.UserControls.PMCC_Controls.PMCCGivenSteps
{
    public partial class PMCCStep1 : UserControl
    {
        public PMCCStep1()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            PMCCGiven backpage = new PMCCGiven();
            this.Controls.Clear();
            this.Controls.Add(backpage);
        }
    }
}
