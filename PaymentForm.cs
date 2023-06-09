﻿using System;
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
        
        public frmPayNow()
        {
            InitializeComponent();
        }


        private void btnPayNow_Click(object sender, EventArgs e)
        {
            ThankYouForm thanks = new ThankYouForm();
            thanks.ShowDialog();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);          
        }
    }
}
