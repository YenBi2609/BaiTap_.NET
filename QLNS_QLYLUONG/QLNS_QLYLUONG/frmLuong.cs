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

namespace QLNS_QLYLUONG
{
    
    public partial class frmLuong : Form
    {
        Ketnoi kn = new Ketnoi();
        public frmLuong()
        {
            InitializeComponent();
        }
        private void Hienthi_Dulieu1()
        {
            txtMaLuong.DataBindings.Clear();
            txtMaLuong.DataBindings.Add("Text", dataGrid.DataSource, "ma_luong");

            cboMaNV.DataBindings.Clear();
            cboMaNV.DataBindings.Add("Text", dataGrid.DataSource, "ma_NV");

            txtLuongCoBan.DataBindings.Clear();
            txtLuongCoBan.DataBindings.Add("Text", dataGrid.DataSource, "luong_co_ban");

            txtCong.DataBindings.Clear();
            txtCong.DataBindings.Add("Text", dataGrid.DataSource, "khoan_cong_them");

            txtTru.DataBindings.Clear();
            txtTru.DataBindings.Add("Text", dataGrid.DataSource, "khoan_tru");

            txtThucLinh.DataBindings.Clear();
            txtThucLinh.DataBindings.Add("Text", dataGrid.DataSource, "thuc_linh");

            

        }
        public void Load_Dulieu_Luong()
        {
            DataTable dta = new DataTable();
            dta = kn.Lay_Dulieu("select * from LUONG");
            dataGrid.DataSource = dta;
            Hienthi_Dulieu1();
        }
        public void Load_Dulieu_NhanVien()
        {
            DataTable dta = new DataTable();
            dta = kn.Lay_Dulieu("select * from NHANVIEN");
            cboMaNV.DataSource = dta;

            cboMaNV.DisplayMember = "ma_NV";
            cboMaNV.ValueMember = "ma_NV";
            cboTKMaNV.DataSource = dta;

            cboTKMaNV.DisplayMember = "ma_NV";
            cboTKMaNV.ValueMember = "ma_NV";

        }
        public void Load_Dulieu_PhongBan()
        {
            DataTable dta = new DataTable();
            dta = kn.Lay_Dulieu("select * from PHONGBAN");
            cboTKMaPB.DataSource = dta;

            cboTKMaPB.DisplayMember = "ma_PB";
            cboTKMaPB.ValueMember = "ma_PB";


        }
        private void frmLuong_Load(object sender, EventArgs e)
        {
            Load_Dulieu_NhanVien();
            Load_Dulieu_Luong();
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
            txtMaLuong.Text = "";
            txtLuongCoBan.Text = "";
            txtCong.Text = "";
            txtTru.Text = "";
            txtThucLinh.Text = "";
            txtMaLuong.Focus();
        }
        private void btnChen_Click(object sender, EventArgs e)
        {
            DialogResult thongbao;
            thongbao = MessageBox.Show("Bạn có chắc chắn muốn chèn ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (thongbao == DialogResult.Yes)
            {
                string sql_chen = "Insert into LUONG values('" + txtMaLuong.Text + "' , '" + cboMaNV.Text + "'," + txtLuongCoBan.Value + "," + txtCong.Value + "," + txtTru.Value + "," + txtThucLinh.Value + ")";
                kn.Execute(sql_chen);
                Load_Dulieu_Luong();
            }
        }
        //        create table LUONG(
        //ma_luong char(10) primary key,
        //ma_NV char (10) references NHANVIEN(ma_NV),
        //luong_co_ban float check(luong_co_ban > 0),
        //khoan_cong_them float check(khoan_cong_them >= 0),
        //khoan_tru float check(khoan_tru >= 0),
        //thuc_linh float);

        private void btnSua_Click(object sender, EventArgs e)
        {
            DialogResult thongbao;
            thongbao = MessageBox.Show("Bạn chắc chắn muốn sửa ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (thongbao == DialogResult.OK)
            {

                string sql_sua = "update LUONG set ma_NV  ='" + cboMaNV.Text + "' ";
                sql_sua = sql_sua + ", luong_co_ban =" + txtLuongCoBan.Value;
                sql_sua = sql_sua + ", khoan_cong_them =" + txtCong.Value + ", khoan_tru =" + txtTru.Value + ", thuc_linh =" + txtThucLinh.Value + " where ma_luong = '" + txtMaLuong.Text + "' ";
                kn.Execute(sql_sua);
                Load_Dulieu_Luong();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult thongbao;
            thongbao = MessageBox.Show("Bạn chắc chắn muốn xóa ?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Hand);
            if (thongbao == DialogResult.Yes)
            {
                kn.Execute("Delete LUONG where ma_luong = '" + txtMaLuong.Text + "'");
                Load_Dulieu_Luong();
            }
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            DataTable dta = new DataTable();
            string sqltk;
            if (checkMaNV.Checked == true)
            {
                sqltk = "select * from LUONG where ma_NV like '" + cboTKMaNV.Text + "'";
                dta = kn.Lay_Dulieu(sqltk);
            }
            if (checkMaPB.Checked == true)
            {
                sqltk = "select * from V_tonghop where ma_PB like '" + cboTKMaPB.Text + "'";
                dta = kn.Lay_Dulieu(sqltk);
            }
            if (checkMaPB.Checked == true && checkMaNV.Checked == true)
            {
                sqltk = "select * from V_tonghop where ma_PB like '" + cboTKMaPB.Text + "' and ma_NV like '"+cboMaNV.Text+ "'";
                dta = kn.Lay_Dulieu(sqltk);
            }

            dataGrid.DataSource = dta;
        }

    }
}
