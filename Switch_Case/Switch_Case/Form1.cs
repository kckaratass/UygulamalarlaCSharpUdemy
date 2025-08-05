using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Switch_Case
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //int ay = Convert.ToInt32(textBox1.Text);
            //switch(ay)
            //{
            //    case 1: label2.Text = "Ocak";
            //            break;
            //    case 2: label2.Text = "Şubat";
            //            break;
            //    case 3: label2.Text = "Mart";
            //            break;
            //    case 4: label2.Text = "Nisan";
            //            break;
            //    case 5: label2.Text = "Mayıs";
            //            break;
            //    case 6: label2.Text = "Haziran";
            //            break;
            //    case 7: label2.Text = "Temmuz";
            //            break;
            //    case 8: label2.Text = "Ağustos";
            //            break;
            //    case 9: label2.Text = "Eylül";
            //            break;
            //    case 10: label2.Text = "Ekim";
            //            break;
            //    case 11: label2.Text = "Kasım";
            //            break;
            //    case 12: label2.Text = "Aralık";
            //            break;
            //    default: label2.Text = "Geçersiz Ay";
            //            break;
            //}

            //string mevsim = textBox1.Text;
            //switch(mevsim)
            //{
            //    case "Yaz": label2.Text = "Haziran,Temmuz,Ağustos";
            //                                break;
            //    case "Sonbahar": label2.Text = "Eylül,Ekim,Kasım";
            //                                break;
            //    case "Kış": label2.Text = "Aralık,Ocak,Şubat";
            //                                break;
            //    default: label2.Text = "Geçersiz Mevsim";
            //                                break;  
            //}

            // konsoldan girilen sembole göre işlem yapma
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
        //    int sayi1, sayi2;

        //    sayi1 = Convert.ToInt32(textBox1.Text);  // Örn: 5
        //    sayi2 = Convert.ToInt32(textBox2.Text);  // Örn: 3
        //    string islem = textBox3.Text;            // Örn: "+"

        //    switch (islem)
        //    {
        //        case "+":
        //            listBox1.Items.Add((sayi1 + sayi2).ToString());
        //            break;

        //        case "-":
        //            listBox1.Items.Add((sayi1 - sayi2).ToString());
        //            break;

        //        case "*":
        //            listBox1.Items.Add((sayi1 * sayi2).ToString());
        //            break;

        //        case "/":
        //            if (sayi2 != 0)
        //                listBox1.Items.Add((sayi1 / sayi2).ToString());
        //            else
        //                listBox1.Items.Add("Sıfıra bölünemez!");
        //            break;

        //        default:
        //            listBox1.Items.Add("Geçersiz işlem!");
        //            break;
        //    }

        //}

        //private void button2_Click(object sender, EventArgs e)
        //{
        //    listBox1.Items.Clear();
        //}
    }
}
