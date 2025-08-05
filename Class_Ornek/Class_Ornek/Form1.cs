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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Araba rb = new Araba();
            rb.renk = "Beyaz";
            rb.hiz = 160;
            rb.motor = 1245.56;
            rb.fiyat = 150000;
            rb.durum = 's';
            rb.YIL = -2018; // Yıl değerini atama
            rb.MARKASI = "golf"; // Marka değerini atama
            rb.muayene = 2020; // Muayene değerini atama
            rb.plaka = "14 ADB 949"; // Plaka değerini atama
            rb.sahip = "Kadir Can Karataş"; // Sahip değerini atama

            label1.Text = "Renk: " + rb.renk;
            label2.Text = "Hız: " + rb.hiz.ToString();
            label3.Text = "Motor: " + rb.motor.ToString();
            label4.Text = "Fiyat: " + rb.fiyat.ToString(); 
            label5.Text = "Durum: " + rb.durum.ToString();
            label6.Text = "Yıl: " + rb.YIL.ToString();
            label7.Text = "Marka: " + rb.MARKASI;
            label8.Text = "Muayene: " + rb.muayene.ToString();
            label9.Text = "Plaka: " + rb.plaka;
            label10.Text = "Sahip: " + rb.sahip;
        }
    }
}
