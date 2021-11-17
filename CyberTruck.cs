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
    public partial class CyberTruck : Form
    {
        public CyberTruck()
        {
            InitializeComponent();
        }

        private void UxCyberTruckDetailButton_Click(object sender, EventArgs e)
        {
            CyberTruckDetails cybertruckdetails = new CyberTruckDetails();
            cybertruckdetails.ShowDialog();
        }
    }
}
