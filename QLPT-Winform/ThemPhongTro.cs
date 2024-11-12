namespace QuanLyPhongTro
{
    public static class ThemPhongTro
    {
        public partial class AddRoomForm : Form
        {
            private TextBox roomIdTextBox;
            private TextBox tenantNameTextBox;
            private TextBox rentPriceTextBox;
            private Button okButton;

            private List<PhongTro> danhSachPhongTro = new List<PhongTro>();
            private List<KhachTro> danhSachKhachTro = new List<KhachTro>();
            private Form1 mainForm;
            public string RoomId { get; private set; }
            public string TenantName { get; private set; }
            public double RentPrice { get; private set; }
            public bool IsOccupied { get; private set; }

            public static void AddRoomPanel(Panel bodyPanel, List<PhongTro> danhSachPhongTro, string roomId, string tenantName, double rentPrice, bool isOccupied)
            {
                int panelWidth = (bodyPanel.Width - 40) / 4; // Chia đều bodyPanel thành 4 phần, trừ đi khoảng trống
                int panelHeight = bodyPanel.Height / 2; // Chia đều bodyPanel theo chiều cao
                var roomPanel = new Panel
                {
                    BorderStyle = BorderStyle.FixedSingle,
                    Width = panelWidth,
                    Height = panelHeight,
                    Margin = new Padding(10),
                    BackColor = isOccupied ? Color.SkyBlue : Color.White
                };

                var roomIdLabel = new Label
                {
                    Text = $"Phòng {roomId}",
                    Location = new Point(0, 10),
                    TextAlign = ContentAlignment.TopCenter,
                    Font = new Font("Arial", 10, FontStyle.Bold)
                };
                roomIdLabel.Width = roomPanel.Width - 20;
                roomPanel.Controls.Add(roomIdLabel);

                // Tính toán vị trí của các nút nằm ngang dưới Mã phòng
                int buttonWidth = (roomPanel.Width - 40) / 3; // Chiều rộng của mỗi nút, trừ đi một khoảng cho margin
                int buttonHeight = 30; // Chiều cao của nút
                int startBtnLocation = 10; // Điểm bắt đầu của nút đầu tiên

                if (isOccupied)
                {
                    // Các nút "Trả phòng", "Xem thông tin", "Sửa phòng"
                    var vacateRoomButton = new Button
                    {
                        Text = "Trả phòng",
                        Location = new Point(startBtnLocation, 40), // Vị trí của nút Trả phòng
                        Size = new Size(buttonWidth, buttonHeight),
                        BackColor = Color.SeaGreen,
                        ForeColor = Color.White
                    };
                    roomPanel.Controls.Add(vacateRoomButton);

                    var viewInfoButton = new Button
                    {
                        Text = "Xem thông tin",
                        Location = new Point(startBtnLocation + buttonWidth + 10, 40), // Vị trí của nút Xem thông tin
                        Size = new Size(buttonWidth, buttonHeight),
                        BackColor = Color.DarkGray,
                        ForeColor = Color.White
                    };
                    roomPanel.Controls.Add(viewInfoButton);

                    var editRoomButton = new Button
                    {
                        Text = "Sửa phòng",
                        Location = new Point(startBtnLocation + 2 * (buttonWidth + 10), 40), // Vị trí của nút Sửa phòng
                        Size = new Size(buttonWidth, buttonHeight),
                        BackColor = Color.DeepSkyBlue,
                        ForeColor = Color.White,
                        // FormBorderStyle = FormBorderStyle.None
                    };
                    roomPanel.Controls.Add(editRoomButton);

                    var tenantNameLabel = new Label
                    {
                        Text = $"{tenantName}",
                        Location = new Point(10, 80),
                        ForeColor = Color.Green
                    };
                    roomPanel.Controls.Add(tenantNameLabel);

                    var rentPriceLabel = new Label
                    {
                        Text = $"{rentPrice}",
                        Location = new Point(10, 110),
                        ForeColor = Color.Red
                    };
                    roomPanel.Controls.Add(rentPriceLabel);

                    var editTenantButton = new Button
                    {
                        Text = "Chỉnh sửa",
                        Location = new Point(10, 140),
                        Size = new Size(80, 30),
                        BackColor = Color.SkyBlue,
                        ForeColor = Color.White
                    };
                    roomPanel.Controls.Add(editTenantButton);

                    var deleteRoomButton = new Button
                    {
                        Text = "Xóa phòng",
                        Location = new Point(100, 140),
                        Size = new Size(80, 30),
                        BackColor = Color.OrangeRed,
                        ForeColor = Color.White
                    };
                    roomPanel.Controls.Add(deleteRoomButton);
                }
                else
                {
                    // Nếu phòng chưa có người thuê, hiển thị nút "Thêm khách"
                    var addTenantButton = new Button
                    {
                        Text = "Thêm khách",
                        Location = new Point(10, 40),
                        Size = new Size(roomPanel.Width - 20, buttonHeight) // Nút "Thêm khách" chiếm toàn bộ chiều rộng của roomPanel
                    };
                    // addTenantButton.Click += (sender, e) => buttonThemKhachTro_Click(sender, e, danhSachKhachTro);
                    roomPanel.Controls.Add(addTenantButton);

                    var rentPriceLabel = new Label
                    {
                        Text = $"{rentPrice}",
                        Location = new Point(10, 110)
                    };
                    roomPanel.Controls.Add(rentPriceLabel);

                }

                bodyPanel.Controls.Add(roomPanel);
                danhSachPhongTro.Add(new PhongTro(roomId, tenantName, rentPrice, isOccupied));
            }


            public AddRoomForm()
            {
                InitializeComponent();
            }

            private void InitializeComponent()
            {
                // Khởi tạo các điều khiển
                this.roomIdTextBox = new TextBox
                {
                    Location = new Point(100, 20),
                    Width = 200
                };
                var roomIdLabel = new Label
                {
                    Text = "Mã phòng:",
                    Location = new Point(20, 20),
                    AutoSize = true
                };

                this.tenantNameTextBox = new TextBox
                {
                    Location = new Point(100, 60),
                    Width = 200
                };
                var tenantNameLabel = new Label
                {
                    Text = "Tên người thuê:",
                    Location = new Point(20, 60),
                    AutoSize = true
                };

                this.rentPriceTextBox = new TextBox
                {
                    Location = new Point(100, 100),
                    Width = 200
                };
                var rentPriceLabel = new Label
                {
                    Text = "Giá thuê:",
                    Location = new Point(20, 100),
                    AutoSize = true
                };

                this.okButton = new Button
                {
                    Text = "OK",
                    Location = new Point(100, 140),
                    DialogResult = DialogResult.OK
                };
                this.okButton.Click += OkButton_Click;

                // Thêm các điều khiển vào form
                this.Controls.Add(roomIdLabel);
                this.Controls.Add(this.roomIdTextBox);
                this.Controls.Add(tenantNameLabel);
                this.Controls.Add(this.tenantNameTextBox);
                this.Controls.Add(rentPriceLabel);
                this.Controls.Add(this.rentPriceTextBox);
                this.Controls.Add(this.okButton);

                // Thiết lập các thuộc tính form
                this.Text = "Thêm phòng";
                this.Size = new Size(350, 220);
                this.StartPosition = FormStartPosition.CenterParent;
            }

            private void OkButton_Click(object sender, EventArgs e)
            {
                // Lấy thông tin từ các điều khiển trên form
                RoomId = roomIdTextBox.Text;
                TenantName = tenantNameTextBox.Text;
                RentPrice = double.Parse(rentPriceTextBox.Text);
                IsOccupied = !string.IsNullOrEmpty(TenantName);
            }
            private static void buttonThemKhachTro_Click(object sender, EventArgs e, List<KhachTro> danhSachKhachTro)
            {
                using (var addTenantForm = new AddTenantForm(danhSachKhachTro))
                {
                    if (addTenantForm.ShowDialog() == DialogResult.OK)
                    {
                        // Cập nhật thông tin phòng hoặc làm các xử lý cần thiết sau khi thêm khách trọ
                        MessageBox.Show("Thêm khách trọ thành công.");
                    }
                }
            }
        }
    }

}