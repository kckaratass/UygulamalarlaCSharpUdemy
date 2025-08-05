using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loops_Donguler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // for Loop
        private void button1_Click(object sender, EventArgs e)
        {
            //int i;
            //for(i = 1; i <= 10; i++)
            //{
            //    listBox1.Items.Add("Merhaba Ankara");
            //}

            //for(i = 1; i <= 90; i++)
            //{
            //    listBox1.Items.Add(i + "Merhaba Dünya");
            //}

            //for(i = 0; i < 10; i+= 2)
            //{
            //    listBox1.Items.Add(i);
            //}

            // Döngülerde ardışık sayıların toplamını bulma;

            //int toplam = 0;
            //for(int i = 1; i <= 10; i++)
            //{
            //    toplam += i; // toplam = toplam + i;
            //}
            //label1.Text = "Toplam: " + toplam.ToString();

            // 1'den 100'e kadar olan çift sayıların toplamını bulma;

            //int toplam = 0;

            //for (int i = 1; i <= 100; i++)
            //{
            //    if(i % 2 == 0) // Çift sayılar
            //    {
            //        toplam += i; // toplam = toplam + i;
            //    }
            //}
            //label2.Text = toplam.ToString();

            // 1'den 100'e kadar olan tek sayıların toplamını bulma;

            //int toplam = 0;

            //for(int i = 1; i <= 100; i++)
            //{
            //    if(i % 2 != 0) // Tek Sayılar 
            //    {
            //        toplam += i;
            //    } 
            //}
            //label2.Text = toplam.ToString();

            // 1'den 100'e kadar olan sayılardan 5 ve 7'ye tam bölünen sayılar 

            //for(int i = 1; i <= 100; i++)
            //{
            //    if(i % 5 == 0 && i % 7 == 0) // 5 ve 7'ye tam bölünen sayılar
            //    {
            //       label2.Text += i.ToString() + " "; // label2.Text = label2.Text + i.ToString() + " ";
            //    }
            //}

            //int sayi = Convert.ToInt32(textBox1.Text);

            //for( int i = 1; i <= sayi; i++)
            //{
            //    if(sayi % i == 0) // sayının bölenlerini bulma 
            //    {
            //        listBox1.Items.Add(i); // sayının bölenlerini listeye ekleme
            //    } 
            //}

            // Klavyeden girilen sayının faktöriyelini hesaplama

            //int sayi = Convert.ToInt32(textBox1.Text);

            //int faktoriyel = 1;

            //for(int i = 1; i <= sayi; i++)
            //{
            //    faktoriyel *= i; // faktoriyel = faktoriyel * i;
            //}
            //listBox1.Items.Add(sayi + " sayının faktöriyel değeri: " + faktoriyel.ToString());
        }
    }
}
