using System.Drawing;
using System.Windows.Forms;

namespace bai4
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
            tableLayoutPanel = new TableLayoutPanel();
            lblSoViTri = new Label();
            lblTamTinh = new Label();
            lblKhungGio = new Label();
            cboKhungGio = new ComboBox();
            btnXacNhan = new Button();
            btnHuyTatCa = new Button();
            lblChuThich = new Label();

            SuspendLayout();

            // tableLayoutPanel
            tableLayoutPanel.ColumnCount = 5;
            tableLayoutPanel.RowCount = 4;
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));

            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));

            tableLayoutPanel.Location = new Point(30, 80);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.Size = new Size(740, 300);
            tableLayoutPanel.TabIndex = 0;

            // lblSoViTri
            lblSoViTri.AutoSize = true;
            lblSoViTri.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblSoViTri.Location = new Point(30, 25);
            lblSoViTri.Name = "lblSoViTri";
            lblSoViTri.Size = new Size(180, 23);
            lblSoViTri.Text = "Số vị trí đang chọn: 0";

            // lblTamTinh
            lblTamTinh.AutoSize = true;
            lblTamTinh.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTamTinh.Location = new Point(250, 25);
            lblTamTinh.Name = "lblTamTinh";
            lblTamTinh.Size = new Size(170, 23);
            lblTamTinh.Text = "Tạm tính tiền: 0đ";

            // lblKhungGio
            lblKhungGio.AutoSize = true;
            lblKhungGio.Location = new Point(470, 28);
            lblKhungGio.Name = "lblKhungGio";
            lblKhungGio.Text = "Khung giờ:";

            // cboKhungGio
            cboKhungGio.DropDownStyle = ComboBoxStyle.DropDownList;
            cboKhungGio.FormattingEnabled = true;
            cboKhungGio.Location = new Point(545, 25);
            cboKhungGio.Name = "cboKhungGio";
            cboKhungGio.Size = new Size(225, 28);
            cboKhungGio.TabIndex = 1;
            cboKhungGio.SelectedIndexChanged += cboKhungGio_SelectedIndexChanged;

            // lblChuThich
            lblChuThich.AutoSize = true;
            lblChuThich.Location = new Point(30, 400);
            lblChuThich.Name = "lblChuThich";
            lblChuThich.Text = "Trống: Trắng/Xám nhạt    Đang chọn: Xanh lá    Đã đặt/Khóa: Đỏ";

            // btnXacNhan
            btnXacNhan.Location = new Point(450, 395);
            btnXacNhan.Name = "btnXacNhan";
            btnXacNhan.Size = new Size(150, 40);
            btnXacNhan.TabIndex = 2;
            btnXacNhan.Text = "Xác nhận đặt";
            btnXacNhan.UseVisualStyleBackColor = true;
            btnXacNhan.Click += btnXacNhan_Click;

            // btnHuyTatCa
            btnHuyTatCa.Location = new Point(610, 395);
            btnHuyTatCa.Name = "btnHuyTatCa";
            btnHuyTatCa.Size = new Size(160, 40);
            btnHuyTatCa.TabIndex = 3;
            btnHuyTatCa.Text = "Hủy chọn tất cả";
            btnHuyTatCa.UseVisualStyleBackColor = true;
            btnHuyTatCa.Click += btnHuyTatCa_Click;

            // Form1
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 460);
            Controls.Add(lblSoViTri);
            Controls.Add(lblTamTinh);
            Controls.Add(lblKhungGio);
            Controls.Add(cboKhungGio);
            Controls.Add(tableLayoutPanel);
            Controls.Add(lblChuThich);
            Controls.Add(btnXacNhan);
            Controls.Add(btnHuyTatCa);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Interactive Slot Booking";

            ResumeLayout(false);
            PerformLayout();
        }

        private TableLayoutPanel tableLayoutPanel;

        private Label lblSoViTri;
        private Label lblTamTinh;
        private Label lblKhungGio;
        private Label lblChuThich;

        private ComboBox cboKhungGio;

        private Button btnXacNhan;
        private Button btnHuyTatCa;
    }

}
