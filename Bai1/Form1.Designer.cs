
namespace Bai1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private GroupBox groupBox1;
        private Label label1;
        private ComboBox cbbTenMonHoc;
        private Label label2;
        private TextBox txtSoTinChi;
        private Label label3;
        private TextBox txtDiem;
        private Button btnThem;
        private GroupBox groupBox2;
        private ListBox lstMonHoc;
        private Label label4;
        private TextBox txtTongTinChi;
        private Label label5;
        private TextBox txtTongDiem;
        private Label label6;
        private TextBox txtDiemTB;
        private Button btnTinh;
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
            label1 = new Label();
            cbbTenMonHoc = new ComboBox();
            label2 = new Label();
            txtSoTinChi = new TextBox();
            label3 = new Label();
            txtDiem = new TextBox();
            btnThem = new Button();
            groupBox2 = new GroupBox();
            lstMonHoc = new ListBox();
            label4 = new Label();
            txtTongTinChi = new TextBox();
            label5 = new Label();
            txtTongDiem = new TextBox();
            label6 = new Label();
            txtDiemTB = new TextBox();
            btnTinh = new Button();
            btnThoat = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(cbbTenMonHoc);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtSoTinChi);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtDiem);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(312, 363);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin điểm sinh viên";
            // 
            // label1
            // 
            label1.Location = new Point(20, 30);
            label1.Name = "label1";
            label1.Size = new Size(80, 23);
            label1.TabIndex = 0;
            label1.Text = "Tên môn học";
            // 
            // cbbTenMonHoc
            // 
            cbbTenMonHoc.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbTenMonHoc.Items.AddRange(new object[] { "Giải tích f1", "Tin học đại cương" });
            cbbTenMonHoc.Location = new Point(120, 30);
            cbbTenMonHoc.Name = "cbbTenMonHoc";
            cbbTenMonHoc.Size = new Size(150, 23);
            cbbTenMonHoc.TabIndex = 1;
            cbbTenMonHoc.SelectedValueChanged += cbbTenMonHoc_SelectedValueChanged;
            // 
            // label2
            // 
            label2.Location = new Point(20, 70);
            label2.Name = "label2";
            label2.Size = new Size(80, 23);
            label2.TabIndex = 2;
            label2.Text = "Số tín chỉ";
            // 
            // txtSoTinChi
            // 
            txtSoTinChi.Location = new Point(120, 70);
            txtSoTinChi.Name = "txtSoTinChi";
            txtSoTinChi.Size = new Size(150, 23);
            txtSoTinChi.TabIndex = 3;
            // 
            // label3
            // 
            label3.Location = new Point(20, 110);
            label3.Name = "label3";
            label3.Size = new Size(80, 23);
            label3.TabIndex = 4;
            label3.Text = "Điểm";
            // 
            // txtDiem
            // 
            txtDiem.Location = new Point(120, 110);
            txtDiem.Name = "txtDiem";
            txtDiem.Size = new Size(150, 23);
            txtDiem.TabIndex = 5;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(90, 160);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(120, 30);
            btnThem.TabIndex = 6;
            btnThem.Text = "Thêm vào DS";
            btnThem.Click += btnThem_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lstMonHoc);
            groupBox2.Location = new Point(330, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(400, 220);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách các môn học";
            // 
            // lstMonHoc
            // 
            lstMonHoc.Location = new Point(15, 30);
            lstMonHoc.Name = "lstMonHoc";
            lstMonHoc.SelectionMode = SelectionMode.None;
            lstMonHoc.Size = new Size(370, 169);
            lstMonHoc.TabIndex = 0;
            // 
            // label4
            // 
            label4.Location = new Point(330, 250);
            label4.Name = "label4";
            label4.Size = new Size(100, 23);
            label4.TabIndex = 2;
            label4.Text = "Tổng số tín chỉ";
            // 
            // txtTongTinChi
            // 
            txtTongTinChi.Location = new Point(430, 250);
            txtTongTinChi.Name = "txtTongTinChi";
            txtTongTinChi.ReadOnly = true;
            txtTongTinChi.Size = new Size(60, 23);
            txtTongTinChi.TabIndex = 3;
            // 
            // label5
            // 
            label5.Location = new Point(510, 250);
            label5.Name = "label5";
            label5.Size = new Size(100, 23);
            label5.TabIndex = 4;
            label5.Text = "Tổng số điểm";
            // 
            // txtTongDiem
            // 
            txtTongDiem.Location = new Point(610, 250);
            txtTongDiem.Name = "txtTongDiem";
            txtTongDiem.ReadOnly = true;
            txtTongDiem.Size = new Size(60, 23);
            txtTongDiem.TabIndex = 5;
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.Location = new Point(330, 290);
            label6.Name = "label6";
            label6.Size = new Size(120, 23);
            label6.TabIndex = 6;
            label6.Text = "Điểm trung bình";
            // 
            // txtDiemTB
            // 
            txtDiemTB.Location = new Point(460, 290);
            txtDiemTB.Name = "txtDiemTB";
            txtDiemTB.ReadOnly = true;
            txtDiemTB.Size = new Size(60, 23);
            txtDiemTB.TabIndex = 7;
            // 
            // btnTinh
            // 
            btnTinh.Location = new Point(420, 340);
            btnTinh.Name = "btnTinh";
            btnTinh.Size = new Size(100, 35);
            btnTinh.TabIndex = 8;
            btnTinh.Text = "Tính";
            btnTinh.Click += btnTinh_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(570, 340);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(100, 35);
            btnThoat.TabIndex = 9;
            btnThoat.Text = "Thoát";
            btnThoat.Click += btnThoat_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(750, 400);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Controls.Add(label4);
            Controls.Add(txtTongTinChi);
            Controls.Add(label5);
            Controls.Add(txtTongDiem);
            Controls.Add(label6);
            Controls.Add(txtDiemTB);
            Controls.Add(btnTinh);
            Controls.Add(btnThoat);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}
