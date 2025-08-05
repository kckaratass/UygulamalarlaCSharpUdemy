using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Variables_Double
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //double sayi;
            //sayi = 4.25;
            //label1.Text = sayi.ToString();

            //double s1, s2, s3, ortalama;

            //s1 = 60;
            //s2 = 70;
            //s3 = 79;

            //ortalama = (s1 + s2 + s3) / 3;

            //label1.Text = ortalama.ToString("0.00");

            double sayi = Convert.ToDouble(textBox1.Text);
            label1.Text = sayi.ToString();
        }
    }
}
