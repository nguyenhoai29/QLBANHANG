namespace QLBANHANG
{
    partial class FORM_TRANGCHU
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
            this.panelContent = new System.Windows.Forms.Panel();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuQLMH = new System.Windows.Forms.ToolStripMenuItem();
            this.menuQLLH = new System.Windows.Forms.ToolStripMenuItem();
            this.menuQLNV = new System.Windows.Forms.ToolStripMenuItem();
            this.menuQLKH = new System.Windows.Forms.ToolStripMenuItem();
            this.menuQLHD = new System.Windows.Forms.ToolStripMenuItem();
            this.menuQLDDH = new System.Windows.Forms.ToolStripMenuItem();
            this.menuQLNCC = new System.Windows.Forms.ToolStripMenuItem();
            this.menuThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.btnQLMH = new System.Windows.Forms.Button();
            this.btnQLLH = new System.Windows.Forms.Button();
            this.btnQLNV = new System.Windows.Forms.Button();
            this.btnQLKH = new System.Windows.Forms.Button();
            this.btnQLHD = new System.Windows.Forms.Button();
            this.btnQLDDH = new System.Windows.Forms.Button();
            this.btnQLNCC = new System.Windows.Forms.Button();
            this.btnTKBC = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.panelContent.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelContent
            // 
            this.panelContent.AutoScroll = true;
            this.panelContent.BackColor = System.Drawing.Color.Ivory;
            this.panelContent.Controls.Add(this.pictureBoxLogo);
            this.panelContent.Controls.Add(this.lblWelcome);
            this.panelContent.Location = new System.Drawing.Point(177, 50);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(801, 455);
            this.panelContent.TabIndex = 0;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font(".VnBodoniH", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(329, 13);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(214, 41);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "WELLCOME!";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.ForestGreen;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuQLMH,
            this.menuQLLH,
            this.menuQLNV,
            this.menuQLKH,
            this.menuQLHD,
            this.menuQLDDH,
            this.menuQLNCC,
            this.menuThoat});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(983, 26);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuQLMH
            // 
            this.menuQLMH.Font = new System.Drawing.Font("Arrus-Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuQLMH.ForeColor = System.Drawing.Color.White;
            this.menuQLMH.Name = "menuQLMH";
            this.menuQLMH.Size = new System.Drawing.Size(114, 22);
            this.menuQLMH.Text = "QL Mặt Hàng";
            this.menuQLMH.Click += new System.EventHandler(this.menuQLMH_Click);
            // 
            // menuQLLH
            // 
            this.menuQLLH.Font = new System.Drawing.Font("Arrus-Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuQLLH.ForeColor = System.Drawing.Color.White;
            this.menuQLLH.Name = "menuQLLH";
            this.menuQLLH.Size = new System.Drawing.Size(117, 22);
            this.menuQLLH.Text = "QL Loại Hàng";
            this.menuQLLH.Click += new System.EventHandler(this.menuQLLH_Click);
            // 
            // menuQLNV
            // 
            this.menuQLNV.Font = new System.Drawing.Font("Arrus-Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuQLNV.ForeColor = System.Drawing.Color.White;
            this.menuQLNV.Name = "menuQLNV";
            this.menuQLNV.Size = new System.Drawing.Size(118, 22);
            this.menuQLNV.Text = "QL Nhân Viên";
            this.menuQLNV.Click += new System.EventHandler(this.menuQLNV_Click);
            // 
            // menuQLKH
            // 
            this.menuQLKH.Font = new System.Drawing.Font("Arrus-Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuQLKH.ForeColor = System.Drawing.Color.White;
            this.menuQLKH.Name = "menuQLKH";
            this.menuQLKH.Size = new System.Drawing.Size(131, 22);
            this.menuQLKH.Text = "QL Khách Hàng";
            this.menuQLKH.Click += new System.EventHandler(this.menuQLKH_Click);
            // 
            // menuQLHD
            // 
            this.menuQLHD.Font = new System.Drawing.Font("Arrus-Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuQLHD.ForeColor = System.Drawing.Color.White;
            this.menuQLHD.Name = "menuQLHD";
            this.menuQLHD.Size = new System.Drawing.Size(109, 22);
            this.menuQLHD.Text = "QL Hoá Đơn";
            this.menuQLHD.Click += new System.EventHandler(this.menuQLHD_Click);
            // 
            // menuQLDDH
            // 
            this.menuQLDDH.Font = new System.Drawing.Font("Arrus-Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuQLDDH.ForeColor = System.Drawing.Color.White;
            this.menuQLDDH.Name = "menuQLDDH";
            this.menuQLDDH.Size = new System.Drawing.Size(148, 22);
            this.menuQLDDH.Text = "QL Đơn Đặt Hàng";
            this.menuQLDDH.Click += new System.EventHandler(this.menuQLDDH_Click);
            // 
            // menuQLNCC
            // 
            this.menuQLNCC.Font = new System.Drawing.Font("Arrus-Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuQLNCC.ForeColor = System.Drawing.Color.White;
            this.menuQLNCC.Name = "menuQLNCC";
            this.menuQLNCC.Size = new System.Drawing.Size(79, 22);
            this.menuQLNCC.Text = "QL NCC";
            this.menuQLNCC.Click += new System.EventHandler(this.menuQLNCC_Click);
            // 
            // menuThoat
            // 
            this.menuThoat.Font = new System.Drawing.Font("Arrus-Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuThoat.ForeColor = System.Drawing.Color.White;
            this.menuThoat.Name = "menuThoat";
            this.menuThoat.Size = new System.Drawing.Size(62, 22);
            this.menuThoat.Text = "Thoát";
            this.menuThoat.Click += new System.EventHandler(this.menuThoat_Click);
            // 
            // btnQLMH
            // 
            this.btnQLMH.BackColor = System.Drawing.Color.ForestGreen;
            this.btnQLMH.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLMH.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnQLMH.Location = new System.Drawing.Point(0, 120);
            this.btnQLMH.Name = "btnQLMH";
            this.btnQLMH.Size = new System.Drawing.Size(171, 47);
            this.btnQLMH.TabIndex = 4;
            this.btnQLMH.Text = "MẶT HÀNG";
            this.btnQLMH.UseVisualStyleBackColor = false;
            this.btnQLMH.Click += new System.EventHandler(this.btnQLMH_Click);
            // 
            // btnQLLH
            // 
            this.btnQLLH.BackColor = System.Drawing.Color.ForestGreen;
            this.btnQLLH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLLH.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnQLLH.Location = new System.Drawing.Point(0, 165);
            this.btnQLLH.Name = "btnQLLH";
            this.btnQLLH.Size = new System.Drawing.Size(171, 48);
            this.btnQLLH.TabIndex = 4;
            this.btnQLLH.Text = "LOẠI HÀNG";
            this.btnQLLH.UseVisualStyleBackColor = false;
            this.btnQLLH.Click += new System.EventHandler(this.btnQLLH_Click);
            // 
            // btnQLNV
            // 
            this.btnQLNV.BackColor = System.Drawing.Color.ForestGreen;
            this.btnQLNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLNV.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnQLNV.Location = new System.Drawing.Point(0, 210);
            this.btnQLNV.Name = "btnQLNV";
            this.btnQLNV.Size = new System.Drawing.Size(171, 48);
            this.btnQLNV.TabIndex = 4;
            this.btnQLNV.Text = "NHÂN VIÊN";
            this.btnQLNV.UseVisualStyleBackColor = false;
            this.btnQLNV.Click += new System.EventHandler(this.btnQLNV_Click);
            // 
            // btnQLKH
            // 
            this.btnQLKH.BackColor = System.Drawing.Color.ForestGreen;
            this.btnQLKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLKH.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnQLKH.Location = new System.Drawing.Point(0, 255);
            this.btnQLKH.Name = "btnQLKH";
            this.btnQLKH.Size = new System.Drawing.Size(171, 47);
            this.btnQLKH.TabIndex = 4;
            this.btnQLKH.Text = "KHÁCH HÀNG";
            this.btnQLKH.UseVisualStyleBackColor = false;
            this.btnQLKH.Click += new System.EventHandler(this.btnQLKH_Click);
            // 
            // btnQLHD
            // 
            this.btnQLHD.BackColor = System.Drawing.Color.ForestGreen;
            this.btnQLHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLHD.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnQLHD.Location = new System.Drawing.Point(0, 300);
            this.btnQLHD.Name = "btnQLHD";
            this.btnQLHD.Size = new System.Drawing.Size(171, 48);
            this.btnQLHD.TabIndex = 4;
            this.btnQLHD.Text = "HOÁ ĐƠN ";
            this.btnQLHD.UseVisualStyleBackColor = false;
            this.btnQLHD.Click += new System.EventHandler(this.btnQLHD_Click);
            // 
            // btnQLDDH
            // 
            this.btnQLDDH.BackColor = System.Drawing.Color.ForestGreen;
            this.btnQLDDH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLDDH.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnQLDDH.Location = new System.Drawing.Point(0, 345);
            this.btnQLDDH.Name = "btnQLDDH";
            this.btnQLDDH.Size = new System.Drawing.Size(171, 49);
            this.btnQLDDH.TabIndex = 4;
            this.btnQLDDH.Text = "ĐƠN ĐẶT HÀNG";
            this.btnQLDDH.UseVisualStyleBackColor = false;
            this.btnQLDDH.Click += new System.EventHandler(this.btnQLDDH_Click);
            // 
            // btnQLNCC
            // 
            this.btnQLNCC.BackColor = System.Drawing.Color.ForestGreen;
            this.btnQLNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLNCC.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnQLNCC.Location = new System.Drawing.Point(0, 390);
            this.btnQLNCC.Name = "btnQLNCC";
            this.btnQLNCC.Size = new System.Drawing.Size(171, 47);
            this.btnQLNCC.TabIndex = 4;
            this.btnQLNCC.Text = "NHÀ CUNG CẤP";
            this.btnQLNCC.UseVisualStyleBackColor = false;
            this.btnQLNCC.Click += new System.EventHandler(this.btnQLNCC_Click);
            // 
            // btnTKBC
            // 
            this.btnTKBC.BackColor = System.Drawing.Color.ForestGreen;
            this.btnTKBC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTKBC.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTKBC.Location = new System.Drawing.Point(0, 435);
            this.btnTKBC.Name = "btnTKBC";
            this.btnTKBC.Size = new System.Drawing.Size(171, 48);
            this.btnTKBC.TabIndex = 4;
            this.btnTKBC.Text = "THỐNG KÊ";
            this.btnTKBC.UseVisualStyleBackColor = false;
            this.btnTKBC.Click += new System.EventHandler(this.btnTKBC_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.Red;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnThoat.Location = new System.Drawing.Point(0, 480);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(171, 39);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "THOÁT";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.ForestGreen;
            this.pictureBox1.Image = global::QLBANHANG.Properties.Resources.Screenshot__193_;
            this.pictureBox1.Location = new System.Drawing.Point(0, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(171, 92);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::QLBANHANG.Properties.Resources.Screenshot__193_;
            this.pictureBoxLogo.Location = new System.Drawing.Point(18, 68);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(765, 364);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 1;
            this.pictureBoxLogo.TabStop = false;
            // 
            // FORM_TRANGCHU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ClientSize = new System.Drawing.Size(983, 517);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnTKBC);
            this.Controls.Add(this.btnQLNCC);
            this.Controls.Add(this.btnQLDDH);
            this.Controls.Add(this.btnQLHD);
            this.Controls.Add(this.btnQLKH);
            this.Controls.Add(this.btnQLNV);
            this.Controls.Add(this.btnQLLH);
            this.Controls.Add(this.btnQLMH);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FORM_TRANGCHU";
            this.Text = "FORM_TRANGCHU";
            this.Load += new System.EventHandler(this.FORM_TRANGCHU_Load);
            this.panelContent.ResumeLayout(false);
            this.panelContent.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuQLMH;
        private System.Windows.Forms.ToolStripMenuItem menuQLLH;
        private System.Windows.Forms.ToolStripMenuItem menuQLNV;
        private System.Windows.Forms.ToolStripMenuItem menuQLKH;
        private System.Windows.Forms.ToolStripMenuItem menuQLHD;
        private System.Windows.Forms.ToolStripMenuItem menuQLDDH;
        private System.Windows.Forms.ToolStripMenuItem menuQLNCC;
        private System.Windows.Forms.ToolStripMenuItem menuThoat;
        private System.Windows.Forms.Button btnQLMH;
        private System.Windows.Forms.Button btnQLLH;
        private System.Windows.Forms.Button btnQLNV;
        private System.Windows.Forms.Button btnQLKH;
        private System.Windows.Forms.Button btnQLHD;
        private System.Windows.Forms.Button btnQLDDH;
        private System.Windows.Forms.Button btnQLNCC;
        private System.Windows.Forms.Button btnTKBC;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
    }
}