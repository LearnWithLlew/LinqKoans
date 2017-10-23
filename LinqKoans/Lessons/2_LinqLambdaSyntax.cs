using System;
using System.Linq;
using LinqKoans.TestsAndUtilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LinqKoans.Lessons
{
    [TestClass]
    public class LinqLambdaSyntax
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
            Microwavable result = ObjectsInMicrowave.Where(x => x.Name == "Ping Pong Ball").First();
            Assert.AreEqual(___, result.Name);
        }

        [TestMethod]
        public void LinqWhere()
        {
            Microwavable result = ObjectsInMicrowave.Where(x => x.Name == ___).First();
            Assert.AreEqual("CD", result.Name);
        }

        [TestMethod]
        public void LinqSelect()

        {
            Microwavable result = ObjectsInMicrowave.Where(oim => oim.Effect.Contains('S')).Select(oim => ____).First();
            Assert.AreEqual("CD", result.Name);
        }

        [TestMethod]
        public void LinqSelectPiece()

        {
            var result = ObjectsInMicrowave.Where(x => x.Name.StartsWith("Fire")).Select(x => x.___).First();
            Assert.AreEqual("Firecrackers", result);
        }

        [TestMethod]
        public void LinqSelectPieces()

        {
            var result = ObjectsInMicrowave.Where(x => x.Effect == "Glows").Select(x => new {x.Name, x.___}).First();
            Assert.AreEqual("Glows", result.___);
            Assert.AreEqual("Light Bulbs", result.Name);
        }

        [TestMethod]
        public void TheLeastFun()

        {
            var result = ObjectsInMicrowave.OrderBy(x => x.___).First();
            Assert.AreEqual("Boils", result.Effect);
        }

        [TestMethod]
        public void StackingOrderBys()

        {
            var result = ObjectsInMicrowave.OrderByDescending(x => x.FunFactor).OrderByDescending(x => x.Name).First();
            Assert.AreEqual(___, result.FunFactor);
        }

        [TestMethod]
        public void MulitpleOrderBys()
        {
            var result = ObjectsInMicrowave.OrderByDescending(x => x.FunFactor).ThenByDescending(x => x.___).First();
            Assert.AreEqual(10, result.FunFactor);
            Assert.AreEqual("Twinkies", result.Name);
        }

        [TestMethod]
        public void GroupBy()
        {
            var results = ObjectsInMicrowave.GroupBy(x => x.FunFactor / 5).Select(groupName => groupName)
                .OrderBy(g => g.Key);
            foreach (IGrouping<int, Microwavable> g in results)
            {
                Console.WriteLine(g.Key + ": " + String.Join(", ", g.Select(m => m.Name)));
            }
            Assert.AreEqual(results.First().Key, ___);
        }

        #region Ignore

        protected static Microwavable[] ObjectsInMicrowave = LinqSyntax.ObjectsInMicrowave;

        public string ___ = LinqSyntax.BlankText;

        public Microwavable ____ = ObjectsInMicrowave.Last();

        #endregion
    }
}