namespace QLBANHANG
{
    partial class FORM_DONDATHANG
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
            this.btnTK = new System.Windows.Forms.Button();
            this.btnT = new System.Windows.Forms.Button();
            this.btnX = new System.Windows.Forms.Button();
            this.btnCN = new System.Windows.Forms.Button();
            this.btnL = new System.Windows.Forms.Button();
            this.btnTM = new System.Windows.Forms.Button();
            this.btnXoaChiTiet = new System.Windows.Forms.Button();
            this.btnSuaChiTiet = new System.Windows.Forms.Button();
            this.btnThemChiTiet = new System.Windows.Forms.Button();
            this.dtpNgayDH = new System.Windows.Forms.DateTimePicker();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.txtGiaNhap = new System.Windows.Forms.TextBox();
            this.cboMaMH = new System.Windows.Forms.ComboBox();
            this.cboMaNCC = new System.Windows.Forms.ComboBox();
            this.cboMaNV = new System.Windows.Forms.ComboBox();
            this.dgvChiTietDatHang = new System.Windows.Forms.DataGridView();
            this.dgvDonDatHang = new System.Windows.Forms.DataGridView();
            this.txtMaDDH = new System.Windows.Forms.TextBox();
            this.txtTenDDH = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnHienThi = new System.Windows.Forms.Button();
            this.btnIn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietDatHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonDatHang)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTK
            // 
            this.btnTK.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnTK.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTK.Location = new System.Drawing.Point(564, 360);
            this.btnTK.Name = "btnTK";
            this.btnTK.Size = new System.Drawing.Size(105, 44);
            this.btnTK.TabIndex = 91;
            this.btnTK.Text = "🔍Tìm Kiếm";
            this.btnTK.UseVisualStyleBackColor = false;
            this.btnTK.Click += new System.EventHandler(this.btnTK_Click);
            // 
            // btnT
            // 
            this.btnT.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnT.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnT.Location = new System.Drawing.Point(679, 360);
            this.btnT.Name = "btnT";
            this.btnT.Size = new System.Drawing.Size(99, 44);
            this.btnT.TabIndex = 90;
            this.btnT.Text = "🚪 Thoát";
            this.btnT.UseVisualStyleBackColor = false;
            this.btnT.Click += new System.EventHandler(this.btnT_Click);
            // 
            // btnX
            // 
            this.btnX.BackColor = System.Drawing.Color.Red;
            this.btnX.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnX.Location = new System.Drawing.Point(453, 360);
            this.btnX.Name = "btnX";
            this.btnX.Size = new System.Drawing.Size(99, 44);
            this.btnX.TabIndex = 88;
            this.btnX.Text = "🗑️ Xoá";
            this.btnX.UseVisualStyleBackColor = false;
            this.btnX.Click += new System.EventHandler(this.btnX_Click);
            // 
            // btnCN
            // 
            this.btnCN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCN.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCN.Location = new System.Drawing.Point(341, 360);
            this.btnCN.Name = "btnCN";
            this.btnCN.Size = new System.Drawing.Size(99, 44);
            this.btnCN.TabIndex = 87;
            this.btnCN.Text = "✏️Cập nhật";
            this.btnCN.UseVisualStyleBackColor = false;
            this.btnCN.Click += new System.EventHandler(this.btnCN_Click);
            // 
            // btnL
            // 
            this.btnL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnL.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnL.Location = new System.Drawing.Point(230, 360);
            this.btnL.Name = "btnL";
            this.btnL.Size = new System.Drawing.Size(99, 44);
            this.btnL.TabIndex = 86;
            this.btnL.Text = "💾 Lưu";
            this.btnL.UseVisualStyleBackColor = false;
            this.btnL.Click += new System.EventHandler(this.btnL_Click);
            // 
            // btnTM
            // 
            this.btnTM.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnTM.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTM.Location = new System.Drawing.Point(121, 360);
            this.btnTM.Name = "btnTM";
            this.btnTM.Size = new System.Drawing.Size(99, 44);
            this.btnTM.TabIndex = 85;
            this.btnTM.Text = "➕ Tạo mới";
            this.btnTM.UseVisualStyleBackColor = false;
            this.btnTM.Click += new System.EventHandler(this.btnTM_Click);
            // 
            // btnXoaChiTiet
            // 
            this.btnXoaChiTiet.BackColor = System.Drawing.Color.OrangeRed;
            this.btnXoaChiTiet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaChiTiet.Location = new System.Drawing.Point(318, 97);
            this.btnXoaChiTiet.Name = "btnXoaChiTiet";
            this.btnXoaChiTiet.Size = new System.Drawing.Size(40, 36);
            this.btnXoaChiTiet.TabIndex = 83;
            this.btnXoaChiTiet.Text = "x";
            this.btnXoaChiTiet.UseVisualStyleBackColor = false;
            this.btnXoaChiTiet.Click += new System.EventHandler(this.btnXoaChiTiet_Click);
            // 
            // btnSuaChiTiet
            // 
            this.btnSuaChiTiet.BackColor = System.Drawing.Color.Yellow;
            this.btnSuaChiTiet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaChiTiet.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSuaChiTiet.Location = new System.Drawing.Point(318, 55);
            this.btnSuaChiTiet.Name = "btnSuaChiTiet";
            this.btnSuaChiTiet.Size = new System.Drawing.Size(40, 35);
            this.btnSuaChiTiet.TabIndex = 84;
            this.btnSuaChiTiet.Text = "--";
            this.btnSuaChiTiet.UseVisualStyleBackColor = false;
            this.btnSuaChiTiet.Click += new System.EventHandler(this.btnSuaChiTiet_Click);
            // 
            // btnThemChiTiet
            // 
            this.btnThemChiTiet.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnThemChiTiet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemChiTiet.Location = new System.Drawing.Point(318, 16);
            this.btnThemChiTiet.Name = "btnThemChiTiet";
            this.btnThemChiTiet.Size = new System.Drawing.Size(40, 34);
            this.btnThemChiTiet.TabIndex = 82;
            this.btnThemChiTiet.Text = "+";
            this.btnThemChiTiet.UseVisualStyleBackColor = false;
            this.btnThemChiTiet.Click += new System.EventHandler(this.btnThemChiTiet_Click);
            // 
            // dtpNgayDH
            // 
            this.dtpNgayDH.Location = new System.Drawing.Point(154, 145);
            this.dtpNgayDH.Name = "dtpNgayDH";
            this.dtpNgayDH.Size = new System.Drawing.Size(202, 26);
            this.dtpNgayDH.TabIndex = 81;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(110, 67);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(172, 26);
            this.txtSoLuong.TabIndex = 80;
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(110, 140);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(172, 26);
            this.txtTongTien.TabIndex = 79;
            // 
            // txtGiaNhap
            // 
            this.txtGiaNhap.Location = new System.Drawing.Point(110, 104);
            this.txtGiaNhap.Name = "txtGiaNhap";
            this.txtGiaNhap.Size = new System.Drawing.Size(172, 26);
            this.txtGiaNhap.TabIndex = 78;
            // 
            // cboMaMH
            // 
            this.cboMaMH.FormattingEnabled = true;
            this.cboMaMH.Location = new System.Drawing.Point(110, 33);
            this.cboMaMH.Name = "cboMaMH";
            this.cboMaMH.Size = new System.Drawing.Size(172, 24);
            this.cboMaMH.TabIndex = 77;
            // 
            // cboMaNCC
            // 
            this.cboMaNCC.FormattingEnabled = true;
            this.cboMaNCC.Location = new System.Drawing.Point(154, 87);
            this.cboMaNCC.Name = "cboMaNCC";
            this.cboMaNCC.Size = new System.Drawing.Size(202, 24);
            this.cboMaNCC.TabIndex = 76;
            // 
            // cboMaNV
            // 
            this.cboMaNV.FormattingEnabled = true;
            this.cboMaNV.Location = new System.Drawing.Point(154, 115);
            this.cboMaNV.Name = "cboMaNV";
            this.cboMaNV.Size = new System.Drawing.Size(202, 24);
            this.cboMaNV.TabIndex = 75;
            // 
            // dgvChiTietDatHang
            // 
            this.dgvChiTietDatHang.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvChiTietDatHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTietDatHang.Location = new System.Drawing.Point(6, 189);
            this.dgvChiTietDatHang.Name = "dgvChiTietDatHang";
            this.dgvChiTietDatHang.Size = new System.Drawing.Size(352, 135);
            this.dgvChiTietDatHang.TabIndex = 74;
            this.dgvChiTietDatHang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChiTietDatHang_CellContentClick);
            // 
            // dgvDonDatHang
            // 
            this.dgvDonDatHang.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvDonDatHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDonDatHang.Location = new System.Drawing.Point(6, 189);
            this.dgvDonDatHang.Name = "dgvDonDatHang";
            this.dgvDonDatHang.Size = new System.Drawing.Size(379, 135);
            this.dgvDonDatHang.TabIndex = 73;
            this.dgvDonDatHang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDonDatHang_CellContentClick);
            // 
            // txtMaDDH
            // 
            this.txtMaDDH.Location = new System.Drawing.Point(154, 24);
            this.txtMaDDH.Name = "txtMaDDH";
            this.txtMaDDH.Size = new System.Drawing.Size(202, 26);
            this.txtMaDDH.TabIndex = 78;
            // 
            // txtTenDDH
            // 
            this.txtTenDDH.Location = new System.Drawing.Point(154, 55);
            this.txtTenDDH.Name = "txtTenDDH";
            this.txtTenDDH.Size = new System.Drawing.Size(202, 26);
            this.txtTenDDH.TabIndex = 78;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dgvDonDatHang);
            this.groupBox1.Controls.Add(this.txtMaDDH);
            this.groupBox1.Controls.Add(this.cboMaNCC);
            this.groupBox1.Controls.Add(this.cboMaNV);
            this.groupBox1.Controls.Add(this.dtpNgayDH);
            this.groupBox1.Controls.Add(this.txtTenDDH);
            this.groupBox1.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(391, 330);
            this.groupBox1.TabIndex = 92;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Đơn Đặt Hàng";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 16);
            this.label6.TabIndex = 94;
            this.label6.Text = "Ngày đặt hàng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 16);
            this.label5.TabIndex = 94;
            this.label5.Text = "Tên nhân viên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 16);
            this.label4.TabIndex = 94;
            this.label4.Text = "Tên nhà cung cấp";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 16);
            this.label3.TabIndex = 94;
            this.label3.Text = "Tên đơn đặt hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 16);
            this.label2.TabIndex = 94;
            this.label2.Text = "Mã đơn đặt hàng";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Controls.Add(this.btnIn);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.dgvChiTietDatHang);
            this.groupBox2.Controls.Add(this.cboMaMH);
            this.groupBox2.Controls.Add(this.txtSoLuong);
            this.groupBox2.Controls.Add(this.txtGiaNhap);
            this.groupBox2.Controls.Add(this.txtTongTien);
            this.groupBox2.Controls.Add(this.btnThemChiTiet);
            this.groupBox2.Controls.Add(this.btnSuaChiTiet);
            this.groupBox2.Controls.Add(this.btnXoaChiTiet);
            this.groupBox2.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(409, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(364, 330);
            this.groupBox2.TabIndex = 93;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi Tiết Đơn Đặt Hàng";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(10, 145);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 16);
            this.label10.TabIndex = 94;
            this.label10.Text = "Tổng tiền";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(10, 110);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 16);
            this.label9.TabIndex = 94;
            this.label9.Text = "Giá nhập";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(10, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 16);
            this.label8.TabIndex = 94;
            this.label8.Text = "Số lượng";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(10, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 16);
            this.label7.TabIndex = 94;
            this.label7.Text = "Tên mặt hàng";
            // 
            // btnHienThi
            // 
            this.btnHienThi.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnHienThi.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHienThi.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnHienThi.Location = new System.Drawing.Point(12, 360);
            this.btnHienThi.Name = "btnHienThi";
            this.btnHienThi.Size = new System.Drawing.Size(99, 44);
            this.btnHienThi.TabIndex = 89;
            this.btnHienThi.Text = "👁️ Hiển thị";
            this.btnHienThi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHienThi.UseVisualStyleBackColor = false;
            this.btnHienThi.Click += new System.EventHandler(this.btnHienThi_Click);
            // 
            // btnIn
            // 
            this.btnIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIn.Location = new System.Drawing.Point(318, 141);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(40, 36);
            this.btnIn.TabIndex = 95;
            this.btnIn.Text = "In";
            this.btnIn.UseVisualStyleBackColor = false;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // FORM_DONDATHANG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(785, 416);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnTK);
            this.Controls.Add(this.btnHienThi);
            this.Controls.Add(this.btnT);
            this.Controls.Add(this.btnX);
            this.Controls.Add(this.btnCN);
            this.Controls.Add(this.btnL);
            this.Controls.Add(this.btnTM);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FORM_DONDATHANG";
            this.Text = "FORM_DONDATHANG";
            this.Load += new System.EventHandler(this.FORM_DONDATHANG_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietDatHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonDatHang)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTK;
        private System.Windows.Forms.Button btnHienThi;
        private System.Windows.Forms.Button btnT;
        private System.Windows.Forms.Button btnX;
        private System.Windows.Forms.Button btnCN;
        private System.Windows.Forms.Button btnL;
        private System.Windows.Forms.Button btnTM;
        private System.Windows.Forms.Button btnXoaChiTiet;
        private System.Windows.Forms.Button btnSuaChiTiet;
        private System.Windows.Forms.Button btnThemChiTiet;
        private System.Windows.Forms.DateTimePicker dtpNgayDH;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.TextBox txtGiaNhap;
        private System.Windows.Forms.ComboBox cboMaMH;
        private System.Windows.Forms.ComboBox cboMaNCC;
        private System.Windows.Forms.ComboBox cboMaNV;
        private System.Windows.Forms.DataGridView dgvChiTietDatHang;
        private System.Windows.Forms.DataGridView dgvDonDatHang;
        private System.Windows.Forms.TextBox txtMaDDH;
        private System.Windows.Forms.TextBox txtTenDDH;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnIn;
    }
}