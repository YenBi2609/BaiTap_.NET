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
    public partial class TH_Control : Form
    {
        public TH_Control()
        {
            InitializeComponent();
        }

        private void TH_Control_Load(object sender, EventArgs e)
        {
            cboTruong.Items.Add("Truong DH Kinh te Quoc Dan");
            cboTruong.Items.Add("Truong DH Bach Khoa Ha Noi");
            cboTruong.Items.Add("Truong DH Xay Dung");
            cboTruong.Items.Add("Truong DH Quoc Gia");
            cboTruong.Items.Add("Truong DH Thuy Loi");

            for (int i = 1; i <= 31; i++)
            {
                cboNgay.Items.Add(i);
                cboNgay.SelectedIndex = 0;
            }

            for (int i = 1; i <= 12; i++)
            {
                cboThang.Items.Add(i);
                cboThang.SelectedIndex = 0;
            }

            for (int i = 1980; i <= 2005; i++)
            {
                cboNam.Items.Add(i);
                cboNam.SelectedIndex = 0;
            }

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (lstDanhsach1.Items.Count > 0)
                lstDanhsach2.Items.Add(lstDanhsach1.SelectedItem);
            lstDanhsach1.Items.Remove(lstDanhsach1.SelectedItem);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            for( int i=0;i<lstDanhsach1.Items.Count;i++)
            {
                lstDanhsach2.Items.Add(lstDanhsach1.Items[i]);
            }
            for (int i = 0; i < lstDanhsach2.Items.Count; i++)
            {
                lstDanhsach1.Items.Add(lstDanhsach2.Items[i]);
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if(lstDanhsach2.Items.Count > 0)
            {
                lstDanhsach1.Items.Add(lstDanhsach2.SelectedItem);
                lstDanhsach2.Items.Remove(lstDanhsach2.SelectedItem);
            }    
        }
        private void btn4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lstDanhsach2.Items.Count; i++)
            {
                lstDanhsach1.Items.Add(lstDanhsach2.Items[i]);
            }
            for (int i = 0; i < lstDanhsach1.Items.Count; i++)
            {
                lstDanhsach2.Items.Add(lstDanhsach1.Items[i]);
            }
        }

    }
}
