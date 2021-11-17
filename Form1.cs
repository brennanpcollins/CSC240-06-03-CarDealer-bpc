using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSC240_06_03_CarDealer_bpc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void UxAcuraNSXCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (UxAcuraNSXCheck.Checked)
            {
                AcuraNSX acuraNSX = new AcuraNSX();
                acuraNSX.ShowDialog();
                UxAcuraNSXCheck.Checked = false;
            }
        }

        private void UxCyberTruckCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (UxCyberTruckCheck.Checked)
            {
                CyberTruck cybertruck = new CyberTruck();
                cybertruck.ShowDialog();
                UxCyberTruckCheck.Checked = false;
            }
        }

        private void UxCorvetteCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (UxCorvetteCheck.Checked)
            {
                Corvette corvette = new Corvette();
                corvette.ShowDialog();
                UxCorvetteCheck.Checked = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void UxHelpButton_Click(object sender, EventArgs e)
        {
            HelpScreen helpscreen = new HelpScreen();
            helpscreen.ShowDialog();
        }
    }
}
