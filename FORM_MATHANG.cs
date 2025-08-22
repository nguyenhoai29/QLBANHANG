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
    public partial class FORM_MATHANG : Form
    {
        MATHANG_BLL MH = new MATHANG_BLL();

        public FORM_MATHANG()
        {
            InitializeComponent();
        }

        private void dgvMATHANG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtMaMH.Enabled = false;
                txtMaMH.Text = dgvMATHANG.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtTenMH.Text = dgvMATHANG.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtDonViTinh.Text = dgvMATHANG.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtGiaBan.Text = dgvMATHANG.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtMaLH.Text = dgvMATHANG.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            dgvMATHANG.DataSource = MH.ChonMatHang();
        }

        private void btnTM_Click(object sender, EventArgs e)
        {
            txtMaMH.Text = MH.SinhMaMatHang();
            txtMaMH.Enabled = false;
            txtTenMH.Clear();
            txtDonViTinh.Clear();
            txtGiaBan.Clear();
            txtMaLH.Clear();
            txtTenMH.Focus();
            
        }

        private void btnL_Click(object sender, EventArgs e)
        {
            try
            {
                decimal giaBan = decimal.Parse(txtGiaBan.Text);
                int rowsAffected = MH.ThemMatHang(txtMaMH.Text, txtTenMH.Text, txtDonViTinh.Text, giaBan, txtMaLH.Text);
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
                decimal giaBan = decimal.Parse(txtGiaBan.Text);
                int rowsAffected = MH.SuaMatHang(txtMaMH.Text, txtTenMH.Text, txtDonViTinh.Text, giaBan, txtMaLH.Text);
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Cập nhật thành công");
                    dgvMATHANG.DataSource = MH.ChonMatHang();
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
                int rowsAffected = MH.XoaMatHang(txtMaMH.Text);
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Xóa thành công");
                    dgvMATHANG.DataSource = MH.ChonMatHang();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy mặt hàng để xóa");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa: " + ex.Message);
            }
        }

        private void btnTK_Click(object sender, EventArgs e)
        {
            dgvMATHANG.DataSource = MH.TimKiemMatHang(txtMaMH.Text, txtTenMH.Text);
        }

        private void btnT_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
