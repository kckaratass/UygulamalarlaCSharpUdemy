using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Karar_Yapilari_Pratik
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int kitapadet;
            double toplam;

            kitapadet = Convert.ToInt32(textBox1.Text);

            if(kitapadet >= 0 && kitapadet <= 20)
            {
                toplam = (kitapadet * 8) * (0.8);
                label3.Text = toplam + "TL";
            }
            if(kitapadet >= 21 && kitapadet <= 40)
            {
                toplam = (kitapadet * 8) * (0.6);
                label3.Text = toplam + "TL";
            }
            if(kitapadet >= 41)
            {
                toplam = (kitapadet * 8) * (0.5);
                label3.Text = toplam + "Tl";
            }
        }
    }
}

// 0-20 ==> % 20  /* Uygulanacak 
// 21-40 ==> %40     İndirim
// 41++ ==> %50      Tutarları */
