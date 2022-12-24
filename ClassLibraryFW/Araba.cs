using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryFW
{
    public abstract class Araba
    {

        public string Marka { get; set; }
        public string Model { get; set; }
        public int Yıl { get; set; }
        private decimal _fiyat;
        public decimal Fiyat
        {
            get
            {
                return _fiyat;
            }
            set
            {
                if (value > 0)
                {
                    _fiyat = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Fiyat 0'dan büyük olmak zorunda.");
                }
            }
        }
        public decimal MotorHacmi { get; set; }
        public string YakıtTipi { get; set; }
        public string VitesTipi { get; set; }
        public string Renk { get; set; }
        public int Kilometre { get; set; }

        public virtual string GetDescription()
        {
            return $"{Yıl} {Marka} {Model} - {Renk}";
        }

        public string BilgiPaketiCagir;

        public virtual string AracBilgileriCagir()
        {
            BilgiPaketiCagir = "Bilgi paketi çağırıldı.";
            return BilgiPaketiCagir;
        }
        abstract public void Fiyat_yaz();


    }
}
