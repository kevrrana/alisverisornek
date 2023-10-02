using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace alisveris_ornek1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtBirimFiyat_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            int birimfiyat, adet, toplamtutar;
            birimfiyat = Convert.ToInt32(txtBirimFiyat.Text);

            adet = Convert.ToInt32(txtAdet.Text);
            toplamtutar = birimfiyat * adet;
            lblToplamTutar.Text = "TOPLAM TUTAR: "+toplamtutar.ToString();
        }
    }
}
