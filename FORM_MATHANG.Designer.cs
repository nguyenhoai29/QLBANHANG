namespace QLBANHANG
{
    partial class FORM_MATHANG
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
            this.dgvMATHANG = new System.Windows.Forms.DataGridView();
            this.txtMaMH = new System.Windows.Forms.TextBox();
            this.txtTenMH = new System.Windows.Forms.TextBox();
            this.txtDonViTinh = new System.Windows.Forms.TextBox();
            this.txtGiaBan = new System.Windows.Forms.TextBox();
            this.txtMaLH = new System.Windows.Forms.TextBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvMATHANG)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMATHANG
            // 
            this.dgvMATHANG.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvMATHANG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMATHANG.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dgvMATHANG.Location = new System.Drawing.Point(5, 195);
            this.dgvMATHANG.Name = "dgvMATHANG";
            this.dgvMATHANG.Size = new System.Drawing.Size(772, 149);
            this.dgvMATHANG.TabIndex = 0;
            this.dgvMATHANG.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMATHANG_CellContentClick);
            // 
            // txtMaMH
            // 
            this.txtMaMH.Location = new System.Drawing.Point(152, 52);
            this.txtMaMH.Name = "txtMaMH";
            this.txtMaMH.Size = new System.Drawing.Size(214, 20);
            this.txtMaMH.TabIndex = 1;
            // 
            // txtTenMH
            // 
            this.txtTenMH.Location = new System.Drawing.Point(152, 101);
            this.txtTenMH.Name = "txtTenMH";
            this.txtTenMH.Size = new System.Drawing.Size(214, 20);
            this.txtTenMH.TabIndex = 1;
            // 
            // txtDonViTinh
            // 
            this.txtDonViTinh.Location = new System.Drawing.Point(152, 143);
            this.txtDonViTinh.Name = "txtDonViTinh";
            this.txtDonViTinh.Size = new System.Drawing.Size(214, 20);
            this.txtDonViTinh.TabIndex = 1;
            // 
            // txtGiaBan
            // 
            this.txtGiaBan.Location = new System.Drawing.Point(537, 51);
            this.txtGiaBan.Name = "txtGiaBan";
            this.txtGiaBan.Size = new System.Drawing.Size(206, 20);
            this.txtGiaBan.TabIndex = 1;
            // 
            // txtMaLH
            // 
            this.txtMaLH.Location = new System.Drawing.Point(537, 96);
            this.txtMaLH.Name = "txtMaLH";
            this.txtMaLH.Size = new System.Drawing.Size(206, 20);
            this.txtMaLH.TabIndex = 1;
            // 
            // btnTK
            // 
            this.btnTK.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnTK.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTK.Location = new System.Drawing.Point(568, 360);
            this.btnTK.Name = "btnTK";
            this.btnTK.Size = new System.Drawing.Size(90, 40);
            this.btnTK.TabIndex = 72;
            this.btnTK.Text = "🔍Tìm Kiếm";
            this.btnTK.UseVisualStyleBackColor = false;
            this.btnTK.Click += new System.EventHandler(this.btnTK_Click);
            // 
            // btnHienThi
            // 
            this.btnHienThi.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnHienThi.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHienThi.Location = new System.Drawing.Point(5, 360);
            this.btnHienThi.Name = "btnHienThi";
            this.btnHienThi.Size = new System.Drawing.Size(90, 40);
            this.btnHienThi.TabIndex = 70;
            this.btnHienThi.Text = "👁️ Hiển thị";
            this.btnHienThi.UseVisualStyleBackColor = false;
            this.btnHienThi.Click += new System.EventHandler(this.btnHienThi_Click);
            // 
            // btnT
            // 
            this.btnT.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnT.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnT.Location = new System.Drawing.Point(687, 360);
            this.btnT.Name = "btnT";
            this.btnT.Size = new System.Drawing.Size(90, 40);
            this.btnT.TabIndex = 71;
            this.btnT.Text = "🚪 Thoát";
            this.btnT.UseVisualStyleBackColor = false;
            this.btnT.Click += new System.EventHandler(this.btnT_Click);
            // 
            // btnX
            // 
            this.btnX.BackColor = System.Drawing.Color.Red;
            this.btnX.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnX.Location = new System.Drawing.Point(450, 360);
            this.btnX.Name = "btnX";
            this.btnX.Size = new System.Drawing.Size(90, 40);
            this.btnX.TabIndex = 69;
            this.btnX.Text = "🗑️ Xoá";
            this.btnX.UseVisualStyleBackColor = false;
            this.btnX.Click += new System.EventHandler(this.btnX_Click);
            // 
            // btnCN
            // 
            this.btnCN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCN.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCN.Location = new System.Drawing.Point(339, 360);
            this.btnCN.Name = "btnCN";
            this.btnCN.Size = new System.Drawing.Size(90, 40);
            this.btnCN.TabIndex = 68;
            this.btnCN.Text = "✏️Cập nhật";
            this.btnCN.UseVisualStyleBackColor = false;
            this.btnCN.Click += new System.EventHandler(this.btnCN_Click);
            // 
            // btnL
            // 
            this.btnL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnL.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnL.Location = new System.Drawing.Point(223, 360);
            this.btnL.Name = "btnL";
            this.btnL.Size = new System.Drawing.Size(90, 40);
            this.btnL.TabIndex = 67;
            this.btnL.Text = "💾 Lưu";
            this.btnL.UseVisualStyleBackColor = false;
            this.btnL.Click += new System.EventHandler(this.btnL_Click);
            // 
            // btnTM
            // 
            this.btnTM.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnTM.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTM.Location = new System.Drawing.Point(118, 360);
            this.btnTM.Name = "btnTM";
            this.btnTM.Size = new System.Drawing.Size(90, 40);
            this.btnTM.TabIndex = 66;
            this.btnTM.Text = "➕ Tạo mới";
            this.btnTM.UseVisualStyleBackColor = false;
            this.btnTM.Click += new System.EventHandler(this.btnTM_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 20);
            this.label2.TabIndex = 73;
            this.label2.Text = "Mã Mặt Hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 20);
            this.label3.TabIndex = 73;
            this.label3.Text = "Tên Mặt Hàng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 20);
            this.label4.TabIndex = 73;
            this.label4.Text = "Đơn Vị Tính";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(412, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 20);
            this.label5.TabIndex = 73;
            this.label5.Text = "Giá Bán";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(412, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 20);
            this.label6.TabIndex = 73;
            this.label6.Text = "Mã Loại Hàng";
            // 
            // FORM_MATHANG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(781, 412);
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
            this.Controls.Add(this.txtMaLH);
            this.Controls.Add(this.txtGiaBan);
            this.Controls.Add(this.txtDonViTinh);
            this.Controls.Add(this.txtTenMH);
            this.Controls.Add(this.txtMaMH);
            this.Controls.Add(this.dgvMATHANG);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FORM_MATHANG";
            this.Text = "FORM_MATHANG";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMATHANG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMATHANG;
        private System.Windows.Forms.TextBox txtMaMH;
        private System.Windows.Forms.TextBox txtTenMH;
        private System.Windows.Forms.TextBox txtDonViTinh;
        private System.Windows.Forms.TextBox txtGiaBan;
        private System.Windows.Forms.TextBox txtMaLH;
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
    }
}