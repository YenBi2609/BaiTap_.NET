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


namespace HovatenSV
{
    public partial class FrmDangNhap : Form
    {
        public static string quyentruycap;
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
                dt = kn.Lay_Dulieu("Select * from HETHONG where TENDN='" + TK + "'and MATKHAU ='" + MK + "'");

                if (dt != null)
                {
                    foreach (DataRow dr in dt.Rows)
                    {

                        // Lấy quyền truy cập
                        quyentruycap = dr["QUYEN"].ToString();
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
            kn.KetNoi_CSDL();
            string TN = txtTenDN.Text;
            string MK = txtMatKhau.Text;
            string sql_login = "Select TENDN, MATKHAU from HETHONG where TENDN='" + TN + "'and MATKHAU ='" + MK + "'";
            SqlCommand cmd = new SqlCommand(sql_login, kn.cnn);
            SqlDataReader datRed = cmd.ExecuteReader();
            if(datRed.Read() == true)
            {
                MessageBox.Show("Đăng nhập thành công!");
                getTK(TN,MK);
                Form FM = new Frm1_HovatenSV();
                FM.Show();
                this.Hide();


            }   
            else
            {
                MessageBox.Show("Hãy kiểm tra lại thông tin đăng nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
    }
}
