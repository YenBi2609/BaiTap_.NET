using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _48_QuachThiYen_De2
{
    public partial class FrmTimKiem : Form
    {
        Ketnoi kn = new Ketnoi();
        public FrmTimKiem()
        {
            InitializeComponent();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            DataTable dta = new DataTable();
            string sqltk;

                if (txtMaLoai.Text == "")
                {
                    MessageBox.Show("Hãy nhập một điều kiện để tìm kiếm!");
                    return;
                }
                else
                {
                    sqltk = "select * from LOAITK where MALOAI like '" + txtMaLoai.Text + "'";
                    dta = kn.Lay_Dulieu(sqltk);
                    if (dta.Rows.Count == 0)
                    {
                        MessageBox.Show("Không tìm thấy thông tin loại tiết kiệm nào có mã như trên!");
                    } 
            }

            dataGrid.DataSource = dta;
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
