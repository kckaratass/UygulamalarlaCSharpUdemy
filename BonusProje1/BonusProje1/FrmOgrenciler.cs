using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data.SqlClient;

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

        SqlConnection baglanti = new SqlConnection(@"Data Source=LENOVO\SQLEXPRESS;Initial Catalog=BonusOkul;Integrated Security=True;TrustServerCertificate=True");


        DataSet1TableAdapters.DataTable1TableAdapter ds =
            new DataSet1TableAdapters.DataTable1TableAdapter();

        private void FrmOgrenciler_Load(object sender, EventArgs e)
        {
            ListeyiYenile();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * From TBLKULUPLER", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            comboBox1.DisplayMember = "KULUPAD";
            comboBox1.ValueMember = "KULUPID";
            comboBox1.DataSource = dt;
            baglanti.Close();
        }
        private void ListeyiYenile()
        {
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = ds.OgrenciListesi();
        }

        private void AlanlariTemizle()
        {
            txtOgrenciAd.Text = string.Empty;
            txtOgrenciSoyad.Text = string.Empty;
            comboBox1.Text = string.Empty;     
            radioButton1.Checked = false;      
            radioButton2.Checked = false;      
            txtOgrenciAd.Focus();
        }

        private string SeciliCinsiyet()
        {
            if (radioButton1.Checked) return "KIZ";
            else if (radioButton2.Checked) return "ERKEK";
            else return "Belirtilmemiş";
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            var ad = (txtOgrenciAd.Text ?? "").Trim();
            var soyad = (txtOgrenciSoyad.Text ?? "").Trim();
            var kulup = (comboBox1.Text ?? "").Trim();
            var cinsiyet = SeciliCinsiyet();

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

                ds.OgrenciEkle(ad, soyad, byte.Parse(comboBox1.SelectedValue.ToString()), cinsiyet);

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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtOgrenciId.Text = comboBox1.SelectedValue.ToString();
        }
    }
}
