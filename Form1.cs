namespace LAB4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog
            {
                Title = "Wybierz obraz",
                Filter = "Pliki BMP (*.bmp)|*.bmp"
            };

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pictureBox1.Image = new Bitmap(openFile.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("B³¹d wczytywania obrazu: " + ex.Message, "B³¹d", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnRotate_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                Image img = pictureBox1.Image;

                if (rbtn90.Checked)
                {
                    img.RotateFlip(RotateFlipType.Rotate90FlipNone);
                }
                else if (rbtn180.Checked)
                {
                    img.RotateFlip(RotateFlipType.Rotate180FlipNone);
                }
                else if (rbtn270.Checked)
                {
                    img.RotateFlip(RotateFlipType.Rotate270FlipNone);
                }

                pictureBox1.Image = img;
            }
        }

        private void btnUpsideDown_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                Image img = pictureBox1.Image;

                img.RotateFlip(RotateFlipType.RotateNoneFlipY);

                pictureBox1.Image = img;
            }
        }
        public Bitmap Generate_negative_image(Bitmap sourceimage)

        {
            Color c;

            for (int i = 0; i < sourceimage.Width; i++)
            {
                for (int j = 0; j < sourceimage.Height; j++)

                {
                    c = sourceimage.GetPixel(i, j);

                    c = Color.FromArgb(255 - c.R, 255 - c.G, 255 - c.B);

                    sourceimage.SetPixel(i, j, c);
                }
            }
            return sourceimage;
        }
        private void btnInvertColors_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                pictureBox1.Image = Generate_negative_image((Bitmap)pictureBox1.Image);
            }
        }
    }
}
