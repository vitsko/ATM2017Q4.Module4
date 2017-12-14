namespace TestCalculator.MSTest
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class TestMultiply
    {
        [TestMethod]
        public void TestMultiplyBySelf()
        {
            double multiplied = 10.2d;
            var calc = new CSharpCalculator.Calculator();

            Assert.AreEqual(multiplied * multiplied, calc.Multiply(multiplied, multiplied));
        }

        [TestMethod]
        public void TestMultiplyByOne()
        {
            double multiplied = 10.2d;
            var calc = new CSharpCalculator.Calculator();

            Assert.AreEqual(multiplied, calc.Multiply(multiplied, 1));
        }

        [TestMethod]
        public void TestMultiplyByZero()
        {
            double multiplied = 10.2d;
            var calc = new CSharpCalculator.Calculator();

            Assert.AreEqual(0, calc.Multiply(multiplied, 0));
        }

        [TestMethod]
        public void TestMultiplyWithDifferentOperands()
        {
            double multiplied = 10.2d,
                   factor = -2d;
            var calc = new CSharpCalculator.Calculator();

            Assert.AreEqual(multiplied * factor, calc.Multiply(multiplied, factor));
        }

        [TestMethod]
        public void TestMultiplyWithNegativeInfinity()
        {
            double multiplied = double.NegativeInfinity,
                   factor = 2d;
            var calc = new CSharpCalculator.Calculator();

            Assert.AreEqual(double.NegativeInfinity, calc.Multiply(multiplied, factor));
        }

        [TestMethod]
        public void TestMultiplyWithPositiveInfinity()
        {
            double multiplied = double.PositiveInfinity,
                   factor = 2d;
            var calc = new CSharpCalculator.Calculator();

            Assert.AreEqual(double.PositiveInfinity, calc.Multiply(multiplied, factor));
        }

        [TestMethod]
        public void TestMultiplyWithNaN()
        {
            double multiplied = double.NaN,
                   factor = 2d;
            var calc = new CSharpCalculator.Calculator();

            Assert.AreEqual(double.NaN, calc.Multiply(multiplied, factor));
        }
    }
}