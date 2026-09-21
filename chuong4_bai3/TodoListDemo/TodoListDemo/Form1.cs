namespace TodoListDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtCongViecMoi_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmsCongViec_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtCongViecMoi.Text != "")
            {
                lstCongViec.Items.Add(txtCongViecMoi.Text);
                txtCongViecMoi.Clear();
            }
        }

        private void mnuDanhDauHoanThanh_Click(object sender, EventArgs e)
        {
            if (lstCongViec.SelectedItem != null)
            {
                string congViec = lstCongViec.SelectedItem.ToString();

                if (!congViec.StartsWith("[Hoàn thành] "))
                {
                    int viTri = lstCongViec.SelectedIndex;

                    lstCongViec.Items[viTri] = "[Hoàn thành] " + congViec;
                }
            }
        }

        private void mnuXoaCongViec_Click(object sender, EventArgs e)
        {
            if (lstCongViec.SelectedItem != null)
            {
                lstCongViec.Items.Remove(lstCongViec.SelectedItem);
            }
            else
            {
                MessageBox.Show(
                    "Vui lòng chọn công việc cần xóa.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
        }

        private void mnuXoaTatCa_Click(object sender, EventArgs e)
        {
            DialogResult ketQua = MessageBox.Show(
                "Bạn có chắc muốn xóa tất cả công việc không?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (ketQua == DialogResult.Yes)
            {
                lstCongViec.Items.Clear();
            }
        }
    }
}
