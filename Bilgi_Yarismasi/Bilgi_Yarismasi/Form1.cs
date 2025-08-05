//using System;
//using System.Windows.Forms;

//namespace Bilgi_Yarismasi
//{
//    public partial class Form1 : Form
//    {
//        public Form1()
//        {
//            InitializeComponent();
//        }

//        int soruNo = 0, dogru = 0, yanlis = 0;
//        string dogruCevap = "";

//        private void Form1_Load(object sender, EventArgs e)
//        {
//            // Girişte doğru ve yanlış görsellerini gizle
//            pictureBox1.Visible = false;
//            pictureBox2.Visible = false;
//        }

//        private void BtnSecenek_Click(object sender, EventArgs e)
//        {
//            Button secilenButon = (Button)sender;
//            string kullaniciCevap = secilenButon.Text;

//            if (kullaniciCevap == dogruCevap)
//            {
//                dogru++;
//                label6.Text = dogru.ToString();
//                pictureBox1.Visible = true;
//            }
//            else
//            {
//                yanlis++;
//                label5.Text = yanlis.ToString();
//                pictureBox2.Visible = true;
//            }

//            // Butonları devre dışı bırak
//            BtnA.Enabled = false;
//            BtnB.Enabled = false;
//            BtnC.Enabled = false;
//            BtnD.Enabled = false;
//        }

//        private void BtnSonraki_Click(object sender, EventArgs e)
//        {
//            soruNo++;
//            lblSoruNo.Text = soruNo.ToString();

//            // Görselleri gizle
//            pictureBox1.Visible = false;
//            pictureBox2.Visible = false;

//            // Butonları aktif et
//            BtnA.Enabled = true;
//            BtnB.Enabled = true;
//            BtnC.Enabled = true;
//            BtnD.Enabled = true;

//            // Sorular
//            if (soruNo == 1)
//            {
//                richTextBox1.Text = "Cumhuriyet kaç yılında ilan edilmiştir?";
//                BtnA.Text = "1920";
//                BtnB.Text = "1921";
//                BtnC.Text = "1922";
//                BtnD.Text = "1923";
//                dogruCevap = "1923";
//            }
//            else if (soruNo == 2)
//            {
//                richTextBox1.Text = "Türkiye Cumhuriyeti'nin ilk başbakanı kimdir?";
//                BtnA.Text = "Mustafa Kemal Atatürk";
//                BtnB.Text = "İsmet İnönü";
//                BtnC.Text = "Fevzi Çakmak";
//                BtnD.Text = "Celal Bayar";
//                dogruCevap = "İsmet İnönü";
//            }
//            else if (soruNo == 3)
//            {
//                richTextBox1.Text = "Türkiye'nin başkenti neresidir?";
//                BtnA.Text = "İstanbul";
//                BtnB.Text = "Ankara";
//                BtnC.Text = "İzmir";
//                BtnD.Text = "Bursa";
//                dogruCevap = "Ankara";
//            }
//            else
//            {
//                MessageBox.Show("Yarışma Bitti!\nDoğru: " + dogru + "\nYanlış: " + yanlis);
//                BtnSonraki.Enabled = false;
//            }
//        }
//    }
//}
