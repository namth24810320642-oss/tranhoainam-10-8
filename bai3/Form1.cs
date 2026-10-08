using System;
using System.Windows.Forms;

namespace bai3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        cboDonVi.Items.Add("Cái");
            cboDonVi.Items.Add("Bộ");
            cboDonVi.Items.Add("Kg");
            cboDonVi.Items.Add("Mét");

            cboDonVi.SelectedIndex = 0;
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaVT.Text) ||
                string.IsNullOrWhiteSpace(txtTenVT.Text) ||
                string.IsNullOrWhiteSpace(txtDonGia.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            if (!double.TryParse(txtDonGia.Text, out double donGia))
            {
                MessageBox.Show("Đơn giá phải là số!");
                return;
            }

            if (donGia < 0)
            {
                MessageBox.Show("Đơn giá không hợp lệ!");
                return;
            }

            foreach (ListViewItem item in lvVatTu.Items)
            {
                if (item.SubItems[0].Text.Equals(
                    txtMaVT.Text.Trim(),
                    StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show("Mã vật tư đã tồn tại!");
                    return;
                }
            }

            ListViewItem newItem = new ListViewItem(txtMaVT.Text.Trim());

            newItem.SubItems.Add(txtTenVT.Text.Trim());
            newItem.SubItems.Add(cboDonVi.Text);
            newItem.SubItems.Add(donGia.ToString("N0"));

            lvVatTu.Items.Add(newItem);

            XoaTrang();
        }

        private void lvVatTu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvVatTu.SelectedItems.Count == 0)
                return;

            ListViewItem item = lvVatTu.SelectedItems[0];

            txtMaVT.Text = item.SubItems[0].Text;
            txtTenVT.Text = item.SubItems[1].Text;
            cboDonVi.Text = item.SubItems[2].Text;
            txtDonGia.Text = item.SubItems[3].Text.Replace(",", "");
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (lvVatTu.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn vật tư cần cập nhật!");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtMaVT.Text) ||
                string.IsNullOrWhiteSpace(txtTenVT.Text) ||
                string.IsNullOrWhiteSpace(txtDonGia.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            if (!double.TryParse(txtDonGia.Text, out double donGia))
            {
                MessageBox.Show("Đơn giá phải là số!");
                return;
            }

            if (donGia < 0)
            {
                MessageBox.Show("Đơn giá không hợp lệ!");
                return;
            }

            ListViewItem item = lvVatTu.SelectedItems[0];

            item.SubItems[0].Text = txtMaVT.Text.Trim();
            item.SubItems[1].Text = txtTenVT.Text.Trim();
            item.SubItems[2].Text = cboDonVi.Text;
            item.SubItems[3].Text = donGia.ToString("N0");

            XoaTrang();
        }

        private void btnXoaDong_Click(object sender, EventArgs e)
        {
            if (lvVatTu.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn dòng cần xóa!");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn xóa dòng này?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                lvVatTu.Items.Remove(lvVatTu.SelectedItems[0]);
                XoaTrang();
            }
        }

        private void btnXoaTatCa_Click(object sender, EventArgs e)
        {
            if (lvVatTu.Items.Count == 0)
                return;

            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn xóa toàn bộ danh sách?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                lvVatTu.Items.Clear();
                XoaTrang();
            }
        }

        private void XoaTrang()
        {
            txtMaVT.Clear();
            txtTenVT.Clear();
            txtDonGia.Clear();

            cboDonVi.SelectedIndex = 0;

            lvVatTu.SelectedItems.Clear();

            txtMaVT.Focus();
        }
    }

}
