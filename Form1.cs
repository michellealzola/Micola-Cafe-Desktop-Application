using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Micola_Cafe_Desktop_Application
{
    struct Coffee
    {
        public string coffeeName;
        public double coffeeCost;
        public int coffeeQty;
    }
    public partial class frmMicolaCafe : Form
    {
        private int blackQty;
        private int cappuccinoQty;
        private int columbianQty;
        private int espressoQty;
        private int hazelNutQty;
        private int latteQty;

        private double totalSales;

        public frmMicolaCafe()
        {
            InitializeComponent();
        }

        private void frmMicolaCafe_Load(object sender, EventArgs e)
        {
            blackQty = 20;
            cappuccinoQty = 20;
            columbianQty = 20;
            espressoQty = 20;
            hazelNutQty = 20;
            latteQty = 20;

            lblOutBlack.Text = blackQty.ToString();
            lblOutCappuccino.Text = cappuccinoQty.ToString();
            lblOutColumbian.Text = columbianQty.ToString();
            lblOutEspresso.Text = espressoQty.ToString();
            lblOutHazelNut.Text = hazelNutQty.ToString();
            lblOutLatte.Text = latteQty.ToString();

            lblOutTotal.Text = "";
        }

        private void picBoxBlack_Click(object sender, EventArgs e)
        {
            blackQty--;
            totalSales += 1.0;

            lblOutBlack.Text = blackQty.ToString();
            lblOutTotal.Text = totalSales.ToString("c");
        }

        private void picBoxCappuccino_Click(object sender, EventArgs e)
        {
            cappuccinoQty--;
            totalSales += 1.2;

            lblOutCappuccino.Text = cappuccinoQty.ToString();
            lblOutTotal.Text = totalSales.ToString("c");
        }

        private void picBoxColumbian_Click(object sender, EventArgs e)
        {
            columbianQty--;
            totalSales += 1.15;

            lblOutColumbian.Text = columbianQty.ToString();
            lblOutTotal.Text = totalSales.ToString("c");
        }

        private void picBoxEspresso_Click(object sender, EventArgs e)
        {
            espressoQty--;
            totalSales += 1.1;

            lblOutEspresso.Text = espressoQty.ToString();
            lblOutTotal.Text = totalSales.ToString("c");
        }

        private void picBoxHazelNut_Click(object sender, EventArgs e)
        {
            hazelNutQty--;
            totalSales += 1.25;

            lblOutHazelNut.Text = hazelNutQty.ToString();
            lblOutTotal.Text = totalSales.ToString("c");
        }

        private void picBoxLatte_Click(object sender, EventArgs e)
        {
            latteQty--;
            totalSales += 1.2;

            lblOutLatte.Text = latteQty.ToString();
            lblOutTotal.Text = totalSales.ToString("c");
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            blackQty = 20;
            cappuccinoQty = 20;
            columbianQty = 20;
            espressoQty = 20;
            hazelNutQty = 20;
            latteQty = 20;

            lblOutBlack.Text = blackQty.ToString();
            lblOutCappuccino.Text = cappuccinoQty.ToString();
            lblOutColumbian.Text = columbianQty.ToString();
            lblOutEspresso.Text = espressoQty.ToString();
            lblOutHazelNut.Text = hazelNutQty.ToString();
            lblOutLatte.Text = latteQty.ToString();

            lblOutTotal.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
