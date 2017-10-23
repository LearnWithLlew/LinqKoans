using LinqKoans.Lessons;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LinqKoans.TestsAndUtilities
{
    [TestClass]
    public class LinqSyntaxTest
    {
        [TestMethod]
        public void TestLessons()
        {
            KoanUtils.Verify<LinqSyntax>((t) => t.LinqResults(), "Ping Pong Ball");
            KoanUtils.Verify<LinqSyntax>((t) => t.LinqWhere(), "CD");
            KoanUtils.VerifyEmpty<LinqSyntax>((t) => t.LinqSelect());
            KoanUtils.VerifyEmpty<LinqSyntax>((t) => t.LinqSelectPiece());
            KoanUtils.VerifyEmpty<LinqSyntax>((t) => t.LinqSelectPieces());
            KoanUtils.VerifyEmpty<LinqSyntax>((t) => t.TheLeastFun());
            KoanUtils.VerifyEmpty<LinqSyntax>((t) => t.StackingOrderBys());
            KoanUtils.VerifyEmpty<LinqSyntax>((t) => t.MulitpleOrderBys());
            KoanUtils.VerifyEmpty<LinqSyntax>((t) => t.GroupBy());
        }
    }
}