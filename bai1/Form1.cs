
namespace bai1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tinhtien_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(dongia.Text, out double gia) ||
                !double.TryParse(soluong.Text, out double soLuong) ||
                !double.TryParse(magiam.Text, out double giam))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ và đúng dữ liệu!");
                return;
            }

            if (gia < 0 || soLuong < 0 || giam < 0 || giam > 100)
            {
                MessageBox.Show("Dữ liệu nhập không hợp lệ!");
                return;
            }

            double tong = gia * soLuong * (100 - giam) / 100;

            tongtien.Text = "Tổng tiền: " + tong.ToString("N0") + " VNĐ";
        }

        private void lammoi_Click(object sender, EventArgs e)
        {
            dongia.Clear();
            soluong.Clear();
            magiam.Clear();
            tongtien.Text = "Tổng tiền: 0 VNĐ";
            dongia.Focus();
        }
    }
}

