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
    public partial class FORM_LOAIHANG : Form
    {
        LOAIHANG_BLL LH = new LOAIHANG_BLL();
        public FORM_LOAIHANG()
        {
            InitializeComponent();
        }

        private void dgvLOAIHANG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtMaLH.Enabled = false;
                txtMaLH.Text = dgvLOAIHANG.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtTenLH.Text = dgvLOAIHANG.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            dgvLOAIHANG.DataSource = LH.ChonLoaiHang();
        }

        private void btnTM_Click(object sender, EventArgs e)
        {
            string maLH = LH.SinhMaLoaiHang();
            txtTenLH.Clear();
            txtTenLH.Focus();
            txtMaLH.Enabled = false;
        }

        private void btnL_Click(object sender, EventArgs e)
        {
            try
            {
                int rowsAffected = LH.ThemLoaiHang(txtMaLH.Text, txtTenLH.Text);
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
                int rowsAffected = LH.SuaLoaiHang(txtMaLH.Text, txtTenLH.Text);
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Cập nhật thành công");
                    dgvLOAIHANG.DataSource = LH.ChonLoaiHang();
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
                int rowsAffected = LH.XoaLoaiHang(txtMaLH.Text);
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Xóa thành công");
                    dgvLOAIHANG.DataSource = LH.ChonLoaiHang();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy loại hàng để xóa");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa: " + ex.Message);
            }
        }

        private void btnTK_Click(object sender, EventArgs e)
        {
            dgvLOAIHANG.DataSource = LH.TimKiemLoaiHang(txtMaLH.Text, txtTenLH.Text);
        }

        private void btnT_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
