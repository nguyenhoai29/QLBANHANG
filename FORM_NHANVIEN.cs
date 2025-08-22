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
    public partial class FORM_NHANVIEN : Form
    {
        NHANVIEN_BLL NV = new NHANVIEN_BLL();
        public FORM_NHANVIEN()
        {
            InitializeComponent();
        }

        private void dgvNHANVIEN_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtMNV.Enabled = false;
                txtMNV.Text = dgvNHANVIEN.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtTNV.Text = dgvNHANVIEN.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtDC.Text = dgvNHANVIEN.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtSDT.Text = dgvNHANVIEN.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            dgvNHANVIEN.DataSource = NV.ChonNhanVien();
        }

        private void btnTM_Click(object sender, EventArgs e)
        {
            txtMNV.Text = NV.SinhMaNhanVien();
            txtTNV.Clear();
            txtDC.Clear();
            txtSDT.Clear();
            txtTNV.Focus();
            txtMNV.Enabled = false;
        }

        private void btnL_Click(object sender, EventArgs e)
        {
            try
            {
                int rowsAffected = NV.ThemNhanVien(txtMNV.Text, txtTNV.Text, txtDC.Text, txtSDT.Text);
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
                int rowsAffected = NV.SuaNhanVien(txtMNV.Text, txtTNV.Text, txtDC.Text, txtSDT.Text);
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Cập nhật thành công");
                    dgvNHANVIEN.DataSource = NV.ChonNhanVien();
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
                int rowsAffected = NV.XoaNhanVien(txtMNV.Text);
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Xóa thành công");
                    dgvNHANVIEN.DataSource = NV.ChonNhanVien();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy nhân viên để xóa");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa: " + ex.Message);
            }
        }

        private void btnTK_Click(object sender, EventArgs e)
        {
            dgvNHANVIEN.DataSource = NV.TimKiemNhanVien(txtTK.Text);
        }

        private void btnT_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
