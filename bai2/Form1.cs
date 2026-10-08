

namespace bai2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            cboLoaiSuCo.Items.Add("Phần cứng");
            cboLoaiSuCo.Items.Add("Phần mềm");
            cboLoaiSuCo.Items.Add("Mạng");
            cboLoaiSuCo.Items.Add("Tài khoản");

            cboLoaiSuCo.SelectedIndex = 0;
        }

        private void btnTaiAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "Image Files|*.jpg;*.png";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                picAnhLoi.Image = Image.FromFile(openFileDialog.FileName);
            }
        }

        private void btnGuiYeuCau_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaPhieu.Text))
            {
                MessageBox.Show("Vui lòng nhập mã phiếu!");
                txtMaPhieu.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNguoiYeuCau.Text))
            {
                MessageBox.Show("Vui lòng nhập người yêu cầu!");
                txtNguoiYeuCau.Focus();
                return;
            }

            string mucDo = "";

            if (rdoThap.Checked)
                mucDo = "Thấp";
            else if (rdoTrungBinh.Checked)
                mucDo = "Trung bình";
            else if (rdoKhanCap.Checked)
                mucDo = "Khẩn cấp";

            string thietBi = "";

            if (chkMayTinhBan.Checked)
                thietBi += "Máy tính bàn, ";

            if (chkLaptop.Checked)
                thietBi += "Laptop, ";

            if (chkMayIn.Checked)
                thietBi += "Máy in, ";

            if (chkDienThoai.Checked)
                thietBi += "Điện thoại, ";

            if (thietBi == "")
                thietBi = "Không có";

            string anh = picAnhLoi.Image != null
                ? "Đã tải ảnh"
                : "Chưa có ảnh";

            string thongTin =
                "===== THÔNG TIN PHIẾU =====\n\n" +
                "Mã phiếu: " + txtMaPhieu.Text + "\n" +
                "Người yêu cầu: " + txtNguoiYeuCau.Text + "\n" +
                "Ngày ghi nhận: " +
                dtpNgayGhiNhan.Value.ToString("dd/MM/yyyy") + "\n" +
                "Mức độ ưu tiên: " + mucDo + "\n" +
                "Loại sự cố: " + cboLoaiSuCo.Text + "\n" +
                "Thiết bị ảnh hưởng: " +
                thietBi.TrimEnd(',', ' ') + "\n" +
                "Ảnh lỗi: " + anh;

            MessageBox.Show(thongTin, "Tóm tắt yêu cầu");
        }

        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            txtMaPhieu.Clear();
            txtNguoiYeuCau.Clear();

            dtpNgayGhiNhan.Value = DateTime.Now;

            rdoThap.Checked = true;

            cboLoaiSuCo.SelectedIndex = 0;

            chkMayTinhBan.Checked = false;
            chkLaptop.Checked = false;
            chkMayIn.Checked = false;
            chkDienThoai.Checked = false;

            picAnhLoi.Image = null;

            txtMaPhieu.Focus();
        }
    }
}

