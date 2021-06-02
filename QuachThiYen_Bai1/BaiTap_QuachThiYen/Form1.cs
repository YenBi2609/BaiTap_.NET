using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTap_QuachThiYen
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult thongbao;
            thongbao = MessageBox.Show("Bạn có muốn thoát không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (thongbao == DialogResult.Yes) this.Close();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if ((this.txtDangNhap.Text == "admin") && (this.txtMatKhau.Text == "admin"))
            {
                MessageBox.Show("Bạn đã đăng nhập thành công!", "Thông báo");
                Form Fm = new FrmMain();
                Fm.Show();
                this.Hide();
            }
            else MessageBox.Show("Xin vui lòng xem lại tên đăng nhập và mật khẩu");
        }
    }
}
