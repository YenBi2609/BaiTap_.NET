using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testBai
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
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            DataTable dta = new DataTable();
            dta = kn.Lay_Dulieu("Select * from LOAITK where LOAITIEN LIKE '"+txtLoaiTien.Text+"'");
            BAOCAOLOAITIETKIEM BC1 = new BAOCAOLOAITIETKIEM();
            BC1.SetDataSource(dta);
            CR.ReportSource = BC1;
        }
    }
}
