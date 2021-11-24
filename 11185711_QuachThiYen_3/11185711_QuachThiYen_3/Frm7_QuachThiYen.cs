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
    public partial class Frm7_QuachThiYen : Form
    {
        public Frm7_QuachThiYen()
        {
            InitializeComponent();
        }
        Ketnoi kn = new Ketnoi();


        private void Frm7_QuachThiYen_Load(object sender, EventArgs e)
        {
            DataTable dta = new DataTable();
            dta = kn.Lay_Dulieu("Select * from DMTAISAN where NAMSD = 2015");
            BAOCAO_TAISAN BC1 = new BAOCAO_TAISAN();
            BC1.SetDataSource(dta);
            crystalReportViewer1.ReportSource = BC1;
        }
    }
}
