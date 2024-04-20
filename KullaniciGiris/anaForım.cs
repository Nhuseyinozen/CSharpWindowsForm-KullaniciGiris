using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KullaniciGiris
{
    public partial class anaForım : Form
    {

        public anaForım(kullanici bulunanKullanici)
        {
            InitializeComponent();

            txtAciklama.Text = bulunanKullanici.aciklama;
            txtIsım.Text = bulunanKullanici.isim;
            txtKullaniciAdi.Text = bulunanKullanici.kullaniciAdi;
            txtKullaniciAdi.Enabled = false;
            txtSifre.Text = bulunanKullanici.sifre;
            txtSoyisim.Text = bulunanKullanici.soyisim;
            btnGuncelle.Tag = bulunanKullanici.id;
        }
        private void btnGuncelle_Click_1(object sender, EventArgs e)
        {
            int gelenId = (int)btnGuncelle.Tag;

            int Index = sanalDatabase.KullaniciTablo.FindIndex(i => i.id == gelenId);

            sanalDatabase.KullaniciTablo[Index].sifre = txtSifre.Text;
            sanalDatabase.KullaniciTablo[Index].aciklama = txtAciklama.Text;
            sanalDatabase.KullaniciTablo[Index].isim = txtIsım.Text;
            sanalDatabase.KullaniciTablo[Index].soyisim = txtSoyisim.Text;
            MessageBox.Show("GÜNCELLEME BAŞARILI", "Güncel", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }
    }
}
