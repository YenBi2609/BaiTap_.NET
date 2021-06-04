using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTap_QuachThiYen
{
    public partial class GiaiPTB2 : Form
    {
        public GiaiPTB2()
        {
            InitializeComponent();
        }

        private void GiaiPTB2_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult thongbao;
            thongbao = MessageBox.Show("Bạn có muốn thoát không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (thongbao == DialogResult.Yes) this.Close();
        }

        private void btnGiaiPT_Click(object sender, EventArgs e)
        {
            if (txtHeSo_a.Text == "") MessageBox.Show("ĐÂY KHÔNG PHẢI LÀ PHƯƠNG TRÌNH BẬC 2");
            txtHeSo_a.Focus();
            int a, b, c, denta;
            float x1, x2, can_denta;

            a = Convert.ToInt32(txtHeSo_a.Text);
            b = Convert.ToInt32(txtHeSo_b.Text);
            c = Convert.ToInt32(txtHeSo_c.Text);

            denta = b * b - 4 * a * c;
            if (denta < 0) txtThongBaoNghiem.Text = "Phương trình vô nghiệm";
            else
                if(denta == 0)
            {
                x1 = -b / (2 * a);
                txtThongBaoNghiem.Text = "Phương trình có nghiệm khép: x=" + Convert.ToString(x1);

            }   
            else
            {
                can_denta = (float)Math.Sqrt(denta);
                x1 = (-b + can_denta) / (2 * a);
                x2 = (-b - can_denta) / (2 * a);
                txtThongBaoNghiem.Text = "Phương trình có 2 nghiệm phân biệt: x1 = " + Convert.ToString(x1) +
                    ", x2 = " + Convert.ToString(x2);
            }

        }
    }
}
