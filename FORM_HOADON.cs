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
    public partial class FORM_HOADON : Form
    {
        HOADON_BLL HD = new HOADON_BLL();
        CHITIETHOADON_BLL CTHD = new CHITIETHOADON_BLL();
        KHACHHANG_BLL KH = new KHACHHANG_BLL();
        NHANVIEN_BLL NV = new NHANVIEN_BLL();
        MATHANG_BLL MH = new MATHANG_BLL();
        private DataTable dtChiTietTam;
        public FORM_HOADON()
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
            dtChiTietTam.Columns.Add("GiaBan", typeof(decimal));
            dtChiTietTam.Columns.Add("ThanhTien", typeof(decimal));
        }

        private void FORM_HOADON_Load(object sender, EventArgs e)
        {
            DataTable dtKhachHang = KH.ChonKhachHang();
            cboMaKH.DataSource = dtKhachHang;
            cboMaKH.DisplayMember = "TenKH";
            cboMaKH.ValueMember = "MaKH";

            DataTable dtNhanVien = NV.ChonNhanVien();
            cboMaNV.DataSource = dtNhanVien;
            cboMaNV.DisplayMember = "TenNV";
            cboMaNV.ValueMember = "MaNV";

            DataTable dtMatHang = MH.ChonMatHang();
            cboMaMH.DataSource = dtMatHang;
            cboMaMH.DisplayMember = "TenMH";
            cboMaMH.ValueMember = "MaMH";

            
            txtMaHD.Text = HD.SinhMaHoaDon();
            txtMaHD.Enabled = false; 
        }

        private void dgvHOADON_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtMaHD.Enabled = false;
                txtMaHD.Text = dgvHOADON.Rows[e.RowIndex].Cells[0].Value.ToString();
                dtpNgayLap.Value = DateTime.Parse(dgvHOADON.Rows[e.RowIndex].Cells[1].Value.ToString());
                cboMaKH.SelectedValue = dgvHOADON.Rows[e.RowIndex].Cells[2].Value.ToString();
                cboMaNV.SelectedValue = dgvHOADON.Rows[e.RowIndex].Cells[3].Value.ToString();

                LoadChiTietHoaDon(txtMaHD.Text);
                TinhTongTien();
                dtChiTietTam.Clear();

            }
        }

        private void dgvChiTietHoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                cboMaMH.SelectedValue = dgvChiTietHoaDon.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtSoLuong.Text = dgvChiTietHoaDon.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
        }
        private void LoadChiTietHoaDon(string maHD)
        {
            DataTable dtChiTiet = HD.LayChiTietHoaDon(maHD);
            dgvChiTietHoaDon.DataSource = dtChiTiet;
        }

        private void TinhTongTien()
        {
            decimal tongTien = HD.LayTongTienHoaDon(txtMaHD.Text);
            txtTongTien.Text = tongTien.ToString("N2");
        }
    
        private void btnHienThi_Click(object sender, EventArgs e)
        {
            dgvHOADON.DataSource = HD.LayDanhSachHoaDonTongTien();
            dgvChiTietHoaDon.DataSource = null;
            txtTongTien.Clear();
            dtChiTietTam.Clear();

        }

        private void btnTM_Click(object sender, EventArgs e)
        {
            txtMaHD.Text = HD.SinhMaHoaDon(); 
            dtpNgayLap.Value = DateTime.Now;
            cboMaKH.SelectedIndex = -1;
            cboMaNV.SelectedIndex = -1;
            txtMaHD.Enabled = false;
            dgvChiTietHoaDon.DataSource = null;
            txtTongTien.Clear();
            txtSoLuong.Clear();
            cboMaMH.SelectedIndex = -1;
            dtChiTietTam.Clear();
        }

        private void btnL_Click(object sender, EventArgs e)
        {
            try
            {
                string maKH = cboMaKH.SelectedValue?.ToString();
                string maNV = cboMaNV.SelectedValue?.ToString();
                int rowsAffected = HD.ThemHoaDon(txtMaHD.Text, dtpNgayLap.Value, maKH, maNV);
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Thêm hóa đơn thành công");
                    btnHienThi_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Thêm hóa đơn thất bại");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm hóa đơn: " + ex.Message);
            }
            dtChiTietTam.Clear();



        }


        private void btnCN_Click(object sender, EventArgs e)
        {
            try
            {
                string maKH = cboMaKH.SelectedValue?.ToString();
                string maNV = cboMaNV.SelectedValue?.ToString();
                int rowsAffected = HD.SuaHoaDon(txtMaHD.Text, dtpNgayLap.Value, maKH, maNV);
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Cập nhật hóa đơn thành công");
                    btnHienThi_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Cập nhật hóa đơn thất bại");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật hóa đơn: " + ex.Message);
            }
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            try
            {
                int rowsAffected = HD.XoaHoaDon(txtMaHD.Text);
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Xóa hóa đơn thành công");
                    btnHienThi_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy hóa đơn để xóa");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa hóa đơn: " + ex.Message);
            }

        }

        private void btnTK_Click(object sender, EventArgs e)
        {
            dgvHOADON.DataSource = HD.TimKiemHoaDon(txtTim.Text);
        }

        private void btnThemChiTiet_Click(object sender, EventArgs e)
        {
            try
            {
                string maMH = cboMaMH.SelectedValue?.ToString();
                int soLuong = int.Parse(txtSoLuong.Text);
                int rowsAffected = CTHD.ThemChiTietHoaDon(txtMaHD.Text, maMH, soLuong);
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Thêm chi tiết hóa đơn thành công");
                    LoadChiTietHoaDon(txtMaHD.Text);
                    TinhTongTien();
                }
                else
                {
                    MessageBox.Show("Thêm chi tiết hóa đơn thất bại");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm chi tiết hóa đơn: " + ex.Message);
            }
        }

        private void btnSuaChiTiet_Click(object sender, EventArgs e)
        {
            try
            {
                string maMH = cboMaMH.SelectedValue?.ToString();
                int soLuong = int.Parse(txtSoLuong.Text);
                int rowsAffected = CTHD.SuaChiTietHoaDon(txtMaHD.Text, maMH, soLuong);
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Cập nhật chi tiết hóa đơn thành công");
                    LoadChiTietHoaDon(txtMaHD.Text);
                    TinhTongTien();
                }
                else
                {
                    MessageBox.Show("Cập nhật chi tiết hóa đơn thất bại");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật chi tiết hóa đơn: " + ex.Message);
            }
        }

        private void btnXoaChiTiet_Click(object sender, EventArgs e)
        {
            try
            {
                string maMH = cboMaMH.SelectedValue?.ToString();
                int rowsAffected = CTHD.XoaChiTietHoaDon(txtMaHD.Text, maMH);
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Xóa chi tiết hóa đơn thành công");
                    LoadChiTietHoaDon(txtMaHD.Text);
                    TinhTongTien();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy chi tiết hóa đơn để xóa");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa chi tiết hóa đơn: " + ex.Message);
            }
        }

        private void btnT_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            string maHD = txtMaHD.Text;

            // Gọi BLL để lấy thông tin hóa đơn
            DataTable dtHoaDon = HD.LayThongTinHoaDonIn(maHD); // header + detail

            if (dtHoaDon.Rows.Count == 0)
            {
                MessageBox.Show("Không tìm thấy dữ liệu để in.");
                return;
            }

            // Mở Form in
            InHoaDon formIn = new InHoaDon(dtHoaDon);
            formIn.Show();

        }
    }
}
