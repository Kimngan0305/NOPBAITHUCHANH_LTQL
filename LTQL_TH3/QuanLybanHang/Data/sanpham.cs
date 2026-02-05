using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLybanHang.Data
{
    public class sanpham
    {
        private Loaisanpham loaisanpham = null!;

        public int ID { get; set; }
        public int HangSanXuatID { get; set; }
        public int LoaiSanPhamID { get; set; }
        public string TenSanPham { get; set; }
        public int DonGia { get; set; }
        public int SoLuong { get; set; }
        public string? HinhAnh { get; set; }
        public string? MoTa { get; set; }

        public virtual ObservableCollectionListSource<Hoadonchitiet> Hoadonchitiet { get; } = new();
        public virtual Loaisanpham Loaisanpham { get; set; } = null!;
        public virtual Hangsanxuat Hangsanxuat { get; set; } = null!;
        

    }
    [NotMapped]
    public class DanhSachSanPham
    {

        public int ID { get; set; }
        public int HangSanXuatID { get; set; }
        public string TenHangSanXuat { get; set; }  // Thêm 
        public int LoaiSanPhamID { get; set; }
        public string TenLoai { get; set; }         // Thêm 
        public string TenSanPham { get; set; }
        public int DonGia { get; set; }
        public int SoLuong { get; set; }
        public string? HinhAnh { get; set; }
        public string? MoTa { get; set; }
    }

}