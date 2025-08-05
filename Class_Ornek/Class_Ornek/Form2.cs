using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Class_Ornek
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Araba rb2 = new Araba();
            rb2.renk = "Beyaz";
            rb2.hiz = 140;
            rb2.motor = 1220.36;
            rb2.fiyat = 120000;
            rb2.durum = 'i';

            label1.Text = "Renk: " + rb2.renk;
            label2.Text = "Hız: " + rb2.hiz.ToString();
            label3.Text = "Motor: " + rb2.motor.ToString();
            label4.Text = "Fiyat: " + rb2.fiyat.ToString();
            label5.Text = "Durum: " + rb2.durum.ToString();
        }
    }
}
