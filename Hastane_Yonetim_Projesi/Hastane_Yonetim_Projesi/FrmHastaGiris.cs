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
    public partial class FrmHastaGiris : Form
    {
        public FrmHastaGiris()
        {
            InitializeComponent();
        }

        SqlBaglantisi bgl = new SqlBaglantisi();
        private void lnkSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmHastaKayit frmHastaKayit = new FrmHastaKayit();
            frmHastaKayit.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * From Tbl_Hastalar where HastaTc = @p1 and HastaSifre = @p2", bgl.baglanti());
            
            komut.Parameters.AddWithValue("@p1", mskTC.Text);
            komut.Parameters.AddWithValue("@p2", txtPassword.Text);

            SqlDataReader dr = komut.ExecuteReader();
            if(dr.Read())
            {
                FrmHastaDetay frmHastaDetay = new FrmHastaDetay();
                frmHastaDetay.tc = mskTC.Text;
                frmHastaDetay.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı TC veya Şifre", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            bgl.baglanti().Close();
        }
    }
}
