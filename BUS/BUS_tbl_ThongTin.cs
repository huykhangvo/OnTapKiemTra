using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entity;
using System.Data;

namespace BUS
{
    public class BUS_tbl_ThongTin
    {
        SQL_tbl_ThongTin sql = new SQL_tbl_ThongTin();

        //báo thư viện using QuanLyBanHangEntity;
        //Hàm thêm dữ liệu
        public void ThemDuLieu(EC_tbl_ThongTin et)
        {
            sql.ThemDuLieu(et);
        }

        //Hàm sửa
        public void SuaDuLieu(EC_tbl_ThongTin et)
        {
            sql.SuaDuLieu(et);
        }

        //Hàm xoá
        public void XoaDuLieu(EC_tbl_ThongTin et)
        {
            sql.XoaDuLieu(et);
        }

        //Hàm lấy dữ liệu khai báo thư viện using System.Data;
        public DataTable TaoBang(string DieuKien)
        {
            return sql.TaoBang(DieuKien);
        }
    }
}
