namespace TestCalculator.MSTest
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// Tests are written by https://msdn.microsoft.com/ru-ru/library/system.math.sqrt(v=vs.110).aspx
    /// </summary>
    [TestClass]
    public class TestSqrt
    {
        [TestMethod]
        public void TestSqrtWithAnyOperand()
        {
            // Value isn't 0.
            object toSqrt = "10";
            double result;

            if (double.TryParse(toSqrt.ToString(), out result))
            {
                if (result > 0)
                {
                    var calc = new CSharpCalculator.Calculator();
                    Assert.AreEqual(Math.Sqrt(result), calc.Sqrt(result));
                }
                else
                {
                    Assert.IsFalse(false);
                }
            }
            else
            {
                Assert.IsFalse(false);
            }
        }

        [TestMethod]
        public void TestSqrtPositiveNumber()
        {
            // Value is positive number.
            double number = 9;

            var calc = new CSharpCalculator.Calculator();

            Assert.AreEqual(Math.Sqrt(number), calc.Sqrt(number));
        }

        [TestMethod]
        public void TestSqrtWithZero()
        {
            var calc = new CSharpCalculator.Calculator();

            Assert.AreEqual(0, calc.Sqrt(0));
        }

        [TestMethod]
        public void TestSqrtNegativeNumber()
        {
            // Value is negative number.
            double number = -1;

            var calc = new CSharpCalculator.Calculator();

            Assert.AreEqual(double.NaN, calc.Sqrt(number));
        }

        [TestMethod]
        public void TestSqrtWithNaN()
        {
            double number = double.NaN;
            var calc = new CSharpCalculator.Calculator();

            Assert.AreEqual(double.NaN, calc.Sqrt(number));
        }

        [TestMethod]
        public void TestSqrtWithPositiveInfinity()
        {
            double number = double.PositiveInfinity;
            var calc = new CSharpCalculator.Calculator();

            Assert.AreEqual(double.PositiveInfinity, calc.Sqrt(number));
        }
    }
}
