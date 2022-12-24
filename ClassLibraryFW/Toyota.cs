using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace ClassLibraryFW
{
    public class Toyota : Araba, ISes
    {
        private  string ToyotaMarka;
        public string toyotamarka
        {
            get
            {
                return ToyotaMarka;
            }
            set
            {
                value.ToUpper();
                ToyotaMarka = value;
            }
        }
        private string ToyotaModel;
        public string toyotamodel
        {
            get
            {
                return ToyotaModel;
            }
            set
            {
                value.ToUpper();
                ToyotaModel = value;
            }
        }
        public override string AracBilgileriCagir()
        {
            BilgiPaketiCagir = "Toyota bilgi paketi çağırıldı.";
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
            dizin = "toyotases.mp3";
            ses.SoundLocation = dizin;
            ses.Play();
        }

    }
}
