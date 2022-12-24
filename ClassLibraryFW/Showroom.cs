using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryFW
{
    public class Showroom
    {
        private List<Araba> _araba;

        public Showroom()
        {
            _araba = new List<Araba>();
        }

        public void ArabaEkle(Araba araba)
        {
            _araba.Add(araba);
        }

        public void ArabaSat(Araba araba)
        {
            _araba.Remove(araba);
        }

        public void ArabaSil(Araba araba)
        {
            _araba.Remove(araba);
        }

        public void ArabaKirala(Araba car, Uye uye,DateTime startDate, DateTime endDate)
        {
            _araba.Remove(car);

            KiraSozlesmesi sozlesme = new KiraSozlesmesi
            {
                Uye = musteri,
                Car = car,
                StartDate = startDate,
                EndDate = endDate
            };

            // add the rental agreement to a list of rental agreements as needed...
        }
    }


}
