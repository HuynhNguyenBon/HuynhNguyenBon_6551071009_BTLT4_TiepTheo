namespace FormVe
{
    public partial class FormVe : Form
    {
        private bool dangVe = false;
        private Point diemCu;
        public FormVe()
        {
            InitializeComponent();
        }
        private void pnlCanvas_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                dangVe = true;
                diemCu = e.Location;
                lblViTri.Text = "X: " + e.X + ", Y: " + e.Y + " - Đang vẽ...";
            }
        }
        private void pnlCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            lblViTri.Text = "X: " + e.X + ", Y: " + e.Y +
                            (dangVe ? " - Đang vẽ..." : " - Sẵn sàng");

            if (dangVe)
            {
                using (Graphics g = pnlCanvas.CreateGraphics())
                {
                    g.DrawLine(Pens.Black, diemCu, e.Location);
                }

                diemCu = e.Location;
            }
        }
        private void pnlCanvas_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                dangVe = false;
                lblViTri.Text = "X: " + e.X + ", Y: " + e.Y + " - Sẵn sàng";
            }
        }
        private void pnlCanvas_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                pnlCanvas.Invalidate();

                lblViTri.Text = "X: " + e.X + ", Y: " + e.Y + " - Sẵn sàng";
            }
        }
    }
}
