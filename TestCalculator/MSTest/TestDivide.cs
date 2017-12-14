namespace TestCalculator.MSTest
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class TestDivide
    {
        [TestMethod]
        public void TestDivideBySelf()
        {
            double dividend = 10.2d;
            var calc = new CSharpCalculator.Calculator();

            Assert.AreEqual(1.0d, calc.Divide(dividend, dividend));
        }

        [TestMethod]
        public void TestDivideByOne()
        {
            double dividend = 10.2d;
            var calc = new CSharpCalculator.Calculator();

            Assert.AreEqual(dividend, calc.Divide(dividend, 1));
        }

        [TestMethod]
        public void TestDivideByZero()
        {
            double dividend = 10.2d;
            var calc = new CSharpCalculator.Calculator();

            AssertFailedException.Equals(new Exception(), calc.Divide(dividend, 0));
        }

        [TestMethod]
        public void TestDivideWithDifferentOperands()
        {
            double dividend = 10.2d,
                   divider = -2d;
            var calc = new CSharpCalculator.Calculator();

            Assert.AreEqual(dividend / divider, calc.Divide(dividend, divider));
        }

        [TestMethod]
        public void TestDivideWithNegativeInfinity()
        {
            double dividend = double.NegativeInfinity,
                   divider = 2d;
            var calc = new CSharpCalculator.Calculator();

            Assert.AreEqual(double.NegativeInfinity, calc.Divide(dividend, divider));
        }

        [TestMethod]
        public void TestDivideWithPositiveInfinity()
        {
            double dividend = double.PositiveInfinity,
                   divider = 2d;
            var calc = new CSharpCalculator.Calculator();

            Assert.AreEqual(double.PositiveInfinity, calc.Divide(dividend, divider));
        }

        [TestMethod]
        public void TestDivideWithNaN()
        {
            double dividend = double.NaN,
                   divider = 2d;
            var calc = new CSharpCalculator.Calculator();

            Assert.AreEqual(double.NaN, calc.Divide(dividend, divider));
        }
    }
}