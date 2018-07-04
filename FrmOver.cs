using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace parking_management_system
{
    public partial class FrmOver : Form
    {
        public FrmOver()
        {
            InitializeComponent();
        }
        public FrmOver(double time,double money)
        {
            InitializeComponent();
            txtovertime.Text = time.ToString();
            txtovermoney.Text = money.ToString();
        }

        private void btnover_Click(object sender, EventArgs e)
        {
            Close();
            FrmCheckout.ActiveForm.Close();

        }
    }
}
