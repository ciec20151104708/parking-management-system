namespace parking_management_system
{
    partial class FrmRegister
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
            this.txtregistername = new System.Windows.Forms.TextBox();
            this.txtregisterpass = new System.Windows.Forms.TextBox();
            this.btnregisterok = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.txtresurepass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(127, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "用户名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(128, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "密码";
            // 
            // txtregistername
            // 
            this.txtregistername.Location = new System.Drawing.Point(243, 62);
            this.txtregistername.Name = "txtregistername";
            this.txtregistername.Size = new System.Drawing.Size(209, 25);
            this.txtregistername.TabIndex = 2;
            // 
            // txtregisterpass
            // 
            this.txtregisterpass.Location = new System.Drawing.Point(244, 123);
            this.txtregisterpass.Name = "txtregisterpass";
            this.txtregisterpass.PasswordChar = '*';
            this.txtregisterpass.Size = new System.Drawing.Size(209, 25);
            this.txtregisterpass.TabIndex = 3;
            // 
            // btnregisterok
            // 
            this.btnregisterok.Location = new System.Drawing.Point(119, 243);
            this.btnregisterok.Name = "btnregisterok";
            this.btnregisterok.Size = new System.Drawing.Size(75, 23);
            this.btnregisterok.TabIndex = 4;
            this.btnregisterok.Text = "确认注册";
            this.btnregisterok.UseVisualStyleBackColor = true;
            this.btnregisterok.Click += new System.EventHandler(this.btnregisterok_Click);
            // 
            // btncancel
            // 
            this.btncancel.Location = new System.Drawing.Point(399, 242);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(75, 23);
            this.btncancel.TabIndex = 5;
            this.btncancel.Text = "取消";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // txtresurepass
            // 
            this.txtresurepass.Location = new System.Drawing.Point(244, 184);
            this.txtresurepass.Name = "txtresurepass";
            this.txtresurepass.PasswordChar = '*';
            this.txtresurepass.Size = new System.Drawing.Size(209, 25);
            this.txtresurepass.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(128, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "确认密码";
            // 
            // FrmRegister
            // 
            this.AcceptButton = this.btnregisterok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 303);
            this.Controls.Add(this.txtresurepass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnregisterok);
            this.Controls.Add(this.txtregisterpass);
            this.Controls.Add(this.txtregistername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmRegister";
            this.Text = "注册窗口";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtregistername;
        private System.Windows.Forms.TextBox txtregisterpass;
        private System.Windows.Forms.Button btnregisterok;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.TextBox txtresurepass;
        private System.Windows.Forms.Label label3;
    }
}