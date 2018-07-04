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
    public partial class FrmRegister : Form
    {
        public FrmRegister()
        {
            InitializeComponent();
        }

        private void btnregisterok_Click(object sender, EventArgs e)
        {
            String registername = txtregistername.Text;
            FrmLogin frmlogin = new FrmLogin();
            string connectionString = "server=localhost;user = root;password=123456;Database=parkinglot;";
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            MySqlCommand command = new MySqlCommand("insert into parkinglot.userinfor(username,userpass)values('"+ txtregistername.Text +"','"+ txtregisterpass.Text +"')",connection);
            MySqlCommand command2 = new MySqlCommand("select count(*) from parkinglot.userinfor where username = '"+registername+"'", connection);
            int count =Convert.ToInt16(command2.ExecuteScalar());
            MessageBox.Show(count.ToString());
            if (count > 0)
            {
                MessageBox.Show("用户名已存在，请重新输入！");
                txtregistername.Text = "";
                txtregisterpass.Text = "";
                txtresurepass.Text = "";
            }
            else
            {
               
                if (txtregistername.TextLength <= 0 || txtregisterpass.TextLength <= 0)
                {
                    MessageBox.Show("用户名或密码不能为空！");
                }
                else
                {
                    if (txtresurepass.Text != txtregisterpass.Text)
                    {
                        MessageBox.Show("两次密码输入不同，请重新输入！");
                    }
                    else
                    {
                        if (command.ExecuteNonQuery() > 0)
                        {
                            MessageBox.Show("注册成功！");
                            frmlogin.Show();
                        }
                    }
                }
            }
        }
        private void btncancel_Click(object sender, EventArgs e)
        {
           
            DialogResult tip = MessageBox.Show("确定取消注册？", "提示",
                MessageBoxButtons.OKCancel);
            if(tip ==DialogResult.OK)
            {
                this.Close();
            }
        }

        private void FrmRegister_Load(object sender, EventArgs e)
        {
            pictureBox.ImageLocation = "parkinglog.jpg";
        }
    }
}
