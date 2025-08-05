using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Methods
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void temizle()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox1.Focus(); // TextBox1'e odaklanır
        }

        void renklendir()
        {
            textBox1.BackColor = Color.Green;
            textBox2.BackColor = Color.SaddleBrown;
            textBox3.BackColor = Color.Firebrick;
            textBox4.BackColor = Color.Tan;
        }

        void bilgileriyaz()
        {
            textBox1.Text = "Kadir Can" + textBox1.Text;
            textBox2.Text = "Karataş" + textBox2.Text;
            textBox3.Text = "22" + textBox3.Text;
            textBox4.Text = "Öğrenci" + textBox4.Text;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            renklendir();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bilgileriyaz();
        }
    }
}
