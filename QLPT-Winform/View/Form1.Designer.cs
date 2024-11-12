namespace QuanLyPhongTro
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.listBoxPhongTro = new System.Windows.Forms.ListBox();
            this.listBoxKhachTro = new System.Windows.Forms.ListBox();
            this.buttonThemPhongTro = new System.Windows.Forms.Button();
            this.buttonSuaPhongTro = new System.Windows.Forms.Button();
            this.buttonXoaPhongTro = new System.Windows.Forms.Button();
            this.buttonThemKhachTro = new System.Windows.Forms.Button();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.headerLabel = new System.Windows.Forms.Label();
            this.bodyPanel = new System.Windows.Forms.FlowLayoutPanel();

            this.SuspendLayout();
            // 
            // headerPanel
            // 
            this.headerPanel.Controls.Add(this.headerLabel);
            this.headerPanel.Controls.Add(this.buttonThemPhongTro);
            this.headerPanel.Controls.Add(this.buttonSuaPhongTro);
            this.headerPanel.Controls.Add(this.buttonXoaPhongTro);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(800, 60);
            this.headerPanel.TabIndex = 0;
            this.headerPanel.BorderStyle = BorderStyle.FixedSingle;
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Location = new System.Drawing.Point(800, 12);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(188, 13);
            this.headerLabel.TabIndex = 4;
            this.headerLabel.Text = "{Số phòng trống: 3 | Đã cho thuê: 3}";
            this.headerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // bodyPanel
            // 
            this.bodyPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bodyPanel.Padding = new Padding(0,60,0,0);
            this.bodyPanel.BorderStyle = BorderStyle.FixedSingle;
            this.bodyPanel.Name = "bodyPanel";
            this.bodyPanel.Size = new System.Drawing.Size(800, 500);
            this.bodyPanel.TabIndex = 1;
            this.bodyPanel.AutoScroll = true;
            // // 
            // // listBoxPhongTro
            // // 
            // this.listBoxPhongTro.FormattingEnabled = true;
            // this.listBoxPhongTro.Location = new System.Drawing.Point(12, 12);
            // this.listBoxPhongTro.Name = "listBoxPhongTro";
            // this.listBoxPhongTro.Size = new System.Drawing.Size(240, 368);
            // this.listBoxPhongTro.TabIndex = 0;

            // // 
            // // listBoxKhachTro
            // // 
            // this.listBoxKhachTro.FormattingEnabled = true;
            // this.listBoxKhachTro.Location = new System.Drawing.Point(268, 12);
            // this.listBoxKhachTro.Name = "listBoxKhachTro";
            // this.listBoxKhachTro.Size = new System.Drawing.Size(240, 368);
            // this.listBoxKhachTro.TabIndex = 1;

            // 
            // buttonThemPhongTro
            // 
            this.buttonThemPhongTro.Location = new System.Drawing.Point(12, 12);
            this.buttonThemPhongTro.Name = "buttonThemPhongTro";
            this.buttonThemPhongTro.Size = new System.Drawing.Size(80, 30);
            this.buttonThemPhongTro.TabIndex = 2;
            this.buttonThemPhongTro.Text = "Thêm";
            this.buttonThemPhongTro.UseVisualStyleBackColor = true;
            this.buttonThemPhongTro.Click += new System.EventHandler(this.buttonThemPhongTro_Click);

            // 
            // buttonSuaPhongTro
            // 
            this.buttonSuaPhongTro.Location = new System.Drawing.Point(93, 12);
            this.buttonSuaPhongTro.Name = "buttonSuaPhongTro";
            this.buttonSuaPhongTro.Size = new System.Drawing.Size(80, 30);
            this.buttonSuaPhongTro.TabIndex = 3;
            this.buttonSuaPhongTro.Text = "Sửa";
            this.buttonSuaPhongTro.UseVisualStyleBackColor = true;
            this.buttonSuaPhongTro.Click += new System.EventHandler(this.buttonSuaPhongTro_Click);

            // 
            // buttonXoaPhongTro
            // 
            this.buttonXoaPhongTro.Location = new System.Drawing.Point(174, 12);
            this.buttonXoaPhongTro.Name = "buttonXoaPhongTro";
            this.buttonXoaPhongTro.Size = new System.Drawing.Size(80, 30);
            this.buttonXoaPhongTro.TabIndex = 4;
            this.buttonXoaPhongTro.Text = "Xóa";
            this.buttonXoaPhongTro.UseVisualStyleBackColor = true;
            this.buttonXoaPhongTro.Click += new System.EventHandler(this.buttonXoaPhongTro_Click);

            // // 
            // // buttonThemKhachTro
            // // 
            // this.buttonThemKhachTro.Location = new System.Drawing.Point(268, 386);
            // this.buttonThemKhachTro.Name = "buttonThemKhachTro";
            // this.buttonThemKhachTro.Size = new System.Drawing.Size(240, 23);
            // this.buttonThemKhachTro.TabIndex = 5;
            // this.buttonThemKhachTro.Text = "Thêm Khách Trọ";
            // this.buttonThemKhachTro.UseVisualStyleBackColor = true;
            // this.buttonThemKhachTro.Click += new System.EventHandler(this.buttonThemKhachTro_Click);

            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1080, 720);
            this.Controls.Add(this.headerPanel);
            this.Controls.Add(this.bodyPanel);
            this.Controls.Add(this.buttonThemKhachTro);
            this.Controls.Add(this.listBoxKhachTro);
            this.Controls.Add(this.listBoxPhongTro);
            this.Name = "Form1";
            this.Text = "Quản Lý Phòng Trọ";
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.ListBox listBoxPhongTro;
        private System.Windows.Forms.ListBox listBoxKhachTro;
        private System.Windows.Forms.Button buttonThemPhongTro;
        private System.Windows.Forms.Button buttonSuaPhongTro;
        private System.Windows.Forms.Button buttonXoaPhongTro;
        private System.Windows.Forms.Button buttonThemKhachTro;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.FlowLayoutPanel bodyPanel;
    }
}
