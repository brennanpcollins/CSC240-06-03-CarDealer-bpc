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
    public partial class Corvette : Form
    {
        public Corvette()
        {
            InitializeComponent();
        }

        private void UxCorvetteInfoButton_Click(object sender, EventArgs e)
        {
            CorvetteDetails corvettedetails = new CorvetteDetails();
            corvettedetails.ShowDialog();
        }
    }
}
