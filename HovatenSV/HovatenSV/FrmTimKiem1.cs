using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HovatenSV
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
            if(radMaTS.Checked == true)
            {
                sqltk = "select * from DMTAISAN where MATS like '" + txtMaTS.Text + "'";
                dta = kn.Lay_Dulieu(sqltk);
            }
            if (radLoaiTS.Checked == true)
            {
                sqltk = "select * from LOAITAISAN where MALOAITS like '" + txtMaTS.Text + "'";
                dta = kn.Lay_Dulieu(sqltk);
            }

            dataGrid.DataSource = dta;
        }

        private void FrmTimKiem1_Load(object sender, EventArgs e)
        {

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
