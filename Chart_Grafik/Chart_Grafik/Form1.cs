using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chart_Grafik
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            chart1.Series["Kitap"].Points.AddXY("Akdeniz", 5);
            chart1.Series["Kitap"].Points.AddXY("Ege", 8);
            chart1.Series["Kitap"].Points.AddXY("İç Anadolu", 3);
            chart1.Series["Kitap"].Points.AddXY("Karadeniz", 6);
            chart1.Series["Kitap"].Points.AddXY("Marmara", 10);
            chart1.Series["Kitap"].Points.AddXY("Doğu Anadolu", 1);
            chart1.Series["Kitap"].Points.AddXY("Güneydoğu Anadolu", 4);
        }
    }
}
