using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Metin_Belgesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string dosyaAdı, dosyaYolu;
        StreamWriter sw;

        private void button1_Click(object sender, EventArgs e)
        {
            if(folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                dosyaYolu = folderBrowserDialog1.SelectedPath;
                textBox1.Text = dosyaYolu;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dosyaYolu = textBox1.Text;
            sw = File.CreateText(dosyaYolu + "\\" + textBox2.Text + ".txt");
            sw.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
