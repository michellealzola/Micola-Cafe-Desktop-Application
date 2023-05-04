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
    
    public partial class frmMicolaCafe : Form
    {
        private int blackQty;
        private int cappuccinoQty;
        private int columbianQty;
        private int espressoQty;
        private int hazelNutQty;
        private int latteQty;

        private int blackCount;
        private int cappuccinoCount;
        private int columbianCount;
        private int espressoCount;
        private int hazelNutCount;
        private int latteCount;

        private double totalSales;

        public Dictionary<string, string> coffeeOrders = new Dictionary<string, string>(); 

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

            coffeeOrders.Clear();
        }

        private void picBoxBlack_Click(object sender, EventArgs e)
        {
            blackQty--;
            totalSales += 1.0;

            blackCount++;

            lblOutBlack.Text = blackQty.ToString();
            lblOutTotal.Text = totalSales.ToString("c");

            coffeeOrders["Black"] = blackCount.ToString();
        }

        private void picBoxCappuccino_Click(object sender, EventArgs e)
        {
            cappuccinoQty--;
            totalSales += 1.2;

            cappuccinoCount++;

            lblOutCappuccino.Text = cappuccinoQty.ToString();
            lblOutTotal.Text = totalSales.ToString("c");

            coffeeOrders["Cappuccino"] = cappuccinoCount.ToString();
        }

        private void picBoxColumbian_Click(object sender, EventArgs e)
        {
            columbianQty--;
            totalSales += 1.15;

            columbianCount++;

            lblOutColumbian.Text = columbianQty.ToString();
            lblOutTotal.Text = totalSales.ToString("c");

            coffeeOrders["Columbian"] = columbianCount.ToString();
        }

        private void picBoxEspresso_Click(object sender, EventArgs e)
        {
            espressoQty--;
            totalSales += 1.1;

            espressoCount++;

            lblOutEspresso.Text = espressoQty.ToString();
            lblOutTotal.Text = totalSales.ToString("c");

            coffeeOrders["Espresso"] = espressoCount.ToString();
        }

        private void picBoxHazelNut_Click(object sender, EventArgs e)
        {
            hazelNutQty--;
            totalSales += 1.25;

            hazelNutCount++;

            lblOutHazelNut.Text = hazelNutQty.ToString();
            lblOutTotal.Text = totalSales.ToString("c");

            coffeeOrders["Hazel Nut"] = hazelNutCount.ToString();
        }

        private void picBoxLatte_Click(object sender, EventArgs e)
        {
            latteQty--;
            totalSales += 1.2;

            latteCount++;

            lblOutLatte.Text = latteQty.ToString();
            lblOutTotal.Text = totalSales.ToString("c");

            coffeeOrders["Latte"] = latteCount.ToString();
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

            coffeeOrders.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPayNow_Click(object sender, EventArgs e)
        {
            frmPayNow frmPayNow = new frmPayNow();
            frmPayNow.CoffeeOrders = coffeeOrders;
            frmPayNow.Show();            

        }
    }
}
