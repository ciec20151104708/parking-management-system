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
            if (user != "")
            {
                if (pwd == surepwd)
                {
                    string connectionString = "server=localhost;user = root;password=123456;Database=parkinglot;";
                    MySqlConnection connection = new MySqlConnection(connectionString);
                    connection.Open();
                    MySqlCommand command = new MySqlCommand("update parkinglot.userinfor set userpass = '" + pwd + "' where  username = '" + user + "'", connection);
                    if (command.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("密码已修改成功！");
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
            else
            {
                MessageBox.Show("用户名不能为空！");
            }
         }

        private void btnexit_Click(object sender, EventArgs e)
        {
            DialogResult tip = MessageBox.Show("确定取消修改密码？", "提示",
              MessageBoxButtons.OKCancel);
            if (tip == DialogResult.OK)
            {
                this.Close();
            }
        }
        }
    }

