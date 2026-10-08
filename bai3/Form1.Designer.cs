using System.Drawing;
using System.Windows.Forms;

namespace bai3
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;


    protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            grpNhapLieu = new GroupBox();
            lblMaVT = new Label();
            txtMaVT = new TextBox();
            lblTenVT = new Label();
            txtTenVT = new TextBox();
            lblDonVi = new Label();
            cboDonVi = new ComboBox();
            lblDonGia = new Label();
            txtDonGia = new TextBox();
            grpDanhSach = new GroupBox();
            lvVatTu = new ListView();
            btnThemMoi = new Button();
            btnCapNhat = new Button();
            btnXoaDong = new Button();
            btnXoaTatCa = new Button();
            grpNhapLieu.SuspendLayout();
            grpDanhSach.SuspendLayout();
            SuspendLayout();
            // 
            // grpNhapLieu
            // 
            grpNhapLieu.Controls.Add(lblMaVT);
            grpNhapLieu.Controls.Add(txtMaVT);
            grpNhapLieu.Controls.Add(lblTenVT);
            grpNhapLieu.Controls.Add(txtTenVT);
            grpNhapLieu.Controls.Add(lblDonVi);
            grpNhapLieu.Controls.Add(cboDonVi);
            grpNhapLieu.Controls.Add(lblDonGia);
            grpNhapLieu.Controls.Add(txtDonGia);
            grpNhapLieu.Location = new Point(20, 20);
            grpNhapLieu.Name = "grpNhapLieu";
            grpNhapLieu.Size = new Size(330, 300);
            grpNhapLieu.TabIndex = 0;
            grpNhapLieu.TabStop = false;
            grpNhapLieu.Text = "Nhập thông tin vật tư";
            // 
            // lblMaVT
            // 
            lblMaVT.AutoSize = true;
            lblMaVT.Location = new Point(20, 45);
            lblMaVT.Name = "lblMaVT";
            lblMaVT.Size = new Size(75, 20);
            lblMaVT.TabIndex = 0;
            lblMaVT.Text = "Mã vật tư:";
            // 
            // txtMaVT
            // 
            txtMaVT.Location = new Point(120, 42);
            txtMaVT.Name = "txtMaVT";
            txtMaVT.Size = new Size(180, 27);
            txtMaVT.TabIndex = 0;
            // 
            // lblTenVT
            // 
            lblTenVT.AutoSize = true;
            lblTenVT.Location = new Point(20, 95);
            lblTenVT.Name = "lblTenVT";
            lblTenVT.Size = new Size(77, 20);
            lblTenVT.TabIndex = 1;
            lblTenVT.Text = "Tên vật tư:";
            // 
            // txtTenVT
            // 
            txtTenVT.Location = new Point(120, 92);
            txtTenVT.Name = "txtTenVT";
            txtTenVT.Size = new Size(180, 27);
            txtTenVT.TabIndex = 1;
            // 
            // lblDonVi
            // 
            lblDonVi.AutoSize = true;
            lblDonVi.Location = new Point(20, 145);
            lblDonVi.Name = "lblDonVi";
            lblDonVi.Size = new Size(84, 20);
            lblDonVi.TabIndex = 2;
            lblDonVi.Text = "Đơn vị tính:";
            // 
            // cboDonVi
            // 
            cboDonVi.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDonVi.FormattingEnabled = true;
            cboDonVi.Location = new Point(120, 142);
            cboDonVi.Name = "cboDonVi";
            cboDonVi.Size = new Size(180, 28);
            cboDonVi.TabIndex = 2;
            // 
            // lblDonGia
            // 
            lblDonGia.AutoSize = true;
            lblDonGia.Location = new Point(20, 195);
            lblDonGia.Name = "lblDonGia";
            lblDonGia.Size = new Size(102, 20);
            lblDonGia.TabIndex = 3;
            lblDonGia.Text = "Đơn giá nhập:";
            // 
            // txtDonGia
            // 
            txtDonGia.Location = new Point(120, 192);
            txtDonGia.Name = "txtDonGia";
            txtDonGia.Size = new Size(180, 27);
            txtDonGia.TabIndex = 3;
            // 
            // grpDanhSach
            // 
            grpDanhSach.Controls.Add(lvVatTu);
            grpDanhSach.Location = new Point(370, 20);
            grpDanhSach.Name = "grpDanhSach";
            grpDanhSach.Size = new Size(620, 300);
            grpDanhSach.TabIndex = 1;
            grpDanhSach.TabStop = false;
            grpDanhSach.Text = "Danh sách vật tư";
            // 
            // lvVatTu
            // 
            lvVatTu.FullRowSelect = true;
            lvVatTu.GridLines = true;
            lvVatTu.Location = new Point(24, 26);
            lvVatTu.Name = "lvVatTu";
            lvVatTu.Size = new Size(590, 250);
            lvVatTu.TabIndex = 4;
            lvVatTu.UseCompatibleStateImageBehavior = false;
            lvVatTu.View = View.Details;
            lvVatTu.SelectedIndexChanged += lvVatTu_SelectedIndexChanged;
            // 
            // btnThemMoi
            // 
            btnThemMoi.Location = new Point(20, 340);
            btnThemMoi.Name = "btnThemMoi";
            btnThemMoi.Size = new Size(130, 40);
            btnThemMoi.TabIndex = 5;
            btnThemMoi.Text = "Thêm mới";
            btnThemMoi.UseVisualStyleBackColor = true;
            btnThemMoi.Click += btnThemMoi_Click;
            // 
            // btnCapNhat
            // 
            btnCapNhat.Location = new Point(170, 340);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(130, 40);
            btnCapNhat.TabIndex = 6;
            btnCapNhat.Text = "Cập nhật";
            btnCapNhat.UseVisualStyleBackColor = true;
            btnCapNhat.Click += btnCapNhat_Click;
            // 
            // btnXoaDong
            // 
            btnXoaDong.Location = new Point(320, 340);
            btnXoaDong.Name = "btnXoaDong";
            btnXoaDong.Size = new Size(130, 40);
            btnXoaDong.TabIndex = 7;
            btnXoaDong.Text = "Xóa dòng";
            btnXoaDong.UseVisualStyleBackColor = true;
            btnXoaDong.Click += btnXoaDong_Click;
            // 
            // btnXoaTatCa
            // 
            btnXoaTatCa.Location = new Point(470, 340);
            btnXoaTatCa.Name = "btnXoaTatCa";
            btnXoaTatCa.Size = new Size(130, 40);
            btnXoaTatCa.TabIndex = 8;
            btnXoaTatCa.Text = "Xóa toàn bộ";
            btnXoaTatCa.UseVisualStyleBackColor = true;
            btnXoaTatCa.Click += btnXoaTatCa_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1055, 444);
            Controls.Add(grpNhapLieu);
            Controls.Add(grpDanhSach);
            Controls.Add(btnThemMoi);
            Controls.Add(btnCapNhat);
            Controls.Add(btnXoaDong);
            Controls.Add(btnXoaTatCa);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý danh mục Vật tư / Linh kiện";
            grpNhapLieu.ResumeLayout(false);
            grpNhapLieu.PerformLayout();
            grpDanhSach.ResumeLayout(false);
            ResumeLayout(false);
        }

        private GroupBox grpNhapLieu;
        private Label lblMaVT;
        private TextBox txtMaVT;
        private Label lblTenVT;
        private TextBox txtTenVT;
        private Label lblDonVi;
        private ComboBox cboDonVi;
        private Label lblDonGia;
        private TextBox txtDonGia;

        private GroupBox grpDanhSach;
        private ListView lvVatTu;

        private Button btnThemMoi;
        private Button btnCapNhat;
        private Button btnXoaDong;
        private Button btnXoaTatCa;
    }


}
