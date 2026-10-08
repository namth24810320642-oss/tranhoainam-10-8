
namespace bai1
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
            dongia = new TextBox();
            soluong = new TextBox();
            magiam = new TextBox();
            tongtien = new Label();
            tinhtien = new Button();
            lammoi = new Button();
            SuspendLayout();

            dongia.Location = new Point(80, 80);
            dongia.Name = "dongia";
            dongia.Size = new Size(150, 27);
            dongia.TabIndex = 0;
            dongia.PlaceholderText = "Đơn giá dịch vụ";

            soluong.Location = new Point(260, 80);
            soluong.Name = "soluong";
            soluong.Size = new Size(150, 27);
            soluong.TabIndex = 1;
            soluong.PlaceholderText = "Số lượng khách";

            magiam.Location = new Point(440, 80);
            magiam.Name = "magiam";
            magiam.Size = new Size(150, 27);
            magiam.TabIndex = 2;
            magiam.PlaceholderText = "% giảm giá";

            tongtien.AutoSize = true;
            tongtien.Location = new Point(80, 150);
            tongtien.Name = "tongtien";
            tongtien.Size = new Size(200, 20);
            tongtien.TabIndex = 3;
            tongtien.Text = "Tổng tiền: 0 VNĐ";

            tinhtien.Location = new Point(220, 200);
            tinhtien.Name = "tinhtien";
            tinhtien.Size = new Size(100, 30);
            tinhtien.TabIndex = 4;
            tinhtien.Text = "Tính tiền";
            tinhtien.UseVisualStyleBackColor = true;
            tinhtien.Click += tinhtien_Click;

            lammoi.Location = new Point(350, 200);
            lammoi.Name = "lammoi";
            lammoi.Size = new Size(100, 30);
            lammoi.TabIndex = 5;
            lammoi.Text = "Làm mới";
            lammoi.UseVisualStyleBackColor = true;
            lammoi.Click += lammoi_Click;

            AcceptButton = tinhtien;

            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 300);
            Controls.Add(lammoi);
            Controls.Add(tinhtien);
            Controls.Add(tongtien);
            Controls.Add(magiam);
            Controls.Add(soluong);
            Controls.Add(dongia);
            Name = "Form1";
            Text = "Máy tính tính cước dịch vụ & Giảm giá";

            ResumeLayout(false);
            PerformLayout();
        }

        private TextBox dongia;
        private TextBox soluong;
        private TextBox magiam;
        private Label tongtien;
        private Button tinhtien;
        private Button lammoi;
    }
}

