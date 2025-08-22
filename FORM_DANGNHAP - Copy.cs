using BLL2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBANHANG
{
    public partial class FORM_DANGNHAP : Form
    {
        public static string QuyenNguoiDung = "";
        public static string TenDangNhap = "";

        NguoiDung_BLL nguoiDungBLL = new NguoiDung_BLL();

        public FORM_DANGNHAP()
        {
            InitializeComponent();
        }

        private void btnDN_Click(object sender, EventArgs e)
        {
            string user = txtUN.Text.Trim();
            string pass = txtMK.Text.Trim();

            DataTable dt = nguoiDungBLL.KiemTraDangNhap(user, pass);
            if (dt.Rows.Count > 0)
            {
                QuyenNguoiDung = dt.Rows[0]["MaQuyen"].ToString();
                TenDangNhap = dt.Rows[0]["TenDangNhap"].ToString();

                FORM_TRANGCHU f = new FORM_TRANGCHU();
                f.Show();
                this.Hide();
                f.DangXuat += F_DangXuat;
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUN.Clear();
                txtMK.Clear();
                txtUN.Focus();
            }
        }
        private void F_DangXuat(object sender, EventArgs e)
        {
            (sender as FORM_TRANGCHU).Close();
            this.Show();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            {
                Application.Exit();
            }
        }

        private void FORM_DANGNHAP_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
