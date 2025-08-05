using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KDV_Uygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string urunAdi;
            //int urunFiyati;
            //double kdvTutari, toplamFiyat;

            //try
            //{
            //    urunAdi = textBox1.Text.Trim();
            //    urunFiyati = Convert.ToInt32(textBox2.Text);

            //    KDV hesaplama
            //    kdvTutari = urunFiyati * 0.18;
            //    toplamFiyat = urunFiyati + kdvTutari;

            //    ListBox'a yazdır
            //    listBox1.Items.Add("——————————————");
            //    listBox1.Items.Add($"Ürün Adı: {urunAdi}");
            //    listBox1.Items.Add($"Net Fiyat: {urunFiyati} ₺");
            //    listBox1.Items.Add($"KDV (%18): {kdvTutari:F2} ₺");
            //    listBox1.Items.Add($"Toplam Fiyat: {toplamFiyat:F2} ₺");
            //}
            //catch (FormatException)
            //{
            //    MessageBox.Show("Lütfen ürün fiyatını sayısal olarak giriniz.", "Hatalı Giriş", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}

        }
    }
}
