using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Variables_Sting
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*string metin;
            metin = "Merhaba Bugün 15 Temmuz Salı Günü";
            label1.Text = metin;*/

            //string adsoyad, meslek;

            //adsoyad = "Tuğçe Karataş";
            //meslek = "Mühendis";

            //label1.Text = adsoyad;
            //label2.Text = meslek;

            //string şehir;
            //şehir = textBox1.Text;
            //label1.Text = şehir;
            
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Bu alan boş olabilir ya da işlem yapabilirsin
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //string adsoyad, meslek, şehir;

            //listBox1.Items.Add("Ad Soyad: " + textBox1.Text);
            //listBox1.Items.Add("Meslek: " + textBox2.Text);
            //listBox1.Items.Add("Şehir: " + textBox3.Text);
        }
    }
}
