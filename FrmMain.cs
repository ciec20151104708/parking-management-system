﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace parking_management_system
{
    public partial class FrmMain : Form
    {
        public static DataTable dt = new DataTable();

        public FrmMain()
        {
            InitializeComponent();
        }
        public FrmMain(string username,string password)
        {
            DataColumn colcount = new DataColumn("colCount");
            DataColumn colnum = new DataColumn("colNum");
            DataColumn colarrival = new DataColumn("colArrival");
            DataColumn colleave = new DataColumn("colLeave");
            DataColumn coltime = new DataColumn("colTime");
            DataColumn colmoney = new DataColumn("colMoney");
            
            dt.Columns.Add(colcount);
            dt.Columns.Add(colnum);
            dt.Columns.Add(colarrival);
            dt.Columns.Add(colleave);
            dt.Columns.Add(coltime);
            dt.Columns.Add(colmoney);
            InitializeComponent();
           // dgvInfo.colmn
            lbusername.Text = username;
        }

        private void btnAddCar_Click(object sender, EventArgs e)
        {
            FrmInfo frminfo = new FrmInfo(dgvInfo);
            frminfo.Show();
        }


    }
}
