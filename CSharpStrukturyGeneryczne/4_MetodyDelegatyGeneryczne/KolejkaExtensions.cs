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
        public static IEnumerable<Twyjscie> ElementJako<T,Twyjscie>(this IKolejka<T> kolejka)
        {
            var konwerter = TypeDescriptor.GetConverter(typeof(T)); // przechowuje konwertery dla podstawowych wartości

            foreach (var item in kolejka)
            {
                var wynik = konwerter.ConvertTo(item, typeof(Twyjscie));
                yield return (Twyjscie)wynik;
            }
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
