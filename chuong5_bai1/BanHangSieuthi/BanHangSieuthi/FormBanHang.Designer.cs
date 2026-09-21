namespace BanHangSieuthi
{
    partial class FormBanHang
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
            lblMaSP = new Label();
            txtMaSP = new TextBox();
            lblSoLuong = new Label();
            txtSoLuong = new TextBox();
            lblDonGia = new Label();
            txtDonGia = new TextBox();
            btnThem = new Button();
            btnXoaTrang = new Button();
            lstKetQua = new ListBox();
            SuspendLayout();
            // 
            // lblMaSP
            // 
            lblMaSP.AutoSize = true;
            lblMaSP.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMaSP.Location = new Point(89, 80);
            lblMaSP.Name = "lblMaSP";
            lblMaSP.Size = new Size(131, 25);
            lblMaSP.TabIndex = 0;
            lblMaSP.Text = "Mã sản phẩm:";
            // 
            // txtMaSP
            // 
            txtMaSP.Location = new Point(226, 78);
            txtMaSP.Name = "txtMaSP";
            txtMaSP.Size = new Size(278, 27);
            txtMaSP.TabIndex = 1;
            // 
            // lblSoLuong
            // 
            lblSoLuong.AutoSize = true;
            lblSoLuong.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSoLuong.Location = new Point(89, 129);
            lblSoLuong.Name = "lblSoLuong";
            lblSoLuong.Size = new Size(93, 25);
            lblSoLuong.TabIndex = 2;
            lblSoLuong.Text = "Số lượng:";
            // 
            // txtSoLuong
            // 
            txtSoLuong.Location = new Point(188, 129);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(221, 27);
            txtSoLuong.TabIndex = 3;
            txtSoLuong.KeyPress += txtSoLuong_KeyPress;
            // 
            // lblDonGia
            // 
            lblDonGia.AutoSize = true;
            lblDonGia.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDonGia.Location = new Point(89, 178);
            lblDonGia.Name = "lblDonGia";
            lblDonGia.Size = new Size(83, 25);
            lblDonGia.TabIndex = 4;
            lblDonGia.Text = "Đơn giá:";
            // 
            // txtDonGia
            // 
            txtDonGia.Location = new Point(188, 179);
            txtDonGia.Name = "txtDonGia";
            txtDonGia.Size = new Size(221, 27);
            txtDonGia.TabIndex = 5;
            txtDonGia.KeyPress += txtDonGia_KeyPress;
            // 
            // btnThem
            // 
            btnThem.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThem.Location = new Point(226, 241);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(107, 38);
            btnThem.TabIndex = 6;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnXoaTrang
            // 
            btnXoaTrang.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnXoaTrang.Location = new Point(440, 241);
            btnXoaTrang.Name = "btnXoaTrang";
            btnXoaTrang.Size = new Size(138, 38);
            btnXoaTrang.TabIndex = 7;
            btnXoaTrang.Text = "Xóa trắng";
            btnXoaTrang.UseVisualStyleBackColor = true;
            btnXoaTrang.Click += btnXoaTrang_Click;
            // 
            // lstKetQua
            // 
            lstKetQua.FormattingEnabled = true;
            lstKetQua.Location = new Point(89, 307);
            lstKetQua.Name = "lstKetQua";
            lstKetQua.Size = new Size(593, 104);
            lstKetQua.TabIndex = 8;
            // 
            // FormBanHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lstKetQua);
            Controls.Add(btnXoaTrang);
            Controls.Add(btnThem);
            Controls.Add(txtDonGia);
            Controls.Add(lblDonGia);
            Controls.Add(txtSoLuong);
            Controls.Add(lblSoLuong);
            Controls.Add(txtMaSP);
            Controls.Add(lblMaSP);
            KeyPreview = true;
            Name = "FormBanHang";
            Text = "QUẢN LÝ BÁN HÀNG";
            KeyDown += FormBanHang_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMaSP;
        private TextBox txtMaSP;
        private Label lblSoLuong;
        private TextBox txtSoLuong;
        private Label lblDonGia;
        private TextBox txtDonGia;
        private Button btnThem;
        private Button btnXoaTrang;
        private ListBox lstKetQua;
    }
}
