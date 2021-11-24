using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testBai
{
    public partial class FrmTimKiem : Form
    {
        Ketnoi kn = new Ketnoi();
        public FrmTimKiem()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dta = new DataTable();
            string sqltk;

                sqltk = "select * from LOAITK where MALOAI like '" + txtMaLoai.Text + "'";
                dta = kn.Lay_Dulieu(sqltk);

              dtaGrid.DataSource = dta;
        }

        private void button2_Click(object sender, EventArgs e)
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
