using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HovatenSV
{
    public partial class FrmDMTAISAN : Form
    {
        Ketnoi kn = new Ketnoi(); // khoi tao class
        public FrmDMTAISAN()
        {
            InitializeComponent();
        }
        public void Dulieu_DMTAISAN()
        {
            DataTable dta = new DataTable();
            dta = kn.Lay_Dulieu("select * from DMTAISAN");
            dtaGrid.DataSource = dta;
            Hienthi_Dulieu();
        }
        private void Hienthi_Dulieu()
        {
            txtMaTaiSan.DataBindings.Clear();
            txtMaTaiSan.DataBindings.Add("Text", dtaGrid.DataSource, "MATS");

            txtTenTaiSan.DataBindings.Clear();
            txtTenTaiSan.DataBindings.Add("Text", dtaGrid.DataSource, "TENTS");

            txtNamSX.DataBindings.Clear();
            txtNamSX.DataBindings.Add("Text", dtaGrid.DataSource, "NAMSD");

            txtNuocSX.DataBindings.Clear();
            txtNuocSX.DataBindings.Add("Text", dtaGrid.DataSource, "NUOCSX");

            txtNamSX.DataBindings.Clear();
            txtNamSX.DataBindings.Add("Text", dtaGrid.DataSource, "MALOAITS");

            txtNuocSX.DataBindings.Clear();
            txtNuocSX.DataBindings.Add("Text", dtaGrid.DataSource, "MADONVI");

        }

        public void Load_Dulieu_LOAITAISAN()
        {
            DataTable dta = new DataTable();
            dta = kn.Lay_Dulieu("select * from LOAITAISAN");
            cboMaLoaiTS.DataSource = dta;
            cboMaLoaiTS.DisplayMember = "MALOAITS";
            cboMaLoaiTS.ValueMember = "MALOAITS";
        }
        public void Load_Dulieu_DONVI()
        {
            DataTable dta = new DataTable();
            dta = kn.Lay_Dulieu("select * from DONVI");
            cboMaDV.DataSource = dta;
            cboMaDV.DisplayMember = "MADONVI";
            cboMaDV.ValueMember = "MADONVI";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmDMTAISAN_Load(object sender, EventArgs e)
        {
            Dulieu_DMTAISAN();
            Load_Dulieu_LOAITAISAN();
            Load_Dulieu_DONVI();
            Hienthi_Dulieu();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTao_Click(object sender, EventArgs e)
        {
            txtMaTaiSan.Text = "";
            txtTenTaiSan.Text = "";
            txtNamSX.Text = "";
            txtNuocSX.Text = "";

            txtMaTaiSan.Focus();
        }

        private void btnChen_Click(object sender, EventArgs e)
        {
            string sql_chen = "Insert into DMTAISAN values('" + txtMaTaiSan.Text + "' ,'" + txtTenTaiSan.Text + "','" + cboMaLoaiTS.Text + "','" + txtNamSX.Text + "','" +txtNuocSX.Text+"','"+ cboMaDV.Text +  "')";
            kn.Execute(sql_chen);
            Dulieu_DMTAISAN();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql_sua = "update DMTAISAN set TENTS ='" + txtTenTaiSan.Text + "' ";
            sql_sua = sql_sua + ", MALOAITS ='" + cboMaLoaiTS.Text + "'" + ", NAMSD = '" + txtNamSX.Text + "'" + ", NUOCSX ='" + txtNuocSX.Text + "',MADONVI ='" + cboMaDV.Text + "' where MATS = '" + txtMaTaiSan.Text + "' ";
            kn.Execute(sql_sua);
            Dulieu_DMTAISAN();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            kn.Execute("Delete DMTAISAN where MATS = '" + txtMaTaiSan.Text + "'");
            Dulieu_DMTAISAN();
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

        private void dtaGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
