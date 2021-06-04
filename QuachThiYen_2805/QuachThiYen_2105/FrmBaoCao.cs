using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuachThiYen_2105
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
            dta = kn.Lay_Dulieu("Select * from NHANVIEN");
            BAOCAO_NV BC1 = new BAOCAO_NV();
            BC1.SetDataSource(dta);
            CRV_NhanVien.ReportSource = BC1;
        }
    }
}
