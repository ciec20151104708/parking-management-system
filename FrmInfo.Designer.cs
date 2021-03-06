﻿namespace parking_management_system
{
    partial class FrmInfo
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.txtArrival = new System.Windows.Forms.TextBox();
            this.txtCount = new System.Windows.Forms.TextBox();
            this.btnAddinfo = new System.Windows.Forms.Button();
            this.btnExitInfo = new System.Windows.Forms.Button();
            this.btnGettime = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxtype = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "车牌号";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 264);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "到达时间";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(111, 339);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "位置";
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(190, 135);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(233, 25);
            this.txtNum.TabIndex = 3;
            // 
            // txtArrival
            // 
            this.txtArrival.Location = new System.Drawing.Point(190, 261);
            this.txtArrival.Name = "txtArrival";
            this.txtArrival.Size = new System.Drawing.Size(233, 25);
            this.txtArrival.TabIndex = 4;
            // 
            // txtCount
            // 
            this.txtCount.Location = new System.Drawing.Point(190, 339);
            this.txtCount.Name = "txtCount";
            this.txtCount.Size = new System.Drawing.Size(233, 25);
            this.txtCount.TabIndex = 5;
            // 
            // btnAddinfo
            // 
            this.btnAddinfo.Location = new System.Drawing.Point(49, 422);
            this.btnAddinfo.Name = "btnAddinfo";
            this.btnAddinfo.Size = new System.Drawing.Size(112, 23);
            this.btnAddinfo.TabIndex = 6;
            this.btnAddinfo.Text = "添加车辆";
            this.btnAddinfo.UseVisualStyleBackColor = true;
            this.btnAddinfo.Click += new System.EventHandler(this.btnAddinfo_Click);
            // 
            // btnExitInfo
            // 
            this.btnExitInfo.Location = new System.Drawing.Point(395, 422);
            this.btnExitInfo.Name = "btnExitInfo";
            this.btnExitInfo.Size = new System.Drawing.Size(104, 23);
            this.btnExitInfo.TabIndex = 7;
            this.btnExitInfo.Text = "退出";
            this.btnExitInfo.UseVisualStyleBackColor = true;
            this.btnExitInfo.Click += new System.EventHandler(this.btnExitInfo_Click);
            // 
            // btnGettime
            // 
            this.btnGettime.Location = new System.Drawing.Point(445, 261);
            this.btnGettime.Name = "btnGettime";
            this.btnGettime.Size = new System.Drawing.Size(113, 23);
            this.btnGettime.TabIndex = 8;
            this.btnGettime.Text = "获取当前时间";
            this.btnGettime.UseVisualStyleBackColor = true;
            this.btnGettime.Click += new System.EventHandler(this.btnGettime_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(81, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "车辆类型";
            // 
            // comboBoxtype
            // 
            this.comboBoxtype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxtype.FormattingEnabled = true;
            this.comboBoxtype.Items.AddRange(new object[] {
            "小型车辆",
            "中型车辆",
            "大型车辆"});
            this.comboBoxtype.Location = new System.Drawing.Point(190, 201);
            this.comboBoxtype.Name = "comboBoxtype";
            this.comboBoxtype.Size = new System.Drawing.Size(233, 23);
            this.comboBoxtype.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(61, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(438, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "收费标准：小型车5元/小时，中型车6元/小时，大型车10元/小时\r\n";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(204, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "*注意车辆类型选择！";
            // 
            // FrmInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 507);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxtype);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnGettime);
            this.Controls.Add(this.btnExitInfo);
            this.Controls.Add(this.btnAddinfo);
            this.Controls.Add(this.txtCount);
            this.Controls.Add(this.txtArrival);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmInfo";
            this.Text = "车辆添加菜单";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.TextBox txtArrival;
        private System.Windows.Forms.TextBox txtCount;
        private System.Windows.Forms.Button btnAddinfo;
        private System.Windows.Forms.Button btnExitInfo;
        private System.Windows.Forms.Button btnGettime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxtype;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}