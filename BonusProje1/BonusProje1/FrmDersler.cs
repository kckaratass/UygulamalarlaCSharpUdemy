using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BonusProje1
{
    public partial class FrmDersler : Form
    {
        public FrmDersler()
        {
            InitializeComponent();
        }

        private void FrmDersler_Load(object sender, EventArgs e)
        {
            DataSet1TableAdapters.TBLDERSLERTableAdapter ds = new DataSet1TableAdapters.TBLDERSLERTableAdapter();
            dataGridView1.DataSource = ds.DersListesi();
        }
    }
}
