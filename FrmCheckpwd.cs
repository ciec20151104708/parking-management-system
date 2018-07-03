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
                string connectionString = "server=localhost;user = root;password=123456;Database=parkinglot;";
                MySqlConnection connection = new MySqlConnection(connectionString);
                connection.Open();
                if (txtpwd.Text == txtsurepwd.Text)
                {
                   
                    MySqlCommand command = new MySqlCommand("update parkinglot.userinfor set userpass = '" + txtpwd.Text + "'where  username = '" + txtuser + "' ", connection);
                    if (command.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("修改成功！");
                    } 
                }
                else
                {
                    MessageBox.Show("两次密码输入不同！请重新输入！");
                }
    
            }
           
        }
    }

