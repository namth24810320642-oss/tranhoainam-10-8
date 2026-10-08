using System;
using System.Drawing;
using System.Windows.Forms;

namespace bai4
{
    public partial class Form1 : Form
    {
        private const int SoViTri = 20;
        private const decimal GiaBuoiSang = 100000;
        private const decimal GiaBuoiToi = 150000;


    public Form1()
        {
            InitializeComponent();
            Load += Form1_Load;
        }

        private void Form1_Load(object? sender, EventArgs e)
        {
            cboKhungGio.Items.Add("Sáng - 100.000đ");
            cboKhungGio.Items.Add("Tối - 150.000đ");
            cboKhungGio.SelectedIndex = 0;

            TaoViTri();
            CapNhatThongKe();
        }

        private void TaoViTri()
        {
            for (int i = 1; i <= SoViTri; i++)
            {
                Button btn = new Button();

                btn.Name = "btnViTri" + i;
                btn.Text = "Vị trí " + i;
                btn.Dock = DockStyle.Fill;
                btn.Margin = new Padding(5);
                btn.BackColor = Color.WhiteSmoke;
                btn.Tag = "Trong";

                btn.Click += ViTri_Click;

                tableLayoutPanel.Controls.Add(btn);
            }

            Button? viTri5 = tableLayoutPanel.Controls["btnViTri5"] as Button;
            Button? viTri12 = tableLayoutPanel.Controls["btnViTri12"] as Button;
            Button? viTri18 = tableLayoutPanel.Controls["btnViTri18"] as Button;

            if (viTri5 != null)
            {
                viTri5.BackColor = Color.Red;
                viTri5.ForeColor = Color.White;
                viTri5.Tag = "DaDat";
            }

            if (viTri12 != null)
            {
                viTri12.BackColor = Color.Red;
                viTri12.ForeColor = Color.White;
                viTri12.Tag = "DaDat";
            }

            if (viTri18 != null)
            {
                viTri18.BackColor = Color.Red;
                viTri18.ForeColor = Color.White;
                viTri18.Tag = "DaDat";
            }
        }

        private void ViTri_Click(object? sender, EventArgs e)
        {
            if (sender is not Button btn)
                return;

            string trangThai = btn.Tag?.ToString() ?? "Trong";

            if (trangThai == "DaDat")
            {
                MessageBox.Show("Vị trí này đã có người đặt hoặc đã bị khóa!");
                return;
            }

            if (trangThai == "Trong")
            {
                btn.Tag = "DangChon";
                btn.BackColor = Color.LightGreen;
            }
            else if (trangThai == "DangChon")
            {
                btn.Tag = "Trong";
                btn.BackColor = Color.WhiteSmoke;
            }

            CapNhatThongKe();
        }

        private decimal LayGia()
        {
            if (cboKhungGio.SelectedIndex == 1)
                return GiaBuoiToi;

            return GiaBuoiSang;
        }

        private void CapNhatThongKe()
        {
            int soLuong = 0;

            foreach (Control control in tableLayoutPanel.Controls)
            {
                if (control is Button btn &&
                    btn.Tag?.ToString() == "DangChon")
                {
                    soLuong++;
                }
            }

            decimal tongTien = soLuong * LayGia();

            lblSoViTri.Text = "Số vị trí đang chọn: " + soLuong;
            lblTamTinh.Text = "Tạm tính tiền: " +
                              tongTien.ToString("N0") + "đ";
        }

        private void cboKhungGio_SelectedIndexChanged(
            object? sender, EventArgs e)
        {
            CapNhatThongKe();
        }

        private void btnXacNhan_Click(object? sender, EventArgs e)
        {
            int soLuong = 0;

            foreach (Control control in tableLayoutPanel.Controls)
            {
                if (control is Button btn &&
                    btn.Tag?.ToString() == "DangChon")
                {
                    soLuong++;
                }
            }

            if (soLuong == 0)
            {
                MessageBox.Show("Vui lòng chọn ít nhất một vị trí!");
                return;
            }

            decimal tongTien = soLuong * LayGia();

            DialogResult result = MessageBox.Show(
                "Số vị trí: " + soLuong +
                "\nKhung giờ: " + cboKhungGio.Text +
                "\nTổng tiền: " + tongTien.ToString("N0") + "đ" +
                "\n\nBạn có chắc chắn muốn đặt?",
                "Xác nhận đặt",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                foreach (Control control in tableLayoutPanel.Controls)
                {
                    if (control is Button btn &&
                        btn.Tag?.ToString() == "DangChon")
                    {
                        btn.Tag = "DaDat";
                        btn.BackColor = Color.Red;
                        btn.ForeColor = Color.White;
                    }
                }

                CapNhatThongKe();

                MessageBox.Show(
                    "Đặt vị trí thành công!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void btnHuyTatCa_Click(object? sender, EventArgs e)
        {
            foreach (Control control in tableLayoutPanel.Controls)
            {
                if (control is Button btn &&
                    btn.Tag?.ToString() == "DangChon")
                {
                    btn.Tag = "Trong";
                    btn.BackColor = Color.WhiteSmoke;
                    btn.ForeColor = Color.Black;
                }
            }

            CapNhatThongKe();
        }
    }


}
