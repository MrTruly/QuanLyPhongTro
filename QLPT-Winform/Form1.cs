using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyPhongTro
{
    public partial class Form1 : Form
    {
        private List<PhongTro> danhSachPhongTro = new List<PhongTro>();
        private List<KhachTro> danhSachKhachTro = new List<KhachTro>();
        public Form1()
        {
            InitializeComponent();
            InitializeData();
            InitializeBody();
        }
        private void InitializeData()
        {
            danhSachPhongTro = new List<PhongTro>
            {
                new PhongTro("P001", "Phòng đơn", 1500000, true),
                new PhongTro("P002", "Phòng đơn", 1900000, true),
            };

            danhSachKhachTro = new List<KhachTro>
            {
                new KhachTro("Nguyễn Văn A", "123456789", "P001", "01/01/1990", "Hà Nội", "Nam", "0901234567", "12/03/2024"),
                new KhachTro("Trần Thị B", "287654321", "P002", "02/02/1992", "Bắc Ninh", "Nữ", "0912345678","12/05/2024"),
            };

            // Populate the list boxes with initial data
            UpdatePhongTroList();
            UpdateKhachTroList();

            var KhachTroLists = danhSachKhachTro.Where(g => g.MaPhong == "P001").Take(1);
        }

        private void InitializeBody()
        {
            // Example of adding room panels
            ThemPhongTro.AddRoomForm.AddRoomPanel(bodyPanel, danhSachPhongTro, "101", "Nguyen Van A", 5000000, true);
            ThemPhongTro.AddRoomForm.AddRoomPanel(bodyPanel, danhSachPhongTro, "102", "Nguyen Van B", 6000000, true);
            ThemPhongTro.AddRoomForm.AddRoomPanel(bodyPanel, danhSachPhongTro, "102", "Nguyen Van E", 6000000, false);
            ThemPhongTro.AddRoomForm.AddRoomPanel(bodyPanel, danhSachPhongTro, "102", "Nguyen Van E", 6000000, true);
            ThemPhongTro.AddRoomForm.AddRoomPanel(bodyPanel, danhSachPhongTro, "102", "Nguyen Van E", 6000000, true);
            ThemPhongTro.AddRoomForm.AddRoomPanel(bodyPanel, danhSachPhongTro, "102", "Nguyen Van E", 6000000, true);
            ThemPhongTro.AddRoomForm.AddRoomPanel(bodyPanel, danhSachPhongTro, "102", "Nguyen Van AQE", 6000000, false);
        }


        private void UpdatePhongTroList()
        {
            listBoxPhongTro.Items.Clear();
            foreach (var phong in danhSachPhongTro)
            {
                listBoxPhongTro.Items.Add(phong);
            }
        }

        private void UpdateKhachTroList()
        {
            listBoxKhachTro.Items.Clear();
            foreach (var khach in danhSachKhachTro)
            {
                listBoxKhachTro.Items.Add(khach);
            }
        }

        private void buttonThemPhongTro_Click(object sender, EventArgs e)
        {
            var addRoomForm = new ThemPhongTro.AddRoomForm();
            if (addRoomForm.ShowDialog() == DialogResult.OK)
            {
                // Lấy thông tin từ form và thêm phòng mới vào danh sách
                ThemPhongTro.AddRoomForm.AddRoomPanel(bodyPanel, danhSachPhongTro, addRoomForm.RoomId, addRoomForm.TenantName, addRoomForm.RentPrice, addRoomForm.IsOccupied);
                bodyPanel.Invalidate();
            }
        }

        private void buttonSuaPhongTro_Click(object sender, EventArgs e)
        {
            // Logic to edit a room
            MessageBox.Show($"{headerPanel.Size}");
            // Console.WriteLine(this.bodyPanel.Location);
        }

        private void buttonXoaPhongTro_Click(object sender, EventArgs e)
        {
            // Logic to delete a room
            MessageBox.Show("Xóa Phòng Trọ");
        }

        // private void buttonThemKhachTro_Click(object sender, EventArgs e)
        // {
        //     using (var addTenantForm = new AddTenantForm(danhSachKhachTro))
        //     {
        //         if (addTenantForm.ShowDialog() == DialogResult.OK)
        //         {
        //             // Cập nhật thông tin phòng hoặc làm các xử lý cần thiết sau khi thêm khách trọ
        //             MessageBox.Show("Thêm khách trọ thành công.");
        //         }
        //     }
        // }

        private void UpdatePhongTroListView()
        {
            listViewPhongTro.Items.Clear();
            foreach (var phongTro in danhSachPhongTro)
            {
                ListViewItem item = new ListViewItem(phongTro.MaPhong);
                item.SubItems.Add(phongTro.TenNguoiThue);
                item.SubItems.Add(phongTro.Gia.ToString());
                item.SubItems.Add(phongTro.TrangThai ? "Trống" : "Đã Thuê");
                listViewPhongTro.Items.Add(item);
            }
        }

        private void UpdateKhachTroListView()
        {
            listViewKhachTro.Items.Clear();
            foreach (var khachTro in danhSachKhachTro)
            {
                ListViewItem item = new ListViewItem(khachTro.Ten);
                item.SubItems.Add(khachTro.CMND);
                item.SubItems.Add(khachTro.MaPhong);
                item.SubItems.Add(khachTro.NgaySinh);
                item.SubItems.Add(khachTro.QueQuan);
                item.SubItems.Add(khachTro.GioiTinh);
                item.SubItems.Add(khachTro.SoDienThoai);
                item.SubItems.Add(khachTro.NgayThue);
                listViewKhachTro.Items.Add(item);
            }
        }

        private void ConnectSQL(object sender, EventArgs e)
        {
            string connectionString = @"Server=DESKTOP-4BRMCNG\SQLEXPRESS;Database=QLPT;Integrated Security=True;TrustServerCertificate=True;";
            MessageBox.Show("Kết nối thành công!");
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                    try
                    {
                        string query = "SELECT * FROM QLPT";
                        connection.Open();
                        SqlCommand command = new SqlCommand(query, connection);

                        using SqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            Console.WriteLine($"{reader[0]} \t {reader[1]}");
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Lỗi kết nối: {ex.Message}");
                    }
            }
        }


        private ListView listViewPhongTro;
        private ListView listViewKhachTro;

    }
}
