using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Hastane_Yonetim_Projesi
{
    public partial class FrmDoktorPaneli : Form
    {
        public FrmDoktorPaneli()
        {
            InitializeComponent();
        }

        SqlBaglantisi bgl = new SqlBaglantisi();
        private void FrmDoktorPaneli_Load(object sender, EventArgs e)
        {
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("Select * From Tbl_Doktorlar",bgl.baglanti());
            da1.Fill(dt1);
            dataGridView1.DataSource = dt1;

            // Branşları ComboBoxa Aktarma 

            SqlCommand komut2 = new SqlCommand("Select BransAd From Tbl_Branslar", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                cmbBranch.Items.Add(dr2[0]);
            }
            bgl.baglanti().Close();
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Tbl_Doktorlar (DoktorAd,DoktorSoyad,DoktorBrans,DoktorTC,DoktorSifre) values (@d1,@d2,@d3,@d4,@d5)", bgl.baglanti());
            
            komut.Parameters.AddWithValue("@d1", txtName.Text);
            komut.Parameters.AddWithValue("@d2", txtSurname.Text);
            komut.Parameters.AddWithValue("@d3", cmbBranch.Text);
            komut.Parameters.AddWithValue("@d4", mskTC.Text);
            komut.Parameters.AddWithValue("@d5", txtPassword.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Doktor Eklendi","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            txtName.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtSurname.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
           cmbBranch.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            mskTC.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            txtPassword.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete From Tbl_Doktorlar where DoktorTC = @p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", mskTC.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Doktor Silindi","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Warning);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update Tbl_Doktorlar set DoktorAd=@d1, DoktorSoyad=@d2, DoktorBrans=@d3, DoktorSifre=@d5 where DoktorTC=@d4", bgl.baglanti());
            komut.Parameters.AddWithValue("@d1", txtName.Text);
            komut.Parameters.AddWithValue("@d2", txtSurname.Text);
            komut.Parameters.AddWithValue("@d3", cmbBranch.Text);
            komut.Parameters.AddWithValue("@d4", mskTC.Text);
            komut.Parameters.AddWithValue("@d5", txtPassword.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Doktor Bilgisi Güncellendi","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
