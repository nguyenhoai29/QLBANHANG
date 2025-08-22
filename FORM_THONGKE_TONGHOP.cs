using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL2; 


namespace QLBANHANG
{
    public partial class FORM_THONGKE_TONGHOP : Form
    {
        ThongKeBLL thongKeBLL = new ThongKeBLL(); 

        public FORM_THONGKE_TONGHOP()
        {
            InitializeComponent();
        }

        private void btnThongKeDoanhThu_Click_1(object sender, EventArgs e)
        {
            DateTime tuNgay = dtpTuNgay.Value;
            DateTime denNgay = dtpDenNgay.Value;

            DataTable dt = thongKeBLL.LayDoanhThu(tuNgay, denNgay);
            dgvDoanhThu.DataSource = dt;

            // Hiển thị lên biểu đồ
            chartDoanhThu.Series[0].Points.Clear();
            foreach (DataRow row in dt.Rows)
            {
                chartDoanhThu.Series[0].Points.AddXY(row["ThoiGian"], row["DoanhThu"]);
            }
        }

        private void btnThongKeSanPham_Click_1(object sender, EventArgs e)
        {
            DataTable dt = thongKeBLL.LaySanPhamBanChay();
            dgvSanPham.DataSource = dt;

            chartSanPham.Series[0].Points.Clear();
            foreach (DataRow row in dt.Rows)
            {
                chartSanPham.Series[0].Points.AddXY(row["TenMH"], row["TongSoLuong"]);
            }
        }

        private void btnThongKeNV_Click(object sender, EventArgs e)
        {
            DataTable dt = thongKeBLL.LayHoaDonTheoNhanVien();
            dgvHoaDonNV.DataSource = dt;

            chartNhanVien.Series[0].Points.Clear();
            foreach (DataRow row in dt.Rows)
            {
                chartNhanVien.Series[0].Points.AddXY(row["TenNV"], row["SoHoaDon"]);
            }
        }

        private void btnDuBao_Click(object sender, EventArgs e)
        {
                DataTable dt = thongKeBLL.LayDuBaoDoanhThu();

                dgvDuBao.DataSource = dt;
                chartDuBao.Series[0].Points.Clear();

                double tong = 0;
                foreach (DataRow row in dt.Rows)
                {
                    double doanhThu = Convert.ToDouble(row["DoanhThu"]);
                    tong += doanhThu;
                    chartDuBao.Series[0].Points.AddXY(row["ThangNam"], doanhThu);
                }

                double duBao = tong / dt.Rows.Count;
                lblDuBaoKetQua.Text = $"Dự báo doanh thu tháng tới: {duBao:N0} VNĐ";

        }

        private void chartDuBaoSP_Click(object sender, EventArgs e)
        {

        }

        private void btnDuBaoSP_Click(object sender, EventArgs e)
        {
            DataTable dt = thongKeBLL.LayDuBaoSanPhamBanChay();
            dgvDuBaoSP.DataSource = dt;

            chartDuBaoSP.Series[0].Points.Clear();
            foreach (DataRow row in dt.Rows)
            {
                chartDuBaoSP.Series[0].Points.AddXY(row["TenMH"], Convert.ToDouble(row["DuBaoThangToi"]));
            }

            if (dt.Rows.Count > 0)
            {
                lblTopSP.Text = $"🔥 Sản phẩm dự báo bán chạy nhất: {dt.Rows[0]["TenMH"]}";
            }
        }
    }
}
