using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Personel_Kayit_Projesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=LENOVO\\SQLEXPRESS;Initial Catalog=PersonelVeriTabani;Integrated Security=True;TrustServerCertificate=True");

        void temizle()
        {
            txtId.Text = "";
            txtAd.Text = "";
            txtSoyad.Text = "";
            txtMeslek.Text = "";
            mskMaas.Text = "";
            cmbSehir.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            txtAd.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.tbl_PersonelTableAdapter.Fill(this.personelVeriTabaniDataSet.Tbl_Personel);
            txtAd.Focus();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            this.tbl_PersonelTableAdapter.Fill(this.personelVeriTabaniDataSet.Tbl_Personel);
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand komut = new SqlCommand("insert into Tbl_Personel (Perad, PerSoyad, PerSehir, PerMaas, PerMeslek, PerDurum) values (@p1,@p2,@p3,@p4,@p5,@p6)", baglanti);
            komut.Parameters.AddWithValue("@p1", txtAd.Text);
            komut.Parameters.AddWithValue("@p2", txtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", cmbSehir.Text);
            komut.Parameters.AddWithValue("@p4", mskMaas.Text);
            komut.Parameters.AddWithValue("@p5", txtMeslek.Text);
            komut.Parameters.AddWithValue("@p6", label8.Text); // Durum için label8 kullanılıyor
            komut.ExecuteNonQuery();

            baglanti.Close();

            MessageBox.Show("Personel Başarıyla Eklendi",
                "Bilgi",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                label8.Text = "True";  // Evli
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                label8.Text = "False";  // Bekar
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            txtId.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtSoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            cmbSehir.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            mskMaas.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            txtMeslek.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();

            string durum = dataGridView1.Rows[secilen].Cells[6].Value.ToString().ToLower();

            label8.Text = durum;

            if (durum == "true" || durum == "1")
            {
                radioButton1.Checked = true;
            }
            else
            {
                radioButton2.Checked = true;
            }
        }

        private void label8_TextChanged(object sender, EventArgs e)
        {
            string durum = label8.Text.ToLower();

            if (durum == "true" || durum == "1")
            {
                radioButton1.Checked = true;
            }
            else if (durum == "false" || durum == "0")
            {
                radioButton2.Checked = true;
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komutSil = new SqlCommand("Delete from Tbl_Personel Where PerId = @k1",baglanti);
            komutSil.Parameters.AddWithValue("@k1",txtId.Text);
            komutSil.ExecuteNonQuery();
            MessageBox.Show("Kayıt Silindi","Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            baglanti.Close();
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komutGuncelle = new SqlCommand("Update Tbl_Personel Set PerAd = @a1, PerSoyad = @a2, PerSehir = @a3, PerMaas = @a4, PerDurum = @a5, PerMeslek = @a6 WHERE PerId = @a7" , baglanti);
            komutGuncelle.Parameters.AddWithValue("@a1", txtAd.Text);
            komutGuncelle.Parameters.AddWithValue("@a2", txtSoyad.Text);
            komutGuncelle.Parameters.AddWithValue("@a3", cmbSehir.Text);
            komutGuncelle.Parameters.AddWithValue("@a4", mskMaas.Text);
            komutGuncelle.Parameters.AddWithValue("@a5", label8.Text);
            komutGuncelle.Parameters.AddWithValue("@a6", txtMeslek.Text);
            komutGuncelle.Parameters.AddWithValue("@a7", txtId.Text);
            komutGuncelle.ExecuteNonQuery();
            MessageBox.Show("Personel Bilgi Güncellendi","Bilgi",MessageBoxButtons.OK, MessageBoxIcon.Information);

            baglanti.Close();
            
        }

        private void btnistatistik_Click(object sender, EventArgs e)
        {
            FrmIstatistik frm = new FrmIstatistik();
            frm.Show();
        }
    }
}
