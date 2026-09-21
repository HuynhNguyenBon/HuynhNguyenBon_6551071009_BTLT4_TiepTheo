namespace TodoListDemo
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            txtCongViecMoi = new TextBox();
            btnThem = new Button();
            panel1 = new Panel();
            lstCongViec = new ListBox();
            cmsCongViec = new ContextMenuStrip(components);
            mnuDanhDauHoanThanh = new ToolStripMenuItem();
            mnuXoaCongViec = new ToolStripMenuItem();
            mnuXoaTatCa = new ToolStripMenuItem();
            panel1.SuspendLayout();
            cmsCongViec.SuspendLayout();
            SuspendLayout();
            // 
            // txtCongViecMoi
            // 
            txtCongViecMoi.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtCongViecMoi.Location = new Point(53, 22);
            txtCongViecMoi.Name = "txtCongViecMoi";
            txtCongViecMoi.Size = new Size(571, 27);
            txtCongViecMoi.TabIndex = 0;
            txtCongViecMoi.TextChanged += txtCongViecMoi_TextChanged;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(640, 20);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 1;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(txtCongViecMoi);
            panel1.Controls.Add(btnThem);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 90);
            panel1.TabIndex = 3;
            // 
            // lstCongViec
            // 
            lstCongViec.ContextMenuStrip = cmsCongViec;
            lstCongViec.FormattingEnabled = true;
            lstCongViec.Location = new Point(0, 84);
            lstCongViec.Name = "lstCongViec";
            lstCongViec.Size = new Size(800, 444);
            lstCongViec.TabIndex = 2;
            // 
            // cmsCongViec
            // 
            cmsCongViec.ImageScalingSize = new Size(20, 20);
            cmsCongViec.Items.AddRange(new ToolStripItem[] { mnuDanhDauHoanThanh, mnuXoaCongViec, mnuXoaTatCa });
            cmsCongViec.Name = "cmsCongViec";
            cmsCongViec.Size = new Size(221, 76);
            cmsCongViec.Opening += cmsCongViec_Opening;
            // 
            // mnuDanhDauHoanThanh
            // 
            mnuDanhDauHoanThanh.Name = "mnuDanhDauHoanThanh";
            mnuDanhDauHoanThanh.Size = new Size(220, 24);
            mnuDanhDauHoanThanh.Text = "Đánh dấu hoàn thành";
            mnuDanhDauHoanThanh.Click += mnuDanhDauHoanThanh_Click;
            // 
            // mnuXoaCongViec
            // 
            mnuXoaCongViec.Name = "mnuXoaCongViec";
            mnuXoaCongViec.Size = new Size(220, 24);
            mnuXoaCongViec.Text = "Xóa công việc này";
            mnuXoaCongViec.Click += mnuXoaCongViec_Click;
            // 
            // mnuXoaTatCa
            // 
            mnuXoaTatCa.Name = "mnuXoaTatCa";
            mnuXoaTatCa.Size = new Size(220, 24);
            mnuXoaTatCa.Text = "Xóa tất cả";
            mnuXoaTatCa.Click += mnuXoaTatCa_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(lstCongViec);
            Name = "Form1";
            Text = "Công Việc";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            cmsCongViec.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtCongViecMoi;
        private Button btnThem;
        private Panel panel1;
        private ListBox lstCongViec;
        private ContextMenuStrip cmsCongViec;
        private ToolStripMenuItem mnuDanhDauHoanThanh;
        private ToolStripMenuItem mnuXoaCongViec;
        private ToolStripMenuItem mnuXoaTatCa;
    }
}
