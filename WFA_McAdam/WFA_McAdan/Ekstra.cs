using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_McAdan
{
    public class Ekstralar:Urun
    {
      public static  List<Ekstralar> ekstraListesi = new List<Ekstralar>();
        public override string ToString()
        {
            return $"{Ad} {Fiyat} TL";
        }
    }
}
