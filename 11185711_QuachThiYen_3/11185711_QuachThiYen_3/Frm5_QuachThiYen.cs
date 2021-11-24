using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _11185711_QuachThiYen_3
{
    public partial class Frm5_QuachThiYen : Form
    {
        Ketnoi kn = new Ketnoi(); // khoi tao class
        public static string tenloai, dviqly, chucnang, ghichu;

        public Frm5_QuachThiYen()
        {
            InitializeComponent();
        }
        public void Dulieu_LOAITAISAN()
        {
            DataTable dta = new DataTable();
            dta = kn.Lay_Dulieu("select * from LOAITAISAN");
            dtaGrid.DataSource = dta;
            Hienthi_Dulieu();
        }
        private void Hienthi_Dulieu()
        {
            txtMaLoaiTS.DataBindings.Clear();
            txtMaLoaiTS.DataBindings.Add("Text", dtaGrid.DataSource, "MALOAITS");

            txtTenLoai.DataBindings.Clear();
            txtTenLoai.DataBindings.Add("Text", dtaGrid.DataSource, "TENLOAI");


            txtGhiChu.DataBindings.Clear();
            txtGhiChu.DataBindings.Add("Text", dtaGrid.DataSource, "DVIQLY");

            txtChucNang.DataBindings.Clear();
            txtChucNang.DataBindings.Add("Text", dtaGrid.DataSource, "CHUCNANG");

            txtDVQL.DataBindings.Clear();
            txtDVQL.DataBindings.Add("Text", dtaGrid.DataSource, "GHICHU");

        }

        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmLOAITS_Load(object sender, EventArgs e)
        {
            Dulieu_LOAITAISAN();

            Hienthi_Dulieu();
        }



        private void btnTao_Click(object sender, EventArgs e)
        {
            txtMaLoaiTS.Text = "";
            txtTenLoai.Text = "";
            txtDVQL.Text = "";
            txtChucNang.Text = "";
            txtGhiChu.Text = "";

            txtMaLoaiTS.Focus();
        }

        private void btnChen_Click(object sender, EventArgs e)
        {
            if (txtMaLoaiTS.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập Mã loại tài sản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaLoaiTS.Focus();
                return;
            }
            if (txtTenLoai.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập Tên loại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenLoai.Focus();
                return;
            }
            if (txtDVQL.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập Đơn vị quản lý", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenLoai.Focus();
                return;
            }
            DataTable dt = new DataTable();
            dt = kn.Lay_Dulieu("Select * from LOAITAISAN where MALOAITS = " + txtMaLoaiTS.Text + "");
            if (dt != null && dt.Rows.Count > 0)
            {
                MessageBox.Show("Mã loại tài sản này đã tồn tại, hãy nhập Mã loại tài sản mới !");
                txtMaLoaiTS.Focus();
            }
            else
            {
                    DialogResult TBchen;
                    TBchen = MessageBox.Show("Bạn có chắc chắn muốn thêm Loại tài sản này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (TBchen == DialogResult.Yes)
                    {
                    string sql_chen = "Insert into LOAITAISAN values('" + txtMaLoaiTS.Text + "' ,'" + txtTenLoai.Text + "','" + txtDVQL.Text + "','"  + txtChucNang.Text + "','" + txtGhiChu.Text + "')";
                    kn.Execute(sql_chen);
                    Dulieu_LOAITAISAN();
                }           
            }           
        }
        
        private void btnSua_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = kn.Lay_Dulieu("Select * from LOAITAISAN where MALOAITS = " + txtMaLoaiTS.Text + "");
            if (dt != null)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    tenloai = dr["TENLOAI"].ToString();
                    dviqly = dr["DVIQLY"].ToString();
                    chucnang = dr["CHUCNANG"].ToString();
                    ghichu = dr["GHICHU"].ToString();

                    if(txtTenLoai.Text != tenloai || txtGhiChu.Text != dviqly || txtChucNang.Text != chucnang || txtGhiChu.Text != ghichu )
                    {
                        DialogResult TBsua;
                        TBsua = MessageBox.Show("Bạn có chắc chắn muốn sửa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        if (TBsua == DialogResult.Yes)
                        {
                            string sql_sua = "update LOAITAISAN set TENLOAI ='" + txtTenLoai.Text + "' ";
                            sql_sua = sql_sua + ", DVIQLY ='" + txtDVQL.Text + "'" + ", CHUCNANG = '" + txtChucNang.Text + "'" + ", GHICHU ='" + txtGhiChu.Text  + "' where MALOAITS = '" + txtMaLoaiTS.Text + "' ";
                            kn.Execute(sql_sua);
                            Dulieu_LOAITAISAN();
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
                kn.Execute("Delete LOAITAISAN where MALOAITS = '" + txtMaLoaiTS.Text + "'");
                Dulieu_LOAITAISAN();
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

        private void dtaGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
