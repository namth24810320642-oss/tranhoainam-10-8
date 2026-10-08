using System;
using System.Windows.Forms;

namespace bai5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


            txtTenKhachHang.TextChanged += txtTenKhachHang_TextChanged;
            dgvHangHoa.CellValueChanged += dgvHangHoa_CellValueChanged;
            dgvHangHoa.CellValidating += dgvHangHoa_CellValidating;
            dgvHangHoa.RowsRemoved += dgvHangHoa_RowsRemoved;
            dgvHangHoa.CurrentCellDirtyStateChanged += dgvHangHoa_CurrentCellDirtyStateChanged;

            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            timer1.Start();

            KeyPreview = true;
            KeyDown += Form1_KeyDown;

            CapNhatTong();
        }

        private void txtTenKhachHang_TextChanged(object? sender, EventArgs e)
        {
            errorProvider1.SetError(txtTenKhachHang, "");
        }

        private void dgvHangHoa_CurrentCellDirtyStateChanged(
            object? sender, EventArgs e)
        {
            if (dgvHangHoa.IsCurrentCellDirty)
            {
                dgvHangHoa.CommitEdit(
                    DataGridViewDataErrorContexts.Commit);
            }
        }

        private void dgvHangHoa_CellValueChanged(
            object? sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            TinhThanhTien(e.RowIndex);
            KiemTraDong(e.RowIndex);
            CapNhatTong();
        }

        private void TinhThanhTien(int rowIndex)
        {
            if (rowIndex < 0 ||
                rowIndex >= dgvHangHoa.Rows.Count)
                return;

            DataGridViewRow row = dgvHangHoa.Rows[rowIndex];

            if (row.IsNewRow)
                return;

            decimal soLuong =
                LaySoDecimal(row.Cells["colSoLuong"].Value);

            decimal donGia =
                LaySoDecimal(row.Cells["colDonGia"].Value);

            row.Cells["colThanhTien"].Value =
                (soLuong * donGia).ToString("N0");
        }

        private decimal LaySoDecimal(object? value)
        {
            if (value == null)
                return 0;

            string text = value.ToString() ?? "";

            if (decimal.TryParse(text, out decimal result))
                return result;

            return 0;
        }

        private void KiemTraDong(int rowIndex)
        {
            if (rowIndex < 0 ||
                rowIndex >= dgvHangHoa.Rows.Count)
                return;

            DataGridViewRow row = dgvHangHoa.Rows[rowIndex];

            if (row.IsNewRow)
                return;

            decimal soLuong =
                LaySoDecimal(row.Cells["colSoLuong"].Value);

            decimal trongLuong =
                LaySoDecimal(row.Cells["colTrongLuong"].Value);

            row.Cells["colSoLuong"].ErrorText =
                soLuong <= 0
                    ? "Số lượng phải lớn hơn 0."
                    : "";

            row.Cells["colTrongLuong"].ErrorText =
                trongLuong <= 0
                    ? "Trọng lượng phải lớn hơn 0."
                    : "";
        }

        private void dgvHangHoa_CellValidating(
            object? sender,
            DataGridViewCellValidatingEventArgs e)
        {
            if (e.RowIndex < 0 ||
                e.RowIndex >= dgvHangHoa.Rows.Count)
                return;

            DataGridViewRow row =
                dgvHangHoa.Rows[e.RowIndex];

            if (row.IsNewRow)
                return;

            string value =
                e.FormattedValue?.ToString() ?? "";

            if (e.ColumnIndex == colSoLuong.Index)
            {
                if (!decimal.TryParse(value, out decimal soLuong) ||
                    soLuong <= 0)
                {
                    row.Cells[e.ColumnIndex].ErrorText =
                        "Số lượng phải lớn hơn 0.";
                }
                else
                {
                    row.Cells[e.ColumnIndex].ErrorText = "";
                }
            }

            if (e.ColumnIndex == colTrongLuong.Index)
            {
                if (!decimal.TryParse(value, out decimal trongLuong) ||
                    trongLuong <= 0)
                {
                    row.Cells[e.ColumnIndex].ErrorText =
                        "Trọng lượng phải lớn hơn 0.";
                }
                else
                {
                    row.Cells[e.ColumnIndex].ErrorText = "";
                }
            }
        }

        private void dgvHangHoa_RowsRemoved(
            object? sender,
            DataGridViewRowsRemovedEventArgs e)
        {
            CapNhatTong();
        }

        private void CapNhatTong()
        {
            decimal tongSoLuong = 0;
            decimal tongTrongLuong = 0;
            decimal tongTien = 0;

            foreach (DataGridViewRow row in dgvHangHoa.Rows)
            {
                if (row.IsNewRow)
                    continue;

                decimal soLuong =
                    LaySoDecimal(row.Cells["colSoLuong"].Value);

                decimal trongLuong =
                    LaySoDecimal(row.Cells["colTrongLuong"].Value);

                decimal thanhTien =
                    LaySoDecimal(row.Cells["colThanhTien"].Value);

                tongSoLuong += soLuong;
                tongTrongLuong += soLuong * trongLuong;
                tongTien += thanhTien;
            }

            lblTongSoLuong.Text =
                "Tổng SL: " + tongSoLuong.ToString("N0");

            lblTongTrongLuong.Text =
                "Tổng trọng lượng: " +
                tongTrongLuong.ToString("N2") + " kg";

            lblTongTien.Text =
                "Tổng tiền: " +
                tongTien.ToString("N0") + " đ";
        }

        private void timer1_Tick(object? sender, EventArgs e)
        {
            lblThoiGian.Text =
                "Thời gian: " +
                DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void Form1_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                int rowIndex = dgvHangHoa.Rows.Add();

                dgvHangHoa.CurrentCell =
                    dgvHangHoa.Rows[rowIndex].Cells[colTenHang.Index];

                dgvHangHoa.BeginEdit(true);

                e.Handled = true;
            }

            if (e.KeyCode == Keys.Delete)
            {
                DataGridViewRow? row =
                    dgvHangHoa.CurrentRow;

                if (row != null && !row.IsNewRow)
                {
                    dgvHangHoa.Rows.Remove(row);
                    CapNhatTong();
                }

                e.Handled = true;
            }
        }

        private void btnThemDong_Click(
            object? sender,
            EventArgs e)
        {
            int rowIndex = dgvHangHoa.Rows.Add();

            dgvHangHoa.CurrentCell =
                dgvHangHoa.Rows[rowIndex].Cells[colTenHang.Index];

            dgvHangHoa.BeginEdit(true);
        }

        private void btnXoaDong_Click(
            object? sender,
            EventArgs e)
        {
            DataGridViewRow? row =
                dgvHangHoa.CurrentRow;

            if (row == null || row.IsNewRow)
            {
                MessageBox.Show("Vui lòng chọn dòng cần xóa!");
                return;
            }

            dgvHangHoa.Rows.Remove(row);
            CapNhatTong();
        }

        private void btnLuuDon_Click(
            object? sender,
            EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenKhachHang.Text))
            {
                errorProvider1.SetError(
                    txtTenKhachHang,
                    "Vui lòng nhập tên khách hàng!");

                txtTenKhachHang.Focus();
                return;
            }

            foreach (DataGridViewRow row in dgvHangHoa.Rows)
            {
                if (row.IsNewRow)
                    continue;

                KiemTraDong(row.Index);

                decimal soLuong =
                    LaySoDecimal(row.Cells["colSoLuong"].Value);

                decimal trongLuong =
                    LaySoDecimal(row.Cells["colTrongLuong"].Value);

                if (soLuong <= 0 || trongLuong <= 0)
                {
                    MessageBox.Show(
                        "Có dòng hàng chưa hợp lệ!\n" +
                        "Số lượng và trọng lượng phải lớn hơn 0.");

                    return;
                }
            }

            MessageBox.Show(
                "Đã lưu đơn giao hàng thành công!",
                "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }
    }

}
