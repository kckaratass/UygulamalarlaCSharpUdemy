using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BonusProje1
{
    public partial class FrmOgrenciler : Form
    {
        public FrmOgrenciler()
        {
            InitializeComponent();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        // YALNIZCA combobox'ı doldurmak için bağlantı
        private readonly SqlConnection baglanti = new SqlConnection(
            @"Data Source=LENOVO\SQLEXPRESS;Initial Catalog=BonusOkul;Integrated Security=True;TrustServerCertificate=True");

        // XSD/TableAdapter imzaları:
        //  OgrenciListesi()
        //  OgrenciEkle(@OGRAD nvarchar, @OGRSOYAD nvarchar, @OGRKULUP int, @OGRCINSIYET nvarchar)
        //  OgrenciGuncelle(@OGRAD nvarchar, @OGRSOYAD nvarchar, @OGRKULUP int, @OGRCINSIYET nvarchar, @OGRID int)
        //  OgrenciSil(@OGRID int)
        private readonly DataSet1TableAdapters.DataTable1TableAdapter ds =
            new DataSet1TableAdapters.DataTable1TableAdapter();

        private void FrmOgrenciler_Load(object sender, EventArgs e)
        {
            ListeyiYenile();
            KulupComboboxDoldur();

            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dataGridView1.CellClick += dataGridView1_CellClick;
        }

        // --- Yardımcılar ---
        private void KulupComboboxDoldur()
        {
            using (var cmd = new SqlCommand(
                "SELECT KULUPID, KULUPAD FROM TBLKULUPLER ORDER BY KULUPAD", baglanti))
            using (var da = new SqlDataAdapter(cmd))
            {
                var dt = new DataTable();
                baglanti.Open();
                da.Fill(dt);
                baglanti.Close();

                comboBox1.DisplayMember = "KULUPAD";
                comboBox1.ValueMember = "KULUPID";   // -> int
                comboBox1.DataSource = dt;
                comboBox1.SelectedIndex = -1;
            }
        }

        private void ListeyiYenile()
        {
            // DataTable1: OGRID, OGRAD, OGRSOYAD, OGRCINSIYET, KULUPAD
            dataGridView1.DataSource = ds.OgrenciListesi();
        }

        private void AlanlariTemizle()
        {
            txtOgrenciId.Text = string.Empty;
            txtOgrenciAd.Text = string.Empty;
            txtOgrenciSoyad.Text = string.Empty;
            comboBox1.SelectedIndex = -1;
            radioButton1.Checked = false; // KIZ
            radioButton2.Checked = false; // ERKEK
            txtOgrenciAd.Focus();
        }

        private string SeciliCinsiyet()
        {
            if (radioButton1.Checked) return "KIZ";
            if (radioButton2.Checked) return "ERKEK";
            return "Belirtilmemiş";
        }

        private int? SeciliKulupId()
        {
            if (comboBox1.SelectedIndex < 0 || comboBox1.SelectedValue == null) return null;
            if (int.TryParse(comboBox1.SelectedValue.ToString(), out var id)) return id;
            return null;
        }

        private int? SeciliOgrenciId()
        {
            var s = (txtOgrenciId.Text ?? "").Trim();
            if (int.TryParse(s, out var id)) return id;
            return null;
        }

        // --- EKLE ---
        private void btnEkle_Click(object sender, EventArgs e)
        {
            var ad = (txtOgrenciAd.Text ?? "").Trim();
            var soyad = (txtOgrenciSoyad.Text ?? "").Trim();
            var cins = SeciliCinsiyet();
            var kulupId = SeciliKulupId();

            // Doğrulamalar
            if (string.IsNullOrEmpty(ad))
            {
                MessageBox.Show("Lütfen öğrenci adını girin.", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtOgrenciAd.Focus(); return;
            }
            if (string.IsNullOrEmpty(soyad))
            {
                MessageBox.Show("Lütfen öğrenci soyadını girin.", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtOgrenciSoyad.Focus(); return;
            }
            if (kulupId == null)
            {
                MessageBox.Show("Lütfen bir kulüp seçin.", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                comboBox1.Focus(); return;
            }

            try
            {
                // XSD imzasına göre OGRKULUP -> int
                int affected = ds.OgrenciEkle(ad, soyad, (byte?)kulupId.Value, cins);

                if (affected <= 0)
                {
                    MessageBox.Show("Kayıt eklenemedi (0 satır).", "Uyarı",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                MessageBox.Show("Öğrenci eklendi.", "Bilgi",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                ListeyiYenile();
                AlanlariTemizle();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kayıt sırasında bir hata oluştu:\n" + ex.Message,
                    "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // --- LİSTELE ---
        private void btnListele_Click(object sender, EventArgs e)
        {
            ListeyiYenile();
        }

        // --- GRID TIKLAMA: Alanları doldur ---
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= dataGridView1.Rows.Count) return;

            var row = dataGridView1.Rows[e.RowIndex];

            // DataTable1 kolon adlarına göre doldur
            txtOgrenciId.Text = row.Cells["OGRID"]?.Value?.ToString();
            txtOgrenciAd.Text = row.Cells["OGRAD"]?.Value?.ToString();
            txtOgrenciSoyad.Text = row.Cells["OGRSOYAD"]?.Value?.ToString();

            // OGRKULUP gridde yok; sadece KULUPAD var → ada göre seç
            string kulupAd = row.Cells["KULUPAD"]?.Value?.ToString()?.Trim();
            if (!string.IsNullOrWhiteSpace(kulupAd))
            {
                int ix = -1;
                for (int i = 0; i < comboBox1.Items.Count; i++)
                {
                    if (comboBox1.Items[i] is DataRowView drv)
                    {
                        var ad = drv["KULUPAD"]?.ToString()?.Trim();
                        if (string.Equals(ad, kulupAd, StringComparison.OrdinalIgnoreCase))
                        {
                            ix = i; break;
                        }
                    }
                }
                comboBox1.SelectedIndex = ix; // bulunamazsa -1
            }
            else
            {
                comboBox1.SelectedIndex = -1;
            }

            var cins = row.Cells["OGRCINSIYET"]?.Value?.ToString();
            radioButton1.Checked = string.Equals(cins, "KIZ", StringComparison.OrdinalIgnoreCase);
            radioButton2.Checked = string.Equals(cins, "ERKEK", StringComparison.OrdinalIgnoreCase);
        }

        // --- GÜNCELLE ---
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            var id = SeciliOgrenciId();
            var ad = (txtOgrenciAd.Text ?? "").Trim();
            var soyad = (txtOgrenciSoyad.Text ?? "").Trim();
            var cins = SeciliCinsiyet();
            var kulupId = SeciliKulupId();

            if (id == null)
            {
                MessageBox.Show("Lütfen listeden bir öğrenci seçin (ID).", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(ad) || string.IsNullOrEmpty(soyad) || kulupId == null)
            {
                MessageBox.Show("Ad, Soyad ve Kulüp boş olamaz.", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // İMZA: (OGRAD, OGRSOYAD, OGRKULUP, OGRCINSIYET, OGRID)
                int affected = ds.OgrenciGuncelle(ad, soyad, (byte?)kulupId.Value, cins, id.Value);

                if (affected <= 0)
                {
                    MessageBox.Show(
                        "Güncelleme yapılmadı (0 satır etkilendi). " +
                        "OGRID eşleşmiyor olabilir veya parametre tür/sırası uyumsuz.",
                        "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                MessageBox.Show("Öğrenci güncellendi.", "Bilgi",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                ListeyiYenile();
                AlanlariTemizle();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Güncelleme sırasında bir hata oluştu:\n" + ex.Message,
                    "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // --- SİL ---
        private void btnSil_Click(object sender, EventArgs e)
        {
            var id = SeciliOgrenciId();
            if (id == null)
            {
                MessageBox.Show("Lütfen listeden bir öğrenci seçin (ID).", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Seçili öğrenciyi silmek istiyor musunuz?", "Onay",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            try
            {
                int affected = ds.OgrenciSil(id.Value);

                if (affected <= 0)
                {
                    MessageBox.Show("Silme işlemi gerçekleşmedi (0 satır).", "Uyarı",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                MessageBox.Show("Öğrenci silindi.", "Bilgi",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                ListeyiYenile();
                AlanlariTemizle();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Silme sırasında bir hata oluştu:\n" + ex.Message,
                    "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
