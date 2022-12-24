using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace ClassLibraryFW
{
    public class Ford : Araba , ISes
    {
        private string FordMarka;
        public string fordmarka 
        {
            get
            {
                return FordMarka;
            }
            set
            {
                value.ToUpper();
                FordMarka = value;
            }
        }
        private  string FordModel;
        public string fordmodel
        {
            get
            {
                return FordModel;
            }
            set
            {
                value.ToUpper();
                FordModel = value;
            }
        }
        public override string AracBilgileriCagir()
        {
            BilgiPaketiCagir = "Ford bilgi paketi çağırıldı.";
            return BilgiPaketiCagir;
        }
        public override void Fiyat_yaz()
        {
            int Vergi = 18;
            Fiyat = (Fiyat * Vergi)/100 + Fiyat;
        }

        public void MotorSes()
        {
            SoundPlayer ses = new SoundPlayer();
            string dizin;
            dizin = "fordses.mp3";
            ses.SoundLocation = dizin;
            ses.Play();
        }



        
    }
}
