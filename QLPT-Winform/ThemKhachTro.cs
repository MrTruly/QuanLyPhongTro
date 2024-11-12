using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyPhongTro
{
    public partial class AddTenantForm : Form
    {
        private TextBox tenantNameTextBox;
        private TextBox cmndTextBox;
        private TextBox dateOfBirthTextBox;
        private TextBox hometownTextBox;
        private ComboBox genderComboBox;
        private TextBox phoneNumberTextBox;
        private TextBox rentDateTextBox;
        private Button okButton;
        private List<KhachTro> danhSachKhachTro;

        public string TenantName { get; private set; }
        public string CMND { get; private set; }
        public string DateOfBirth { get; private set; }
        public string Hometown { get; private set; }
        public string Gender { get; private set; }
        public string PhoneNumber { get; private set; }
        public string RentDate { get; private set; }
        public string RoomId { get; private set; }

        public AddTenantForm(List<KhachTro> danhSachKhachTro)
        {
            InitializeComponent();
            this.danhSachKhachTro = danhSachKhachTro;
            // this.RoomId = roomId;
        }

        private void InitializeComponent()
        {
            // Khởi tạo các điều khiển
            this.tenantNameTextBox = new TextBox { Location = new Point(100, 20), Width = 200 };
            var tenantNameLabel = new Label { Text = "Tên khách:", Location = new Point(20, 20), AutoSize = true };

            this.cmndTextBox = new TextBox { Location = new Point(100, 60), Width = 200 };
            var cmndLabel = new Label { Text = "CMND:", Location = new Point(20, 60), AutoSize = true };

            this.dateOfBirthTextBox = new TextBox { Location = new Point(100, 100), Width = 200 };
            var dateOfBirthLabel = new Label { Text = "Ngày sinh:", Location = new Point(20, 100), AutoSize = true };

            this.hometownTextBox = new TextBox { Location = new Point(100, 140), Width = 200 };
            var hometownLabel = new Label { Text = "Quê quán:", Location = new Point(20, 140), AutoSize = true };

            this.genderComboBox = new ComboBox { Location = new Point(100, 180), Width = 200 };
            this.genderComboBox.Items.AddRange(new[] { "Nam", "Nữ" });
            var genderLabel = new Label { Text = "Giới tính:", Location = new Point(20, 180), AutoSize = true };

            this.phoneNumberTextBox = new TextBox { Location = new Point(100, 220), Width = 200 };
            var phoneNumberLabel = new Label { Text = "Số điện thoại:", Location = new Point(20, 220), AutoSize = true };

            this.rentDateTextBox = new TextBox { Location = new Point(100, 260), Width = 200 };
            var rentDateLabel = new Label { Text = "Ngày thuê:", Location = new Point(20, 260), AutoSize = true };

            this.okButton = new Button { Text = "OK", Location = new Point(100, 300), DialogResult = DialogResult.OK };
            this.okButton.Click += OkButton_Click;

            // Thêm các điều khiển vào form
            this.Controls.Add(tenantNameLabel);
            this.Controls.Add(this.tenantNameTextBox);
            this.Controls.Add(cmndLabel);
            this.Controls.Add(this.cmndTextBox);
            this.Controls.Add(dateOfBirthLabel);
            this.Controls.Add(this.dateOfBirthTextBox);
            this.Controls.Add(hometownLabel);
            this.Controls.Add(this.hometownTextBox);
            this.Controls.Add(genderLabel);
            this.Controls.Add(this.genderComboBox);
            this.Controls.Add(phoneNumberLabel);
            this.Controls.Add(this.phoneNumberTextBox);
            this.Controls.Add(rentDateLabel);
            this.Controls.Add(this.rentDateTextBox);
            this.Controls.Add(this.okButton);

            // Thiết lập các thuộc tính form
            this.Text = "Thêm khách trọ";
            this.Size = new Size(350, 380);
            this.StartPosition = FormStartPosition.CenterParent;
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            // Lấy thông tin từ các textbox và combobox
            TenantName = tenantNameTextBox.Text;
            CMND = cmndTextBox.Text;
            DateOfBirth = dateOfBirthTextBox.Text;
            Hometown = hometownTextBox.Text;
            Gender = genderComboBox.SelectedItem?.ToString();
            PhoneNumber = phoneNumberTextBox.Text;
            RentDate = rentDateTextBox.Text;

            // Kiểm tra xem tất cả thông tin đã được điền chưa
            if (string.IsNullOrEmpty(TenantName) || string.IsNullOrEmpty(CMND) || string.IsNullOrEmpty(DateOfBirth) ||
                string.IsNullOrEmpty(Hometown) || string.IsNullOrEmpty(Gender) || string.IsNullOrEmpty(PhoneNumber) ||
                string.IsNullOrEmpty(RentDate))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.");
                return;
            }

            // Tạo đối tượng KhachTro và thêm vào danh sách
            var newTenant = new KhachTro(TenantName, CMND, RoomId, DateOfBirth, Hometown, Gender, PhoneNumber, RentDate);
            danhSachKhachTro.Add(newTenant);

            // Đóng form và trả về kết quả OK
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
