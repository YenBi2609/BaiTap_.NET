using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuachThiYen_2105
{
    public partial class FrmBaoCao_CV : Form
    {
        public FrmBaoCao_CV()
        {
            InitializeComponent();
        }
        Ketnoi kn = new Ketnoi();
        private void FrmBaoCao_CV_Load(object sender, EventArgs e)
        {
            DataTable dta = new DataTable();
            dta = kn.Lay_Dulieu("Select * from CHUCVU");
            Baocao_CV BC1 = new Baocao_CV();
            BC1.SetDataSource(dta);
            crystalReportViewer1.ReportSource = BC1;
        }
    }
}
