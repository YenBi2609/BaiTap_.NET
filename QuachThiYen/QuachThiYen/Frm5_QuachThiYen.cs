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
    public partial class Frm5_QuachThiYen : Form
    {
        public Frm5_QuachThiYen()
        {
            InitializeComponent();
        }
        Ketnoi kn = new Ketnoi();

        private void Frm5_QuachThiYen_Load(object sender, EventArgs e)
        {
            DataTable dta = new DataTable();
            dta = kn.Lay_Dulieu("Select * from DMTAISAN where MADONVI = 'DV001'");
            BAOCAO_TAISAN BC1 = new BAOCAO_TAISAN();
            BC1.SetDataSource(dta);
            crystalReportViewer1.ReportSource = BC1;
        }
    }
}
