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
    public partial class FrmLogin : Form
    {
        String user;
        String pwd;
        public FrmLogin()
        {
            InitializeComponent();
    
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
          
            string connectionString = "server=localhost;user = root;password=123456;Database=parkinglot;";
            MySqlConnection connection_username = new MySqlConnection(connectionString);
            MySqlConnection connection_userpass = new MySqlConnection(connectionString);
            connection_username.Open();
            connection_userpass.Open();
            MySqlCommand command1 = new MySqlCommand("SELECT username FROM parkinglot.userinfor WHERE username = '" + txtusername.Text + "'", connection_username);
            MySqlCommand command2 = new MySqlCommand("SELECT userpass FROM parkinglot.userinfor WHERE username = '" + txtusername.Text + "'", connection_userpass);
            MySqlDataReader reader1 = command1.ExecuteReader();
            MySqlDataReader reader2 = command2.ExecuteReader();   
           // reader1.Read();
            if (reader1.HasRows)
            {
                connection_username.Close();
                reader2.Read();
                pwd = reader2["userpass"].ToString();
                    if (txtuserpass.Text == pwd)
                    {
                        user = txtusername.Text;
                        pwd = txtuserpass.Text;
                        FrmMain fm2 = new FrmMain(user, pwd);
                        fm2.Show();
                    }
                    else
                    {
                        MessageBox.Show("密码输入错误，请重新输入！");
                    }
            }
            else
            {
                MessageBox.Show("用户名不存在，请先注册");
            }  
        }

        private void btnregister_Click(object sender, EventArgs e)
        {
            FrmRegister frmregister = new FrmRegister();
            FrmLogin frmlogin = new FrmLogin();
            frmlogin.Hide();
            frmregister.Show();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            DialogResult tip = MessageBox.Show("确定退出？", "提示",
                MessageBoxButtons.OKCancel);
            if (tip == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
