namespace QLBANHANG
{
    partial class FORM_KHACHHANG
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
            this.dgvKHACHHANG = new System.Windows.Forms.DataGridView();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnTK = new System.Windows.Forms.Button();
            this.btnHienThi = new System.Windows.Forms.Button();
            this.btnT = new System.Windows.Forms.Button();
            this.btnX = new System.Windows.Forms.Button();
            this.btnCN = new System.Windows.Forms.Button();
            this.btnL = new System.Windows.Forms.Button();
            this.btnTM = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTK = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKHACHHANG)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvKHACHHANG
            // 
            this.dgvKHACHHANG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKHACHHANG.Location = new System.Drawing.Point(12, 159);
            this.dgvKHACHHANG.Name = "dgvKHACHHANG";
            this.dgvKHACHHANG.Size = new System.Drawing.Size(756, 195);
            this.dgvKHACHHANG.TabIndex = 0;
            this.dgvKHACHHANG.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKHACHHANG_CellContentClick);
            // 
            // txtMaKH
            // 
            this.txtMaKH.Location = new System.Drawing.Point(146, 48);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(223, 20);
            this.txtMaKH.TabIndex = 1;
            // 
            // txtTenKH
            // 
            this.txtTenKH.Location = new System.Drawing.Point(147, 89);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(223, 20);
            this.txtTenKH.TabIndex = 1;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(146, 128);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(223, 20);
            this.txtDiaChi.TabIndex = 1;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(515, 48);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(227, 20);
            this.txtSDT.TabIndex = 1;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(515, 89);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(227, 20);
            this.txtEmail.TabIndex = 1;
            // 
            // btnTK
            // 
            this.btnTK.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnTK.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTK.Location = new System.Drawing.Point(540, 373);
            this.btnTK.Name = "btnTK";
            this.btnTK.Size = new System.Drawing.Size(106, 34);
            this.btnTK.TabIndex = 72;
            this.btnTK.Text = "🔍Tìm Kiếm";
            this.btnTK.UseVisualStyleBackColor = false;
            this.btnTK.Click += new System.EventHandler(this.btnTK_Click);
            // 
            // btnHienThi
            // 
            this.btnHienThi.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnHienThi.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHienThi.Location = new System.Drawing.Point(658, 122);
            this.btnHienThi.Name = "btnHienThi";
            this.btnHienThi.Size = new System.Drawing.Size(110, 31);
            this.btnHienThi.TabIndex = 70;
            this.btnHienThi.Text = "👁️ Hiển thị";
            this.btnHienThi.UseVisualStyleBackColor = false;
            this.btnHienThi.Click += new System.EventHandler(this.btnHienThi_Click);
            // 
            // btnT
            // 
            this.btnT.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnT.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnT.Location = new System.Drawing.Point(675, 373);
            this.btnT.Name = "btnT";
            this.btnT.Size = new System.Drawing.Size(106, 34);
            this.btnT.TabIndex = 71;
            this.btnT.Text = "🚪 Thoát";
            this.btnT.UseVisualStyleBackColor = false;
            this.btnT.Click += new System.EventHandler(this.btnT_Click);
            // 
            // btnX
            // 
            this.btnX.BackColor = System.Drawing.Color.Red;
            this.btnX.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnX.Location = new System.Drawing.Point(405, 373);
            this.btnX.Name = "btnX";
            this.btnX.Size = new System.Drawing.Size(106, 34);
            this.btnX.TabIndex = 69;
            this.btnX.Text = "🗑️ Xoá";
            this.btnX.UseVisualStyleBackColor = false;
            this.btnX.Click += new System.EventHandler(this.btnX_Click);
            // 
            // btnCN
            // 
            this.btnCN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCN.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCN.Location = new System.Drawing.Point(272, 373);
            this.btnCN.Name = "btnCN";
            this.btnCN.Size = new System.Drawing.Size(106, 34);
            this.btnCN.TabIndex = 68;
            this.btnCN.Text = "✏️Cập nhật";
            this.btnCN.UseVisualStyleBackColor = false;
            this.btnCN.Click += new System.EventHandler(this.btnCN_Click);
            // 
            // btnL
            // 
            this.btnL.BackColor = System.Drawing.Color.Green;
            this.btnL.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnL.Location = new System.Drawing.Point(141, 373);
            this.btnL.Name = "btnL";
            this.btnL.Size = new System.Drawing.Size(106, 34);
            this.btnL.TabIndex = 67;
            this.btnL.Text = "💾 Lưu";
            this.btnL.UseVisualStyleBackColor = false;
            this.btnL.Click += new System.EventHandler(this.btnL_Click);
            // 
            // btnTM
            // 
            this.btnTM.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnTM.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTM.Location = new System.Drawing.Point(12, 373);
            this.btnTM.Name = "btnTM";
            this.btnTM.Size = new System.Drawing.Size(106, 34);
            this.btnTM.TabIndex = 66;
            this.btnTM.Text = "➕ Tạo mới";
            this.btnTM.UseVisualStyleBackColor = false;
            this.btnTM.Click += new System.EventHandler(this.btnTM_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 20);
            this.label2.TabIndex = 73;
            this.label2.Text = "Mã khách hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 20);
            this.label3.TabIndex = 73;
            this.label3.Text = "Tên khách hàng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 20);
            this.label4.TabIndex = 73;
            this.label4.Text = "Địa chỉ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(402, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 20);
            this.label5.TabIndex = 73;
            this.label5.Text = "Số điện thoại";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(402, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 20);
            this.label6.TabIndex = 73;
            this.label6.Text = "Email";
            // 
            // txtTK
            // 
            this.txtTK.Location = new System.Drawing.Point(218, 12);
            this.txtTK.Name = "txtTK";
            this.txtTK.Size = new System.Drawing.Size(306, 20);
            this.txtTK.TabIndex = 1;
            // 
            // FORM_KHACHHANG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(785, 416);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnTK);
            this.Controls.Add(this.btnHienThi);
            this.Controls.Add(this.btnT);
            this.Controls.Add(this.btnX);
            this.Controls.Add(this.btnCN);
            this.Controls.Add(this.btnL);
            this.Controls.Add(this.btnTM);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.txtTenKH);
            this.Controls.Add(this.txtTK);
            this.Controls.Add(this.txtMaKH);
            this.Controls.Add(this.dgvKHACHHANG);
            this.Name = "FORM_KHACHHANG";
            this.Text = "FORM_KHACHHANG";
            this.Load += new System.EventHandler(this.FORM_KHACHHANG_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKHACHHANG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvKHACHHANG;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnTK;
        private System.Windows.Forms.Button btnHienThi;
        private System.Windows.Forms.Button btnT;
        private System.Windows.Forms.Button btnX;
        private System.Windows.Forms.Button btnCN;
        private System.Windows.Forms.Button btnL;
        private System.Windows.Forms.Button btnTM;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTK;
    }
}