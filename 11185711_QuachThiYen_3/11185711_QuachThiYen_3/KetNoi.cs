using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace _11185711_QuachThiYen_3

{
    class Ketnoi
    {
        public SqlConnection cnn;
        public SqlCommand cmd;
        public DataTable dta;
        public SqlDataAdapter ada;
        public void KetNoi_CSDL()
        {
            string strKetNoi = @"Data Source=ADMIN\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=QuachThiYen1";
            cnn = new SqlConnection(strKetNoi);
            cnn.Open();
        }
        public void HuyKetNoi()
        {
            if (cnn.State == ConnectionState.Open)
                cnn.Close();
        }
        public DataTable Lay_Dulieu(string Sql)
        {
            KetNoi_CSDL();
            ada = new SqlDataAdapter(Sql, cnn);
            dta = new DataTable();
            ada.Fill(dta);
            return dta;
        }
        public void Execute(string sql)
        {
            KetNoi_CSDL();
            cmd = new SqlCommand(sql, cnn);
            cmd.ExecuteNonQuery();
            HuyKetNoi();
        }
    }
}