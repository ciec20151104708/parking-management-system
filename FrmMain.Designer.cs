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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCharge = new System.Windows.Forms.Button();
            this.btnAddCar = new System.Windows.Forms.Button();
            this.dgvInfo = new System.Windows.Forms.DataGridView();
            this.ColCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColArrival = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Colplace = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbusername = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnalteruserpass = new System.Windows.Forms.Button();
            this.btnExitSystem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCharge);
            this.groupBox2.Controls.Add(this.btnAddCar);
            this.groupBox2.Controls.Add(this.dgvInfo);
            this.groupBox2.Location = new System.Drawing.Point(12, 141);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(777, 362);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "停车信息";
            // 
            // btnCharge
            // 
            this.btnCharge.Location = new System.Drawing.Point(594, 226);
            this.btnCharge.Name = "btnCharge";
            this.btnCharge.Size = new System.Drawing.Size(113, 23);
            this.btnCharge.TabIndex = 2;
            this.btnCharge.Text = "结算停车费";
            this.btnCharge.UseVisualStyleBackColor = true;
            this.btnCharge.Click += new System.EventHandler(this.btnCharge_Click);
            // 
            // btnAddCar
            // 
            this.btnAddCar.Location = new System.Drawing.Point(594, 85);
            this.btnAddCar.Name = "btnAddCar";
            this.btnAddCar.Size = new System.Drawing.Size(113, 23);
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
            this.ColType,
            this.ColArrival,
            this.Colplace});
            this.dgvInfo.Location = new System.Drawing.Point(6, 34);
            this.dgvInfo.Name = "dgvInfo";
            this.dgvInfo.RowTemplate.Height = 27;
            this.dgvInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInfo.Size = new System.Drawing.Size(551, 305);
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
            // ColType
            // 
            this.ColType.DataPropertyName = "coltype";
            this.ColType.HeaderText = "车辆类型";
            this.ColType.Name = "ColType";
            // 
            // ColArrival
            // 
            this.ColArrival.DataPropertyName = "colarrival";
            this.ColArrival.HeaderText = "到达时间";
            this.ColArrival.Name = "ColArrival";
            // 
            // Colplace
            // 
            this.Colplace.DataPropertyName = "colcount";
            this.Colplace.HeaderText = "位置";
            this.Colplace.Name = "Colplace";
            // 
            // lbusername
            // 
            this.lbusername.AutoSize = true;
            this.lbusername.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbusername.Location = new System.Drawing.Point(132, 27);
            this.lbusername.Name = "lbusername";
            this.lbusername.Size = new System.Drawing.Size(0, 24);
            this.lbusername.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(225, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(202, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "，欢迎使用停车场管理系统！";
            // 
            // btnalteruserpass
            // 
            this.btnalteruserpass.Location = new System.Drawing.Point(576, 30);
            this.btnalteruserpass.Name = "btnalteruserpass";
            this.btnalteruserpass.Size = new System.Drawing.Size(75, 23);
            this.btnalteruserpass.TabIndex = 6;
            this.btnalteruserpass.Text = "修改密码";
            this.btnalteruserpass.UseVisualStyleBackColor = true;
            this.btnalteruserpass.Click += new System.EventHandler(this.btnalteruserpass_Click);
            // 
            // btnExitSystem
            // 
            this.btnExitSystem.Location = new System.Drawing.Point(695, 30);
            this.btnExitSystem.Name = "btnExitSystem";
            this.btnExitSystem.Size = new System.Drawing.Size(75, 23);
            this.btnExitSystem.TabIndex = 7;
            this.btnExitSystem.Text = "退出系统";
            this.btnExitSystem.UseVisualStyleBackColor = true;
            this.btnExitSystem.Click += new System.EventHandler(this.btnExitSystem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(137, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(526, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "*本停车场共50个停车位，停车一小时内免费。超过一小时按照车辆类型收费。\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "您好";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 513);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExitSystem);
            this.Controls.Add(this.btnalteruserpass);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbusername);
            this.Controls.Add(this.groupBox2);
            this.Name = "FrmMain";
            this.Text = "停车场管理系统";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.DataGridViewTextBoxColumn ColType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColArrival;
        private System.Windows.Forms.DataGridViewTextBoxColumn Colplace;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}