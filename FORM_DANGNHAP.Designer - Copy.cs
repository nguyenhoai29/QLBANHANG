namespace QLBANHANG
{
    partial class FORM_DANGNHAP
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
            this.btnDN = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.txtMK = new System.Windows.Forms.TextBox();
            this.txtUN = new System.Windows.Forms.TextBox();
            this.lblMatKhau = new System.Windows.Forms.Label();
            this.lblTen = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Gold;
            this.label1.Font = new System.Drawing.Font("Georgia Ref", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(-2, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(362, 60);
            this.label1.TabIndex = 25;
            this.label1.Text = "ĐĂNG NHẬP";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.UseWaitCursor = true;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnDN
            // 
            this.btnDN.BackColor = System.Drawing.Color.Chartreuse;
            this.btnDN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDN.Location = new System.Drawing.Point(28, 201);
            this.btnDN.Name = "btnDN";
            this.btnDN.Size = new System.Drawing.Size(146, 38);
            this.btnDN.TabIndex = 21;
            this.btnDN.Text = "Đăng nhập";
            this.btnDN.UseVisualStyleBackColor = false;
            this.btnDN.Click += new System.EventHandler(this.btnDN_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.Tomato;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(192, 201);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(146, 38);
            this.btnThoat.TabIndex = 22;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // txtMK
            // 
            this.txtMK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMK.Location = new System.Drawing.Point(145, 131);
            this.txtMK.Name = "txtMK";
            this.txtMK.Size = new System.Drawing.Size(193, 26);
            this.txtMK.TabIndex = 20;
            this.txtMK.UseSystemPasswordChar = true;
            // 
            // txtUN
            // 
            this.txtUN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUN.Location = new System.Drawing.Point(145, 86);
            this.txtUN.Name = "txtUN";
            this.txtUN.Size = new System.Drawing.Size(193, 26);
            this.txtUN.TabIndex = 19;
            // 
            // lblMatKhau
            // 
            this.lblMatKhau.AutoSize = true;
            this.lblMatKhau.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatKhau.Location = new System.Drawing.Point(12, 131);
            this.lblMatKhau.Name = "lblMatKhau";
            this.lblMatKhau.Size = new System.Drawing.Size(104, 23);
            this.lblMatKhau.TabIndex = 23;
            this.lblMatKhau.Text = "PassWord";
            // 
            // lblTen
            // 
            this.lblTen.AutoSize = true;
            this.lblTen.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTen.Location = new System.Drawing.Point(11, 89);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(102, 23);
            this.lblTen.TabIndex = 24;
            this.lblTen.Text = "Username";
            // 
            // FORM_DANGNHAP
            // 
            this.AcceptButton = this.btnDN;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(359, 264);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDN);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.txtMK);
            this.Controls.Add(this.txtUN);
            this.Controls.Add(this.lblMatKhau);
            this.Controls.Add(this.lblTen);
            this.Name = "FORM_DANGNHAP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FORM_DANGNHAP";
            this.Load += new System.EventHandler(this.FORM_DANGNHAP_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDN;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.TextBox txtMK;
        private System.Windows.Forms.TextBox txtUN;
        private System.Windows.Forms.Label lblMatKhau;
        private System.Windows.Forms.Label lblTen;
    }
}