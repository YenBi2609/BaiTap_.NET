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
    public partial class FormTinh : Form
    {
        public FormTinh()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult thongbao;
            thongbao = MessageBox.Show("Bạn có muốn thoát không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (thongbao == DialogResult.Yes) this.Close();
        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            String So1 = txtSo1.Text;
            String So2 = txtSo2.Text;
            int i1 = int.Parse(So1);
            int i2 = int.Parse(So2);
            long Tong = 0;
            Tong = i1 + i2;
            txtKQ.Text = Tong.ToString();

        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            String So1 = txtSo1.Text;
            String So2 = txtSo2.Text;
            int i1 = int.Parse(So1);
            int i2 = int.Parse(So2);
            long Tru = 0;
            Tru = i1 - i2;
            txtKQ.Text = Tru.ToString();
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            String So1 = txtSo1.Text;
            String So2 = txtSo2.Text;
            int i1 = int.Parse(So1);
            int i2 = int.Parse(So2);
            long Nhan = 0;
            Nhan = i1 * i2;
            txtKQ.Text = Nhan.ToString();
        }

        private void btnChia_Click(object sender, EventArgs e)
        {
            String So1 = txtSo1.Text;
            String So2 = txtSo2.Text;
            float i1 = int.Parse(So1);
            float i2 = int.Parse(So2);
            if (i2 == 0)
                MessageBox.Show("Lỗi chia cho 0");
            float Chia = 0;           
            Chia = i1 / i2;
            txtKQ.Text = Chia.ToString();
        }
    }
}
