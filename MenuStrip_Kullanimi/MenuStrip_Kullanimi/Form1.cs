using System;
using System.Windows.Forms;

namespace MenuStrip_Kullanimi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Sayfa ilk açıldığında varsayılan değerleri ayarlayabilirsin
            this.BackColor = System.Drawing.Color.FromArgb(30, 30, 47); // Modern koyu arka plan
            label1.Text = "Bir film seçin";
        }

        // Tema renkleri
        private void maviToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.CadetBlue;
        }

        private void griToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.Gray;
        }

        private void turuncuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.Orange;
        }

        // Hakkımızda mesajı
        private void hakkımızdaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bu proje Kadir Can Karataş tarafından geliştirildi.", "Hakkımızda", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Çıkış
        private void çıkıiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Filmler
        private void madMaxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FragmanGöster("Mad Max", "https://www.youtube.com/watch?v=hEJnMQG9ev8");
        }

        private void psILoveYouToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FragmanGöster("P.S. I Love You", "https://www.youtube.com/watch?v=CZzW6_hR068");
        }

        private void aynıYıldızınToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FragmanGöster("Aynı Yıldızın Altında", "https://www.youtube.com/watch?v=aQnlngjZG48");
        }

        private void korkuSeansıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FragmanGöster("Korku Seansı", "https://www.youtube.com/watch?v=5u5A471adxg");
        }

        private void uzayYolcularıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FragmanGöster("Uzay Yolcuları", "https://www.youtube.com/watch?v=8GKyQ1S5594");
        }

        // Tekrarlanan kodu sadeleştirdik
        private void FragmanGöster(string filmAdi, string url)
        {
            label1.Text = filmAdi;
            webBrowser1.Navigate(url);
        }
    }
}
