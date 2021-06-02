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
    public partial class FrmPhongBan : Form
    {
        Ketnoi kn = new Ketnoi(); // khoi tao class
        public FrmPhongBan()
        {
            InitializeComponent();
        }
        public void Dulieu_PhongBan()
        {
            DataTable dta = new DataTable();
            dta = kn.Lay_Dulieu("select MAPB,TENPB,DIACHI,CHUCNANG,SODT from PHONGBAN");
            dtaGrid.DataSource = dta;
            Hienthi_Dulieu();
        }
        private void Hienthi_Dulieu()
        {
            txtMaPhongBan.DataBindings.Clear();
            txtMaPhongBan.DataBindings.Add("Text", dtaGrid.DataSource, "MAPB");

            txtTenPhongBan.DataBindings.Clear();
            txtTenPhongBan.DataBindings.Add("Text", dtaGrid.DataSource, "TENPB");

            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("Text", dtaGrid.DataSource, "DIACHI");

            txtChucNang.DataBindings.Clear();
            txtChucNang.DataBindings.Add("Text", dtaGrid.DataSource, "CHUCNANG");

            txtSoDt.DataBindings.Clear();
            txtSoDt.DataBindings.Add("Text", dtaGrid.DataSource, "SODT");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmPhongBan_Load(object sender, EventArgs e)
        {
            Dulieu_PhongBan();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTao_Click(object sender, EventArgs e)
        {
            txtMaPhongBan.Text = "";
            txtTenPhongBan.Text = "";

            txtDiaChi.Text = "";
            txtChucNang.Text = "";
            txtSoDt.Text = "";
            txtMaPhongBan.Focus();
        }

        private void btnChen_Click(object sender, EventArgs e)
        {
            string sql_chen = "Insert into PHONGBAN values('" + txtMaPhongBan.Text + "' ,'" + txtTenPhongBan.Text + "','" + txtDiaChi.Text + "','" + txtChucNang.Text + "','" + txtSoDt.Text +  "')";
            kn.Execute(sql_chen);
            Dulieu_PhongBan();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql_sua = "update PHONGBAN set TENPB ='" + txtTenPhongBan.Text + "' ";
            sql_sua = sql_sua + ", DIACHI ='" + txtDiaChi.Text + "'" + ", CHUCNANG = '" + txtChucNang.Text + "'"+", SODT ='" + txtSoDt.Text + "' where MAPB = '" + txtMaPhongBan.Text + "' ";
            kn.Execute(sql_sua);
            Dulieu_PhongBan();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            kn.Execute("Delete PHONGBAN where MAPB = '" + txtMaPhongBan.Text + "'");
            Dulieu_PhongBan();
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
