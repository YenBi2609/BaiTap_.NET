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


namespace QuachThiYen_2105
{
    public partial class FrmDangNhap : Form
    {
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

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            kn.KetNoi_CSDL();
            string TN = txtTenDN.Text;
            string MK = txtMatKhau.Text;
            string sql_login = "Select TaiKhoan, MatKhau from DangNhap where TaiKhoan='" + TN + "'and MatKhau ='" + MK + "'";
            SqlCommand cmd = new SqlCommand(sql_login, kn.cnn);
            SqlDataReader datRed = cmd.ExecuteReader();
            if(datRed.Read() == true)
            {
                MessageBox.Show("Đăng nhập thành công!");

            }   
            else
            {
                MessageBox.Show("Hãy kiểm tra lại thông tin đăng nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
    }
}
