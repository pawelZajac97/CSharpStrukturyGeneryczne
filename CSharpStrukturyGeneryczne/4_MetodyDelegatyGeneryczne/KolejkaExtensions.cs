using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_MetodyDelegatyGeneryczne
{

    

    public static class KolejkaExtensions
    {
        public static IEnumerable<Twyjscie> Mapuj<T,Twyjscie>(this IKolejka<T> kolejka, Converter<T,Twyjscie> konwerter)
        {

            return kolejka.Select(i => konwerter(i));
        }

        public static void Drukuj<T>(this IKolejka<T> kolejka, Action<T> drukuj)
        {
            foreach (var item in kolejka)
            {
                drukuj(item);
            }
        }
    }
}
