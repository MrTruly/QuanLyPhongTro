using System;

public class KhachTro
{
    public string Ten { get; set; }
    public string CMND { get; set; }
    public string MaPhong { get; set; }
    public string NgaySinh { get; set; }
    public string QueQuan { get; set; }
    public string GioiTinh { get; set; }
    public string SoDienThoai { get; set; }
    public string NgayThue { get; set; }

    public KhachTro(string ten, string cmnd, string maPhong, string ngaySinh, string queQuan, string gioiTinh, string soDienThoai, string ngayThue)
    {
        Ten = ten;
        CMND = cmnd;
        MaPhong = maPhong;
        NgaySinh = ngaySinh;
        QueQuan = queQuan;
        GioiTinh = gioiTinh;
        SoDienThoai = soDienThoai;
        NgayThue = ngayThue;
    }

    public override string ToString()
    {
        return $"Tên: {Ten}, CMND: {CMND}, Mã Phòng: {MaPhong}, Ngày Sinh: {NgaySinh}, Quê Quán: {QueQuan}, Giới Tính: {GioiTinh}, SĐT: {SoDienThoai}, Ngày Thuê: {NgayThue}";
    }
}
