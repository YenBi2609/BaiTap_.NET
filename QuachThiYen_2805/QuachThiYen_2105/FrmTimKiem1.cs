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
    public partial class FrmTimKiem1 : Form
    {
        Ketnoi kn = new Ketnoi();
        public FrmTimKiem1()
        {
            InitializeComponent();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            DataTable dta = new DataTable();
            string sqltk;
            if(radMaNV.Checked == true)
            {
                sqltk = "select * from NHANVIEN where MANV like '" + txtMaNV.Text + "'";
                dta = kn.Lay_Dulieu(sqltk);
            }
            if (radTenNV.Checked == true)
            {
                sqltk = "select * from NHANVIEN where TENNV like '%" + txtTenNV.Text + "%'";
                dta = kn.Lay_Dulieu(sqltk);
            }
            if (radPB.Checked == true)
            {
                sqltk = "select * from NHANVIEN where MAPB like '" + cboPB.Text + "'";
                dta = kn.Lay_Dulieu(sqltk);
            }
            if (radCV.Checked == true)
            {
                sqltk = "select * from NHANVIEN where MACV like '" + cboCV.Text + "'";
                dta = kn.Lay_Dulieu(sqltk);
            }
            dataGrid.DataSource = dta;

        }

        private void FrmTimKiem1_Load(object sender, EventArgs e)
        {
            DataTable dta = kn.Lay_Dulieu("select MAPB, TENPB from PHONGBAN");
            cboPB.DataSource = dta;
            cboPB.DisplayMember = "MAPB";
            cboPB.ValueMember = "MAPB";

            DataTable dta1 = kn.Lay_Dulieu("select * from CHUCVU");
            cboCV.DataSource = dta1;
            cboCV.DisplayMember = "MACV";
            cboCV.ValueMember = "MACV";

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
    }
}
