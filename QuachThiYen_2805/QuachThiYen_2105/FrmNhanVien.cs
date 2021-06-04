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
    
    public partial class FrmNhanVien : Form
    {
        Ketnoi kn = new Ketnoi();
        public FrmNhanVien()
        {
            InitializeComponent();
        }
        private void Hienthi_Dulieu1()
        {
            txtMaNV.DataBindings.Clear();
            txtMaNV.DataBindings.Add("Text", dataGrid.DataSource, "MANV");

            txtHoTen.DataBindings.Clear();
            txtHoTen.DataBindings.Add("Text", dataGrid.DataSource, "TENNV");

            txtHeSoLuong.DataBindings.Clear();
            txtHeSoLuong.DataBindings.Add("Text", dataGrid.DataSource, "HESO_LUONG");

            cboChucVu.DataBindings.Clear();
            cboChucVu.DataBindings.Add("Text", dataGrid.DataSource, "MACV");

            cboPhongBan.DataBindings.Clear();
            cboPhongBan.DataBindings.Add("Text", dataGrid.DataSource, "MAPB");
        }
        public void Load_Dulieu_Nhanvien()
        {
            DataTable dta = new DataTable();
            dta = kn.Lay_Dulieu("select * from NHANVIEN");
            dataGrid.DataSource = dta;
            Hienthi_Dulieu1();
        }
        public void Load_Dulieu_Chucvu()
        {
            DataTable dta = new DataTable();
            dta = kn.Lay_Dulieu("select * from CHUCVU");
            cboChucVu.DataSource = dta;
<<<<<<< HEAD
            cboChucVu.DisplayMember = "TENCV";
            cboChucVu.ValueMember = "TENCV";
=======
            cboChucVu.DisplayMember = "MACV";
            cboChucVu.ValueMember = "MACV";
>>>>>>> ce14b3ba1ffbd613f13ee2ee691906aba06e9957
        }
        public void Load_Dulieu_PhongBan()
        {
            DataTable dta = new DataTable();
            dta = kn.Lay_Dulieu("select * from PHONGBAN");
            cboPhongBan.DataSource = dta;
            cboPhongBan.DisplayMember = "MAPB";
            cboPhongBan.ValueMember = "MAPB";
        }
        private void FrmNhanVien_Load(object sender, EventArgs e)
        {
            Load_Dulieu_Chucvu();
            Load_Dulieu_Nhanvien();
            Load_Dulieu_PhongBan();
            Hienthi_Dulieu1();
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

        private void btnTao_Click(object sender, EventArgs e)
        {
            txtMaNV.Text = "";
            txtHoTen.Text = "";
            txtHeSoLuong.Text = "";
            txtMaNV.Focus();
        }
        private void btnChen_Click(object sender, EventArgs e)
        {
            string sql_chen = "Insert into NHANVIEN values('" + txtMaNV.Text + "' ,'" + txtHoTen.Text + "','" + txtHeSoLuong.Text + "' ,'" + cboChucVu.Text + "','"  + cboPhongBan.Text +  "')";
            kn.Execute(sql_chen);
            Load_Dulieu_Nhanvien();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql_sua = "update NHANVIEN set TENNV ='" + txtHoTen.Text + "' ";
            sql_sua = sql_sua + ", HESO_LUONG ='" + txtHeSoLuong.Text + "'";
            sql_sua = sql_sua + ", MACV ='" + cboChucVu.Text +"'"+ ", MAPB ='" + cboPhongBan.Text + "' where MANV = '" + txtMaNV.Text + "' ";
            kn.Execute(sql_sua);
            Load_Dulieu_Nhanvien();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            kn.Execute("Delete NHANVIEN where MANV = '" + txtMaNV.Text + "'");
            Load_Dulieu_Nhanvien();
        }

    }
}
