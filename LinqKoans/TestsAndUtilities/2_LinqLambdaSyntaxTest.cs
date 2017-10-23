using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lesson = LinqKoans.Lessons.LinqLambdaSyntax;

namespace LinqKoans.TestsAndUtilities
{
    [TestClass]
    public class LinqLambdaSyntaxTest
    {
        [TestMethod]
        public void TestLessons()
        {
            KoanUtils.Verify<Lesson>((t) => t.LinqResults(), "Ping Pong Ball");
            KoanUtils.Verify<Lesson>((t) => t.LinqWhere(), "CD");
            KoanUtils.VerifyEmpty<Lesson>((t) => t.LinqSelect());
            KoanUtils.VerifyEmpty<Lesson>((t) => t.LinqSelectPiece());
            KoanUtils.VerifyEmpty<Lesson>((t) => t.LinqSelectPieces());
            KoanUtils.VerifyEmpty<Lesson>((t) => t.TheLeastFun());
            KoanUtils.VerifyEmpty<Lesson>((t) => t.StackingOrderBys());
            KoanUtils.VerifyEmpty<Lesson>((t) => t.MulitpleOrderBys());
            KoanUtils.VerifyEmpty<Lesson>((t) => t.GroupBy());
        }
    }
}