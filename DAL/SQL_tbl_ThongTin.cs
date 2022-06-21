using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using System.Data;

namespace DAL
{
    public class SQL_tbl_ThongTin
    {
        KetNoiDB cn = new KetNoiDB();
        public void ThemDuLieu(EC_tbl_ThongTin et)
        {
            cn.ThucThiCauLenhSQL(@"INSERT INTO tbl_ThongTin (ID, HoTen, DiaChi, SDT, Tuoi, NgaySinh) VALUES ('"+et.ID+ "','" + et.HoTen + "','" + et.DiaChi + "','" + et.SDT + "','" + et.Tuoi + "','" + et.NgaySinh + "')");
        }
        public void SuaDuLieu(EC_tbl_ThongTin et)
        {
            cn.ThucThiCauLenhSQL(@"UPDATE tbl_ThongTin SET HoTen = '" + et.HoTen + "', DiaChi = '" + et.DiaChi + "', SDT = '" + et.SDT + "', Tuoi = '" + et.Tuoi + "', NgaySinh = '" + et.NgaySinh + "' WHERE ID = '" + et.ID + "'");
        }
        public void XoaDuLieu(EC_tbl_ThongTin et)
        {
            cn.ThucThiCauLenhSQL(@"DELETE FROM tbl_ThongTin WHERE ID='" + et.ID + "'");
        }
        public DataTable LayDuLieu(string DieuKien)
        {
            return cn.GetDataTable(@"SELECT * FROM tbl_ThongTin " + DieuKien);
        }

        public DataTable TaoBang(string DieuKien)
        {
            return cn.GetDataTable(@"SELECT * FROM tbl_ThongTin " + DieuKien);
        }


        /*
          public DataTable LayThongTinKH(string DieuKien)
          {
              return cn.GetDataTable(@"SELECT MaKH, TenKH from tbl_ThongTin " + DieuKien);
          }
          public DataTable LayThongTinNV(string DieuKien)
          {
              return cn.GetDataTable(@"SELECT MaNV,TenNV from tbl_ThongTin " + DieuKien);
          }*/
    }
}
