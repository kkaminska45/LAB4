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
    }
}
