using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LTUD1_QLSV_QuachThiYen
{
    public partial class FrmBaoCao : Form
    {
        Ketnoi kn = new Ketnoi();
        public FrmBaoCao()
        {
            InitializeComponent();
        }

        private void FrmBaoCao_Load(object sender, EventArgs e)
        {
            DataTable dta = new DataTable();
            dta = kn.Lay_Dulieu("Select * from DMSV");
            BAOCAO_SINHVIEN BC1 = new BAOCAO_SINHVIEN();
            BC1.SetDataSource(dta);
            crystalReportViewer1.ReportSource = BC1;
        }
    }
}
