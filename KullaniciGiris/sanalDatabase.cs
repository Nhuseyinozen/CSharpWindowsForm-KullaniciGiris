using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KullaniciGiris
{
    public class sanalDatabase
    {
        public static List<kullanici> KullaniciTablo = new List<kullanici>();

        static sanalDatabase()
        {
            KullaniciTablo.Add(new kullanici()
            {
                id = 1,
                isim = "Hüseyin",
                soyisim = "Özen",
                sifre = "1",
                kullaniciAdi = "Huseyin.Ozen",
                aciklama = "Hüseyin Özen profiline giriş yapıldı"
            });

            KullaniciTablo.Add(new kullanici()
            {
                id = 2,
                isim = "Emir",
                soyisim = "Özen",
                sifre = "2",
                kullaniciAdi = "Emir.Ozen",
                aciklama = "Emir Özen profiline giriş yapıldı"
            });


        }






    }
}
