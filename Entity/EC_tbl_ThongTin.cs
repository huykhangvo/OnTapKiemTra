using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class EC_tbl_ThongTin
    {
        private string _ID;
        private string _HoTen;
        private string _DiaChi;
        private string _SDT;
        private string _Tuoi;
        private string _NgaySinh;

        public string ID { get => _ID; set => _ID = value; }
        public string HoTen { get => _HoTen; set => _HoTen = value; }
        public string DiaChi { get => _DiaChi; set => _DiaChi = value; }
        public string SDT { get => _SDT; set => _SDT = value; }
        public string Tuoi { get => _Tuoi; set => _Tuoi = value; }
        public string NgaySinh { get => _NgaySinh; set => _NgaySinh = value; }
    }
}
