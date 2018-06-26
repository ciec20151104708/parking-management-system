namespace parking_management_system
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnrefresh = new System.Windows.Forms.Button();
            this.lboccupy = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbresidue = new System.Windows.Forms.Label();
            this.lball = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCharge = new System.Windows.Forms.Button();
            this.btnAddCar = new System.Windows.Forms.Button();
            this.dgvInfo = new System.Windows.Forms.DataGridView();
            this.ColCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColArrival = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColLeave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColMoney = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbusername = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnalteruserpass = new System.Windows.Forms.Button();
            this.btnExitSystem = new System.Windows.Forms.Button();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnrefresh);
            this.groupBox1.Controls.Add(this.lboccupy);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lbresidue);
            this.groupBox1.Controls.Add(this.lball);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(15, 81);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(838, 61);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "车位信息";
            // 
            // btnrefresh
            // 
            this.btnrefresh.Location = new System.Drawing.Point(707, 24);
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.Size = new System.Drawing.Size(75, 23);
            this.btnrefresh.TabIndex = 6;
            this.btnrefresh.Text = "刷新车位";
            this.btnrefresh.UseVisualStyleBackColor = true;
            // 
            // lboccupy
            // 
            this.lboccupy.AutoSize = true;
            this.lboccupy.Location = new System.Drawing.Point(359, 28);
            this.lboccupy.Name = "lboccupy";
            this.lboccupy.Size = new System.Drawing.Size(55, 15);
            this.lboccupy.TabIndex = 5;
            this.lboccupy.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(271, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "占用车位：";
            // 
            // lbresidue
            // 
            this.lbresidue.AutoSize = true;
            this.lbresidue.Location = new System.Drawing.Point(592, 28);
            this.lbresidue.Name = "lbresidue";
            this.lbresidue.Size = new System.Drawing.Size(55, 15);
            this.lbresidue.TabIndex = 3;
            this.lbresidue.Text = "label5";
            // 
            // lball
            // 
            this.lball.AutoSize = true;
            this.lball.Location = new System.Drawing.Point(151, 28);
            this.lball.Name = "lball";
            this.lball.Size = new System.Drawing.Size(23, 15);
            this.lball.TabIndex = 2;
            this.lball.Text = "50";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(513, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "剩余车位：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "总共车位：";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_refresh);
            this.groupBox2.Controls.Add(this.btnCharge);
            this.groupBox2.Controls.Add(this.btnAddCar);
            this.groupBox2.Controls.Add(this.dgvInfo);
            this.groupBox2.Location = new System.Drawing.Point(184, 166);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(669, 385);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "停车信息";
            // 
            // btnCharge
            // 
            this.btnCharge.Location = new System.Drawing.Point(484, 345);
            this.btnCharge.Name = "btnCharge";
            this.btnCharge.Size = new System.Drawing.Size(113, 23);
            this.btnCharge.TabIndex = 2;
            this.btnCharge.Text = "结算停车费";
            this.btnCharge.UseVisualStyleBackColor = true;
            // 
            // btnAddCar
            // 
            this.btnAddCar.Location = new System.Drawing.Point(82, 345);
            this.btnAddCar.Name = "btnAddCar";
            this.btnAddCar.Size = new System.Drawing.Size(75, 23);
            this.btnAddCar.TabIndex = 1;
            this.btnAddCar.Text = "添加车辆";
            this.btnAddCar.UseVisualStyleBackColor = true;
            this.btnAddCar.Click += new System.EventHandler(this.btnAddCar_Click);
            // 
            // dgvInfo
            // 
            this.dgvInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColCount,
            this.ColNum,
            this.ColArrival,
            this.ColLeave,
            this.ColTime,
            this.ColMoney});
            this.dgvInfo.Location = new System.Drawing.Point(6, 34);
            this.dgvInfo.Name = "dgvInfo";
            this.dgvInfo.RowTemplate.Height = 27;
            this.dgvInfo.Size = new System.Drawing.Size(645, 305);
            this.dgvInfo.TabIndex = 0;
            // 
            // ColCount
            // 
            this.ColCount.DataPropertyName = "colcount";
            this.ColCount.HeaderText = "编号";
            this.ColCount.Name = "ColCount";
            // 
            // ColNum
            // 
            this.ColNum.DataPropertyName = "colnum";
            this.ColNum.HeaderText = "车牌号";
            this.ColNum.Name = "ColNum";
            // 
            // ColArrival
            // 
            this.ColArrival.DataPropertyName = "colarrival";
            this.ColArrival.HeaderText = "到达时间";
            this.ColArrival.Name = "ColArrival";
            // 
            // ColLeave
            // 
            this.ColLeave.DataPropertyName = "colleave";
            this.ColLeave.HeaderText = "离开时间";
            this.ColLeave.Name = "ColLeave";
            // 
            // ColTime
            // 
            this.ColTime.DataPropertyName = "coltime";
            this.ColTime.HeaderText = "停车时长";
            this.ColTime.Name = "ColTime";
            // 
            // ColMoney
            // 
            this.ColMoney.DataPropertyName = "colmoney";
            this.ColMoney.HeaderText = "停车费用";
            this.ColMoney.Name = "ColMoney";
            // 
            // lbusername
            // 
            this.lbusername.AutoSize = true;
            this.lbusername.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbusername.Location = new System.Drawing.Point(64, 27);
            this.lbusername.Name = "lbusername";
            this.lbusername.Size = new System.Drawing.Size(0, 24);
            this.lbusername.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(157, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(202, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "，欢迎使用停车场管理系统！";
            // 
            // btnalteruserpass
            // 
            this.btnalteruserpass.Location = new System.Drawing.Point(587, 31);
            this.btnalteruserpass.Name = "btnalteruserpass";
            this.btnalteruserpass.Size = new System.Drawing.Size(75, 23);
            this.btnalteruserpass.TabIndex = 6;
            this.btnalteruserpass.Text = "修改密码";
            this.btnalteruserpass.UseVisualStyleBackColor = true;
            // 
            // btnExitSystem
            // 
            this.btnExitSystem.Location = new System.Drawing.Point(706, 31);
            this.btnExitSystem.Name = "btnExitSystem";
            this.btnExitSystem.Size = new System.Drawing.Size(75, 23);
            this.btnExitSystem.TabIndex = 7;
            this.btnExitSystem.Text = "退出系统";
            this.btnExitSystem.UseVisualStyleBackColor = true;
            // 
            // btn_refresh
            // 
            this.btn_refresh.Location = new System.Drawing.Point(290, 345);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(75, 23);
            this.btn_refresh.TabIndex = 3;
            this.btn_refresh.Text = "刷新";
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 649);
            this.Controls.Add(this.btnExitSystem);
            this.Controls.Add(this.btnalteruserpass);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbusername);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmMain";
            this.Text = "停车场管理系统";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbresidue;
        private System.Windows.Forms.Label lball;
        private System.Windows.Forms.Button btnrefresh;
        private System.Windows.Forms.Label lboccupy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvInfo;
        private System.Windows.Forms.Label lbusername;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnalteruserpass;
        private System.Windows.Forms.Button btnExitSystem;
        private System.Windows.Forms.Button btnCharge;
        private System.Windows.Forms.Button btnAddCar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColArrival;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColLeave;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMoney;
        private System.Windows.Forms.Button btn_refresh;
    }
}