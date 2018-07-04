namespace parking_management_system
{
    partial class FrmOver
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
            this.txtovertime = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtovermoney = new System.Windows.Forms.Label();
            this.btnover = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "您好，本次停车时长为：";
            // 
            // txtovertime
            // 
            this.txtovertime.AutoSize = true;
            this.txtovertime.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtovertime.Location = new System.Drawing.Point(269, 76);
            this.txtovertime.Name = "txtovertime";
            this.txtovertime.Size = new System.Drawing.Size(75, 20);
            this.txtovertime.TabIndex = 1;
            this.txtovertime.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(107, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "本次停车费用为：";
            // 
            // txtovermoney
            // 
            this.txtovermoney.AutoSize = true;
            this.txtovermoney.Font = new System.Drawing.Font("Agency FB", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtovermoney.Location = new System.Drawing.Point(273, 159);
            this.txtovermoney.Name = "txtovermoney";
            this.txtovermoney.Size = new System.Drawing.Size(71, 35);
            this.txtovermoney.TabIndex = 3;
            this.txtovermoney.Text = "label4";
            // 
            // btnover
            // 
            this.btnover.Location = new System.Drawing.Point(185, 321);
            this.btnover.Name = "btnover";
            this.btnover.Size = new System.Drawing.Size(75, 23);
            this.btnover.TabIndex = 4;
            this.btnover.Text = "确定";
            this.btnover.UseVisualStyleBackColor = true;
            this.btnover.Click += new System.EventHandler(this.btnover_Click);
            // 
            // FrmOver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 437);
            this.Controls.Add(this.btnover);
            this.Controls.Add(this.txtovermoney);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtovertime);
            this.Controls.Add(this.label1);
            this.Name = "FrmOver";
            this.Text = "确认结算";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtovertime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label txtovermoney;
        private System.Windows.Forms.Button btnover;
    }
}