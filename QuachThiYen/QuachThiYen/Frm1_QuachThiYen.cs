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
    public partial class Frm1_QuachThiYen : Form
    {
        private int childFormNumber = 0;

        public Frm1_QuachThiYen()
        {
            InitializeComponent();
        }
       
        private void dmts_Click(object sender, EventArgs e)
        {
            Form f = new Frm3_QuachThiYen();
            f.Show();
        }

        private void timKiem_Click(object sender, EventArgs e)
        {
            Form f = new Frm4_QuachThiYen();
            f.Show();
        }

        private void Frm1_HovatenSV_Load(object sender, EventArgs e)
        {
            if (Frm2_QuachThiYen.quyentruycap.Equals("1")) dmts.Enabled = false;
        }

        private void baoCao_Click(object sender, EventArgs e)
        {
            Form f = new Frm5_QuachThiYen();
            f.Show();
        }
    }
}
