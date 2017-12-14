namespace TestCalculator.MSTest
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class TestSin
    {
        [TestMethod]
        public void TestSinWithAnyOperand()
        {
            object toSin = "10--";
            double result;

            if (double.TryParse(toSin.ToString(), out result))
            {
                var calc = new CSharpCalculator.Calculator();
                Assert.AreEqual(Math.Sin(result), calc.Sin(result));
            }
            else
            {
                Assert.IsFalse(false);
            }
        }

        [TestMethod]
        public void TestSinWithZero()
        {
            var calc = new CSharpCalculator.Calculator();

            Assert.AreEqual(0, calc.Sin(0));
        }

        [TestMethod]
        public void TestSinWith90degrees()
        {
            var calc = new CSharpCalculator.Calculator();

            Assert.AreEqual(1, calc.Sin(Math.PI / 2));
        }

        [TestMethod]
        public void TestSinWithNegativeInfinity()
        {
            double angleInRad = double.NegativeInfinity;
            var calc = new CSharpCalculator.Calculator();

            Assert.AreEqual(double.NaN, calc.Sin(angleInRad));
        }

        [TestMethod]
        public void TestSinWithPositiveInfinity()
        {
            double angleInRad = double.PositiveInfinity;
            var calc = new CSharpCalculator.Calculator();

            Assert.AreEqual(double.NaN, calc.Sin(angleInRad));
        }

        [TestMethod]
        public void TestSinWithNaN()
        {
            double angleInRad = double.NaN;
            var calc = new CSharpCalculator.Calculator();

            Assert.AreEqual(double.NaN, calc.Sin(angleInRad));
        }
    }
}