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
    public partial class FrmBaoCao : Form
    {
        public FrmBaoCao()
        {
            InitializeComponent();
        }
        Ketnoi kn = new Ketnoi();

        private void FrmBaoCao_Load(object sender, EventArgs e)
        {
            DataTable dta = new DataTable();
            dta = kn.Lay_Dulieu("Select LOAITIEN,MALOAI,TENLOAI,KYHAN,LAISUAT from LOAITK group by LOAITIEN, MALOAI, TENLOAI,KYHAN,LAISUAT");
            BAOCAO BC1 = new BAOCAO();
            BC1.SetDataSource(dta);
            crystalReportViewer1.ReportSource = BC1;

        }
    }
}
