using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_McAdan
{
    public class Menuler : Urun
    {
        //Bir menunun nesi olur?

        //public string MenuAdi { get; set; }
        //public decimal MenuFiyat { get; set; }

       public static List<Menuler> menuListesi = new List<Menuler>();
        public override string ToString()
        {
            return $"{Ad} {Fiyat} TL";
        }

    }
}
