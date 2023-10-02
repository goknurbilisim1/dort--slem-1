using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace degisken_ornek_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            double sayi1, sayi2, toplam, fark, carp, bol;

            sayi1 = Convert.ToDouble(txtSayi1.Text);
            sayi2= Convert.ToDouble(txtSayi2.Text);

            toplam = sayi1 + sayi2;
            fark = sayi1 - sayi2;
            carp = sayi1 * sayi2;
            bol = sayi1 / sayi2;

            lblToplam.Text = "Toplam: " + toplam;
            lblFark.Text = "Fark: " + fark;
            lblCarp.Text = "Çarpım: " + carp;
            lblBol.Text = "Bölüm: " + bol;




        }
    }
}
