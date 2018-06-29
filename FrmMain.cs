using System;
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
            DataColumn coltype = new DataColumn("colType");

            
            dt.Columns.Add(colcount);
            dt.Columns.Add(colnum);
            dt.Columns.Add(colarrival);
            dt.Columns.Add(coltype);

            InitializeComponent();
           // dgvInfo.colmn
            lbusername.Text = username;
        }

        private void btnAddCar_Click(object sender, EventArgs e)
        {
            FrmInfo frminfo = new FrmInfo(dgvInfo);    
            frminfo.Show();
        }

        private void btnCharge_Click(object sender, EventArgs e)
        {
            String num = null;
            String count = null;
            String type = null;
            String arrival = null;
            DateTime leave = DateTime.Now;
            
            string connectionString = "server=localhost;user = root;password=123456;Database=parkinglot;";
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            MySqlCommand command = new MySqlCommand("select * from parkinglot.vehicleinfo", connection);
            MySqlDataReader reader = null;

            reader = command.ExecuteReader();
            while (reader.Read())
            {
                num = reader[1].ToString();
                type = reader[2].ToString();
                count = reader[3].ToString();
                arrival = reader[4].ToString();
            } 
            reader.Close();
            connection.Close();
            DateTime arrival_time = Convert.ToDateTime(arrival);
            TimeSpan getHours = leave.Subtract(arrival_time);

            double time = getHours.TotalHours;
            Math.Round(time,2);
            double money = time * 3;
            Math.Round(time,2);
            FrmCheckout frmcheckout = new FrmCheckout(dgvInfo,num,type,count,arrival,leave,time,money);
            frmcheckout.Show();
        }




    }
}
