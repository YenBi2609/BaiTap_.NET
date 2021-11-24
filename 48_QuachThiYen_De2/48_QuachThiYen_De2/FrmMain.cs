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
    public partial class FrmMain : Form
    {

        public FrmMain()
        {
            InitializeComponent();
        }


        private void nhanVien_Click(object sender, EventArgs e)
        {
            Form f = new FrmNhanVien();
            f.Show();
        }

        private void timKiem_Click(object sender, EventArgs e)
        {
            Form f = new FrmTimKiem();
            f.Show();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            
        }

        private void baoCao_Click(object sender, EventArgs e)
        {
            Form f = new FrmBaoCao();
            f.Show();
        }
    }
}
