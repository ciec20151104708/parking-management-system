namespace parking_management_system
{
    partial class FrmCheckpwd
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
            this.btnchangepwd = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.txtuser = new System.Windows.Forms.TextBox();
            this.txtpwd = new System.Windows.Forms.TextBox();
            this.txtsurepwd = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "用户名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "密码";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "确认密码";
            // 
            // btnchangepwd
            // 
            this.btnchangepwd.Location = new System.Drawing.Point(101, 285);
            this.btnchangepwd.Name = "btnchangepwd";
            this.btnchangepwd.Size = new System.Drawing.Size(75, 23);
            this.btnchangepwd.TabIndex = 3;
            this.btnchangepwd.Text = "更改密码";
            this.btnchangepwd.UseVisualStyleBackColor = true;
            this.btnchangepwd.Click += new System.EventHandler(this.btnchangepwd_Click);
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(347, 285);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(75, 23);
            this.btnexit.TabIndex = 4;
            this.btnexit.Text = "取消";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // txtuser
            // 
            this.txtuser.Location = new System.Drawing.Point(191, 50);
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(199, 25);
            this.txtuser.TabIndex = 5;
            // 
            // txtpwd
            // 
            this.txtpwd.Location = new System.Drawing.Point(191, 128);
            this.txtpwd.Name = "txtpwd";
            this.txtpwd.PasswordChar = '*';
            this.txtpwd.Size = new System.Drawing.Size(199, 25);
            this.txtpwd.TabIndex = 6;
            // 
            // txtsurepwd
            // 
            this.txtsurepwd.Location = new System.Drawing.Point(191, 203);
            this.txtsurepwd.Name = "txtsurepwd";
            this.txtsurepwd.PasswordChar = '*';
            this.txtsurepwd.Size = new System.Drawing.Size(199, 25);
            this.txtsurepwd.TabIndex = 7;
            // 
            // FrmCheckpwd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 349);
            this.Controls.Add(this.txtsurepwd);
            this.Controls.Add(this.txtpwd);
            this.Controls.Add(this.txtuser);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnchangepwd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmCheckpwd";
            this.Text = "修改密码";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnchangepwd;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.TextBox txtuser;
        private System.Windows.Forms.TextBox txtpwd;
        private System.Windows.Forms.TextBox txtsurepwd;
    }
}