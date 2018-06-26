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
        DateTime arrival  = DateTime.Now;
        String num = null;
        String count = null;
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

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            FrmInfo frminfo = new FrmInfo(arrival,num,count);
            DateTime leave = DateTime.Now;
            TimeSpan time = leave - arrival;
            double getHours = time.TotalHours;
            double money = getHours * 2;

            int index = dgvInfo.SelectedRows[0].Index;
            FrmMain.dt.Rows[index]["colcount"] = count;
            FrmMain.dt.Rows[index]["colnum"] = num;
            FrmMain.dt.Rows[index]["colarrival"] = arrival;
            FrmMain.dt.Rows[index]["colleave"] = leave;
            FrmMain.dt.Rows[index]["colltime"] = time;
            FrmMain.dt.Rows[index]["colmoney"] = money;
            dgvInfo.DataSource = FrmMain.dt;
        }


    }
}