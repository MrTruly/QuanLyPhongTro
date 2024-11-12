using System;

public class PhongTro
{
    public string MaPhong { get; set; }
    public string TenNguoiThue { get; set; }
    public double Gia { get; set; }
    public bool TrangThai { get; set; }

    public PhongTro(string maPhong, string tenNguoiThue, double gia, bool trangThai)
    {
        MaPhong = maPhong;
        TenNguoiThue = tenNguoiThue;
        Gia = gia;
        TrangThai = trangThai;
    }
    

    public override string ToString()
    {
        return $"Mã: {MaPhong}, Tên người thuê: {TenNguoiThue}, Giá: {Gia}, Trạng Thái: {TrangThai}";
    }
}
