using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _11185711_QuachThiYen_3
{
    public partial class Frm6_QuachThiYen : Form
    {
        Ketnoi kn = new Ketnoi();
        public Frm6_QuachThiYen()
        {
            InitializeComponent();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            DataTable dta = new DataTable();
            string sqltk;
            if(radTinhTrang.Checked == true)
            {
                if (txtTinhTrang.Text == "")
                {
                    MessageBox.Show("Hãy nhập một điều kiện để tìm kiếm!");
                    return;
                }
                else
                {
                    sqltk = "select * from TS_SUACHUA where TINHTRANG like '" + txtTinhTrang.Text + "'";
                    dta = kn.Lay_Dulieu(sqltk);
                    if (dta.Rows.Count == 0)
                    {
                        MessageBox.Show("Không tìm thấy thông tin tài sản sửa chữa nào có mã như trên!");
                    }

                }
 
            }
            if (radNgayYC.Checked == true)
            {
                if (dtpNgayYC.Text == "")
                {
                    MessageBox.Show("Hãy nhập một điều kiện để tìm kiếm!");
                    return;
                }
                else
                {
                    sqltk = "select * from TS_SUACHUA where NGAYYC = '" + dtpNgayYC.Text + "'";
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
