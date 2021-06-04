using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuachThiYen_2105
{
    public partial class FrmTimKiem : Form
    {
        Ketnoi kn = new Ketnoi();
        public FrmTimKiem()
        {
            InitializeComponent();
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

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            DataTable dta = new DataTable();
            string sqltk = "select * from NHANVIEN where MANV like '" + txtMaNV.Text + "'";
            //string sqltk = "select * from NHANVIEN where TENNV like '%" + txtHoTen.Text + "%'";
            dta = kn.Lay_Dulieu(sqltk);
            dataGrid_KetQua.DataSource = dta;
        }
    }
}
