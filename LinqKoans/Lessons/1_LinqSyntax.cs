using System;
using System.Linq;
using LinqKoans.TestsAndUtilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LinqKoans.Lessons
{
    [TestClass]
    public class LinqSyntax
    {
        /// <summary>
        ///     1) How to Run: Press Ctrl+R,T (NOT Ctrl+R, Ctrl +T)
        ///     2) Find the 1st method that fails and read the method name
        ///     3) Fill in the blank ____ to make it pass
        ///     4) Run it again and see it pass
        ///     5) Meditate for 1 minute on what this puzzle has taught you
        ///     6) Continue
        ///     Note: Do not change anything other than the blank
        ///     Hint: if you stuck, place a debug and run the tests in debug (Ctrl R, Ctrl A)
        /// </summary>
        /// <author>
        ///     @LlewellynFalco - http://llewellynfalco.blogspot.com
        ///     @LynnLangit  - http://www.lynnlangit.com
        /// </author>
        [TestMethod]
        public void LinqResults()
        {
            Microwavable result = (from x in ObjectsInMicrowave
                where x.Name == "Ping Pong Ball"
                select x).First();
            Assert.AreEqual(___, result.Name);
        }

        [TestMethod]
        public void LinqWhere()
        {
            Microwavable result = (from x in ObjectsInMicrowave
                where x.Name == ___
                select x).First();
            Assert.AreEqual("CD", result.Name);
        }

        [TestMethod]
        public void LinqSelect()

        {
            Microwavable result = (from oim in ObjectsInMicrowave
                where oim.Effect.Contains('S')
                select ____).First();
            Assert.AreEqual("CD", result.Name);
        }

        [TestMethod]
        public void LinqSelectPiece()

        {
            var result = (from x in ObjectsInMicrowave
                where x.Name.StartsWith("Fire")
                select x.___).First();
            Assert.AreEqual("Firecrackers", result);
        }

        [TestMethod]
        public void LinqSelectPieces()

        {
            var result = (from x in ObjectsInMicrowave
                where x.Effect == "Glows"
                select new {x.Name, x.___}).First();
            Assert.AreEqual("Glows", result.___);
            Assert.AreEqual("Light Bulbs", result.Name);
        }

        [TestMethod]
        public void TheLeastFun()

        {
            var result = (from x in ObjectsInMicrowave
                orderby x.___ ascending
                select x
            ).First();
            Assert.AreEqual("Boils", result.Effect);
        }

        [TestMethod]
        public void StackingOrderBys()

        {
            var result = (from x in ObjectsInMicrowave
                orderby x.FunFactor descending
                orderby x.Name descending
                select x).First();
            Assert.AreEqual(___, result.FunFactor);
        }

        [TestMethod]
        public void MulitpleOrderBys()
        {
            var result = (from x in ObjectsInMicrowave
                orderby x.FunFactor descending, x.___ descending
                select x).First();
            Assert.AreEqual(10, result.FunFactor);
            Assert.AreEqual("Twinkies", result.Name);
        }

        [TestMethod]
        public void GroupBy()
        {
            var results = (from x in ObjectsInMicrowave
                group x by x.FunFactor / 5
                into groupName
                orderby groupName.Key
                select groupName);
            foreach (IGrouping<int, Microwavable> g in results)
            {
                Console.WriteLine(g.Key + ": " + String.Join(", ", g.Select(m => m.Name)));
            }
            Assert.AreEqual(results.First().Key, ___);
        }

        #region Ignore

        public static string BlankText = "Please Fill in the Blank ___";

        public static Microwavable[] ObjectsInMicrowave =
            new[]
            {
                new Microwavable {Name = "Ping Pong Ball", FunFactor = 10, Effect = "Ball Of Fire"},
                new Microwavable {Name = "CD", FunFactor = 8, Effect = "Sparks"},
                new Microwavable {Name = "Firecrackers", FunFactor = 7, Effect = "Boom"},
                new Microwavable {Name = "Marshmallow Peeps", FunFactor = 9, Effect = "Expanding Maddness"},
                new Microwavable {Name = "Soap", FunFactor = 9, Effect = "Bubbles"},
                new Microwavable {Name = "Eggs", FunFactor = 8, Effect = "Explosion"},
                new Microwavable {Name = "Gremlins", FunFactor = 8, Effect = "Explosion"},
                new Microwavable {Name = "Twinkies", FunFactor = 10, Effect = "Expanding Middle"},
                new Microwavable {Name = "Etch a Sketch", FunFactor = 5, Effect = "Melted Iron Beads"},
                new Microwavable {Name = "Light Bulbs", FunFactor = 9, Effect = "Glows"},
                new Microwavable {Name = "Water", FunFactor = 1, Effect = "Boils"},
                new Microwavable {Name = BlankText, FunFactor = 5, Effect = BlankText},
            };

        public string ___ = BlankText;

        public Microwavable ____ = ObjectsInMicrowave.Last();

        #endregion
    }
}