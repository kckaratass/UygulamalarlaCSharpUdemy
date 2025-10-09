using System;
using System.Data;
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

        // Typed DataSet TableAdapter (DataSet1.xsd'den)
        // Not: XSD'de OgrenciEkle imzasının şu şekilde TANIMLI olduğundan emin olun:
        // OgrenciEkle(@OGRAD, @OGRSOYAD, @OGRKULUP, @OGRCINSIYET)
        DataSet1TableAdapters.DataTable1TableAdapter ds =
            new DataSet1TableAdapters.DataTable1TableAdapter();

        private void FrmOgrenciler_Load(object sender, EventArgs e)
        {
            ListeyiYenile();

            // İsterseniz kulüp adlarını burada doldurabilirsiniz:
            // comboBox1.Items.AddRange(new object[] { "Futbol", "Basketbol", "Satranç" });
        }

        // ---- Yardımcılar ----
        private void ListeyiYenile()
        {
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = ds.OgrenciListesi();
        }

        private void AlanlariTemizle()
        {
            // .Clear() yerine .Text = "" kullanıyoruz; böylece Label/TextBox ayrımı sorun olmaz.
            txtOgrenciAd.Text = string.Empty;
            txtOgrenciSoyad.Text = string.Empty;
            comboBox1.Text = string.Empty;     // kulüp adı metin
            radioButton1.Checked = false;      // Kız
            radioButton2.Checked = false;      // Erkek
            txtOgrenciAd.Focus();
        }

        private string SeciliCinsiyet()
        {
            // Doğru if-else zinciri
            if (radioButton1.Checked) return "KIZ";
            else if (radioButton2.Checked) return "ERKEK";
            else return "Belirtilmemiş";
        }

        // ---- Olaylar ----
        private void btnEkle_Click(object sender, EventArgs e)
        {
            var ad = (txtOgrenciAd.Text ?? "").Trim();
            var soyad = (txtOgrenciSoyad.Text ?? "").Trim();
            var kulup = (comboBox1.Text ?? "").Trim();   // KULUP metin (ID değil)
            var cinsiyet = SeciliCinsiyet();

            // Temel doğrulamalar
            if (string.IsNullOrEmpty(ad))
            {
                MessageBox.Show("Lütfen öğrenci adını girin.", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtOgrenciAd.Focus();
                return;
            }
            if (string.IsNullOrEmpty(soyad))
            {
                MessageBox.Show("Lütfen öğrenci soyadını girin.", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtOgrenciSoyad.Focus();
                return;
            }
            if (string.IsNullOrEmpty(kulup))
            {
                MessageBox.Show("Lütfen bir kulüp adı seçin/girin.", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                comboBox1.Focus();
                return;
            }

            try
            {
                // XSD imzanız 4 parametreli değilse, DataSet1.xsd içindeki OgrenciEkle sorgusunu
                // Configure/Add Query ile @OGRAD,@OGRSOYAD,@OGRKULUP,@OGRCINSIYET parametreleriyle güncelleyin.
                ds.OgrenciEkle(ad, soyad, byte.Parse(kulup), cinsiyet);

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

        private void btnListele_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.OgrenciListesi();
        }
    }
}
