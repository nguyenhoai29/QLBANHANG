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
    public partial class FORM_KHACHHANG : Form
    {
        KHACHHANG_BLL KH = new KHACHHANG_BLL();
        public FORM_KHACHHANG()
        {
            InitializeComponent();
        }

        
        private void dgvKHACHHANG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtMaKH.Enabled = false;
                txtMaKH.Text = dgvKHACHHANG.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtTenKH.Text = dgvKHACHHANG.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtDiaChi.Text = dgvKHACHHANG.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtSDT.Text = dgvKHACHHANG.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtEmail.Text = dgvKHACHHANG.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            dgvKHACHHANG.DataSource = KH.ChonKhachHang();
        }

        private void btnTM_Click(object sender, EventArgs e)
        {
            txtMaKH.Text = KH.SinhMaKhachHang(); 
            txtTenKH.Clear();
            txtDiaChi.Clear();
            txtSDT.Clear();
            txtEmail.Clear();
            txtTenKH.Focus();
            txtMaKH.Enabled = false;
        }

        private void btnL_Click(object sender, EventArgs e)
        {
            try
            {
                int rowsAffected = KH.ThemKhachHang(txtMaKH.Text, txtTenKH.Text, txtDiaChi.Text, txtSDT.Text, txtEmail.Text);
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Thêm thành công");
                    btnHienThi_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Thêm thất bại");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm: " + ex.Message);
            }
        }

        private void btnCN_Click(object sender, EventArgs e)
        {
            try
            {
                int rowsAffected = KH.SuaKhachHang(txtMaKH.Text, txtTenKH.Text, txtDiaChi.Text, txtSDT.Text, txtEmail.Text);
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Cập nhật thành công");
                    dgvKHACHHANG.DataSource = KH.ChonKhachHang();
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật: " + ex.Message);
            }
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            try
            {
                int rowsAffected = KH.XoaKhachHang(txtMaKH.Text);
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Xóa thành công");
                    dgvKHACHHANG.DataSource = KH.ChonKhachHang();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy khách hàng để xóa");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa: " + ex.Message);
            }
        }

        private void btnTK_Click(object sender, EventArgs e)
        {
            dgvKHACHHANG.DataSource = KH.TimKiemKhachHang(txtTK.Text);
        }

        private void btnT_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FORM_KHACHHANG_Load(object sender, EventArgs e)
        {
            try
            {
                // Sinh mã tự động khi Form được tải
                string maKH = KH.SinhMaKhachHang();
                txtMaKH.Text = maKH;
                txtMaKH.Enabled = false; 
                dgvKHACHHANG.DataSource = KH.ChonKhachHang();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải Form: " + ex.Message);
            }
        }
    }
}
