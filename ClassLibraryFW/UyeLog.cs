using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryFW
{
    public class UyeLog
    {
        private List<Uye> _uye;

        public UyeLog()
        {
            _uye = new List<Uye>();
        }

        public void UyeEkle(Uye uye)
        {
            _uye.Add(uye);
        }

        public void UyeSil(Uye uye)
        {
            _uye.Remove(uye);
        }

        
    }
}
