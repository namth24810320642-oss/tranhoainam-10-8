
namespace bai2
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

        private void InitializeComponent()
        {
            txtMaPhieu = new TextBox();
            txtNguoiYeuCau = new TextBox();
            dtpNgayGhiNhan = new DateTimePicker();

            grpUuTien = new GroupBox();
            rdoThap = new RadioButton();
            rdoTrungBinh = new RadioButton();
            rdoKhanCap = new RadioButton();

            cboLoaiSuCo = new ComboBox();

            grpThietBi = new GroupBox();
            chkMayTinhBan = new CheckBox();
            chkLaptop = new CheckBox();
            chkMayIn = new CheckBox();
            chkDienThoai = new CheckBox();

            picAnhLoi = new PictureBox();

            btnTaiAnh = new Button();
            btnGuiYeuCau = new Button();
            btnNhapLai = new Button();

            lblMaPhieu = new Label();
            lblNguoiYeuCau = new Label();
            lblNgayGhiNhan = new Label();
            lblLoaiSuCo = new Label();
            lblAnhLoi = new Label();

            grpUuTien.SuspendLayout();
            grpThietBi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picAnhLoi).BeginInit();
            SuspendLayout();

            // lblMaPhieu
            lblMaPhieu.AutoSize = true;
            lblMaPhieu.Location = new Point(30, 30);
            lblMaPhieu.Text = "Mã phiếu:";

            // txtMaPhieu
            txtMaPhieu.Location = new Point(150, 27);
            txtMaPhieu.Size = new Size(220, 27);
            txtMaPhieu.TabIndex = 0;

            // lblNguoiYeuCau
            lblNguoiYeuCau.AutoSize = true;
            lblNguoiYeuCau.Location = new Point(30, 75);
            lblNguoiYeuCau.Text = "Người yêu cầu:";

            // txtNguoiYeuCau
            txtNguoiYeuCau.Location = new Point(150, 72);
            txtNguoiYeuCau.Size = new Size(220, 27);
            txtNguoiYeuCau.TabIndex = 1;

            // lblNgayGhiNhan
            lblNgayGhiNhan.AutoSize = true;
            lblNgayGhiNhan.Location = new Point(30, 120);
            lblNgayGhiNhan.Text = "Ngày ghi nhận:";

            // dtpNgayGhiNhan
            dtpNgayGhiNhan.Location = new Point(150, 117);
            dtpNgayGhiNhan.Size = new Size(220, 27);
            dtpNgayGhiNhan.TabIndex = 2;

            // grpUuTien
            grpUuTien.Location = new Point(30, 165);
            grpUuTien.Size = new Size(340, 100);
            grpUuTien.Text = "Mức độ ưu tiên";

            // rdoThap
            rdoThap.AutoSize = true;
            rdoThap.Location = new Point(15, 30);
            rdoThap.Text = "Thấp";
            rdoThap.Checked = true;

            // rdoTrungBinh
            rdoTrungBinh.AutoSize = true;
            rdoTrungBinh.Location = new Point(100, 30);
            rdoTrungBinh.Text = "Trung bình";

            // rdoKhanCap
            rdoKhanCap.AutoSize = true;
            rdoKhanCap.Location = new Point(220, 30);
            rdoKhanCap.Text = "Khẩn cấp";

            grpUuTien.Controls.Add(rdoThap);
            grpUuTien.Controls.Add(rdoTrungBinh);
            grpUuTien.Controls.Add(rdoKhanCap);

            // lblLoaiSuCo
            lblLoaiSuCo.AutoSize = true;
            lblLoaiSuCo.Location = new Point(420, 30);
            lblLoaiSuCo.Text = "Loại sự cố:";

            // cboLoaiSuCo
            cboLoaiSuCo.DropDownStyle = ComboBoxStyle.DropDownList;
            cboLoaiSuCo.Location = new Point(520, 27);
            cboLoaiSuCo.Size = new Size(220, 28);
            cboLoaiSuCo.TabIndex = 3;

            // grpThietBi
            grpThietBi.Location = new Point(420, 75);
            grpThietBi.Size = new Size(320, 190);
            grpThietBi.Text = "Thiết bị ảnh hưởng";

            // chkMayTinhBan
            chkMayTinhBan.AutoSize = true;
            chkMayTinhBan.Location = new Point(20, 30);
            chkMayTinhBan.Text = "Máy tính bàn";

            // chkLaptop
            chkLaptop.AutoSize = true;
            chkLaptop.Location = new Point(20, 65);
            chkLaptop.Text = "Laptop";

            // chkMayIn
            chkMayIn.AutoSize = true;
            chkMayIn.Location = new Point(20, 100);
            chkMayIn.Text = "Máy in";

            // chkDienThoai
            chkDienThoai.AutoSize = true;
            chkDienThoai.Location = new Point(20, 135);
            chkDienThoai.Text = "Điện thoại";

            grpThietBi.Controls.Add(chkMayTinhBan);
            grpThietBi.Controls.Add(chkLaptop);
            grpThietBi.Controls.Add(chkMayIn);
            grpThietBi.Controls.Add(chkDienThoai);

            // lblAnhLoi
            lblAnhLoi.AutoSize = true;
            lblAnhLoi.Location = new Point(30, 300);
            lblAnhLoi.Text = "Ảnh chụp lỗi:";

            // picAnhLoi
            picAnhLoi.Location = new Point(150, 295);
            picAnhLoi.Size = new Size(220, 130);
            picAnhLoi.SizeMode = PictureBoxSizeMode.StretchImage;
            picAnhLoi.BorderStyle = BorderStyle.FixedSingle;

            // btnTaiAnh
            btnTaiAnh.Location = new Point(390, 340);
            btnTaiAnh.Size = new Size(120, 35);
            btnTaiAnh.Text = "Tải ảnh lỗi";
            btnTaiAnh.Click += btnTaiAnh_Click;

            // btnGuiYeuCau
            btnGuiYeuCau.Location = new Point(530, 340);
            btnGuiYeuCau.Size = new Size(120, 35);
            btnGuiYeuCau.Text = "Gửi yêu cầu";
            btnGuiYeuCau.Click += btnGuiYeuCau_Click;

            // btnNhapLai
            btnNhapLai.Location = new Point(670, 340);
            btnNhapLai.Size = new Size(100, 35);
            btnNhapLai.Text = "Nhập lại";
            btnNhapLai.Click += btnNhapLai_Click;

            // Form1
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 470);
            Controls.Add(lblMaPhieu);
            Controls.Add(txtMaPhieu);
            Controls.Add(lblNguoiYeuCau);
            Controls.Add(txtNguoiYeuCau);
            Controls.Add(lblNgayGhiNhan);
            Controls.Add(dtpNgayGhiNhan);
            Controls.Add(grpUuTien);
            Controls.Add(lblLoaiSuCo);
            Controls.Add(cboLoaiSuCo);
            Controls.Add(grpThietBi);
            Controls.Add(lblAnhLoi);
            Controls.Add(picAnhLoi);
            Controls.Add(btnTaiAnh);
            Controls.Add(btnGuiYeuCau);
            Controls.Add(btnNhapLai);

            Name = "Form1";
            Text = "IT Support Ticket Form";
            StartPosition = FormStartPosition.CenterScreen;

            grpUuTien.ResumeLayout(false);
            grpUuTien.PerformLayout();

            grpThietBi.ResumeLayout(false);
            grpThietBi.PerformLayout();

            ((System.ComponentModel.ISupportInitialize)picAnhLoi).EndInit();

            ResumeLayout(false);
            PerformLayout();
        }

        private TextBox txtMaPhieu;
        private TextBox txtNguoiYeuCau;
        private DateTimePicker dtpNgayGhiNhan;

        private GroupBox grpUuTien;
        private RadioButton rdoThap;
        private RadioButton rdoTrungBinh;
        private RadioButton rdoKhanCap;

        private ComboBox cboLoaiSuCo;

        private GroupBox grpThietBi;
        private CheckBox chkMayTinhBan;
        private CheckBox chkLaptop;
        private CheckBox chkMayIn;
        private CheckBox chkDienThoai;

        private PictureBox picAnhLoi;

        private Button btnTaiAnh;
        private Button btnGuiYeuCau;
        private Button btnNhapLai;

        private Label lblMaPhieu;
        private Label lblNguoiYeuCau;
        private Label lblNgayGhiNhan;
        private Label lblLoaiSuCo;
        private Label lblAnhLoi;
    }
}




