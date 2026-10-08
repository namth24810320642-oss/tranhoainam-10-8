using System.Drawing;
using System.Windows.Forms;

namespace bai5
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
            components = new System.ComponentModel.Container();
            splitContainer1 = new SplitContainer();
            tabControl1 = new TabControl();
            tabKhachHang = new TabPage();
            btnXoaDong = new Button();
            btnThemDong = new Button();
            dgvHangHoa = new DataGridView();
            colTenHang = new DataGridViewTextBoxColumn();
            colSoLuong = new DataGridViewTextBoxColumn();
            colTrongLuong = new DataGridViewTextBoxColumn();
            colDonGia = new DataGridViewTextBoxColumn();
            colThanhTien = new DataGridViewTextBoxColumn();
            lblTenKhachHang = new Label();
            txtTenKhachHang = new TextBox();
            lblSoDienThoai = new Label();
            txtSoDienThoai = new TextBox();
            lblDiaChi = new Label();
            txtDiaChi = new TextBox();
            tabVanChuyen = new TabPage();
            lblLoaiVanChuyen = new Label();
            cboLoaiVanChuyen = new ComboBox();
            btnLuuDon = new Button();
            statusStrip1 = new StatusStrip();
            lblThoiGian = new ToolStripStatusLabel();
            lblTongSoLuong = new ToolStripStatusLabel();
            lblTongTrongLuong = new ToolStripStatusLabel();
            lblTongTien = new ToolStripStatusLabel();
            timer1 = new System.Windows.Forms.Timer(components);
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabKhachHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHangHoa).BeginInit();
            tabVanChuyen.SuspendLayout();
            statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(tabControl1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(btnLuuDon);
            splitContainer1.Size = new Size(1383, 504);
            splitContainer1.SplitterDistance = 1115;
            splitContainer1.TabIndex = 0;
            splitContainer1.SplitterMoved += splitContainer1_SplitterMoved;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabKhachHang);
            tabControl1.Controls.Add(tabVanChuyen);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1115, 504);
            tabControl1.TabIndex = 0;
            // 
            // tabKhachHang
            // 
            tabKhachHang.Controls.Add(btnXoaDong);
            tabKhachHang.Controls.Add(btnThemDong);
            tabKhachHang.Controls.Add(dgvHangHoa);
            tabKhachHang.Controls.Add(lblTenKhachHang);
            tabKhachHang.Controls.Add(txtTenKhachHang);
            tabKhachHang.Controls.Add(lblSoDienThoai);
            tabKhachHang.Controls.Add(txtSoDienThoai);
            tabKhachHang.Controls.Add(lblDiaChi);
            tabKhachHang.Controls.Add(txtDiaChi);
            tabKhachHang.Location = new Point(4, 29);
            tabKhachHang.Name = "tabKhachHang";
            tabKhachHang.Padding = new Padding(10);
            tabKhachHang.Size = new Size(1107, 471);
            tabKhachHang.TabIndex = 0;
            tabKhachHang.Text = "Khách hàng";
            tabKhachHang.UseVisualStyleBackColor = true;
            // 
            // btnXoaDong
            // 
            btnXoaDong.Location = new Point(794, 399);
            btnXoaDong.Name = "btnXoaDong";
            btnXoaDong.Size = new Size(120, 35);
            btnXoaDong.TabIndex = 5;
            btnXoaDong.Text = "Xóa dòng";
            btnXoaDong.UseVisualStyleBackColor = true;
            btnXoaDong.Click += btnXoaDong_Click;
            // 
            // btnThemDong
            // 
            btnThemDong.Location = new Point(511, 399);
            btnThemDong.Name = "btnThemDong";
            btnThemDong.Size = new Size(120, 35);
            btnThemDong.TabIndex = 4;
            btnThemDong.Text = "Thêm dòng";
            btnThemDong.UseVisualStyleBackColor = true;
            btnThemDong.Click += btnThemDong_Click;
            // 
            // dgvHangHoa
            // 
            dgvHangHoa.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHangHoa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHangHoa.Columns.AddRange(new DataGridViewColumn[] { colTenHang, colSoLuong, colTrongLuong, colDonGia, colThanhTien });
            dgvHangHoa.Location = new Point(357, 3);
            dgvHangHoa.Name = "dgvHangHoa";
            dgvHangHoa.RowHeadersWidth = 51;
            dgvHangHoa.Size = new Size(660, 390);
            dgvHangHoa.TabIndex = 3;
            // 
            // colTenHang
            // 
            colTenHang.HeaderText = "Tên hàng";
            colTenHang.MinimumWidth = 6;
            colTenHang.Name = "colTenHang";
            // 
            // colSoLuong
            // 
            colSoLuong.HeaderText = "Số lượng";
            colSoLuong.MinimumWidth = 6;
            colSoLuong.Name = "colSoLuong";
            // 
            // colTrongLuong
            // 
            colTrongLuong.HeaderText = "Trọng lượng (kg)";
            colTrongLuong.MinimumWidth = 6;
            colTrongLuong.Name = "colTrongLuong";
            // 
            // colDonGia
            // 
            colDonGia.HeaderText = "Đơn giá";
            colDonGia.MinimumWidth = 6;
            colDonGia.Name = "colDonGia";
            // 
            // colThanhTien
            // 
            colThanhTien.HeaderText = "Thành tiền";
            colThanhTien.MinimumWidth = 6;
            colThanhTien.Name = "colThanhTien";
            colThanhTien.ReadOnly = true;
            // 
            // lblTenKhachHang
            // 
            lblTenKhachHang.AutoSize = true;
            lblTenKhachHang.Location = new Point(15, 25);
            lblTenKhachHang.Name = "lblTenKhachHang";
            lblTenKhachHang.Size = new Size(114, 20);
            lblTenKhachHang.TabIndex = 0;
            lblTenKhachHang.Text = "Tên khách hàng:";
            // 
            // txtTenKhachHang
            // 
            txtTenKhachHang.Location = new Point(15, 50);
            txtTenKhachHang.Name = "txtTenKhachHang";
            txtTenKhachHang.Size = new Size(250, 27);
            txtTenKhachHang.TabIndex = 0;
            // 
            // lblSoDienThoai
            // 
            lblSoDienThoai.AutoSize = true;
            lblSoDienThoai.Location = new Point(15, 95);
            lblSoDienThoai.Name = "lblSoDienThoai";
            lblSoDienThoai.Size = new Size(100, 20);
            lblSoDienThoai.TabIndex = 1;
            lblSoDienThoai.Text = "Số điện thoại:";
            // 
            // txtSoDienThoai
            // 
            txtSoDienThoai.Location = new Point(15, 120);
            txtSoDienThoai.Name = "txtSoDienThoai";
            txtSoDienThoai.Size = new Size(250, 27);
            txtSoDienThoai.TabIndex = 1;
            // 
            // lblDiaChi
            // 
            lblDiaChi.AutoSize = true;
            lblDiaChi.Location = new Point(15, 165);
            lblDiaChi.Name = "lblDiaChi";
            lblDiaChi.Size = new Size(58, 20);
            lblDiaChi.TabIndex = 2;
            lblDiaChi.Text = "Địa chỉ:";
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(15, 190);
            txtDiaChi.Multiline = true;
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(250, 80);
            txtDiaChi.TabIndex = 2;
            // 
            // tabVanChuyen
            // 
            tabVanChuyen.Controls.Add(lblLoaiVanChuyen);
            tabVanChuyen.Controls.Add(cboLoaiVanChuyen);
            tabVanChuyen.Location = new Point(4, 29);
            tabVanChuyen.Name = "tabVanChuyen";
            tabVanChuyen.Padding = new Padding(10);
            tabVanChuyen.Size = new Size(1107, 471);
            tabVanChuyen.TabIndex = 1;
            tabVanChuyen.Text = "Vận chuyển";
            tabVanChuyen.UseVisualStyleBackColor = true;
            // 
            // lblLoaiVanChuyen
            // 
            lblLoaiVanChuyen.AutoSize = true;
            lblLoaiVanChuyen.Location = new Point(15, 30);
            lblLoaiVanChuyen.Name = "lblLoaiVanChuyen";
            lblLoaiVanChuyen.Size = new Size(117, 20);
            lblLoaiVanChuyen.TabIndex = 0;
            lblLoaiVanChuyen.Text = "Loại vận chuyển:";
            // 
            // cboLoaiVanChuyen
            // 
            cboLoaiVanChuyen.DropDownStyle = ComboBoxStyle.DropDownList;
            cboLoaiVanChuyen.FormattingEnabled = true;
            cboLoaiVanChuyen.Items.AddRange(new object[] { "Tiêu chuẩn", "Nhanh", "Hỏa tốc" });
            cboLoaiVanChuyen.Location = new Point(15, 60);
            cboLoaiVanChuyen.Name = "cboLoaiVanChuyen";
            cboLoaiVanChuyen.Size = new Size(250, 28);
            cboLoaiVanChuyen.TabIndex = 0;
            // 
            // btnLuuDon
            // 
            btnLuuDon.Location = new Point(285, 420);
            btnLuuDon.Name = "btnLuuDon";
            btnLuuDon.Size = new Size(120, 35);
            btnLuuDon.TabIndex = 6;
            btnLuuDon.Text = "Lưu đơn";
            btnLuuDon.UseVisualStyleBackColor = true;
            btnLuuDon.Click += btnLuuDon_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblThoiGian, lblTongSoLuong, lblTongTrongLuong, lblTongTien });
            statusStrip1.Location = new Point(0, 504);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1383, 26);
            statusStrip1.TabIndex = 7;
            // 
            // lblThoiGian
            // 
            lblThoiGian.Name = "lblThoiGian";
            lblThoiGian.Size = new Size(74, 20);
            lblThoiGian.Text = "Thời gian:";
            // 
            // lblTongSoLuong
            // 
            lblTongSoLuong.Name = "lblTongSoLuong";
            lblTongSoLuong.Size = new Size(77, 20);
            lblTongSoLuong.Text = "Tổng SL: 0";
            // 
            // lblTongTrongLuong
            // 
            lblTongTrongLuong.Name = "lblTongTrongLuong";
            lblTongTrongLuong.Size = new Size(161, 20);
            lblTongTrongLuong.Text = "Tổng trọng lượng: 0 kg";
            // 
            // lblTongTien
            // 
            lblTongTien.Name = "lblTongTien";
            lblTongTien.Size = new Size(100, 20);
            lblTongTien.Text = "Tổng tiền: 0 đ";
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1383, 530);
            Controls.Add(splitContainer1);
            Controls.Add(statusStrip1);
            KeyPreview = true;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bảng điều khiển Quản lý Đơn giao hàng";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabKhachHang.ResumeLayout(false);
            tabKhachHang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHangHoa).EndInit();
            tabVanChuyen.ResumeLayout(false);
            tabVanChuyen.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private SplitContainer splitContainer1;

        private TabControl tabControl1;
        private TabPage tabKhachHang;
        private TabPage tabVanChuyen;

        private Label lblTenKhachHang;
        private TextBox txtTenKhachHang;

        private Label lblSoDienThoai;
        private TextBox txtSoDienThoai;

        private Label lblDiaChi;
        private TextBox txtDiaChi;

        private Label lblLoaiVanChuyen;
        private ComboBox cboLoaiVanChuyen;

        private DataGridView dgvHangHoa;

        private DataGridViewTextBoxColumn colTenHang;
        private DataGridViewTextBoxColumn colSoLuong;
        private DataGridViewTextBoxColumn colTrongLuong;
        private DataGridViewTextBoxColumn colDonGia;
        private DataGridViewTextBoxColumn colThanhTien;

        private Button btnThemDong;
        private Button btnXoaDong;
        private Button btnLuuDon;

        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblThoiGian;
        private ToolStripStatusLabel lblTongSoLuong;
        private ToolStripStatusLabel lblTongTrongLuong;
        private ToolStripStatusLabel lblTongTien;

        private System.Windows.Forms.Timer timer1;
        private ErrorProvider errorProvider1;
    }


}
