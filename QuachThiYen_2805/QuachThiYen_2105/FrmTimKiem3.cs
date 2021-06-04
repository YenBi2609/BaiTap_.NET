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
    public partial class FrmTimKiem3 : Form
    {
        Ketnoi kn = new Ketnoi();
        public FrmTimKiem3()
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
            string sqltk;
            if (radMaCV.Checked == true)
            {
                sqltk = "select * from CHUCVU where MACV like '" + txtMaCV.Text + "'";
                dta = kn.Lay_Dulieu(sqltk);
            }
            if (radTenCV.Checked == true)
            {
                sqltk = "select * from CHUCVU where TENCV like '%" + txtTenCV.Text + "%'";
                dta = kn.Lay_Dulieu(sqltk);
            }
            if (radMaPB.Checked == true)
            {
                sqltk = "select * from PHONGBAN where MAPB like '" + txtMaPB.Text + "'";
                dta = kn.Lay_Dulieu(sqltk);
            }
            if (radTenPB.Checked == true)
            {
                sqltk = "select * from PHONGBAN where TENPB like '%" + txtTenPB.Text + "%'";
                dta = kn.Lay_Dulieu(sqltk);
            }
            dataGrid.DataSource = dta;
        }

        private void FrmTimKiem3_Load(object sender, EventArgs e)
        {

        }
    }
}
