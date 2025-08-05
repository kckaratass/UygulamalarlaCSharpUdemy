using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Karar_Yapilari_Egzersiz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double vize, final, proje, ortalama;
            string durum;

            vize = Convert.ToDouble(textBox1.Text);
            final = Convert.ToDouble(textBox2.Text);
            proje = Convert.ToDouble(textBox3.Text);

            ortalama = (vize * 0.3 + final * 0.6 + proje * 0.1);

            if(ortalama >= 50)
            {
                durum = "Geçti";
            }
            else
            {
                durum = "Kaldı";
            }
            textBox4.Text = ortalama.ToString("0.00") + " / " + durum;
        }
    }
}
