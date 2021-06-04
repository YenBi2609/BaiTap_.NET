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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            String strGT = "";
            if (radNam.Checked == true)
                strGT += radNam.Text;
            if (radNu.Checked == true)
                strGT += radNu.Text;
            lblXem.Text = "Giới tính là: " + strGT;

            String strUutien = "";
            if (radCo.Checked == true)
                strUutien += radCo.Text;
            if (radKhong.Checked == true)
                strUutien += radKhong.Text;
            lblXem.Text += "\nƯu tiên: " + strUutien;
        }

        private void btnKetQua_Click(object sender, EventArgs e)
        {
            String strKQ = "";
            if (chkKhoiA.Checked == true)
                strKQ += chkKhoiA.Text + ", ";
            if (chkKhoiA1.Checked == true)
                strKQ += chkKhoiA1.Text + ", ";
            if (chkKhoiD0.Checked == true)
                strKQ += chkKhoiD0.Text + ", ";
            if (chkKhoiB.Checked == true)
                strKQ += chkKhoiB.Text + ", ";
            if (chkKhoiD7.Checked == true)
                strKQ += chkKhoiD7.Text + ", ";
            if (strKQ == "")
                lblKetQua.Text = "Bạn không chọn khối thi nào";
            else
            {
                strKQ = strKQ.Substring(0, strKQ.Length - 2);
                lblKetQua.Text = "Bạn đã chọn các môn học sau: " + strKQ;

            }

        }
    }
}
