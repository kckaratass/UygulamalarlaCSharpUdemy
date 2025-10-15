using System;
using System.ComponentModel;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace EntityProjeUygulama
{
    public partial class FrmUrun : Form
    {
        public FrmUrun()
        {
            InitializeComponent();
        }
        private readonly DbEntityUrunEntities db = new DbEntityUrunEntities();

        private void FrmUrun_Load(object sender, EventArgs e)
        {
            try
            {
                var kategoriler = db.TBLKATEGORI
                    .Select(k => new { k.ID, k.AD })
                    .OrderBy(k => k.AD)
                    .ToList();

                cmbKategori.DisplayMember = "AD";
                cmbKategori.ValueMember = "ID";
                cmbKategori.DataSource = kategoriler;

                ListeyiYenile();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Form yüklenirken hata: " + ex.Message,
                    "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            ListeyiYenile();
        }

        private void ListeyiYenile()
        {
            dataGridView1.DataSource = db.TBLURUN
                .Select(u => new
                {
                    u.URUNID,
                    u.URUNAD,
                    u.MARKA,
                    u.STOK,
                    u.KATEGORI, 
                    u.FIYAT,
                    u.DURUM
                })
                .ToList();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtUrunAd.Text))
                {
                    MessageBox.Show("Ürün adı boş olamaz.");
                    txtUrunAd.Focus();
                    return;
                }

                if (!TryParseShort(txtStokSayisi.Text, out short stok))
                {
                    MessageBox.Show("Stok sayısı sayısal olmalı (0-32767).");
                    txtStokSayisi.Focus();
                    return;
                }

                if (!TryParseDecimal(txtUrunFiyati.Text, out decimal fiyat))
                {
                    MessageBox.Show("Fiyat sayısal olmalı. (Örn: 199,99)");
                    txtUrunFiyati.Focus();
                    return;
                }

                int kategoriId = GetSelectedKategoriId();
                if (kategoriId <= 0)
                {
                    MessageBox.Show("Lütfen bir kategori seçin.");
                    cmbKategori.DroppedDown = true;
                    return;
                }

                var t = new TBLURUN
                {
                    URUNAD = txtUrunAd.Text.Trim(),
                    MARKA = txtMarka.Text?.Trim(),
                    STOK = stok,
                    KATEGORI = kategoriId, // FK
                    FIYAT = fiyat,
                    DURUM = true
                };

                db.TBLURUN.Add(t);
                db.SaveChanges();

                MessageBox.Show("Ürün eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ListeyiYenile();
                FormuTemizle();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ekleme sırasında hata: " + ex.Message,
                    "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txtUrunId.Text, out int id))
                {
                    MessageBox.Show("Geçerli bir Ürün ID girin.");
                    txtUrunId.Focus();
                    return;
                }

                var urun = db.TBLURUN.Find(id);
                if (urun == null)
                {
                    MessageBox.Show("Ürün bulunamadı.");
                    return;
                }

                var onay = MessageBox.Show($"'{urun.URUNAD}' silinsin mi?",
                    "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (onay != DialogResult.Yes) return;

                db.TBLURUN.Remove(urun);
                db.SaveChanges();

                MessageBox.Show("Ürün silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ListeyiYenile();
                FormuTemizle();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Silme sırasında hata: " + ex.Message,
                    "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txtUrunId.Text, out int id))
                {
                    MessageBox.Show("Geçerli bir Ürün ID girin.");
                    txtUrunId.Focus();
                    return;
                }

                var urun = db.TBLURUN.Find(id);
                if (urun == null)
                {
                    MessageBox.Show("Ürün bulunamadı.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtUrunAd.Text))
                {
                    MessageBox.Show("Ürün adı boş olamaz.");
                    txtUrunAd.Focus();
                    return;
                }

                if (!TryParseShort(txtStokSayisi.Text, out short stok))
                {
                    MessageBox.Show("Stok sayısı sayısal olmalı (0-32767).");
                    txtStokSayisi.Focus();
                    return;
                }

                if (!TryParseDecimal(txtUrunFiyati.Text, out decimal fiyat))
                {
                    MessageBox.Show("Fiyat sayısal olmalı. (Örn: 199,99)");
                    txtUrunFiyati.Focus();
                    return;
                }

                urun.URUNAD = txtUrunAd.Text.Trim();
                urun.MARKA = txtMarka.Text?.Trim();
                urun.STOK = stok;
                urun.FIYAT = fiyat;
                urun.DURUM = true;

                db.SaveChanges();

                MessageBox.Show("Ürün güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ListeyiYenile();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Güncelleme sırasında hata: " + ex.Message,
                    "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private int GetSelectedKategoriId()
        {
            if (cmbKategori.DataSource != null && cmbKategori.SelectedValue != null &&
                int.TryParse(cmbKategori.SelectedValue.ToString(), out int idFromValue))
            {
                return idFromValue;
            }

            if (int.TryParse(cmbKategori.Text, out int idFromText))
                return idFromText;

            return -1;
        }

        private static bool TryParseShort(string input, out short value)
        {
            return short.TryParse(input, NumberStyles.Integer, CultureInfo.CurrentCulture, out value);
        }

        private static bool TryParseDecimal(string input, out decimal value)
        {
            if (decimal.TryParse(input, NumberStyles.Number, CultureInfo.CurrentCulture, out value))
                return true;

            return decimal.TryParse(input, NumberStyles.Number, CultureInfo.InvariantCulture, out value);
        }

        private void FormuTemizle()
        {
            txtUrunId.Clear();
            txtUrunAd.Clear();
            txtMarka.Clear();
            txtStokSayisi.Clear();
            txtUrunFiyati.Clear();
            if (cmbKategori.Items.Count > 0) cmbKategori.SelectedIndex = 0;
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            db.Dispose();
            base.OnClosing(e);
        }
    }
}
