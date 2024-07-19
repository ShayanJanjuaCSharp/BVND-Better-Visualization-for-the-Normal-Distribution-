using BVND.Classes;
using Microsoft.VisualBasic.Devices;
using Newtonsoft.Json;
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

        private void Confirm_Button_Click(object sender, EventArgs e)
        {
            Double[,] PMCCTable = { { 0.8, 0.687, 0.6084, 0.5509, 0.5067, 0.4716, 0.4428, 0.4187, 0.3981, 0.3802, 0.3646, 0.3507, 0.3383, 0.3271, 0.3170, 0.3077, 0.2992, 0.2914, 0.2841, 0.2774, 0.2711, 0.2653, 0.2598, 0.2546, 0.2497, 0.2451, 0.2407, 0.207, 0.1843, 0.1678, 0.1550, 0.1448, 0.1364, 0.1292 },
            { 0.9, 0.8054, 0.7293, 0.6694, 0.6215, 0.5822, 0.5494, 0.5214, 0.4973, 0.4762, 0.4575, 0.4409, 0.4259, 0.4124, 0.4, 0.3887, 0.3783, 0.3687, 0.3598, 0.3515, 0.3438, 0.3365, 0.3297, 0.3233, 0.3172, 0.3115, 0.3061, 0.2638, 0.2353, 0.2144, 0.1982, 0.1852, 0.1745, 0.1654 },
            { 0.95, 0.8783, 0.8114, 0.7545, 0.7067, 0.6664, 0.6319, 0.6021, 0.5760, 0.5529, 0.5324, 0.5140, 0.4973, 0.4821, 0.4683, 0.4555, 0.4438, 0.4329, 0.4227, 0.4133, 0.4044, 0.3961, 0.3882, 0.3809, 0.3739, 0.3673, 0.3610, 0.3120, 0.2787, 0.2542, 0.2352, 0.2199, 0.2072, 0.1966 },
            { 0.98, 0.9343, 0.8822, 0.8329, 0.7887, 7498, 0.7155, 0.6851, 0.6581, 0.6339, 0.612, 0.5923, 0.5742, 0.5577, 0.5425, 0.5285, 0.5155, 0.5034, 0.4921, 0.4815, 0.4716, 0.4622, 0.4534, 0.4451, 0.4372, 0.4297, 0.4226, 0.3665, 0.3281, 0.2997, 0.2776, 0.2597, 0.2449, 0.2324 },
            { 0.99, 0.9587, 0.9172, 0.8745, 0.8343, 0.7977, 0.7646, 0.7348, 0.7079, 0.6835, 0.6614, 0.6411, 0.6226, 0.6055, 0.5897, 0.5751, 0.5614, 0.5487, 0.5368, 0.5256, 0.5151, 0.5052, 0.4958, 0.4869, 0.4785, 0.4705, 0.4629, 0.4026, 0.3610, 0.3301, 0.3060, 0.2864, 0.2702, 0.2565 } };

            Double crit = PMCCTable[slBox.SelectedIndex, SampleBox.SelectedIndex];

            if (LGCBox.SelectedIndex == 2)
            {
                crit = PMCCTable[slBox.SelectedIndex + 1, SampleBox.SelectedIndex];
            }

            if (LGCBox.SelectedIndex == 0)
            {
                crit = -crit;
            }

            Double r = Convert.ToDouble(RBox.Text);
            if (r < 0)
            {
                crit = -crit;
            }

            PMCCGivenData trdata = new PMCCGivenData();
            trdata.r = r;
            trdata.sl = slBox.SelectedIndex;
            trdata.cv = crit;
            trdata.sample = SampleBox.SelectedIndex;
            trdata.lgc = LGCBox.SelectedIndex;

            File.WriteAllText(@"c:\BVNDDataFiles\PMCCGivenData.json", JsonConvert.SerializeObject(trdata));
        }

    }

}
