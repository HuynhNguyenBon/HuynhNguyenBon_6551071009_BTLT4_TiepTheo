namespace ClinicManagementDemo
{
    partial class frmBenhNhan
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
            lblHoTen = new Label();
            txtHoTen = new TextBox();
            lblTuoi = new Label();
            numTuoi = new NumericUpDown();
            lblTrieuChung = new Label();
            txtTrieuChung = new TextBox();
            btnLuuTam = new Button();
            lstBenhNhan = new ListBox();
            lblBenhNhan = new Label();
            ((System.ComponentModel.ISupportInitialize)numTuoi).BeginInit();
            SuspendLayout();
            // 
            // lblHoTen
            // 
            lblHoTen.AutoSize = true;
            lblHoTen.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHoTen.Location = new Point(115, 45);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(75, 25);
            lblHoTen.TabIndex = 0;
            lblHoTen.Text = "Họ tên:";
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(196, 45);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(263, 27);
            txtHoTen.TabIndex = 1;
            // 
            // lblTuoi
            // 
            lblTuoi.AutoSize = true;
            lblTuoi.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTuoi.Location = new Point(115, 90);
            lblTuoi.Name = "lblTuoi";
            lblTuoi.Size = new Size(54, 25);
            lblTuoi.TabIndex = 2;
            lblTuoi.Text = "Tuổi:";
            // 
            // numTuoi
            // 
            numTuoi.Location = new Point(196, 90);
            numTuoi.Maximum = new decimal(new int[] { 120, 0, 0, 0 });
            numTuoi.Name = "numTuoi";
            numTuoi.Size = new Size(150, 27);
            numTuoi.TabIndex = 3;
            // 
            // lblTrieuChung
            // 
            lblTrieuChung.AutoSize = true;
            lblTrieuChung.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTrieuChung.Location = new Point(115, 140);
            lblTrieuChung.Name = "lblTrieuChung";
            lblTrieuChung.Size = new Size(119, 25);
            lblTrieuChung.TabIndex = 4;
            lblTrieuChung.Text = "Triệu chứng:";
            // 
            // txtTrieuChung
            // 
            txtTrieuChung.Location = new Point(240, 140);
            txtTrieuChung.Multiline = true;
            txtTrieuChung.Name = "txtTrieuChung";
            txtTrieuChung.Size = new Size(331, 50);
            txtTrieuChung.TabIndex = 5;
            // 
            // btnLuuTam
            // 
            btnLuuTam.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLuuTam.Location = new Point(355, 220);
            btnLuuTam.Name = "btnLuuTam";
            btnLuuTam.Size = new Size(104, 35);
            btnLuuTam.TabIndex = 6;
            btnLuuTam.Text = "Lưu tạm";
            btnLuuTam.UseVisualStyleBackColor = true;
            btnLuuTam.Click += btnLuuTam_Click;
            // 
            // lstBenhNhan
            // 
            lstBenhNhan.FormattingEnabled = true;
            lstBenhNhan.Location = new Point(115, 305);
            lstBenhNhan.Name = "lstBenhNhan";
            lstBenhNhan.Size = new Size(573, 84);
            lstBenhNhan.TabIndex = 7;
            // 
            // lblBenhNhan
            // 
            lblBenhNhan.AutoSize = true;
            lblBenhNhan.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBenhNhan.Location = new Point(115, 264);
            lblBenhNhan.Name = "lblBenhNhan";
            lblBenhNhan.Size = new Size(183, 25);
            lblBenhNhan.TabIndex = 8;
            lblBenhNhan.Text = "Bệnh nhân đã nhập:";
            // 
            // frmBenhNhan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblBenhNhan);
            Controls.Add(lstBenhNhan);
            Controls.Add(btnLuuTam);
            Controls.Add(txtTrieuChung);
            Controls.Add(lblTrieuChung);
            Controls.Add(numTuoi);
            Controls.Add(lblTuoi);
            Controls.Add(txtHoTen);
            Controls.Add(lblHoTen);
            Name = "frmBenhNhan";
            Text = "Thông tin bệnh nhân";
            Load += frmBenhNhan_Load;
            ((System.ComponentModel.ISupportInitialize)numTuoi).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHoTen;
        private TextBox txtHoTen;
        private Label lblTuoi;
        private NumericUpDown numTuoi;
        private Label lblTrieuChung;
        private TextBox txtTrieuChung;
        private Button btnLuuTam;
        private ListBox lstBenhNhan;
        private Label lblBenhNhan;
    }
}