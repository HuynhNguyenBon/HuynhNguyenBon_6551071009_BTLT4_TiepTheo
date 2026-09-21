using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ClinicManagementDemo
{
    public partial class frmBenhNhan : Form
    {
        private List<string> danhSachBenhNhan = new List<string>();
        public frmBenhNhan()
        {
            InitializeComponent();
        }

        private void frmBenhNhan_Load(object sender, EventArgs e)
        {

        }

        private void btnLuuTam_Click(object sender, EventArgs e)
        {
            if (txtHoTen.Text != "")
            {
                string thongTin =
                    txtHoTen.Text +
                    " - " + numTuoi.Value +
                    " tuổi - " +
                    txtTrieuChung.Text;

                danhSachBenhNhan.Add(thongTin);

                lstBenhNhan.Items.Add(thongTin);

                txtHoTen.Clear();
                txtTrieuChung.Clear();
                numTuoi.Value = 0;
            }
            else
            {
                MessageBox.Show(
                    "Vui lòng nhập họ tên bệnh nhân.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
        }
    }
}
