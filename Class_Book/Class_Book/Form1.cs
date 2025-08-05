using System;
using System.Windows.Forms;

namespace Class_Book
{
    public partial class Form1 : Form
    {
        Book b = new Book();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
          
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            b.Title = txtTitle.Text;
            b.Author = txtAuthor.Text;
            b.PageCount = Convert.ToInt32(txtPageCount.Text);
            b.IsRead = false;

            textBox1.Text = b.GetInfo(); // Bilgiyi listBox'a ekle
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            // Kitap bilgilerini dolduralım
            b.Title = "The Great Gatsby";
            b.Author = "F. Scott Fitzgerald";
            b.PageCount = 218;
            b.IsRead = true;

            // Bilgileri textBox'a yaz
            textBox1.Text = b.GetInfo();
        }
    }
}
