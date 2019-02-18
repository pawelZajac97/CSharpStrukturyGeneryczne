using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_MetodyDelegatyGeneryczne
{
 
        public class KolejkaKolowa<T> : DuzaKolejka<T>
        {
            private int _pojemnosc;

            public event EventHandler<ElementUsunietyEventArgs<T>> elementUsunięty;


            public KolejkaKolowa(int pojemnosc = 5)
            {
                _pojemnosc = pojemnosc;
            }

            public override void Zapisz(T wartosc)
            {
                base.Zapisz(wartosc);
                if (kolejka.Count > _pojemnosc)
                {
                   var usuniety = kolejka.Dequeue();
                   PoUsunieciuElementu(usuniety, wartosc);
                }
            }

        private void PoUsunieciuElementu(T usuniety, T wartosc)
        {
            if (elementUsunięty != null)
            {
                var args = new ElementUsunietyEventArgs<T>(usuniety, wartosc);
                elementUsunięty(this, args);
            }
        }

        public override bool JestPelny
            {
                get
                {
                    return kolejka.Count == _pojemnosc;
                }
            }


    }
    public class ElementUsunietyEventArgs<T> : EventArgs
    {
        public T ElementUsuniety { get; set; }
        public T ElementNowy { get; set; }

        public ElementUsunietyEventArgs(T elementusuniety, T elementnowy)
        {
            ElementUsuniety = elementusuniety;
            ElementNowy = elementnowy;
        }
    }
    
}
