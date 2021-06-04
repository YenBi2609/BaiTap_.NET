using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace BaiTap_QuachThiYen
{
    class Ketnoi
    {
        public SqlConnection cnn;
        public SqlCommand cmd;
        public DataTable dta;
        public SqlDataAdapter ada;

        public void KetNoi_CSDL()
        {
            string strKetNoi = @"Provider=SQLNCLI11;Data Source=ADMIN\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=QUANLY123";
            cnn = new SqlConnection(strKetNoi);
            cnn.Open();
        }
        public void HuyKetNoi()
        {
            if (cnn.State == ConnectionState.Open)
                cnn.Close();
        }
    }
}
