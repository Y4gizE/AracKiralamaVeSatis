using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryFW
{
    public class Uye: Kullanicilar
    {
        public override int ErisimSeviyesi()
        {
            return 1;
        }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Telefon { get; set; }
        public string Mail { get; set; }



    }
}
