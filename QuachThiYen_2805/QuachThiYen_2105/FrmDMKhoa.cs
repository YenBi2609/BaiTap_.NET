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
    public partial class FrmDMKhoa : Form

    {
        Ketnoi kn = new Ketnoi();
        public FrmDMKhoa()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult thongbao;
            thongbao = MessageBox.Show("Bạn có muốn thoát không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (thongbao == DialogResult.Yes)
            {
                this.Close();
            }
        }
        public void Dulieu_DMKhoa()
        {
            DataTable dta = new DataTable();
            dta = kn.Lay_Dulieu("select MAKHOA,TENKHOA,DIACHI from DMKHOA");
            dtaGrid.DataSource = dta;
            Hienthi_Dulieu();
        }
        private void Hienthi_Dulieu()
        {
            txtMaKhoa.DataBindings.Clear();
            txtMaKhoa.DataBindings.Add("Text", dtaGrid.DataSource, "MAKHOA");

            txtTenKhoa.DataBindings.Clear();
            txtTenKhoa.DataBindings.Add("Text", dtaGrid.DataSource, "TENKHOA");

            txtDiachi.DataBindings.Clear();
            txtDiachi.DataBindings.Add("Text", dtaGrid.DataSource, "DIACHI");
        }

        private void FrmDMKhoa_Load(object sender, EventArgs e)
        {
            Dulieu_DMKhoa();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnTao_Click(object sender, EventArgs e)
        {
            txtMaKhoa.Text = "";
            txtTenKhoa.Text = "";
            txtDiachi.Text = "";
            txtMaKhoa.Focus();
        }

        private void btnChen_Click(object sender, EventArgs e)
        {
            string sql_chen = "Insert into DMKHOA values('"+txtMaKhoa.Text+"' ,'"+txtTenKhoa.Text+"','" + txtDiachi.Text+"')";
                kn.Execute(sql_chen);
            Dulieu_DMKhoa();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            kn.Execute("Delete DMKHOA where MAKHOA = '" + txtMaKhoa.Text + "'");
            Dulieu_DMKhoa();
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql_sua = "update DMKHOA set TENKHOA ='" + txtTenKhoa.Text+"' ";
            sql_sua = sql_sua + ", DIACHI ='" + txtDiachi.Text + "' where MAKHOA = '" + txtMaKhoa.Text + "' ";
            kn.Execute(sql_sua);
            Dulieu_DMKhoa();
        }

        private void dtaGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
