using System;
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
        
        public FrmMain()
        {
            InitializeComponent();
        }
        public FrmMain(string username,string password)
        {
            InitializeComponent();
            txtname.Text = username;
            txtpwd.Text = password;
        }

    }
}
