using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class KetNoiDB
    {
        public static SqlConnection connect;

        public static void MoKetNoi()
        {
            if (KetNoiDB.connect == null)
                KetNoiDB.connect = new SqlConnection("Server=FIT\\FIT1;Database=ThongTin;User Id=sa;Password=123456");
            if (KetNoiDB.connect.State != ConnectionState.Open)
                KetNoiDB.connect.Open();
        }

        public void DongKetNoi()
        {
            if (KetNoiDB.connect != null)
            {
                if (KetNoiDB.connect.State == ConnectionState.Open)
                    KetNoiDB.connect.Close();
            }
        }

        //Insert, update, delete
        public void ThucThiCauLenhSQL(string strSQL)
        {
            try
            {
                MoKetNoi();
                SqlCommand sqlcmd = new SqlCommand(strSQL, connect);
                sqlcmd.ExecuteNonQuery();
                DongKetNoi();
            }
            catch
            {
                //câu thông báo
            }
        }

        public DataTable GetDataTable(string strSQL) //select...    
        {
            try
            {
                MoKetNoi();
                DataTable dt = new DataTable();
                SqlDataAdapter sqlda = new SqlDataAdapter(strSQL, connect);
                sqlda.Fill(dt);
                DongKetNoi();
                return dt;
            }
            catch
            {
                return null;
            }
        }

        public string GetValue(string strSQL)// select
        {
            string temp = null;
            MoKetNoi();
            SqlCommand sqlcmd = new SqlCommand(strSQL, connect);
            SqlDataReader sqldr = sqlcmd.ExecuteReader();
            while (sqldr.Read())
                temp = sqldr[0].ToString();
            DongKetNoi();
            return temp;
        }
    }
}
