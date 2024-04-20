using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KullaniciGiris
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            
            string kullaniciAdi =txtKullaniciAdi.Text;
            string sifre= txtSifre.Text;

            kullanici bulunanKullanici = sanalDatabase.KullaniciTablo.Find(i=> i.kullaniciAdi == kullaniciAdi && i.sifre==sifre);

            if (bulunanKullanici != null)
            {
               
                anaForım _anaForum = new anaForım(bulunanKullanici);
                _anaForum.Show();

            }
            else
            {
                MessageBox.Show("Hatalı Giriş Yaptınız !","HATA",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }



        }

        private void txtKullaniciAdi_Enter(object sender, EventArgs e)
        {
            TextBox T1 = (TextBox)sender;
            T1.BackColor = Color.AliceBlue;
        }

        private void txtKullaniciAdi_Leave(object sender, EventArgs e)
        {
            TextBox T1 = (TextBox)sender;
            T1.BackColor = Color.White;
        }
    }
}
