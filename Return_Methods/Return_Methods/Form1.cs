using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Return_Methods
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int Toplam(int n1, int n2)
        {
            int n3 = n1 + n2;
            return n3;
        }

        int carpma(int n1, int n2, int n3)
        {
            int n4 = n1 * n2 * n3;
            return n4;
        }

        int kup(int n1)
        {
            int n2 = n1 * n1 * n1;
            return n2;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = Toplam(4, 6).ToString();
            label2.Text = Toplam(2, 3).ToString();
            label3.Text = Toplam(4, 8).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = carpma(4, 6, 2).ToString();
            label2.Text = carpma(2, 6, 2).ToString();
            label3.Text = carpma(4, 8, 2).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int n2 = Convert.ToInt32(textBox1.Text);
            label1.Text = kup(n2).ToString();
        }
    }
}
