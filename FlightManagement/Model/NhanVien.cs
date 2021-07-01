using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightManagement.Model
{
    public class NhanVien
    {
        private string manv;
        private string tennv;
        private string ngaysinh;
        private string gioitinh;
        private string sdt;
        private string diachi;
        private string quyentruycap;

        public NhanVien(string MaNV, string TenNV, string NgaySinh, string GioiTinh, string SDT, string DiaChi, string QuyenTruyCap)
        {
            this.Manv = MaNV;
            this.Tennv = TenNV;
            this.ngaysinh = NgaySinh;
            this.Gioitinh = GioiTinh;
            this.Sdt = SDT;
            this.Diachi = DiaChi;
            this.Quyentruycap = QuyenTruyCap;
        }

        public NhanVien(DataRow row)
        {
            this.Manv = (string)row["MaNV"];
            this.Tennv = (string)row["TenNV"];
            DateTime a = (DateTime)row["NgaySinh"];
            this.Ngaysinh = a.ToString("dd/MM/yyyy");
            this.Gioitinh = (string)row["GioiTinh"];
            this.Sdt = (string)row["SDT"];
            this.Diachi = (string)row["DiaChi"];
            this.Quyentruycap = (string)row["QuyenTruyCap"];
        }
        public string Manv { get => manv; set => manv = value; }
        public string Tennv { get => tennv; set => tennv = value; }
        public string Ngaysinh { get => ngaysinh; set => ngaysinh = value; }
        public string Gioitinh { get => gioitinh; set => gioitinh = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string Diachi { get => diachi; set => diachi = value; }
        public string Quyentruycap { get => quyentruycap; set => quyentruycap = value; }
    }
}
