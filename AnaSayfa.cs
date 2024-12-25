using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisualProje
{
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            InitializeComponent();
        }

        private void AnaSayfa_Load(object sender, EventArgs e)
        {

        }

        private void btnÜyeEkle_Click(object sender, EventArgs e)
        {
            ÜyeEkle uyeEkle = new ÜyeEkle();
            uyeEkle.ShowDialog();
        }

        private void btnÜyeListele_Click(object sender, EventArgs e)
        {
            UyeListele uyeListele = new UyeListele();
            uyeListele.ShowDialog();
        }

        private void btnKitapEkle_Click(object sender, EventArgs e)
        {
            KitapEkle kitapEkle = new KitapEkle();
            kitapEkle.ShowDialog();

        }

        private void btnKitapListele_Click(object sender, EventArgs e)
        {
            KitapListele kitapListele = new KitapListele();
            kitapListele.ShowDialog();
        }

        private void btnEmanetVer_Click(object sender, EventArgs e)
        {
            EmanetKitapVer emanetKitapVer = new EmanetKitapVer();
            emanetKitapVer.ShowDialog();
        }

        private void btnEmanetListele_Click(object sender, EventArgs e)
        {
            EmanetKitapListele emanetKitapListele = new EmanetKitapListele();
            emanetKitapListele.ShowDialog();
        }

        private void btnEmanetİade_Click(object sender, EventArgs e)
        {
            EmanetKitapİade emanetKitapİade = new EmanetKitapİade();
            emanetKitapİade.ShowDialog();
        }

        private void btnSırala_Click(object sender, EventArgs e)
        {
            Sıralama sıralama = new Sıralama();
            sıralama.ShowDialog();
        }
    }
}
