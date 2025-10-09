using System;
using System.Data;
using System.Windows.Forms;

namespace BonusProje1
{
    public partial class FrmDersler : Form
    {
        public FrmDersler()
        {
            InitializeComponent();
        }

        // TableAdapter (typed dataset’inden geliyor)
        DataSet1TableAdapters.TBLDERSLERTableAdapter ds =
            new DataSet1TableAdapters.TBLDERSLERTableAdapter();

        // --- Yardımcı metotlar ---
        private void ListeyiYenile()
        {
            dataGridView1.AutoGenerateColumns = true; // güvenli varsayılan
            dataGridView1.DataSource = ds.DersListesi();
        }

        private void AlanlariTemizle()
        {
            txtDersId.Clear();
            txtDersAd.Clear();
            txtDersAd.Focus();
        }

        private bool DersIdTryParse(out byte id)
        {
            // DersID tipiniz 0–255 dışına çıkabilecekse byte yerine int kullanın
            // (o durumda TableAdapter metod imzalarını da int yapmanız gerekir).
            var s = (txtDersId.Text ?? "").Trim();
            return byte.TryParse(s, out id);
        }

        // --- Olaylar ---
        private void FrmDersler_Load(object sender, EventArgs e)
        {
            ListeyiYenile();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            var dersAd = (txtDersAd.Text ?? "").Trim();
            if (string.IsNullOrEmpty(dersAd))
            {
                MessageBox.Show("Lütfen ders adını girin.", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ds.DersEkle(dersAd);
            MessageBox.Show("Ders ekleme işlemi yapıldı.", "Bilgi",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            ListeyiYenile();
            AlanlariTemizle();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            ListeyiYenile();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (!DersIdTryParse(out var id))
            {
                MessageBox.Show("Geçerli bir Ders ID seçin.", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ds.DersSil(id);
            MessageBox.Show("Ders silindi.", "Bilgi",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            ListeyiYenile();
            AlanlariTemizle();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            var dersAd = (txtDersAd.Text ?? "").Trim();
            if (string.IsNullOrEmpty(dersAd))
            {
                MessageBox.Show("Lütfen ders adını girin.", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!DersIdTryParse(out var id))
            {
                MessageBox.Show("Geçerli bir Ders ID seçin.", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ds.DersGüncelle(dersAd, id);
            MessageBox.Show("Ders güncellendi.", "Bilgi",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            ListeyiYenile();
            AlanlariTemizle();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Başlık veya geçersiz tıklamalarda çık
            if (e.RowIndex < 0 || e.RowIndex >= dataGridView1.Rows.Count) return;

            var row = dataGridView1.Rows[e.RowIndex];

            // --- Tercihen SÜTUN ADLARIYLA okuyun ---
            // Aşağıdaki isimleri, kendi tablonuzdaki gerçek kolon adlarıyla aynı tutun:
            // "DERSID" ve "DERSAD" (gerekiyorsa değiştirin).
            try
            {
                var idObj = row.Cells["DERSID"].Value;
                var adObj = row.Cells["DERSAD"].Value;

                txtDersId.Text = idObj?.ToString();
                txtDersAd.Text = adObj?.ToString();
            }
            catch
            {
                // Eğer kolon adları farklıysa, SIRA ile deneyin (0: ID, 1: AD gibi).
                // DİKKAT: Sütun sırası grid’de değişirse bu kırılabilir.
                // Mümkün olduğunca üstteki "adla erişim" yöntemini kullanın.
                if (row.Cells.Count >= 2)
                {
                    txtDersId.Text = row.Cells[0].Value?.ToString();
                    txtDersAd.Text = row.Cells[1].Value?.ToString();
                }
            }
        }
    }
}
