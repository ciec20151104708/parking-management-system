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
    public partial class FrmInfo : Form
    {
        DataGridView dgvInfo;
        string arrival = DateTime.Now.ToString();
        public FrmInfo()
        {
            InitializeComponent();
        }
        public FrmInfo(DataGridView _dgvinfo)
        {
            
            InitializeComponent();
            dgvInfo = _dgvinfo;
        }
        private void btnAddinfo_Click(object sender, EventArgs e)
        {

            String num = txtNum.Text;
            
            String count = txtCount.Text;
           // DateTime leave = DateTime.Now;
           
            DataRow dr = FrmMain.dt.NewRow();
          
            dr["colnum"] = num;
            dr["colarrival"] = arrival;
            dr["colcount"] = count;

            FrmMain.dt.Rows.Add(dr);
            dgvInfo.DataSource = FrmMain.dt;
        }

        private void btnGettime_Click(object sender, EventArgs e)
        {
            txtArrival.Text = arrival;
        }

    }
}
