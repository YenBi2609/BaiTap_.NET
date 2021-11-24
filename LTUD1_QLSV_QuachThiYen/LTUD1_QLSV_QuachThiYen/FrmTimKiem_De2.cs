using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LTUD1_QLSV_QuachThiYen
{
    public partial class FrmTimKiem_De2 : Form
    {
        Ketnoi kn = new Ketnoi();
        public FrmTimKiem_De2()
        {
            InitializeComponent();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            DataTable dta = new DataTable();
            string sqltk;
            if(radMaKhoa.Checked == true)
            {
                if (txtMaKhoa.Text == "")
                {
                    MessageBox.Show("Hãy nhập một điều kiện để tìm kiếm!");
                    return;
                }
                else
                {
                    sqltk = "select * from DMSV where MAKHOA like '" + txtMaKhoa.Text + "'";
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
