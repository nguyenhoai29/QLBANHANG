using System;
using System.Data;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using BLL2;

namespace QLBANHANG
{
    public partial class InHoaDon : Form
    {
        private DataTable DLHoaDon; // Dữ liệu truyền vào từ Form_HoaDon

        // Constructor nhận DataTable
        public InHoaDon(DataTable dt)
        {
            InitializeComponent();
            DLHoaDon = dt;
        }

        private void InHoaDon_Load(object sender, EventArgs e)
        {
            try
            {
                // Tạo mới báo cáo
                ReportDocument rpt = new ReportDocument();

                // Load file Crystal Report (bạn phải có file Indanhoa.rpt trong thư mục debug)
                rpt.Load(Application.StartupPath + @"\HoaDonBanHang.rpt");

                // Gán dữ liệu cho báo cáo
                rpt.SetDataSource(DLHoaDon);

                // 👉 Tính tổng tiền từ cột "ThanhTien"
                decimal tongTien = 0;
                foreach (DataRow row in DLHoaDon.Rows)
                {
                    if (row["ThanhTien"] != DBNull.Value)
                    {
                        tongTien += Convert.ToDecimal(row["ThanhTien"]);
                    }
                }

                // 👉 Đổi tổng tiền thành chữ
                string tienChu = TienBangChu.DocSo((long)tongTien);

                // 👉 Gán tham số vào báo cáo (parameter phải được tạo trong Crystal Report)
                rpt.SetParameterValue("TienBangChu", tienChu);

                // 👉 Hiển thị trên CrystalReportViewer
                crystalReportViewer1.ReportSource = rpt;
                crystalReportViewer1.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi in hóa đơn: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
