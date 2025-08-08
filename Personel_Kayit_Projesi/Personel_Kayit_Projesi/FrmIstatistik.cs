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
        }
    }
}
