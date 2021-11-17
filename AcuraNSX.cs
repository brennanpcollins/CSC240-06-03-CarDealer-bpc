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
    public partial class AcuraNSX : Form
    {
        public AcuraNSX()
        {
            InitializeComponent();
        }

        private void UxAcuraImage_Click(object sender, EventArgs e)
        {

        }

        private void UxAcuraDetailButton_Click(object sender, EventArgs e)
        {
            AcuraDetails acuradetails = new AcuraDetails();
            acuradetails.ShowDialog();
        }
    }
}
