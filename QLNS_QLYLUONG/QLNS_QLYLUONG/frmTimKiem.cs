using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNS_QLYLUONG
{
    public partial class frmTimKiem : Form
    {
        Ketnoi kn = new Ketnoi();
        public frmTimKiem()
        {
            InitializeComponent();
        }
        public void Load_Dulieu_PhongBan()
        {
            DataTable dta = new DataTable();
            dta = kn.Lay_Dulieu("select * from PHONGBAN");
            cboTim1.DataSource = dta;

            cboTim1.DisplayMember = "ma_PB";
            cboTim1.ValueMember = "ma_PB";


        }
        public void Load_Dulieu_NhanVien()
        {
            DataTable dta = new DataTable();
            dta = kn.Lay_Dulieu("select * from NHANVIEN");
            txtTim2.DataSource = dta;

            txtTim2.DisplayMember = "ma_NV";
            txtTim2.ValueMember = "ma_NV";
            txtTim2.DataSource = dta;

            txtTim2.DisplayMember = "ma_NV";
            txtTim2.ValueMember = "ma_NV";

        }

        private void btnTK_Click(object sender, EventArgs e)
        {
            DataTable dta = new DataTable();
            string sqltk;
            if (checkMaNV.Checked == true)
            {
                sqltk = "select * from LUONG where ma_NV like '" + txtTim2.Text + "'";
                dta = kn.Lay_Dulieu(sqltk);
            }
            if (checkMaPB.Checked == true)
            {
                sqltk = "select * from V_tonghop where ma_PB like '" + cboTim1.Text + "'";
                dta = kn.Lay_Dulieu(sqltk);
            }
            if (checkPC.Checked == true)
            {
                sqltk = "select * from V_tonghop where phu_cap like '" + txtTim3.Text + "'";
                dta = kn.Lay_Dulieu(sqltk);
            }
            if (checkHSL.Checked == true)
            {
                sqltk = "select * from V_tonghop where he_so_luong like '" + txtTim4.Text + "'";
                dta = kn.Lay_Dulieu(sqltk);
            }
            if (checkMaPB.Checked == true && checkMaNV.Checked == true)
            {
                sqltk = "select * from V_tonghop where ma_PB like '" + cboTim1.Text + "' and ma_NV like '" + txtTim2.Text + "'";
                dta = kn.Lay_Dulieu(sqltk);
            }
            if (checkMaPB.Checked == true && checkPC.Checked == true)
            {
                sqltk = "select * from V_tonghop where ma_PB like '" + cboTim1.Text + "' and phu_cap like '" + txtTim3.Text + "'";
                dta = kn.Lay_Dulieu(sqltk);
            }
            if (checkMaPB.Checked == true && checkHSL.Checked == true)
            {
                sqltk = "select * from V_tonghop where ma_PB like '" + cboTim1.Text + "' and he_so_luong like '" + txtTim4.Text + "'";
                dta = kn.Lay_Dulieu(sqltk);
            }
            if (checkMaNV.Checked == true && checkPC.Checked == true)
            {
                sqltk = "select * from V_tonghop where ma_NV like '" + txtTim2.Text + "' and phu_cap like '" + txtTim3.Text + "'";
                dta = kn.Lay_Dulieu(sqltk);
            }
            if (checkMaNV.Checked == true && checkHSL.Checked == true)
            {
                sqltk = "select * from V_tonghop where ma_NV like '" + txtTim2.Text + "' and he_so_luong like '" + txtTim4.Text + "'";
                dta = kn.Lay_Dulieu(sqltk);
            }
            if (checkHSL.Checked == true && checkPC.Checked == true)
            {
                sqltk = "select * from V_tonghop where he_so_luong like '" + txtTim4.Text + "' and phu_cap like '" + txtTim3.Text + "'";
                dta = kn.Lay_Dulieu(sqltk);
            }
            if (checkMaPB.Checked == true && checkMaNV.Checked == true && checkPC.Checked == true)
            {
                sqltk = "select * from V_tonghop where ma_PB like '" + cboTim1.Text + "' and ma_NV like '" + txtTim2.Text + "' and phu_cap like '"+txtTim3.Text+"'";
                dta = kn.Lay_Dulieu(sqltk);
            }
            if (checkMaPB.Checked == true && checkMaNV.Checked == true && checkHSL.Checked == true)
            {
                sqltk = "select * from V_tonghop where ma_PB like '" + cboTim1.Text + "' and ma_NV like '" + txtTim2.Text + "' and he_so_luong like '" + txtTim4.Text + "'";
                dta = kn.Lay_Dulieu(sqltk);
            }
            if (checkMaPB.Checked == true && checkHSL.Checked == true && checkPC.Checked == true)
            {
                sqltk = "select * from V_tonghop where ma_PB like '" + cboTim1.Text + "' and he_so_luong like '" + txtTim4.Text + "' and phu_cap like '" + txtTim3.Text + "'";
                dta = kn.Lay_Dulieu(sqltk);
            }
            if (checkMaNV.Checked == true && checkHSL.Checked == true && checkPC.Checked == true)
            {
                sqltk = "select * from V_tonghop where ma_NV like '" + txtTim2.Text + "' and he_so_luong like '" + txtTim4.Text + "' and phu_cap like '" + txtTim3.Text + "'";
                dta = kn.Lay_Dulieu(sqltk);
            }
            if (checkMaPB.Checked == true && checkMaNV.Checked == true && checkPC.Checked == true && checkHSL.Checked == true)
            {
                sqltk = "select * from V_tonghop where ma_PB like '" + cboTim1.Text + "' and ma_NV like '" + txtTim2.Text + "' and phu_cap like '" + txtTim3.Text + "' and he_so_luong like '"+ txtTim4.Text+"'";
                dta = kn.Lay_Dulieu(sqltk);
            }


            dtaGrid.DataSource = dta;
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

        private void frmTimKiem_Load(object sender, EventArgs e)
        {
            Load_Dulieu_NhanVien();
            Load_Dulieu_PhongBan();
        }
    }
}
