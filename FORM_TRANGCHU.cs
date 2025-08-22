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
    public partial class FORM_TRANGCHU : Form
    {
        private Dictionary<Type, Form> openForms = new Dictionary<Type, Form>();
        public FORM_TRANGCHU()
        {
            InitializeComponent();
        }
        public event EventHandler DangXuat;
        private void FORM_TRANGCHU_Load(object sender, EventArgs e)
        {
            lblWelcome.Visible = true;
            pictureBoxLogo.Visible = true;
            // Xử lý phân quyền
            string quyen = FORM_DANGNHAP.QuyenNguoiDung;

            if (quyen == "NV")
            {
                // Ẩn nút hoặc menu không cho phép với Nhân viên
                menuQLNV.Visible = false;      // Menu quản lý nhân viên
                btnQLNV.Visible = false;       // Button quản lý nhân viên

                btnTKBC.Visible = false;       // Nút Thống kê
            }
        }
        private void ShowFormInPanel<T>() where T : Form, new()
        {
            try
            {
                Type formType = typeof(T);

                // Kiểm tra xem form có đang hiển thị trong panelContent không
                if (openForms.ContainsKey(formType) && !openForms[formType].IsDisposed)
                {
                    // Nếu form đã có trong panelContent, không cần làm gì
                    if (panelContent.Controls.Contains(openForms[formType]))
                        return;

                    // Nếu form tồn tại nhưng không trong panelContent, xóa khỏi openForms
                    openForms.Remove(formType);
                }

                // Ẩn giao diện chào mừng
                lblWelcome.Visible = false;
                pictureBoxLogo.Visible = false;

                // Tạo form mới
                T form = new T();
                form.TopLevel = false;
                form.FormBorderStyle = FormBorderStyle.None;
                form.Dock = DockStyle.Fill;

                // Xóa nội dung panel và thêm form mới
                panelContent.Controls.Clear();
                panelContent.Controls.Add(form);
                form.Show();

                // Lưu instance
                openForms[formType] = form;

                // Xử lý khi form đóng
                form.FormClosed += (s, args) =>
                {
                    openForms.Remove(formType);
                    lblWelcome.Visible = true;
                    pictureBoxLogo.Visible = true;
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi mở form: {ex.Message}");
            }
        
    }
        //Menu
        private void menuQLMH_Click(object sender, EventArgs e)
        {
            ShowFormInPanel<FORM_MATHANG>();
        }

        private void menuQLLH_Click(object sender, EventArgs e)
        {
            ShowFormInPanel<FORM_LOAIHANG>();
        }

        private void menuQLNV_Click(object sender, EventArgs e)
        {
            ShowFormInPanel<FORM_NHANVIEN>();
        }

        private void menuQLKH_Click(object sender, EventArgs e)
        {
            ShowFormInPanel<FORM_KHACHHANG>();
        }

        private void menuQLHD_Click(object sender, EventArgs e)
        {
            ShowFormInPanel<FORM_HOADON>();
        }

        private void menuQLDDH_Click(object sender, EventArgs e)
        {
            ShowFormInPanel<FORM_DONDATHANG>();
        }

        private void menuQLNCC_Click(object sender, EventArgs e)
        {
            ShowFormInPanel<FORM_NHACUNGCAP>();
        }

        private void menuThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnQLMH_Click(object sender, EventArgs e)
        {
            ShowFormInPanel<FORM_MATHANG>();
        }

        private void btnQLLH_Click(object sender, EventArgs e)
        {
            ShowFormInPanel<FORM_LOAIHANG>();
        }

        private void btnQLNV_Click(object sender, EventArgs e)
        {
            ShowFormInPanel<FORM_NHANVIEN>();
        }

        private void btnQLKH_Click(object sender, EventArgs e)
        {
            ShowFormInPanel<FORM_KHACHHANG>();
        }

        private void btnQLHD_Click(object sender, EventArgs e)
        {
            ShowFormInPanel<FORM_HOADON>();
        }

        private void btnQLDDH_Click(object sender, EventArgs e)
        {
            ShowFormInPanel<FORM_DONDATHANG>();
        }

        private void btnQLNCC_Click(object sender, EventArgs e)
        {
            ShowFormInPanel<FORM_NHACUNGCAP>();
        }

        private void btnTKBC_Click(object sender, EventArgs e)
        {
            ShowFormInPanel<FORM_THONGKE_TONGHOP>();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đăng xuất ?",
                        "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close(); // Đóng form hiện tại (FORM_TRANGCHU)

                // Gọi sự kiện DangXuat nếu có (đã được khai báo trong FORM_DANGNHAP)
                DangXuat?.Invoke(this, EventArgs.Empty);
            }
        }
        private void FORM_TRANGCHU_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

    }
}
