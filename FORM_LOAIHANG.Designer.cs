namespace QLBANHANG
{
    partial class FORM_LOAIHANG
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
            this.dgvLOAIHANG = new System.Windows.Forms.DataGridView();
            this.txtMaLH = new System.Windows.Forms.TextBox();
            this.txtTenLH = new System.Windows.Forms.TextBox();
            this.btnTK = new System.Windows.Forms.Button();
            this.btnHienThi = new System.Windows.Forms.Button();
            this.btnT = new System.Windows.Forms.Button();
            this.btnX = new System.Windows.Forms.Button();
            this.btnCN = new System.Windows.Forms.Button();
            this.btnL = new System.Windows.Forms.Button();
            this.btnTM = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLOAIHANG)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLOAIHANG
            // 
            this.dgvLOAIHANG.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvLOAIHANG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLOAIHANG.Location = new System.Drawing.Point(28, 143);
            this.dgvLOAIHANG.Name = "dgvLOAIHANG";
            this.dgvLOAIHANG.Size = new System.Drawing.Size(718, 197);
            this.dgvLOAIHANG.TabIndex = 0;
            this.dgvLOAIHANG.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLOAIHANG_CellContentClick);
            // 
            // txtMaLH
            // 
            this.txtMaLH.Location = new System.Drawing.Point(230, 36);
            this.txtMaLH.Name = "txtMaLH";
            this.txtMaLH.Size = new System.Drawing.Size(319, 20);
            this.txtMaLH.TabIndex = 1;
            // 
            // txtTenLH
            // 
            this.txtTenLH.Location = new System.Drawing.Point(230, 78);
            this.txtTenLH.Name = "txtTenLH";
            this.txtTenLH.Size = new System.Drawing.Size(319, 20);
            this.txtTenLH.TabIndex = 1;
            // 
            // btnTK
            // 
            this.btnTK.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnTK.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTK.Location = new System.Drawing.Point(484, 360);
            this.btnTK.Name = "btnTK";
            this.btnTK.Size = new System.Drawing.Size(105, 40);
            this.btnTK.TabIndex = 72;
            this.btnTK.Text = "🔍Tìm Kiếm";
            this.btnTK.UseVisualStyleBackColor = false;
            this.btnTK.Click += new System.EventHandler(this.btnTK_Click);
            // 
            // btnHienThi
            // 
            this.btnHienThi.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnHienThi.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHienThi.Location = new System.Drawing.Point(622, 89);
            this.btnHienThi.Name = "btnHienThi";
            this.btnHienThi.Size = new System.Drawing.Size(124, 31);
            this.btnHienThi.TabIndex = 70;
            this.btnHienThi.Text = "👁️ Hiển thị";
            this.btnHienThi.UseVisualStyleBackColor = false;
            this.btnHienThi.Click += new System.EventHandler(this.btnHienThi_Click);
            // 
            // btnT
            // 
            this.btnT.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnT.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnT.Location = new System.Drawing.Point(641, 360);
            this.btnT.Name = "btnT";
            this.btnT.Size = new System.Drawing.Size(105, 40);
            this.btnT.TabIndex = 71;
            this.btnT.Text = "🚪 Thoát";
            this.btnT.UseVisualStyleBackColor = false;
            this.btnT.Click += new System.EventHandler(this.btnT_Click);
            // 
            // btnX
            // 
            this.btnX.BackColor = System.Drawing.Color.Red;
            this.btnX.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnX.Location = new System.Drawing.Point(329, 360);
            this.btnX.Name = "btnX";
            this.btnX.Size = new System.Drawing.Size(105, 40);
            this.btnX.TabIndex = 69;
            this.btnX.Text = "🗑️ Xoá";
            this.btnX.UseVisualStyleBackColor = false;
            this.btnX.Click += new System.EventHandler(this.btnX_Click);
            // 
            // btnCN
            // 
            this.btnCN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCN.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCN.Location = new System.Drawing.Point(172, 360);
            this.btnCN.Name = "btnCN";
            this.btnCN.Size = new System.Drawing.Size(105, 40);
            this.btnCN.TabIndex = 68;
            this.btnCN.Text = "✏️Cập nhật";
            this.btnCN.UseVisualStyleBackColor = false;
            this.btnCN.Click += new System.EventHandler(this.btnCN_Click);
            // 
            // btnL
            // 
            this.btnL.BackColor = System.Drawing.Color.Green;
            this.btnL.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnL.Location = new System.Drawing.Point(28, 360);
            this.btnL.Name = "btnL";
            this.btnL.Size = new System.Drawing.Size(105, 40);
            this.btnL.TabIndex = 67;
            this.btnL.Text = "💾 Lưu";
            this.btnL.UseVisualStyleBackColor = false;
            this.btnL.Click += new System.EventHandler(this.btnL_Click);
            // 
            // btnTM
            // 
            this.btnTM.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnTM.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTM.Location = new System.Drawing.Point(622, 36);
            this.btnTM.Name = "btnTM";
            this.btnTM.Size = new System.Drawing.Size(124, 31);
            this.btnTM.TabIndex = 66;
            this.btnTM.Text = "➕ Tạo mới";
            this.btnTM.UseVisualStyleBackColor = false;
            this.btnTM.Click += new System.EventHandler(this.btnTM_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(89, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 20);
            this.label1.TabIndex = 73;
            this.label1.Text = "Mã Loại hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(89, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 20);
            this.label2.TabIndex = 73;
            this.label2.Text = "Tên loại hàng";
            // 
            // FORM_LOAIHANG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(781, 412);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTK);
            this.Controls.Add(this.btnHienThi);
            this.Controls.Add(this.btnT);
            this.Controls.Add(this.btnX);
            this.Controls.Add(this.btnCN);
            this.Controls.Add(this.btnL);
            this.Controls.Add(this.btnTM);
            this.Controls.Add(this.txtTenLH);
            this.Controls.Add(this.txtMaLH);
            this.Controls.Add(this.dgvLOAIHANG);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FORM_LOAIHANG";
            this.Text = "FORM_LOAIHANG";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLOAIHANG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLOAIHANG;
        private System.Windows.Forms.TextBox txtMaLH;
        private System.Windows.Forms.TextBox txtTenLH;
        private System.Windows.Forms.Button btnTK;
        private System.Windows.Forms.Button btnHienThi;
        private System.Windows.Forms.Button btnT;
        private System.Windows.Forms.Button btnX;
        private System.Windows.Forms.Button btnCN;
        private System.Windows.Forms.Button btnL;
        private System.Windows.Forms.Button btnTM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}