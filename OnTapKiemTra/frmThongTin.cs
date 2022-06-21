using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using Entity;

namespace OnTapKiemTra
{
    public partial class frmThongTin : Form
    {
        public frmThongTin()
        {
            InitializeComponent();
        }
        BUS_tbl_ThongTin bus = new BUS_tbl_ThongTin();
        EC_tbl_ThongTin ec = new EC_tbl_ThongTin();
        bool themmoi;
        void KhoaDieuKhien()
        {
            txtID.Enabled = false;
            txtHoTen.Enabled = false;
            txtTuoi.Enabled = false;
            txtSDT.Enabled = false;
            txtDiaChi.Enabled = false;
            date.Enabled = false;

            btnThemMoi.Enabled = true;
            btnLuu.Enabled = false;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
        }

        void MoDieuKhien()
        {
            txtID.Enabled = true;
            txtHoTen.Enabled = true;
            txtTuoi.Enabled = true;
            txtSDT.Enabled = true;
            txtDiaChi.Enabled = true;
            date.Enabled = true;

            btnThemMoi.Enabled = false;
            btnLuu.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }

        void setnull()
        {
            txtID.Text = "";
            txtHoTen.Text = "";
            txtTuoi.Text = "";
            txtSDT.Text = "";
            txtDiaChi.Text = "";
            date.Text = "";
        }
        void hienthi(string where)
        {
            msds.DataSource = bus.TaoBang(where);
        }

        private void frmThongTin_Load(object sender, EventArgs e)
        {
            KhoaDieuKhien();
            hienthi("");
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            MoDieuKhien();
            setnull();
            themmoi = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (themmoi == true)
            {
                try
                {
                    ec.ID = txtID.Text;
                    ec.HoTen = txtHoTen.Text;
                    ec.Tuoi = txtTuoi.Text;
                    ec.DiaChi = txtDiaChi.Text;
                    ec.SDT = txtSDT.Text;
                    ec.NgaySinh = date.Text;
                    bus.ThemDuLieu(ec);
                    MessageBox.Show("Đã thêm mới thành công");
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Lỗi thêm không thành công"+ ex.Message);
                    return;
                }
            }
            else
            {
                try
                {
                    ec.ID = txtID.Text;
                    ec.HoTen = txtHoTen.Text;
                    ec.Tuoi = txtTuoi.Text;
                    ec.DiaChi = txtDiaChi.Text;
                    ec.SDT = txtSDT.Text;
                    ec.NgaySinh = date.Text;
                    bus.SuaDuLieu(ec);
                    MessageBox.Show("Đã sữa thành công");
                }
                catch
                {
                    MessageBox.Show("Lỗi thêm không thành công");
                    return;
                }
            }
            setnull();
            KhoaDieuKhien();
            hienthi("");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            MoDieuKhien();
            txtID.Enabled = false;
            themmoi = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                ec.ID = txtID.Text;
                bus.XoaDuLieu(ec);
                MessageBox.Show("Đã xoá thành công");
                KhoaDieuKhien();
                setnull();
                hienthi("");
            }
            catch
            {
                MessageBox.Show("Lỗi Không thể xoá");
            }
        }

        private void msds_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            KhoaDieuKhien();
            try
            {
                txtID.Text = msds.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtHoTen.Text = msds.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtTuoi.Text = msds.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtSDT.Text = msds.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtDiaChi.Text = msds.Rows[e.RowIndex].Cells[2].Value.ToString();
                date.Text = msds.Rows[e.RowIndex].Cells[5].Value.ToString();
            }
            catch
            {

            }
        }
    }
}
