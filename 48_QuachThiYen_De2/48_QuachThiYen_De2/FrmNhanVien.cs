using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _48_QuachThiYen_De2
{
    public partial class FrmNhanVien : Form
    {
        Ketnoi kn = new Ketnoi(); // khoi tao class
        public static string hoten, ngaysinh, diachi,dienthoai, maphong;

        public FrmNhanVien()
        {
            InitializeComponent();
        }
        public void Dulieu_DMNV()
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

            txtDienThoai.DataBindings.Clear();
            txtDienThoai.DataBindings.Add("Text", dtaGrid.DataSource, "DIENTHOAI");

            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("Text", dtaGrid.DataSource, "DIACHI");

            dtpNgaySinh.DataBindings.Clear();
            dtpNgaySinh.DataBindings.Add("Text", dtaGrid.DataSource, "NGAYSINH");

            cboMaPhong.DataBindings.Clear();
            cboMaPhong.DataBindings.Add("Text", dtaGrid.DataSource, "MAPHONG");

        }

        public void Load_Dulieu_MAPHONG()
        {
            DataTable dta = new DataTable();
            dta = kn.Lay_Dulieu("select * from PHONGGD");
            cboMaPhong.DataSource = dta;
            cboMaPhong.DisplayMember = "MAPHONG";
            cboMaPhong.ValueMember = "MAPHONG";
        }

        private void FrmNhanVien_Load(object sender, EventArgs e)
        {
            Dulieu_DMNV();
            Load_Dulieu_MAPHONG();
            Hienthi_Dulieu();
            
        }

        private void btnTao_Click(object sender, EventArgs e)
        {
            txtMaNV.Text = "";
            txtHoTen.Text = "";
            txtDienThoai.Text = "";
            txtDiaChi.Text = "";
            dtpNgaySinh.Text = "";

            txtMaNV.Focus();
        }

        private void btnChen_Click(object sender, EventArgs e)
        {
            if (txtMaNV.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập Mã nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaNV.Focus();
                return;
            }
            if (txtHoTen.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập Họ tên nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtHoTen.Focus();
                return;
            }
            if (txtDiaChi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập Địa chỉ nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDiaChi.Focus();
                return;
            }
            DataTable dt = new DataTable();
            dt = kn.Lay_Dulieu("Select * from NHANVIEN where MANV = " + txtMaNV.Text + "");
            if (dt != null && dt.Rows.Count > 0)
            {
                MessageBox.Show("Mã Nhân viên này đã tồn tại, hãy nhập Mã nhân viên mới !");
                txtMaNV.Focus();
            }
            else
            {
                    DialogResult TBchen;
                    TBchen = MessageBox.Show("Bạn có chắc chắn muốn thêm nhân viên này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (TBchen == DialogResult.Yes)
                    {
                    string sql_chen = "Insert into NHANVIEN values('" + txtMaNV.Text + "' ,'" + txtHoTen.Text + "','" + dtpNgaySinh.Text + "','" + txtDiaChi.Text + "','" + txtDienThoai.Text + "','"+cboMaPhong.Text+ "')";
                    kn.Execute(sql_chen);
                    Dulieu_DMNV();
                }           
            }           
        }
        
        private void btnSua_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = kn.Lay_Dulieu("Select * from NHANVIEN where MANV = " + txtMaNV.Text + "");
            if (dt != null)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    hoten = dr["HOTEN"].ToString();
                    dienthoai = dr["DIENTHOAI"].ToString();
                    diachi = dr["DIACHI"].ToString();
                    ngaysinh = dr["NGAYSINH"].ToString();
                    maphong = dr["MAPHONG"].ToString();

                    DateTime a = Convert.ToDateTime(ngaysinh);
                    string b = a.ToString("MM/dd/yyyy");

                    if (txtHoTen.Text != hoten || txtDiaChi.Text != diachi || cboMaPhong.Text != maphong  || txtDienThoai.Text != dienthoai || dtpNgaySinh.Text != b)
                    {
                        DialogResult TBsua;
                        TBsua = MessageBox.Show("Bạn có chắc chắn muốn sửa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        if (TBsua == DialogResult.Yes)
                        {
                            string sql_sua = "update NHANVIEN set HOTEN ='" + txtHoTen.Text + "' ";
                            sql_sua = sql_sua + ", NGAYSINH = '" + dtpNgaySinh.Text + "'" + ", DIACHI ='" + txtDiaChi.Text + "',DIENTHOAI ='" + txtDienThoai.Text + "',MAPHONG ='"+cboMaPhong.Text+ "' where MANV = '" + txtMaNV.Text + "' ";
                            kn.Execute(sql_sua);
                            Dulieu_DMNV();
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
                kn.Execute("Delete NHANVIEN where MANV = '" + txtMaNV.Text + "'");
                Dulieu_DMNV();
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
