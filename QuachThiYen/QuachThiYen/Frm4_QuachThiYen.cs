using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuachThiYen
{
    public partial class Frm4_QuachThiYen : Form
    {
        Ketnoi kn = new Ketnoi();
        public Frm4_QuachThiYen()
        {
            InitializeComponent();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            DataTable dta = new DataTable();
            string sqltk;
            if(radMaTS.Checked == true)
            {
                if (txtMaTS.Text == "")
                {
                    MessageBox.Show("Hãy nhập một điều kiện để tìm kiếm!");
                    return;
                }
                else
                {
                    sqltk = "select * from DMTAISAN where MATS like '" + txtMaTS.Text + "'";
                    dta = kn.Lay_Dulieu(sqltk);
                    if (dta.Rows.Count == 0)
                    {
                        MessageBox.Show("Không tìm thấy thông tin tài sản nào có mã như trên!");
                    }
                }
 
            }
            if (radLoaiTS.Checked == true)
            {
                if (txtMaLTS.Text == "")
                {
                    MessageBox.Show("Hãy nhập một điều kiện để tìm kiếm!");
                    return;
                }
                else
                {
                    sqltk = "select * from DMTAISAN where MALOAITS like '" + txtMaLTS.Text + "'";
                    dta = kn.Lay_Dulieu(sqltk);
                    if (dta.Rows.Count == 0)
                    {
                        MessageBox.Show("Không tìm thấy thông tin tài sản nào có mã như trên!");
                    }
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
