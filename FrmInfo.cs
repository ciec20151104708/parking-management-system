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
        DateTime arrival = DateTime.Now;
        DateTime leave = DateTime.Now;

        public FrmInfo()
        {
            InitializeComponent();
        }
        public FrmInfo(DataGridView _dgvinfo)
        {
            
            InitializeComponent();
            dgvInfo = _dgvinfo;
        }
        public FrmInfo( DateTime _arrival,String _num , String _count)
        {
            InitializeComponent();
            arrival = _arrival;

        }
        private void btnAddinfo_Click(object sender, EventArgs e)
        {

            String num = txtNum.Text;
            
            String count = txtCount.Text;
           // DateTime leave = DateTime.Now;
            TimeSpan time = leave - arrival;
            double getHours = time.TotalHours;
            double money = getHours * 2;
            DataRow dr = FrmMain.dt.NewRow();
          
            dr["colnum"] = num;
            dr["colarrival"] = arrival;
            dr["colcount"] = count;
            dr["colleave"]=leave;
            dr["coltime"] = time;
            dr["colmoney"] = money;
            FrmMain.dt.Rows.Add(dr);
            dgvInfo.DataSource = FrmMain.dt;
        }

        private void btnGettime_Click(object sender, EventArgs e)
        {
            txtArrival.Text = Convert.ToString(arrival);
        }

    }
}
