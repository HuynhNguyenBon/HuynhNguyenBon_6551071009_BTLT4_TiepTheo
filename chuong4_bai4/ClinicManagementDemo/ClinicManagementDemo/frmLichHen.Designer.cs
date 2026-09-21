namespace ClinicManagementDemo
{
    partial class frmLichHen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblNgayGioHen = new Label();
            dtpNgayGioHen = new DateTimePicker();
            lblTenBenhNhan = new Label();
            txtTenBenhNhan = new TextBox();
            btnDatLich = new Button();
            lstLichHen = new ListBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // lblNgayGioHen
            // 
            lblNgayGioHen.AutoSize = true;
            lblNgayGioHen.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNgayGioHen.Location = new Point(84, 46);
            lblNgayGioHen.Name = "lblNgayGioHen";
            lblNgayGioHen.Size = new Size(131, 25);
            lblNgayGioHen.TabIndex = 0;
            lblNgayGioHen.Text = "Ngày giờ hẹn:";
            // 
            // dtpNgayGioHen
            // 
            dtpNgayGioHen.CustomFormat = "dd/MM/yyyy HH:mm";
            dtpNgayGioHen.Format = DateTimePickerFormat.Custom;
            dtpNgayGioHen.Location = new Point(221, 46);
            dtpNgayGioHen.Name = "dtpNgayGioHen";
            dtpNgayGioHen.Size = new Size(250, 27);
            dtpNgayGioHen.TabIndex = 1;
            // 
            // lblTenBenhNhan
            // 
            lblTenBenhNhan.AutoSize = true;
            lblTenBenhNhan.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTenBenhNhan.Location = new Point(84, 96);
            lblTenBenhNhan.Name = "lblTenBenhNhan";
            lblTenBenhNhan.Size = new Size(143, 25);
            lblTenBenhNhan.TabIndex = 2;
            lblTenBenhNhan.Text = "Tên bệnh nhân:";
            // 
            // txtTenBenhNhan
            // 
            txtTenBenhNhan.Location = new Point(233, 96);
            txtTenBenhNhan.Name = "txtTenBenhNhan";
            txtTenBenhNhan.Size = new Size(238, 27);
            txtTenBenhNhan.TabIndex = 3;
            // 
            // btnDatLich
            // 
            btnDatLich.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDatLich.Location = new Point(377, 154);
            btnDatLich.Name = "btnDatLich";
            btnDatLich.Size = new Size(94, 35);
            btnDatLich.TabIndex = 4;
            btnDatLich.Text = "Đặt lịch";
            btnDatLich.UseVisualStyleBackColor = true;
            btnDatLich.Click += btnDatLich_Click;
            // 
            // lstLichHen
            // 
            lstLichHen.FormattingEnabled = true;
            lstLichHen.Location = new Point(84, 284);
            lstLichHen.Name = "lstLichHen";
            lstLichHen.Size = new Size(634, 104);
            lstLichHen.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(84, 245);
            label1.Name = "label1";
            label1.Size = new Size(177, 25);
            label1.TabIndex = 6;
            label1.Text = "Danh sách lịch hẹn:";
            label1.Click += label1_Click;
            // 
            // frmLichHen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(lstLichHen);
            Controls.Add(btnDatLich);
            Controls.Add(txtTenBenhNhan);
            Controls.Add(lblTenBenhNhan);
            Controls.Add(dtpNgayGioHen);
            Controls.Add(lblNgayGioHen);
            Name = "frmLichHen";
            Text = "Đặt lịch hẹn";
            Load += frmLichHen_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNgayGioHen;
        private DateTimePicker dtpNgayGioHen;
        private Label lblTenBenhNhan;
        private TextBox txtTenBenhNhan;
        private Button btnDatLich;
        private ListBox lstLichHen;
        private Label label1;
    }
}