using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryFW
{
    public class Admin : Kullanicilar, IKullaniciBilgi
    {
        public override int ErisimSeviyesi()
        {
            return 2;
        }

    }
}
