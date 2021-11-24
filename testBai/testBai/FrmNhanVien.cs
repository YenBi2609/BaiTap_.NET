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
    public partial class FrmNhanVien : Form
    {
        Ketnoi kn = new Ketnoi();
        public FrmNhanVien()
        {
            InitializeComponent();
        }
        public void Dulieu_NHANVIEN()
        {
            DataTable dta = new DataTable();
            dta = kn.Lay_Dulieu("select * from NHANVIEN");
            dtaGrid.DataSource = dta;
            Hienthi_Dulieu();
        }
        private void Hienthi_Dulieu()
        {
            txtMaNV.DataBindings.Clear();
            txtMaNV.DataBindings.Add("Text", dtaGrid.DataSource, "MANV");

            txtHoTen.DataBindings.Clear();
            txtHoTen.DataBindings.Add("Text", dtaGrid.DataSource, "HOTEN");

            dtpNgaySinh.DataBindings.Clear();
            dtpNgaySinh.DataBindings.Add("Text", dtaGrid.DataSource, "NGAYSINH");

            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("Text", dtaGrid.DataSource, "DIACHI");

            txtDienThoai.DataBindings.Clear();
            txtDienThoai.DataBindings.Add("Text", dtaGrid.DataSource, "DIENTHOAI");

        }

        public void Load_Dulieu_MAPHONG()
        {
            DataTable dta = new DataTable();
            dta = kn.Lay_Dulieu("select * from PHONGGD");
            cboMaPhong.DataSource = dta;
            cboMaPhong.DisplayMember = "MAPHONG";
            cboMaPhong.ValueMember = "MAPHONG";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMaNV.Text = "";
            txtHoTen.Text = "";
            txtDiaChi.Text = "";
            txtDienThoai.Text = "";


            txtMaNV.Focus();
        }

        private void btnChen_Click(object sender, EventArgs e)
        {
            string sql_chen = "Insert into NHANVIEN values('" + txtMaNV.Text + "' ,'" + txtHoTen.Text + "','" + dtpNgaySinh.Text + "','" + txtDiaChi.Text + "','" + txtDienThoai.Text + "','" + cboMaPhong.Text + "')";
            kn.Execute(sql_chen);
            Dulieu_NHANVIEN();
        }
        //        CREATE TABLE[NHANVIEN](
        //[MANV][VARCHAR](10) NOT NULL,
        //[HOTEN] [NVARCHAR] (50) NOT NULL,
        //[NGAYSINH] [DATETIME] NULL,
        //[DIACHI] [NVARCHAR] (100) NOT NULL,
        // [DIENTHOAI] [VARCHAR] (20) NULL,
        //[MAPHONG] [VARCHAR] (10) NOT NULL,
        // PRIMARY KEY CLUSTERED([MANV] ASC))
        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql_sua = "update NHANVIEN set HOTEN ='" + txtHoTen.Text + "' ";
            sql_sua = sql_sua + ", NGAYSINH ='" + dtpNgaySinh.Value + "'" + ", DIACHI = '" + txtDiaChi.Text + "'" + ", DIENTHOAI ='" + txtDienThoai.Text + "',MAPHONG ='" + cboMaPhong.Text + "' where MANV = '" + txtMaNV.Text + "' ";
            kn.Execute(sql_sua);
            Dulieu_NHANVIEN();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            kn.Execute("Delete NHANVIEN where MANV = '" + txtMaNV.Text + "'");
            Dulieu_NHANVIEN();
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

        private void FrmNhanVien_Load(object sender, EventArgs e)
        {

            Dulieu_NHANVIEN();
            Load_Dulieu_MAPHONG();
        }
    }
}
