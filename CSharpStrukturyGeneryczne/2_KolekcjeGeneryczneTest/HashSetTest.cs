using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _2_KolekcjeGeneryczneTest
{
    [TestClass]
    public class HashSetTest
    {
        [TestMethod]
        public void IntersectSets()
        {
            var set1 = new HashSet<int> { 1, 2, 3 };
            var set2 = new HashSet<int> { 2, 3, 4 };
            set1.IntersectWith(set2); // zwraca nam elementy wspólne dwóch hash set i zapisuje je w set1
            Assert.IsTrue(set1.SetEquals(new[] { 2, 3 }));
        }

        public void UnionSets()
        {
            var set1 = new HashSet<int> { 1, 2, 3 };
            var set2 = new HashSet<int> { 2, 3, 4 };
            set1.UnionWith(set2); // łączy oba zestawy. Wynikowy set 1 ma elementy z obu setów
            Assert.IsTrue(set1.SetEquals(new[] { 1, 2, 3, 4 }));
        }
        public void SymmetricExceptWith()
        {
            var set1 = new HashSet<int> { 1, 2, 3 };
            var set2 = new HashSet<int> { 2, 3, 4 };
            set1.SymmetricExceptWith(set2); // różnica setów zapisana 
            Assert.IsTrue(set1.SetEquals(new[] { 1, 4 }));
        }

        public void RemoveSets()
        {
            var set1 = new HashSet<int> { 1, 2, 3 };
            var set2 = new HashSet<int> { 2, 3, 4 };
            set1.Remove(1); // usuwa z seta wybrany element
            Assert.IsTrue(set1.SetEquals(new[] { 2, 3 }));
            Assert.AreEqual(2, set1.Count);
        }
        public void RemoveWhereSets()
        {
            var set1 = new HashSet<int> { 1, 2, 3 };
            var set2 = new HashSet<int> { 2, 3, 4 };
            set1.RemoveWhere(x => x > 1); // usuwa z seta elementy zgodne z warunkiem
            Assert.AreEqual(1, set1.Count); 
        }

        public void ContainsSets()
        {
            var set1 = new HashSet<int> { 1, 2, 3 };
            // sprawdza czy set zawiera element 3
            Assert.IsTrue(set1.Contains(3));
        }

    }
}
