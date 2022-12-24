using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace ClassLibraryFW
{
    public class Audi:Araba, ISes
    {
        private string AudiMarka;
        public string audimarka
        {
            get
            {
                return AudiMarka;
            }
            set
            {
                value.ToUpper();
                AudiMarka = value;
            }
        }
        private  string AudiModel;

        public string audimodel
        {
            get
            {
                return AudiModel;
            }
            set
            {
                value.ToUpper();
                AudiModel = value;
            }
        }
        public override string AracBilgileriCagir()
        {
            BilgiPaketiCagir = "AUDI bilgi paketi çağırıldı.";
            return BilgiPaketiCagir;
        }
        public override void Fiyat_yaz()
        {
            Fiyat = (Fiyat * Vergi) / 100 + Fiyat;
        }

        public void MotorSes()
        {
            SoundPlayer ses = new SoundPlayer();
            string dizin;
            dizin = "audises.mp3";
            ses.SoundLocation = dizin;
            ses.Play();
        }

    }
}
