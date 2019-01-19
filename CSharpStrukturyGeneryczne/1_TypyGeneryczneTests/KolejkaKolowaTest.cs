using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _1_TypyGeneryczne;

namespace _1_TypyGeneryczneTests
{
    [TestClass]
    public class KolejkaKolowaTest
    {
        [TestMethod]
        public void NowaKolejkaJestPusta()
        {
            var Kolejka = new KolejkaKolowa();
            Assert.IsTrue(Kolejka.JestPusty);
        }

        [TestMethod]
        public void KolejkaTrzyElementowaJestPelnaPoTrzechZapisach()
        {
            var Kolejka = new KolejkaKolowa(3);
            Kolejka.Zapisz(3.8);
            Kolejka.Zapisz(5.7);
            Kolejka.Zapisz(9.3);
            Assert.IsTrue(Kolejka.JestPelny);
        }

        public void PierwszyWchodziPierwszyWychodzi()
        {
            var Kolejka = new KolejkaKolowa(3);
            var wartosc1 = 4.6;
            var wartosc2 = 3.7;
            Kolejka.Zapisz(wartosc1);
            Kolejka.Zapisz(wartosc2);

            Assert.AreEqual(wartosc1, Kolejka.Czytaj());
            Assert.AreEqual(wartosc2, Kolejka.Czytaj());
            Assert.IsTrue(Kolejka.JestPusty);
        }

        public void NadpisujeGdyJestWiekszaNizPojemnosc()
        {
            var Kolejka = new KolejkaKolowa(3);
            var wartosci = new[] { 1.2, 2.4, 3.6, 4.8, 5.3, 6.8 };

            foreach (var wartosc in wartosci)
            {
                Kolejka.Zapisz(wartosc);
            }
            Assert.IsTrue(Kolejka.JestPelny);
            Assert.AreEqual(wartosci[3], Kolejka.Czytaj());
            Assert.AreEqual(wartosci[4], Kolejka.Czytaj());
            Assert.AreEqual(wartosci[5], Kolejka.Czytaj());
            Assert.IsTrue(Kolejka.JestPusty);
        }
    }
}

