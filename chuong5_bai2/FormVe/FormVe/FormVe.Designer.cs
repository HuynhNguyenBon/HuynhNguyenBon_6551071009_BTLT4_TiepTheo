namespace FormVe
{
    partial class FormVe
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
            pnlCanvas = new Panel();
            lblViTri = new Label();
            SuspendLayout();
            // 
            // pnlCanvas
            // 
            pnlCanvas.BackColor = Color.White;
            pnlCanvas.Location = new Point(43, 37);
            pnlCanvas.Name = "pnlCanvas";
            pnlCanvas.Size = new Size(700, 338);
            pnlCanvas.TabIndex = 0;
            pnlCanvas.MouseClick += this.pnlCanvas_MouseClick;
            pnlCanvas.MouseDown += pnlCanvas_MouseDown;
            pnlCanvas.MouseMove += pnlCanvas_MouseMove;
            pnlCanvas.MouseUp += pnlCanvas_MouseUp;
            // 
            // lblViTri
            // 
            lblViTri.AutoSize = true;
            lblViTri.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblViTri.Location = new Point(43, 400);
            lblViTri.Name = "lblViTri";
            lblViTri.Size = new Size(178, 25);
            lblViTri.TabIndex = 1;
            lblViTri.Text = "X: 0, Y: 0 - Sẵn sàng";
            // 
            // FormVe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblViTri);
            Controls.Add(pnlCanvas);
            Name = "FormVe";
            Text = "BẢNG VẼ MINI";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlCanvas;
        private Label lblViTri;
    }
}
