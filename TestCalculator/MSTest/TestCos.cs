﻿namespace TestCalculator.MSTest
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class TestCos
    {
        [TestMethod]
        public void TestCosWithAnyOperand()
        {
            object toCos = "10";
            double result;

            if (double.TryParse(toCos.ToString(), out result))
            {
                var calc = new CSharpCalculator.Calculator();
                Assert.AreEqual(Math.Cos(result), calc.Cos(result));
            }
            else
            {
                Assert.IsFalse(false);
            }
        }

        [TestMethod]
        public void TestCosWithZero()
        {
            var calc = new CSharpCalculator.Calculator();

            Assert.AreEqual(1, calc.Cos(0));
        }

        [TestMethod]
        public void TestCosWith180degrees()
        {
            var calc = new CSharpCalculator.Calculator();

            Assert.AreEqual(-1, calc.Cos(Math.PI));
        }

        [TestMethod]
        public void TestCosWithNegativeInfinity()
        {
            double angleInRad = double.NegativeInfinity;
            var calc = new CSharpCalculator.Calculator();

            Assert.AreEqual(double.NaN, calc.Cos(angleInRad));
        }

        [TestMethod]
        public void TestCosWithPositiveInfinity()
        {
            double angleInRad = double.PositiveInfinity;
            var calc = new CSharpCalculator.Calculator();

            Assert.AreEqual(double.NaN, calc.Cos(angleInRad));
        }

        [TestMethod]
        public void TestCosWithNaN()
        {
            double angleInRad = double.NaN;
            var calc = new CSharpCalculator.Calculator();

            Assert.AreEqual(double.NaN, calc.Cos(angleInRad));
        }
    }
}