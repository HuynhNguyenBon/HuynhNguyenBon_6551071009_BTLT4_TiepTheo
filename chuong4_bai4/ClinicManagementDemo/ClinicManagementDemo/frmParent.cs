namespace ClinicManagementDemo
{
    public partial class frmParent : Form
    {
        public frmParent()
        {
            InitializeComponent();
        }

        private void mnuThongTinBenhNhan_Click(object sender, EventArgs e)
        {
            frmBenhNhan formBenhNhan = new frmBenhNhan();

            formBenhNhan.MdiParent = this;

            formBenhNhan.Show();
        }

        private void mnuDatLichHen_Click(object sender, EventArgs e)
        {
            frmLichHen formLichHen = new frmLichHen();

            formLichHen.MdiParent = this;

            formLichHen.Show();
        }
    }
}
