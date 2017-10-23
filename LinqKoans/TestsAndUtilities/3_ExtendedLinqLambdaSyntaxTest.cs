using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lesson = LinqKoans.Lessons.ExtendedLinqLambdaSyntax;

namespace LinqKoans.TestsAndUtilities
{
    [TestClass]
    public class LessonTest
    {
        public Car[] cars = Lesson.CarsForSale;

        [TestMethod]
        public void TestLessons()
        {
            KoanUtils.Verify<Lesson>((t) => t.Aggregate(), "#  3 5 7 8 9");
            KoanUtils.Verify<Lesson>((t) => t.All(), false);
            KoanUtils.Verify<Lesson>((t) => t.Any(), 2);
            KoanUtils.Verify<Lesson>((t) => t.AsParallel(), true);
            KoanUtils.Verify<Lesson>((t) => t.Average(), 5.25);

            KoanUtils.Verify<Lesson>((t) => t.SumTotalMilesDriven(), cars.Sum(c => c.MilesDriven));
            KoanUtils.Verify<Lesson>((t) => t.AveragePriceOfACar(), cars.Average(c => c.Price));
            KoanUtils.Verify<Lesson>((t) => t.BestMilesPerGallon(), cars.Max(c => c.MilesPerGallon));
            KoanUtils.Verify<Lesson>((t) => t.BestCarForMilesPerGallon(),
                cars.OrderByDescending(c => c.MilesPerGallon).First());
            KoanUtils.Verify<Lesson>((t) => t.Cars3_4_5(), cars.Skip(2).Take(3));
        }
    }
}