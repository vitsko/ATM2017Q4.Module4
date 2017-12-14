namespace TestCalculator.MSTest
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// Tests are written by https://msdn.microsoft.com/ru-ru/library/system.math.pow(v=vs.110).aspx.
    /// </summary>
    [TestClass]
    public class TestPow
    {
        [TestMethod]
        public void TestPowWithAnyOperands()
        {
            // Only positive number.
            object number = 10,
                   power = "-1.5";

            double parseToNumber, parseToPower;

            if (double.TryParse(number.ToString(), out parseToNumber)
                && double.TryParse(power.ToString(), out parseToPower))
            {
                var calc = new CSharpCalculator.Calculator();

                Assert.AreEqual(Math.Pow(parseToNumber, parseToPower), calc.Pow(parseToNumber, parseToPower));
            }
            else
            {
                Assert.IsFalse(false);
            }
        }

        [TestMethod]
        public void TestPowByOne()
        {
            double number = 10.2d;
            var calc = new CSharpCalculator.Calculator();

            Assert.AreEqual(number, calc.Pow(number, 1));
        }

        [TestMethod]
        public void TestPowWithPowerZero()
        {
            double number = 10.2d;
            var calc = new CSharpCalculator.Calculator();

            Assert.AreEqual(1d, calc.Pow(number, 0));
        }

        [TestMethod]
        public void TestPowByPowerNaN()
        {
            double number = 1.1;
            var calc = new CSharpCalculator.Calculator();

            Assert.AreEqual(double.NaN, calc.Pow(number, double.NaN));
        }

        [TestMethod]
        public void TestPowByNumberNaN()
        {
            double power = 5;

            var calc = new CSharpCalculator.Calculator();

            Assert.AreEqual(double.NaN, calc.Pow(double.NaN, power));
        }

        [TestMethod]
        public void TestPowByNumberNegativeInfinity()
        {
            // Value must be less than 0.
            double power = -5;

            var calc = new CSharpCalculator.Calculator();

            Assert.AreEqual(0d, calc.Pow(double.NegativeInfinity, power));
        }

        [TestMethod]
        public void TestPowByOddPower()
        {
            // Value must be odd positive integer.
            double power = 5;

            var calc = new CSharpCalculator.Calculator();

            Assert.AreEqual(double.NegativeInfinity, calc.Pow(double.NegativeInfinity, power));
        }

        [TestMethod]
        public void TestPowByEvenPower()
        {
            // Value must be even positive integer.
            double power = 4;

            var calc = new CSharpCalculator.Calculator();

            Assert.AreEqual(double.PositiveInfinity, calc.Pow(double.NegativeInfinity, power));
        }

        [TestMethod]
        public void TestPowByDoublePower()
        {
            // Value is negative, but isn't NegativeInfinity
            double number = -10;

            // Value isn't an integer, NegativeInfinity, or PositiveInfinity. 
            double power = 4.7;

            var calc = new CSharpCalculator.Calculator();

            Assert.AreEqual(double.NaN, calc.Pow(number, power));
        }

        [TestMethod]
        public void TestPowByMinusOne()
        {
            // Value is -1
            double number = -1;

            // Value is NegativeInfinity or PositiveInfinity. 
            double power = double.NegativeInfinity;

            var calc = new CSharpCalculator.Calculator();

            Assert.AreEqual(double.NaN, calc.Pow(number, power));
        }

        [TestMethod]
        public void TestPowByRangeMinus1By1AndNegativeInfinity()
        {
            // Value is in  range from -1 to 1.
            double number = -0.5;

            // Value is NegativeInfinity. 
            double power = double.NegativeInfinity;

            var calc = new CSharpCalculator.Calculator();

            Assert.AreEqual(double.PositiveInfinity, calc.Pow(number, power));
        }

        [TestMethod]
        public void TestPowByRangeMinus1By1AndPositiveInfinity()
        {
            // Value is in  range from -1 to 1.
            double number = -0.5;

            // Value is PositiveInfinity. 
            double power = double.PositiveInfinity;

            var calc = new CSharpCalculator.Calculator();

            Assert.AreEqual(0d, calc.Pow(number, power));
        }

        [TestMethod]
        public void TestPowWithLessThanMinus1AndNegativeInfinity()
        {
            // Value is less than -1.
            double number = -2;

            // Value is NegativeInfinity. 
            double power = double.NegativeInfinity;

            var calc = new CSharpCalculator.Calculator();

            Assert.AreEqual(0d, calc.Pow(number, power));
        }

        [TestMethod]
        public void TestPowWithGreatThan1AndNegativeInfinity()
        {
            // Value is great than 1.
            double number = 2;

            // Value is NegativeInfinity. 
            double power = double.NegativeInfinity;

            var calc = new CSharpCalculator.Calculator();

            Assert.AreEqual(0d, calc.Pow(number, power));
        }

        [TestMethod]
        public void TestPowWithLessThanMinus1AndPositiveInfinity()
        {
            // Value is less than -1.
            double number = -2;

            // Value is PositiveInfinity. 
            double power = double.PositiveInfinity;

            var calc = new CSharpCalculator.Calculator();

            Assert.AreEqual(double.PositiveInfinity, calc.Pow(number, power));
        }

        [TestMethod]
        public void TestPowWithGreatThan1AndPositiveInfinity()
        {
            // Value is great than 1.
            double number = 2;

            // Value is PositiveInfinity. 
            double power = double.PositiveInfinity;

            var calc = new CSharpCalculator.Calculator();

            Assert.AreEqual(double.PositiveInfinity, calc.Pow(number, power));
        }

        [TestMethod]
        public void TestPowWithNumberZeroAndPowerLessZero()
        {
            // Value is 0.
            double number = 0;

            // Value is less than 0. 
            double power = -7;

            var calc = new CSharpCalculator.Calculator();

            Assert.AreEqual(double.PositiveInfinity, calc.Pow(number, power));
        }

        [TestMethod]
        public void TestPowWithNumberZeroAndPowerGreatZero()
        {
            // Value is 0.
            double number = 0;

            // Value is great than 0. 
            double power = 7;

            var calc = new CSharpCalculator.Calculator();

            Assert.AreEqual(0d, calc.Pow(number, power));
        }

        [TestMethod]
        public void TestPowWithNumberOneAndPowerNotNaN()
        {
            // Value is 1.
            double number = 1;

            // Value isn't NaN. 
            double power = 26;

            var calc = new CSharpCalculator.Calculator();

            Assert.AreEqual(1d, calc.Pow(number, power));
        }

        [TestMethod]
        public void TestPowWithNumberPositiveInfinityAndPowerLessZero()
        {
            // Value is PositiveInfinity.
            double number = double.PositiveInfinity;

            // Value is less than 0. 
            double power = -9;

            var calc = new CSharpCalculator.Calculator();

            Assert.AreEqual(0d, calc.Pow(number, power));
        }

        [TestMethod]
        public void TestPowWithNumberPositiveInfinityAndPowerGreatZero()
        {
            // Value is PositiveInfinity.
            double number = double.PositiveInfinity;

            // Value is great than 0. 
            double power = 17;

            var calc = new CSharpCalculator.Calculator();

            Assert.AreEqual(double.PositiveInfinity, calc.Pow(number, power));
        }
    }
}