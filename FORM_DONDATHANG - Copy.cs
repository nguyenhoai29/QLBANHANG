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
    public partial class FORM_DONDATHANG : Form
    {
        DONDATHANG_BLL DDH = new DONDATHANG_BLL();
        CHITIETDATHANG_BLL CTDH = new CHITIETDATHANG_BLL();
        NHACUNGCAP_BLL NCC = new NHACUNGCAP_BLL();
        NHANVIEN_BLL NV = new NHANVIEN_BLL();
        MATHANG_BLL MH = new MATHANG_BLL();
        private DataTable dtChiTietTam;

        public FORM_DONDATHANG()
        {
            InitializeComponent();
            InitializeChiTietTam();
        }
        private void InitializeChiTietTam()
        {
            dtChiTietTam = new DataTable();
            dtChiTietTam.Columns.Add("MaMH", typeof(string));
            dtChiTietTam.Columns.Add("TenMH", typeof(string));
            dtChiTietTam.Columns.Add("SoLuong", typeof(int));
            dtChiTietTam.Columns.Add("GiaNhap", typeof(decimal));
            dtChiTietTam.Columns.Add("ThanhTien", typeof(decimal));
        }
        private void FORM_DONDATHANG_Load(object sender, EventArgs e)
        {
            DataTable dtNhaCungCap = NCC.ChonNhaCungCap();
            cboMaNCC.DataSource = dtNhaCungCap;
            cboMaNCC.DisplayMember = "TenNCC";
            cboMaNCC.ValueMember = "MaNCC";

            DataTable dtNhanVien = NV.ChonNhanVien();
            cboMaNV.DataSource = dtNhanVien;
            cboMaNV.DisplayMember = "TenNV";
            cboMaNV.ValueMember = "MaNV";

            DataTable dtMatHang = MH.ChonMatHang();
            cboMaMH.DataSource = dtMatHang;
            cboMaMH.DisplayMember = "TenMH";
            cboMaMH.ValueMember = "MaMH";

            // Sinh mã tự động khi Form được tải
            txtMaDDH.Text = DDH.SinhMaDonDatHang();
            txtMaDDH.Enabled = false;
        }

        private void dgvDonDatHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtMaDDH.Enabled = false;
                txtMaDDH.Text = dgvDonDatHang.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtTenDDH.Text = dgvDonDatHang.Rows[e.RowIndex].Cells[1].Value.ToString();
                dtpNgayDH.Value = DateTime.Parse(dgvDonDatHang.Rows[e.RowIndex].Cells[2].Value.ToString());
                cboMaNCC.SelectedValue = dgvDonDatHang.Rows[e.RowIndex].Cells[3].Value.ToString();
                cboMaNV.SelectedValue = dgvDonDatHang.Rows[e.RowIndex].Cells[4].Value.ToString();

                LoadChiTietDatHang(txtMaDDH.Text);
                TinhTongTien();
                dtChiTietTam.Clear();
            }
        }

        private void dgvChiTietDatHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                cboMaMH.SelectedValue = dgvChiTietDatHang.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtSoLuong.Text = dgvChiTietDatHang.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtGiaNhap.Text = dgvChiTietDatHang.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
        }

        private void LoadChiTietDatHang(string maDDH)
        {
            DataTable dtChiTiet = DDH.LayChiTietDonDatHang(maDDH);
            dgvChiTietDatHang.DataSource = dtChiTiet;
        }

        private void TinhTongTien()
        {
            decimal tongTien = DDH.LayTongTienDonDatHang(txtMaDDH.Text);
            txtTongTien.Text = tongTien.ToString("N2");
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            dgvDonDatHang.DataSource = DDH.LayDanhSachDonDatHangTongTien();
            dgvChiTietDatHang.DataSource = null;
            txtTongTien.Clear();
            dtChiTietTam.Clear();
        }

        private void btnTM_Click(object sender, EventArgs e)
        {
            txtMaDDH.Text = DDH.SinhMaDonDatHang();
            txtMaDDH.Enabled = false; 
            txtTenDDH.Clear();
            dtpNgayDH.Value = DateTime.Now;
            cboMaNCC.SelectedIndex = -1;
            cboMaNV.SelectedIndex = -1;
            txtTenDDH.Focus();
            dgvChiTietDatHang.DataSource = null;
            txtTongTien.Clear();
            txtSoLuong.Clear();
            txtGiaNhap.Clear();
            cboMaMH.SelectedIndex = -1;
            dtChiTietTam.Clear();
        }

        private void btnL_Click(object sender, EventArgs e)
        {
           
                 try
            {
                string maNCC = cboMaNCC.SelectedValue?.ToString();
                string maNV = cboMaNV.SelectedValue?.ToString();
                int rowsAffected = DDH.ThemDonDatHang(txtMaDDH.Text, txtTenDDH.Text, dtpNgayDH.Value, maNCC, maNV);
                if (rowsAffected >= 0)
                {
                    MessageBox.Show("Thêm đơn hàng thành công");
                    btnHienThi_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Thêm đơn hàng thất bại");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm đơn hàng: " + ex.Message);
            }
            dtChiTietTam.Clear();

        }

        private void btnCN_Click(object sender, EventArgs e)
        {
            try
            {
                string maNCC = cboMaNCC.SelectedValue?.ToString();
                string maNV = cboMaNV.SelectedValue?.ToString();
                int rowsAffected = DDH.SuaDonDatHang(txtMaDDH.Text, txtTenDDH.Text, dtpNgayDH.Value, maNCC, maNV);
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Cập nhật đơn đặt hàng thành công");
                    btnHienThi_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Cập nhật đơn đặt hàng thất bại");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật đơn đặt hàng: " + ex.Message);
            }
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            try
            {
                int rowsAffected = DDH.XoaDonDatHang(txtMaDDH.Text);
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Xóa đơn đặt hàng thành công");
                    btnHienThi_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy đơn đặt hàng để xóa");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa đơn đặt hàng: " + ex.Message);
            }
        }

        private void btnTK_Click(object sender, EventArgs e)
        {
            dgvDonDatHang.DataSource = DDH.TimKiemDonDatHangTongTien(txtMaDDH.Text, txtTenDDH.Text);
        }

        private void btnThemChiTiet_Click(object sender, EventArgs e)
        {
            try
            {
                string maMH = cboMaMH.SelectedValue?.ToString();
                int soLuong = int.Parse(txtSoLuong.Text);
                decimal giaNhap = decimal.Parse(txtGiaNhap.Text);
                int rowsAffected = CTDH.ThemChiTietDatHang(txtMaDDH.Text, maMH, soLuong, giaNhap);
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Thêm chi tiết đơn đặt hàng thành công");
                    LoadChiTietDatHang(txtMaDDH.Text);
                    TinhTongTien();
                }
                else
                {
                    MessageBox.Show("Thêm chi tiết đơn đặt hàng thất bại");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm chi tiết đơn đặt hàng: " + ex.Message);
            }

        }

        private void btnSuaChiTiet_Click(object sender, EventArgs e)
        {
            try
            {
                string maMH = cboMaMH.SelectedValue?.ToString();
                int soLuong = int.Parse(txtSoLuong.Text);
                decimal giaNhap = decimal.Parse(txtGiaNhap.Text);
                int rowsAffected = CTDH.SuaChiTietDatHang(txtMaDDH.Text, maMH, soLuong, giaNhap);
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Cập nhật chi tiết đơn đặt hàng thành công");
                    LoadChiTietDatHang(txtMaDDH.Text);
                    TinhTongTien();
                }
                else
                {
                    MessageBox.Show("Cập nhật chi tiết đơn đặt hàng thất bại");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật chi tiết đơn đặt hàng: " + ex.Message);
            }

        }

        private void btnXoaChiTiet_Click(object sender, EventArgs e)
        {
            try
            {
                string maMH = cboMaMH.SelectedValue?.ToString();
                int rowsAffected = CTDH.XoaChiTietDatHang(txtMaDDH.Text, maMH);
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Xóa chi tiết đơn đặt hàng thành công");
                    LoadChiTietDatHang(txtMaDDH.Text);
                    TinhTongTien();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy chi tiết đơn đặt hàng để xóa");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa chi tiết đơn đặt hàng: " + ex.Message);
            }

        }

        private void btnT_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            string maDDH = txtMaDDH.Text;

            // Gọi BLL để lấy thông tin hóa đơn
            DataTable dtDondathang = DDH.LayThongTinDonDatHangIn(maDDH); // header + detail

            if (dtDondathang.Rows.Count == 0)
            {
                MessageBox.Show("Không tìm thấy dữ liệu để in.");
                return;
            }
           
        }
    }
}
