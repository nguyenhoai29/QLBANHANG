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
    public partial class FORM_NHACUNGCAP : Form
    {
        NHACUNGCAP_BLL NCC = new NHACUNGCAP_BLL();
        public FORM_NHACUNGCAP()
        {
            InitializeComponent();
        }

        private void dgvNHACUNGCAP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtMaNCC.Enabled = false;
                txtMaNCC.Text = dgvNHACUNGCAP.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtTenNCC.Text = dgvNHACUNGCAP.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtDiaChi.Text = dgvNHACUNGCAP.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtSDT.Text = dgvNHACUNGCAP.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtEmail.Text = dgvNHACUNGCAP.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            dgvNHACUNGCAP.DataSource = NCC.ChonNhaCungCap();
        }

        private void btnTM_Click(object sender, EventArgs e)
        {
            txtMaNCC.Text = NCC.SinhMaNhaCungCap(); 
            txtMaNCC.Enabled = false;
            txtTenNCC.Clear();
            txtDiaChi.Clear();
            txtSDT.Clear();
            txtEmail.Clear();
            txtTenNCC.Focus();
            
        }

        private void btnL_Click(object sender, EventArgs e)
        {
            try
            {
                int rowsAffected = NCC.ThemNhaCungCap(txtMaNCC.Text, txtTenNCC.Text, txtDiaChi.Text, txtSDT.Text, txtEmail.Text);
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
                int rowsAffected = NCC.SuaNhaCungCap(txtMaNCC.Text, txtTenNCC.Text, txtDiaChi.Text, txtSDT.Text, txtEmail.Text);
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Cập nhật thành công");
                    dgvNHACUNGCAP.DataSource = NCC.ChonNhaCungCap();
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
                int rowsAffected = NCC.XoaNhaCungCap(txtMaNCC.Text);
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Xóa thành công");
                    dgvNHACUNGCAP.DataSource = NCC.ChonNhaCungCap();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy nhà cung cấp để xóa");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa: " + ex.Message);
            }
        }

        private void btnTK_Click(object sender, EventArgs e)
        {
            dgvNHACUNGCAP.DataSource = NCC.TimKiemNhaCungCap(txtMaNCC.Text, txtTenNCC.Text);
        }

        private void btnT_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
