﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace parking_management_system
{
    public partial class FrmInfo : Form
    {
        DataGridView dgvInfo;
        DateTime arrival = DateTime.Now;
   
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
            String type = comboBoxtype.Text;
            Encoding.Default.GetString(Encoding.Default.GetBytes(type)); 
            string connectionString = "server=localhost;user = root;password=123456;Database=parkinglot;";
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            MySqlCommand command = new MySqlCommand("insert into parkinglot.vehicleinfo(vehicle_id,vehicle_type,vehicle_place,vehicle_arrival)values('" + txtNum.Text + "','" + type + "','" + count+"','" + arrival + "')", connection);
            if (command.ExecuteNonQuery() > 0)
            {
               
                DataRow dr = FrmMain.dt.NewRow();
                dr["colnum"] = num;
                dr["colarrival"] = arrival;
                dr["colcount"] = count;
                dr["coltype"] = type;
                FrmMain.dt.Rows.Add(dr);
                dgvInfo.DataSource = FrmMain.dt;
                MessageBox.Show("车辆已停入！");
                this.Close();
                
            }
            else
            {
                MessageBox.Show("录入失败");
            }
           // DateTime leave = DateTime.Now;
           // TimeSpan time = leave - arrival;
           // double getHours = time.TotalHours;
           // double money = getHours * 2;
        }

        private void btnGettime_Click(object sender, EventArgs e)
        {
            txtArrival.Text = Convert.ToString(arrival);
        }

        private void btnExitInfo_Click(object sender, EventArgs e)
        {
            DialogResult tip = MessageBox.Show("确定取消添加车辆？", "提示",
               MessageBoxButtons.OKCancel);
            if (tip == DialogResult.OK)
            {
                this.Close();
            }
        }




    }
}
