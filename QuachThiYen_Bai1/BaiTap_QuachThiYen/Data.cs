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
    public partial class Data : Form
    {
        public Data()
        {
            InitializeComponent();
        }

        private void Data_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet3.DangNhap' table. You can move, or remove it, as needed.
            this.dangNhapTableAdapter1.Fill(this.dataSet3.DangNhap);

        }
    }
}
