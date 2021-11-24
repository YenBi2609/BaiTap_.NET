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

namespace testBai
{
    public partial class FrmDangNhap : Form
    {
        Ketnoi kn = new Ketnoi();
        public FrmDangNhap()
        {
            InitializeComponent();
        }

        private void btnDN_Click(object sender, EventArgs e)
        {
            kn.KetNoi_CSDL();
            string TN = txtDN.Text;
            string MK = txtMK.Text;
            string sql_login = "Select MADN, MAMK from LOGIN where MADN='" + TN + "'and MAMK ='" + MK + "'";
            SqlCommand cmd = new SqlCommand(sql_login, kn.cnn);
            SqlDataReader datRed = cmd.ExecuteReader();
            if (datRed.Read() == true)
            {
                MessageBox.Show("Đăng nhập thành công!");
                Form FM = new FrmMain();
                FM.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Hãy kiểm tra lại thông tin đăng nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult thongbao;
            thongbao = MessageBox.Show("Bạn có muốn thoát không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (thongbao == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void FrmDangNhap_Load(object sender, EventArgs e)
        {

        }
    }
}
