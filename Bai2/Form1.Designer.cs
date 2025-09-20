namespace Bai2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private GroupBox groupBox1;
        private Label labelHoTen;
        private TextBox txtHoTen;
        private RadioButton rdoCaNgay;
        private RadioButton rdoNuaNgay;
        private Label labelGiaDuThuyen;
        private TextBox txtGiaDuThuyen;
        private Label labelChonDoUong;
        private ComboBox cbbDoUong;
        private Label labelSoLuong;
        private ComboBox cbbSoLuong;
        private Label labelTienDoUong;
        private TextBox txtTienDoUong;
        private Button btnThemDS;
        private Button btnThemMoi;
        private GroupBox groupBox2;
        private ListBox lstKhachHang;
        private Button btnThoat;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			groupBox1 = new GroupBox();
			labelHoTen = new Label();
			txtHoTen = new TextBox();
			rdoCaNgay = new RadioButton();
			rdoNuaNgay = new RadioButton();
			labelGiaDuThuyen = new Label();
			txtGiaDuThuyen = new TextBox();
			labelChonDoUong = new Label();
			cbbDoUong = new ComboBox();
			labelSoLuong = new Label();
			cbbSoLuong = new ComboBox();
			labelTienDoUong = new Label();
			txtTienDoUong = new TextBox();
			btnThemDS = new Button();
			btnThemMoi = new Button();
			groupBox2 = new GroupBox();
			lstKhachHang = new ListBox();
			btnThoat = new Button();
			groupBox1.SuspendLayout();
			groupBox2.SuspendLayout();
			SuspendLayout();
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(labelHoTen);
			groupBox1.Controls.Add(txtHoTen);
			groupBox1.Controls.Add(rdoCaNgay);
			groupBox1.Controls.Add(rdoNuaNgay);
			groupBox1.Controls.Add(labelGiaDuThuyen);
			groupBox1.Controls.Add(txtGiaDuThuyen);
			groupBox1.Controls.Add(labelChonDoUong);
			groupBox1.Controls.Add(cbbDoUong);
			groupBox1.Controls.Add(labelSoLuong);
			groupBox1.Controls.Add(cbbSoLuong);
			groupBox1.Controls.Add(labelTienDoUong);
			groupBox1.Controls.Add(txtTienDoUong);
			groupBox1.Controls.Add(btnThemDS);
			groupBox1.Controls.Add(btnThemMoi);
			groupBox1.Location = new Point(20, 20);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(422, 320);
			groupBox1.TabIndex = 0;
			groupBox1.TabStop = false;
			groupBox1.Text = "Nhập Thông Tin Khách Hàng Đặt Tour";
			// 
			// labelHoTen
			// 
			labelHoTen.Location = new Point(20, 40);
			labelHoTen.Name = "labelHoTen";
			labelHoTen.Size = new Size(60, 23);
			labelHoTen.TabIndex = 0;
			labelHoTen.Text = "Họ Tên";
			// 
			// txtHoTen
			// 
			txtHoTen.Location = new Point(90, 40);
			txtHoTen.Name = "txtHoTen";
			txtHoTen.Size = new Size(150, 23);
			txtHoTen.TabIndex = 1;
			// 
			// rdoCaNgay
			// 
			rdoCaNgay.Location = new Point(20, 80);
			rdoCaNgay.Name = "rdoCaNgay";
			rdoCaNgay.Size = new Size(80, 23);
			rdoCaNgay.TabIndex = 2;
			rdoCaNgay.Text = "Cả Ngày";
			rdoCaNgay.CheckedChanged += rdoCaNgay_CheckedChanged;
			// 
			// rdoNuaNgay
			// 
			rdoNuaNgay.Location = new Point(110, 80);
			rdoNuaNgay.Name = "rdoNuaNgay";
			rdoNuaNgay.Size = new Size(80, 23);
			rdoNuaNgay.TabIndex = 3;
			rdoNuaNgay.Text = "Nửa Ngày";
			rdoNuaNgay.CheckedChanged += rdoNuaNgay_CheckedChanged;
			// 
			// labelGiaDuThuyen
			// 
			labelGiaDuThuyen.Location = new Point(20, 120);
			labelGiaDuThuyen.Name = "labelGiaDuThuyen";
			labelGiaDuThuyen.Size = new Size(90, 23);
			labelGiaDuThuyen.TabIndex = 4;
			labelGiaDuThuyen.Text = "Giá Du Thuyền";
			// 
			// txtGiaDuThuyen
			// 
			txtGiaDuThuyen.Location = new Point(120, 120);
			txtGiaDuThuyen.Name = "txtGiaDuThuyen";
			txtGiaDuThuyen.ReadOnly = true;
			txtGiaDuThuyen.Size = new Size(80, 23);
			txtGiaDuThuyen.TabIndex = 5;
			// 
			// labelChonDoUong
			// 
			labelChonDoUong.Location = new Point(20, 160);
			labelChonDoUong.Name = "labelChonDoUong";
			labelChonDoUong.Size = new Size(90, 23);
			labelChonDoUong.TabIndex = 6;
			labelChonDoUong.Text = "Chọn Đồ Uống";
			// 
			// cbbDoUong
			// 
			cbbDoUong.DropDownStyle = ComboBoxStyle.DropDownList;
			cbbDoUong.Location = new Point(20, 191);
			cbbDoUong.Name = "cbbDoUong";
			cbbDoUong.Size = new Size(100, 23);
			cbbDoUong.TabIndex = 7;
			cbbDoUong.SelectedIndexChanged += cbbDoUong_SelectedIndexChanged;
			// 
			// labelSoLuong
			// 
			labelSoLuong.Location = new Point(157, 160);
			labelSoLuong.Name = "labelSoLuong";
			labelSoLuong.Size = new Size(60, 23);
			labelSoLuong.TabIndex = 8;
			labelSoLuong.Text = "Số Lượng";
			// 
			// cbbSoLuong
			// 
			cbbSoLuong.Location = new Point(157, 191);
			cbbSoLuong.Name = "cbbSoLuong";
			cbbSoLuong.Size = new Size(50, 23);
			cbbSoLuong.TabIndex = 9;
			cbbSoLuong.SelectedIndexChanged += cbbSoLuong_SelectedIndexChanged;
			// 
			// labelTienDoUong
			// 
			labelTienDoUong.Location = new Point(245, 160);
			labelTienDoUong.Name = "labelTienDoUong";
			labelTienDoUong.Size = new Size(40, 23);
			labelTienDoUong.TabIndex = 10;
			labelTienDoUong.Text = "Tiền";
			// 
			// txtTienDoUong
			// 
			txtTienDoUong.Location = new Point(245, 191);
			txtTienDoUong.Name = "txtTienDoUong";
			txtTienDoUong.ReadOnly = true;
			txtTienDoUong.Size = new Size(50, 23);
			txtTienDoUong.TabIndex = 11;
			// 
			// btnThemDS
			// 
			btnThemDS.Location = new Point(120, 220);
			btnThemDS.Name = "btnThemDS";
			btnThemDS.Size = new Size(120, 35);
			btnThemDS.TabIndex = 12;
			btnThemDS.Text = "Thêm Vào DS";
			btnThemDS.Click += btnThemDS_Click;
			// 
			// btnThemMoi
			// 
			btnThemMoi.Location = new Point(270, 220);
			btnThemMoi.Name = "btnThemMoi";
			btnThemMoi.Size = new Size(120, 35);
			btnThemMoi.TabIndex = 13;
			btnThemMoi.Text = "Thêm Mới";
			btnThemMoi.Click += btnThemMoi_Click;
			// 
			// groupBox2
			// 
			groupBox2.Controls.Add(lstKhachHang);
			groupBox2.Location = new Point(465, 20);
			groupBox2.Name = "groupBox2";
			groupBox2.Size = new Size(518, 320);
			groupBox2.TabIndex = 1;
			groupBox2.TabStop = false;
			groupBox2.Text = "Danh Sách Khách Hàng Đặt Tour";
			// 
			// lstKhachHang
			// 
			lstKhachHang.Location = new Point(15, 30);
			lstKhachHang.Name = "lstKhachHang";
			lstKhachHang.Size = new Size(484, 259);
			lstKhachHang.TabIndex = 0;
			// 
			// btnThoat
			// 
			btnThoat.Location = new Point(652, 366);
			btnThoat.Name = "btnThoat";
			btnThoat.Size = new Size(100, 35);
			btnThoat.TabIndex = 2;
			btnThoat.Text = "Thoát";
			btnThoat.Click += btnThoat_Click;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.LightSteelBlue;
			ClientSize = new Size(1005, 430);
			Controls.Add(groupBox1);
			Controls.Add(groupBox2);
			Controls.Add(btnThoat);
			FormBorderStyle = FormBorderStyle.FixedToolWindow;
			Name = "Form1";
			Text = "Công Ty Du Thuyền Hồ Tây";
			Load += Form1_Load;
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			groupBox2.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion
	}
}
