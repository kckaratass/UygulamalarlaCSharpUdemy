using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Personel_Kayit_Projesi
{
    public partial class FrmIstatistik : Form
    {
        public FrmIstatistik()
        {
            InitializeComponent();
        }

        // SQL bağlantı nesnesi
        SqlConnection baglanti = new SqlConnection("Data Source=LENOVO\\SQLEXPRESS;Initial Catalog=PersonelVeriTabani;Integrated Security=True;TrustServerCertificate=True");

        // Form yüklendiğinde çalışan metod
        private void FrmIstatistik_Load(object sender, EventArgs e)
        {
            // Bağlantıyı aç
            baglanti.Open();

            // Personel sayısını sayan SQL komutu
            SqlCommand komut1 = new SqlCommand("Select Count (*) From Tbl_Personel", baglanti);

            // Komutu çalıştır ve sonuçları oku
            SqlDataReader dr1 = komut1.ExecuteReader();

            // Okuma işlemi devam ettiği sürece
            while (dr1.Read())
            {
                // İlk sütundaki değeri al ve label'a yazdır
                lblToplamPersonel.Text = dr1[0].ToString();
            }

            // Bağlantıyı kapat
            baglanti.Close();

            // Evli Personel Sayısı
            baglanti.Open();

            SqlCommand komut2 = new SqlCommand("Select count(*) From Tbl_Personel Where PerDurum = 1", baglanti);
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                lblEvliPersonelSayisi.Text = dr2[0].ToString();
            }
            baglanti.Close();

            // Bekar Personel Sayısı
            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("Select count(*) From Tbl_Personel Where PerDurum = 0", baglanti);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                lblBekarPersonelSayisi.Text = dr3[0].ToString();
            }
            baglanti.Close();

            // Şehir Sayısı
            baglanti.Open();
            SqlCommand komut4 = new SqlCommand("Select Count(distinct(PerSehir)) From Tbl_Personel", baglanti);
            SqlDataReader dr4 = komut4.ExecuteReader();
            while (dr4.Read())
            {
                lblSehirSayisi.Text = dr4[0].ToString();
            }
            baglanti.Close();

            // Toplam Maas
            baglanti.Open();
            SqlCommand komut5 = new SqlCommand("Select Sum(PerMaas) From Tbl_Personel", baglanti);
            SqlDataReader dr5 = komut5.ExecuteReader();
            while (dr5.Read())
            {
                lblToplamMaas.Text = dr5[0].ToString();
            }
            baglanti.Close();

            // Ortalama Maas 
            baglanti.Open();
            SqlCommand komut6 = new SqlCommand("Select Avg(PerMaas) From Tbl_Personel", baglanti);
            SqlDataReader dr6 = komut6.ExecuteReader();
            while (dr6.Read())
            {
                lblOrtalamaMaas.Text = dr6[0].ToString();
            }
            baglanti.Close();

        }
    }
}
