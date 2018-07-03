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
    public partial class FrmCheckpwd : Form
    {
        
        public FrmCheckpwd()
        {
            InitializeComponent();
        }

        private void btnchangepwd_Click(object sender, EventArgs e)
        {
            String pwd = txtpwd.Text;
            String user = txtuser.Text;
            String surepwd = txtsurepwd.Text;
            if (pwd == surepwd)
            {
                string connectionString = "server=localhost;user = root;password=123456;Database=parkinglot;";
                MySqlConnection connection = new MySqlConnection(connectionString);
                connection.Open();
                MySqlCommand command = new MySqlCommand("update parkinglot.userinfor set userpass = '" + pwd + "' where  username = '" + user + "'", connection);
                if (command.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("修改成功！");
                }
                else
                {
                    MessageBox.Show("修改失败");
                }
            }
            else
            {
                MessageBox.Show("两次密码不统一，请重新输入！");
            }
         }
        }
    }

