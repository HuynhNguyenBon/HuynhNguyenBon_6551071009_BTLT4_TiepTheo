namespace ClinicManagementDemo
{
    partial class frmParent
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            mnuNghiepVu = new ToolStripMenuItem();
            mnuThongTinBenhNhan = new ToolStripMenuItem();
            mnuDatLichHen = new ToolStripMenuItem();
            mnuCuaSo = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { mnuNghiepVu, mnuCuaSo });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.MdiWindowListItem = mnuCuaSo;
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // mnuNghiepVu
            // 
            mnuNghiepVu.DropDownItems.AddRange(new ToolStripItem[] { mnuThongTinBenhNhan, mnuDatLichHen });
            mnuNghiepVu.Name = "mnuNghiepVu";
            mnuNghiepVu.Size = new Size(91, 24);
            mnuNghiepVu.Text = "Nghiệp vụ";
            // 
            // mnuThongTinBenhNhan
            // 
            mnuThongTinBenhNhan.Name = "mnuThongTinBenhNhan";
            mnuThongTinBenhNhan.Size = new Size(228, 26);
            mnuThongTinBenhNhan.Text = "Thông tin bệnh nhân";
            mnuThongTinBenhNhan.Click += mnuThongTinBenhNhan_Click;
            // 
            // mnuDatLichHen
            // 
            mnuDatLichHen.Name = "mnuDatLichHen";
            mnuDatLichHen.Size = new Size(228, 26);
            mnuDatLichHen.Text = "Đặt lịch hẹn";
            mnuDatLichHen.Click += mnuDatLichHen_Click;
            // 
            // mnuCuaSo
            // 
            mnuCuaSo.Name = "mnuCuaSo";
            mnuCuaSo.Size = new Size(68, 24);
            mnuCuaSo.Text = "Cửa sổ";
            // 
            // frmParent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "frmParent";
            Text = "QUẢN LÝ PHÒNG KHÁM";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem mnuNghiepVu;
        private ToolStripMenuItem mnuThongTinBenhNhan;
        private ToolStripMenuItem mnuDatLichHen;
        private ToolStripMenuItem mnuCuaSo;
    }
}
