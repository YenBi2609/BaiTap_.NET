using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LTUD1_QLSV_QuachThiYen
{
    public partial class FrmDMSV_De2 : Form
    {
        Ketnoi kn = new Ketnoi(); // khoi tao class
        public static string hoten, gioitinh,ngaysinh, noisinh, makhoa, malop;

        public FrmDMSV_De2()
        {
            InitializeComponent();
        }
        public void Dulieu_DMSV()
        {
            DataTable dta = new DataTable();
            dta = kn.Lay_Dulieu("select * from DMSV");
            dtaGrid.DataSource = dta;
            Hienthi_Dulieu();
        }
        private void Hienthi_Dulieu()
        {
            txtMaSV.DataBindings.Clear();
            txtMaSV.DataBindings.Add("Text", dtaGrid.DataSource, "MASV");

            txtHoTen.DataBindings.Clear();
            txtHoTen.DataBindings.Add("Text", dtaGrid.DataSource, "HOTEN");

            txtGioiTinh.DataBindings.Clear();
            txtGioiTinh.DataBindings.Add("Text", dtaGrid.DataSource, "GIOITINH");

            txtNoiSinh.DataBindings.Clear();
            txtNoiSinh.DataBindings.Add("Text", dtaGrid.DataSource, "NOISINH");

            dtpNgaySinh.DataBindings.Clear();
            dtpNgaySinh.DataBindings.Add("Text", dtaGrid.DataSource, "NGAYSINH");

            cboMaLop.DataBindings.Clear();
            cboMaLop.DataBindings.Add("Text", dtaGrid.DataSource, "MALOP");

            cboMaKhoa.DataBindings.Clear();
            cboMaKhoa.DataBindings.Add("Text", dtaGrid.DataSource, "MAKHOA");

        }

        public void Load_Dulieu_MAKHOA()
        {
            DataTable dta = new DataTable();
            dta = kn.Lay_Dulieu("select * from DMKHOA");
            cboMaKhoa.DataSource = dta;
            cboMaKhoa.DisplayMember = "MaKhoa";
            cboMaKhoa.ValueMember = "MaKhoa";
        }
        public void Load_Dulieu_MALOP()
        {
            DataTable dta = new DataTable();
            dta = kn.Lay_Dulieu("select * from DMLOP");
            cboMaLop.DataSource = dta;
            cboMaLop.DisplayMember = "MaLop";
            cboMaLop.ValueMember = "MaLop";
        }

        private void FrmDMSV_Load(object sender, EventArgs e)
        {
            Dulieu_DMSV();
            Load_Dulieu_MAKHOA();
            Load_Dulieu_MALOP();
            Hienthi_Dulieu();
            
        }

        private void btnTao_Click(object sender, EventArgs e)
        {
            txtMaSV.Text = "";
            txtHoTen.Text = "";
            txtGioiTinh.Text = "";
            txtNoiSinh.Text = "";
            dtpNgaySinh.Text = "";

            txtMaSV.Focus();
        }

        private void btnChen_Click(object sender, EventArgs e)
        {
            if (txtMaSV.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập Mã sinh viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaSV.Focus();
                return;
            }
            if (txtHoTen.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập Họ tên sinh viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtHoTen.Focus();
                return;
            }
            if (txtGioiTinh.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập Giới tính sinh viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtGioiTinh.Focus();
                return;
            }
            DataTable dt = new DataTable();
            dt = kn.Lay_Dulieu("Select * from DMSV where MASV = " + txtMaSV.Text + "");
            if (dt != null && dt.Rows.Count > 0)
            {
                MessageBox.Show("Mã Sinh viên này đã tồn tại, hãy nhập Mã sinh viên mới !");
                txtMaSV.Focus();
            }
            else
            {
                    DialogResult TBchen;
                    TBchen = MessageBox.Show("Bạn có chắc chắn muốn thêm Danh mục sinh viên này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (TBchen == DialogResult.Yes)
                    {
                    string sql_chen = "Insert into DMSV values('" + txtMaSV.Text + "' ,'" + txtHoTen.Text + "','" + txtGioiTinh.Text + "','" + dtpNgaySinh.Text + "','" + txtNoiSinh.Text + "','" + cboMaKhoa.Text + "','"+cboMaLop.Text+ "')";
                    kn.Execute(sql_chen);
                    Dulieu_DMSV();
                }           
            }           
        }
        
        private void btnSua_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = kn.Lay_Dulieu("Select * from DMSV where MASV = " + txtMaSV.Text + "");
            if (dt != null)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    hoten = dr["HOTEN"].ToString();
                    gioitinh = dr["GIOITINH"].ToString();
                    noisinh = dr["NOISINH"].ToString();
                    ngaysinh = dr["NGAYSINH"].ToString();
                    makhoa = dr["MAKHOA"].ToString();
                    malop = dr["MALOP"].ToString();

                    DateTime a = Convert.ToDateTime(ngaysinh);
                    string b = a.ToString("MM/dd/yyyy");

                    if (txtHoTen.Text != hoten || txtNoiSinh.Text != noisinh || cboMaKhoa.Text != makhoa || cboMaLop.Text != malop || txtGioiTinh.Text != gioitinh || dtpNgaySinh.Text != b)
                    {
                        DialogResult TBsua;
                        TBsua = MessageBox.Show("Bạn có chắc chắn muốn sửa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        if (TBsua == DialogResult.Yes)
                        {
                            string sql_sua = "update DMSV set HOTEN ='" + txtHoTen.Text + "' ";
                            sql_sua = sql_sua + ", GIOITINH ='" + txtGioiTinh.Text + "'" + ", NGAYSINH = '" + dtpNgaySinh.Text + "'" + ", NOISINH ='" + txtNoiSinh.Text + "',MAKHOA ='" + cboMaKhoa.Text + "',MALOP ='"+cboMaLop.Text+ "' where MASV = '" + txtMaSV.Text + "' ";
                            kn.Execute(sql_sua);
                            Dulieu_DMSV();
                        }
                    }
                    else MessageBox.Show("Bạn chưa chỉnh sửa thông tin cần cập nhật !");
                }
            }          

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult TBxoa;
            TBxoa = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (TBxoa == DialogResult.Yes)
            {
                kn.Execute("Delete DMSV where MASV = '" + txtMaSV.Text + "'");
                Dulieu_DMSV();
            }
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
    }
}
