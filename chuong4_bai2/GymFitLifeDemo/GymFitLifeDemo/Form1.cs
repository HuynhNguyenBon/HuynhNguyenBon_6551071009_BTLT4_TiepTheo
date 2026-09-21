namespace GymFitLifeDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            toolTip1.AutoPopDelay = 5000;
            toolTip1.InitialDelay = 500;
            toolTip1.ReshowDelay = 100;
            toolTip1.ShowAlways = true;
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if (txtHoTen.Text == "" || txtSDT.Text == "")
            {
                MessageBox.Show(
                    "Vui lòng nhập đầy đủ Họ tên và Số điện thoại",
                    "Cảnh báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
            else
            {
                string thongTin =
                    "Họ tên: " + txtHoTen.Text +
                    "\nSố điện thoại: " + txtSDT.Text +
                    "\nGói tập: " + cboGoiTap.Text +
                    "\nSố buổi/tuần: " + numSoBuoiTuan.Value;

                MessageBox.Show(
                    thongTin,
                    "Thông tin đăng ký",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
        }
    }
}
