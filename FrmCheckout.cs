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
    public partial class FrmCheckout : Form
    {
        DataGridView dgvInfo;
        String num = null;
        String count = null;
        String type = null;
        String arrival = null;
        DateTime leave = new DateTime();
        double time = 0;
        double money = 0;
        public FrmCheckout()
        {
            InitializeComponent();
        }
        public FrmCheckout(DataGridView _dgvInfo, String _num, String _type, String _count, String _arrival, DateTime _leave, double _time, double _money)
        {
            InitializeComponent();
            dgvInfo = _dgvInfo;
            num = _num;
            type = _type;
            count = _count;
            arrival = _arrival;
            leave = _leave;
            time = _time;
            money = _money;
            lbname.Text = num;
            lbtype.Text = type;
            lbcount.Text = count;
            lbarrival.Text = arrival;
            lbleave.Text = Convert.ToString(leave);        
            lbtime.Text = Convert.ToString(time);
            lbmoney.Text = Convert.ToString(money);
            int index = dgvInfo.SelectedRows[0].Index;    
            String selectnum = dgvInfo.Rows[index].Cells["colNum"].Value.ToString();
            string connectionString = "server=localhost;user = root;password=123456;Database=parkinglot;Charset=utf8";
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            MySqlCommand command = new MySqlCommand("update vehicleinfo set vehicle_leave = '" + leave + "',vehicle_time = '" + time + "',vehicle_money = '" + money + "' where  vehicle_id = '" + selectnum + "' ", connection);
            if (command.ExecuteNonQuery() > 0)
                {
                    dgvInfo.DataSource = FrmMain.dt;
                }
            
             }


        private void btncheckout_Click(object sender, EventArgs e)
        {
            int index = dgvInfo.SelectedRows[0].Index;
            FrmMain.dt.Rows.RemoveAt(index);
            FrmOver frmover = new FrmOver(time,money);
            frmover.Show();

        }
        private void btnExitInfo_Click(object sender, EventArgs e)
        {
            DialogResult tip = MessageBox.Show("确定取消结算？", "提示",
               MessageBoxButtons.OKCancel);
            if (tip == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void FrmCheckout_Load(object sender, EventArgs e)
        {

        }
    }
}

