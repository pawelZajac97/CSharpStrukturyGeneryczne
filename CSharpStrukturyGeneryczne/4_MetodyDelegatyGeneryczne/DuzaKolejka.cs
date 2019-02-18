using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_MetodyDelegatyGeneryczne
{
    public class DuzaKolejka<T> : IKolejka<T>
    {
        protected Queue<T> kolejka = new Queue<T>();

        public DuzaKolejka()
        {
            Queue<T> kolejka = new Queue<T>();
        }

        public virtual bool JestPelny => throw new System.NotImplementedException();

        public virtual bool JestPusty
        {
            get
            {
                return kolejka.Count == 0;
            }
        }

        public virtual T Czytaj()
        {
            return kolejka.Dequeue();
        }

        public virtual void Zapisz(T wartosc)
        {
            kolejka.Enqueue(wartosc);
        }

  

        public IEnumerator<T> GetEnumerator() // pozwala robic iteracje po kolekcji
        {
            //return kolejka.GetEnumerator();
            foreach (var item in kolejka)
            {
                // filtrowanie
                yield return item; // Z enumaratora będą zwraca wartości pojedynczo
            }
        }

        IEnumerator IEnumerable.GetEnumerator() // zwraca GetEnumerator który pozwala użyć go w metodzie wyżej GetEnumaerator();
        {
            return GetEnumerator();

        }


    }
}

