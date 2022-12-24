using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryFW
{
    public abstract class Kullanicilar: IKullaniciBilgi
    {
        private string _sifre;
        public string Adı { get; set; }
        public string Soyadı { get; set; }
        public string MailAdresi { get; set; }

        public int Telefon { get; set; }
        public abstract int ErisimSeviyesi();

        public string Bilgi()
        {
            return "(ad)  (soyad)  (mail)  (telefon)";
        }
        public void SifreAta(string sifre) 
        {
            _sifre = sifre;
        }
        public bool sifreDogrula(string sifre) 
        {
            return sifre == _sifre;
        }
        public static Uye RegisterMember(string ad, string soyad, string email, string password)
        {
            var uye = new Uye
            {
                Adı = ad,
                Soyadı = soyad,
                MailAdresi = email
            };
            uye.SifreAta(password);
            return uye;
        }
    }
}
