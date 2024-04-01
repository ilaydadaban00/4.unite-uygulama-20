using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4.unite_20.uygulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVeri_Click(object sender, EventArgs e)
        {
            Ogrenciler ogrenci = new Ogrenciler();
            ogrenci.alan = "bilişim";
            ogrenci.adSoyad = "ilayda";
            ogrenci.numara = 1111;
            txtNumara.DataBindings.Add("Text", ogrenci, "numara");
            txtAdSoyad.DataBindings.Add("Text", ogrenci, "AdSoyad");
            txtAlan.DataBindings.Add("Text", ogrenci, "Alan");



        }
    }
}
