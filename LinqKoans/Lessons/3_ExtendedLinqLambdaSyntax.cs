using System;
using System.Collections.Generic;
using System.Linq;
using LinqKoans.TestsAndUtilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LinqKoans.Lessons
{
    [TestClass]
    public class ExtendedLinqLambdaSyntax
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
        public void All()
        {
            var names = new[] {"Bert", "Ernie", "Kermet", "Grover", "Big Bird", "The Count"};
            var result = names.All(n => n[0].IsConsonant());
            Assert.AreEqual(___, result);
        }

        [TestMethod]
        public void Any()
        {
            var names = new[] {"Bert", "Ernie", "Kermet", "Grover", "Big Bird", "The Count"};
            int times = 0;
            var result = names.Any(n =>
            {
                times++;
                return n[0].IsVowel();
            });
            Assert.AreEqual(true, result);
            Assert.AreEqual(___, times);
        }


        [TestMethod]
        public void AsParallel()
        {
            var names = new[] {"Bert", "Ernie", "Kermet", "Grover", "Big Bird", "The Count"};
            var result = names.AsParallel().Any(n =>
            {
                Console.WriteLine(n);
                return n[0].IsVowel();
            });
            Assert.AreEqual(___, result);
        }

        [TestMethod]
        public void Average()
        {
            var names = new[] {"Bert", "Ernie", "Kermet", "Grover"};
            var result = names.Average(n => n.Length);
            Assert.AreEqual(___, result);
        }

        [TestMethod]
        public void Aggregate()
        {
            var numbers = new[] {3, 5, 7, 8, 9};
            var result = numbers.Aggregate("# ", (text, o) => text += " " + o);
            Assert.AreEqual(___, result);
        }

        [TestMethod]
        public void SumTotalMilesDriven()
        {
            var cars = CarsForSale;
            var result = ___;
            Assert.AreEqual(315000, result);
        }

        [TestMethod]
        public void AveragePriceOfACar()
        {
            var cars = CarsForSale;
            var result = ____;
            Assert.AreEqual(16888.89, result, 0.01);
        }

        [TestMethod]
        public void BestMilesPerGallon()
        {
            var cars = CarsForSale;
            var result = ___;
            Assert.AreEqual(50, result);
        }

        [TestMethod]
        public void BestCarForMilesPerGallon()
        {
            var cars = CarsForSale;
            var result = __;
            Assert.AreEqual("Toyota Prius", result.Name);
        }

        [TestMethod]
        public void Cars3_4_5()
        {
            // Hint (use take and skip)
            var cars = CarsForSale;
            var result = _____;
            Assert.AreEqual("Toyota Prius,Ford Mustang,Saturn,", result.Aggregate("", (a, b) => a += b.Name + ","));
        }

        [TestMethod]
        public void LinqResults()
        {
//      var result = ObjectsInMicrowave.Concat();
//      var result = ObjectsInMicrowave.Contains();
//      var result = ObjectsInMicrowave.Distinct();
//      var result = ObjectsInMicrowave.Except();
//      var result = ObjectsInMicrowave.FirstOrDefault();
//      var result = ObjectsInMicrowave.GroupBy();
//      var result = ObjectsInMicrowave.GroupJoin();
//      var result = ObjectsInMicrowave.Intersect();
//      var result = ObjectsInMicrowave.Join();
//      var result = ObjectsInMicrowave.Last();
//      var result = ObjectsInMicrowave.Max();
//      var result = ObjectsInMicrowave.Min();
//      var result = ObjectsInMicrowave.OfType<>();
//      var result = ObjectsInMicrowave.Reverse();
//      var result = ObjectsInMicrowave.SelectMany();
//      var result = ObjectsInMicrowave.Single();
//      var result = ObjectsInMicrowave.Skip();
//      var result = ObjectsInMicrowave.SkipWhile();
//      var result = ObjectsInMicrowave.Sum();
//      var result = ObjectsInMicrowave.Take();
//      var result = ObjectsInMicrowave.TakeWhile();
//      var result = ObjectsInMicrowave.ToArray();
//      var result = ObjectsInMicrowave.ToDictionary();
//      var result = ObjectsInMicrowave.Union();
//      var result = ObjectsInMicrowave.Zip();
//      Assert.AreEqual(___, result.Name);
        }

        #region Ignore

        protected static Microwavable[] ObjectsInMicrowave = LinqSyntax.ObjectsInMicrowave;

        public object ___ = LinqSyntax.BlankText;

        public double ____ = 0;
        public Car __ = null;
        public IEnumerable<Car> _____ = null;

        public static Car[] CarsForSale = new Car[]
        {
            new Car
                {Name = "VW Bettle", MilesDriven = 1000, Price = 15000, MilesPerGallon = 20},
            new Car
                {Name = "Honda Accord", MilesDriven = 20000, Price = 10000, MilesPerGallon = 31},
            new Car
                {Name = "Toyota Prius", MilesDriven = 55000, Price = 22000, MilesPerGallon = 50},
            new Car
                {Name = "Ford Mustang", MilesDriven = 10000, Price = 30000, MilesPerGallon = 15},
            new Car {Name = "Saturn", MilesDriven = 24000, Price = 13000, MilesPerGallon = 28},
            new Car
                {Name = "Chevy Buick", MilesDriven = 40000, Price = 24000, MilesPerGallon = 15},
            new Car
                {Name = "Smart Car", MilesDriven = 15000, Price = 9000, MilesPerGallon = 44},
            new Car {Name = "Mini", MilesDriven = 70000, Price = 18000, MilesPerGallon = 25},
            new Car
                {Name = "Hyundia", MilesDriven = 80000, Price = 11000, MilesPerGallon = 32}
        };

        #endregion
    }

    public static class StringUtils
    {
        public static Boolean IsConsonant(this char c)
        {
            return !IsVowel(c);
        }

        public static Boolean IsVowel(this char c)
        {
            return new[] {'a', 'e', 'i', 'o', 'u'}.Contains(Char.ToLowerInvariant(c));
        }
    }
}