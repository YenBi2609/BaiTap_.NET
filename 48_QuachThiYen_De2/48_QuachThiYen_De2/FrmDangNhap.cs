using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace _48_QuachThiYen_De2
{
    public partial class FrmDangNhap : Form
    {
        public static string id_tk = "";
        Ketnoi kn = new Ketnoi(); // khoi tao class
        public FrmDangNhap()
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
            if(thongbao == DialogResult.Yes)
            {
                this.Close();
            }
        }
        public void getTK(string TK, string MK)
        {
            try
            {

                DataTable dt = new DataTable();
                dt = kn.Lay_Dulieu("Select * from LOGIN where MADN='" + TK + "'and MAMK ='" + MK + "'");

                if (dt != null)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        id_tk = dr["MADN"].ToString();

                    }
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi xảy ra khi truy vấn dữ liệu hoặc kết nối với server thất bại !");
            }
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txtTenDN.Text == string.Empty)
            {
                MessageBox.Show("Tài khoản không được để trống !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenDN.Focus();
                return;
            }
            getTK(txtTenDN.Text, txtMatKhau.Text);

            try
            {
                if (id_tk != "")
                {
                    MessageBox.Show("Đăng nhập thành công!");
                    Form FM = new FrmMain();
                    FM.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không đúng !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtMatKhau.Text = "";
                    txtTenDN.Focus();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Đăng nhập thất bại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            
         }

    }
}
