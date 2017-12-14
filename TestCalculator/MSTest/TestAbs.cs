namespace TestCalculator
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class TestAbs
    {
        [TestMethod]
        public void TestAbsWithAnyOperandAndInt()
        {
            object toAbs = "10";
            double result;

            if (double.TryParse(toAbs.ToString(), out result))
            {
                var calc = new CSharpCalculator.Calculator();
                Assert.AreEqual(Math.Abs(result), calc.Abs(result));
            }
            else
            {
                Assert.IsFalse(false);
            }
        }

        [TestMethod]
        public void TestAbsWithZero()
        {
            object toAbs = "0.0";
            var calc = new CSharpCalculator.Calculator();
            var result = double.Parse(toAbs.ToString());

            Assert.AreEqual(result, calc.Abs(result));
        }

        [TestMethod]
        public void TestAbsIntWithLessThanZero()
        {
            object toAbs = "-3.0";
            var calc = new CSharpCalculator.Calculator();
            var result = double.Parse(toAbs.ToString());

            Assert.AreEqual(result * -1, calc.Abs(result));
        }

        [TestMethod]
        public void TestAbsIntWithGreatThanZero()
        {
            object toAbs = "100.0";
            var calc = new CSharpCalculator.Calculator();
            var result = double.Parse(toAbs.ToString());

            Assert.AreEqual(result, calc.Abs(result));
        }

        [TestMethod]
        public void TestFailAbsWithNotInt()
        {
            object toAbs = "10.2";
            var calc = new CSharpCalculator.Calculator();
            var result = double.Parse(toAbs.ToString());

            if (result > 0)
            {
                Assert.AreEqual(result, calc.Abs(result));
            }
            else
            {
                Assert.AreEqual(result * -1, calc.Abs(result));
            }
        }

        [TestMethod]
        public void TestFailAbsWithIncorrectOperand()
        {
            object toAbs = string.Empty;
            var calc = new CSharpCalculator.Calculator();

            Assert.AreEqual(toAbs, calc.Abs(toAbs));
        }
    }
}