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
    public partial class frmPayNow : Form
    {
        public Dictionary<string, string> CoffeeOrders { get; set; }
        public frmPayNow()
        {
            InitializeComponent();
        }

        private void frmPayNow_Load(object sender, EventArgs e)
        {
           
        }
    }
}
