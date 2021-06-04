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
    public partial class DataTest : Form
    {
        public DataTest()
        {
            InitializeComponent();
        }

        private void DataTest_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.PHONGBAN' table. You can move, or remove it, as needed.
            this.pHONGBANTableAdapter.Fill(this.dataSet1.PHONGBAN);
            // TODO: This line of code loads data into the 'dataSet1.DMKHOA' table. You can move, or remove it, as needed.
            this.dMKHOATableAdapter.Fill(this.dataSet1.DMKHOA);

        }

        private void dMKHOABindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
