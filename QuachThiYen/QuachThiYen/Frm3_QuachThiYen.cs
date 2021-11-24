using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuachThiYen
{
    public partial class Frm3_QuachThiYen : Form
    {
        Ketnoi kn = new Ketnoi(); // khoi tao class
        public static string tents, maloaits,nuocsx,madonvi;
        public static int namsx;

        public Frm3_QuachThiYen()
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

            nmrNamSX.DataBindings.Clear();
            nmrNamSX.DataBindings.Add("Text", dtaGrid.DataSource, "NAMSD");

            txtNuocSX.DataBindings.Clear();
            txtNuocSX.DataBindings.Add("Text", dtaGrid.DataSource, "NUOCSX");

            cboMaLoaiTS.DataBindings.Clear();
            cboMaLoaiTS.DataBindings.Add("Text", dtaGrid.DataSource, "MALOAITS");

            cboMaDV.DataBindings.Clear();
            cboMaDV.DataBindings.Add("Text", dtaGrid.DataSource, "MADONVI");

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

        private void FrmDMTAISAN_Load(object sender, EventArgs e)
        {
            Dulieu_DMTAISAN();
            Load_Dulieu_LOAITAISAN();
            Load_Dulieu_DONVI();
            Hienthi_Dulieu();
        }

        private void btnTao_Click(object sender, EventArgs e)
        {
            txtMaTaiSan.Text = "";
            txtTenTaiSan.Text = "";
            nmrNamSX.Value = 0;
            txtNuocSX.Text = "";

            txtMaTaiSan.Focus();
        }

        private void btnChen_Click(object sender, EventArgs e)
        {
            if (txtMaTaiSan.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập Mã tài sản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaTaiSan.Focus();
                return;
            }
            if (txtTenTaiSan.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập Tên tài sản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenTaiSan.Focus();
                return;
            }
            DataTable dt = new DataTable();
            dt = kn.Lay_Dulieu("Select * from DMTAISAN where MATS = " + txtMaTaiSan.Text + "");
            if (dt != null && dt.Rows.Count > 0)
            {
                MessageBox.Show("Mã tài sản này đã tồn tại, hãy nhập Mã tài sản mới !");
                txtMaTaiSan.Focus();
            }
            else
            {
                    DialogResult TBchen;
                    TBchen = MessageBox.Show("Bạn có chắc chắn muốn thêm Danh mục tài sản này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (TBchen == DialogResult.Yes)
                    {
                    string sql_chen = "Insert into DMTAISAN values('" + txtMaTaiSan.Text + "' ,'" + txtTenTaiSan.Text + "','" + cboMaLoaiTS.Text + "','" + nmrNamSX.Value + "','" + txtNuocSX.Text + "','" + cboMaDV.Text + "')";
                    kn.Execute(sql_chen);
                    Dulieu_DMTAISAN();
                }           
            }           
        }
        
        private void btnSua_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = kn.Lay_Dulieu("Select * from DMTAISAN where MATS = " + txtMaTaiSan.Text + "");
            if (dt != null)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    tents = dr["TENTS"].ToString();
                    maloaits = dr["MALOAITS"].ToString();
                    nuocsx = dr["NUOCSX"].ToString();
                    madonvi = dr["MADONVI"].ToString();
                    namsx = (int)dr["NAMSD"];

                    if(txtTenTaiSan.Text != tents || txtNuocSX.Text != nuocsx || cboMaDV.Text != madonvi || cboMaLoaiTS.Text != maloaits || nmrNamSX.Value != namsx)
                    {
                        DialogResult TBsua;
                        TBsua = MessageBox.Show("Bạn có chắc chắn muốn sửa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        if (TBsua == DialogResult.Yes)
                        {
                            string sql_sua = "update DMTAISAN set TENTS ='" + txtTenTaiSan.Text + "' ";
                            sql_sua = sql_sua + ", MALOAITS ='" + cboMaLoaiTS.Text + "'" + ", NAMSD = '" + nmrNamSX.Value + "'" + ", NUOCSX ='" + txtNuocSX.Text + "',MADONVI ='" + cboMaDV.Text + "' where MATS = '" + txtMaTaiSan.Text + "' ";
                            kn.Execute(sql_sua);
                            Dulieu_DMTAISAN();
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
                kn.Execute("Delete DMTAISAN where MATS = '" + txtMaTaiSan.Text + "'");
                Dulieu_DMTAISAN();
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
