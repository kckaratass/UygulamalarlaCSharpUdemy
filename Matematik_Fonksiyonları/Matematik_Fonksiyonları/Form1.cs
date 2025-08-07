using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matematik_Fonksiyonları
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sayi = Convert.ToDouble(textBox1.Text);
            // label2.Text = "Mutlak Değer: " + Math.Abs(sayi).ToString();
            // label2.Text = "Yuvarlanmış Değer: " + Math.Ceiling(sayi).ToString();
            // label2.Text = "Yuvarlanmış Değer: " + Math.Floor(sayi).ToString();
            // label2.Text = "Kuvvet: " + Math.Pow(sayi, 2).ToString();
            label2.Text = "Karekök: " + Math.Sqrt(sayi).ToString();
        }
    }
}

/*
 * Abs = Matematiksel mutlak değer fonksiyonudur.
 * Ceil = Sayıyı bir üst tam sayıya yuvarlar.
 * Floor = Sayıyı bir alt tam sayıya yuvarlar.
 * Pow = Sayının kuvvetini alır.
 * sqrt = Sayının karekökünü alır.
 */