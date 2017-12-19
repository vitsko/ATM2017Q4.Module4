namespace TestCalculator
{
    using CSharpCalculator;
    using NUnit.Framework;

    [TestFixture]
    public class TestDivide
    {
        private static Calculator calc;

        /// <summary>
        /// Initialize Calculator for test of operation Divide
        /// </summary>
        [OneTimeSetUp]
        public void TestDivideInitialize()
        {
            TestDivide.calc = new Calculator();
        }

        /// <summary>
        /// Clean up Calculator for test of operation Divide
        /// </summary>
        [OneTimeTearDown]
        public void TestDivideCleanup()
        {
            TestDivide.calc = null;
        }

        /// <summary>
        /// Test operation Divide with dividend is divider
        /// </summary>
        [TestCase(12.5d, ExpectedResult = 1d, Category = "Dividend is divider")]
        [TestCase(0, ExpectedResult = double.NaN, Category = "Dividend is divider")]
        [TestCase(-3, ExpectedResult = 1.0d, Category = "Dividend is divider")]
        [TestCase(double.NaN, ExpectedResult = double.NaN, Category = "Dividend is divider")]
        [TestCase(double.NegativeInfinity, ExpectedResult = double.NaN, Category = "Dividend is divider")]
        [TestCase(double.PositiveInfinity, ExpectedResult = double.NaN, Category = "Dividend is divider")]
        [TestCase(double.MaxValue, ExpectedResult = 1d, Category = "Dividend is divider")]
        [TestCase(double.MinValue, ExpectedResult = 1d, Category = "Dividend is divider")]
        [TestCase(double.Epsilon, ExpectedResult = 1d, Category = "Dividend is divider")]
        public double TestDivideBySelf(double dividend)
        {
            return TestDivide.calc.Divide(dividend, dividend);
        }

        /// <summary>
        /// Test operation Divide with divider is 1d
        /// </summary>
        [TestCase(12.5d, ExpectedResult = 12.5d, Category = "Divider is 1d")]
        [TestCase(0, ExpectedResult = 0d, Category = "Divider is 1d")]
        [TestCase(-3, ExpectedResult = -3d, Category = "Divider is 1d")]
        [TestCase(double.NaN, ExpectedResult = double.NaN, Category = "Divider is 1d")]
        [TestCase(double.NegativeInfinity, ExpectedResult = double.NegativeInfinity, Category = "Divider is 1d")]
        [TestCase(double.PositiveInfinity, ExpectedResult = double.PositiveInfinity, Category = "Divider is 1d")]
        [TestCase(double.MaxValue, ExpectedResult = double.MaxValue, Category = "Divider is 1d")]
        [TestCase(double.MinValue, ExpectedResult = double.MinValue, Category = "Divider is 1d")]
        [TestCase(double.Epsilon, ExpectedResult = double.Epsilon, Category = "Divider is 1d")]
        public double TestDivideByOne(double dividend)
        {
            return TestDivide.calc.Divide(dividend, 1d);
        }

        /// <summary>
        /// Test operation Divide with divider is 0
        /// </summary>
        [TestCase(12, ExpectedResult = double.PositiveInfinity, Category = "Divider is 0d")]
        [TestCase(0, ExpectedResult = double.NaN, Category = "Divider is 0d")]
        [TestCase(-3, ExpectedResult = double.NegativeInfinity, Category = "Divider is 0d")]
        [TestCase(double.NaN, ExpectedResult = double.NaN, Category = "Divider is 0d")]
        [TestCase(double.NegativeInfinity, ExpectedResult = double.NegativeInfinity, Category = "Divider is 0d")]
        [TestCase(double.PositiveInfinity, ExpectedResult = double.PositiveInfinity, Category = "Divider is 0d")]
        [TestCase(double.MaxValue, ExpectedResult = double.PositiveInfinity, Category = "Divider is 0d")]
        [TestCase(double.MinValue, ExpectedResult = double.NegativeInfinity, Category = "Divider is 0d")]
        [TestCase(double.Epsilon, ExpectedResult = double.PositiveInfinity, Category = "Divider is 0d")]
        public object TestDivideByZero(double dividend)
        {
            return TestDivide.calc.Divide(dividend, 0);
        }

        /// <summary>
        /// Test operation Divide with operands are double
        /// </summary>
        [TestCase(12, 8.5, ExpectedResult = 12 / 8.5, Category = "Operands are double")]
        [TestCase(0, 0, ExpectedResult = double.NaN, Category = "Operands are double")]
        [TestCase(-3, 7d, ExpectedResult = -3 / 7d, Category = "Operands are double")]
        [TestCase(double.NaN, 9, ExpectedResult = double.NaN, Category = "Operands are double")]
        [TestCase(double.NegativeInfinity, 8, ExpectedResult = double.NegativeInfinity, Category = "Operands are double")]
        [TestCase(double.PositiveInfinity, 7, ExpectedResult = double.PositiveInfinity, Category = "Operands are double")]
        [TestCase(double.MaxValue, 10, ExpectedResult = double.MaxValue / 10, Category = "Operands are double")]
        [TestCase(double.MinValue, 112.35d, ExpectedResult = double.MinValue / 112.35d, Category = "Operands are double")]
        [TestCase(double.Epsilon, 123d, ExpectedResult = double.Epsilon / 123d, Category = "Operands are double")]
        [TestCase(9, double.NaN, ExpectedResult = double.NaN, Category = "Operands are double")]
        [TestCase(8, double.NegativeInfinity, ExpectedResult = 8 / double.NegativeInfinity, Category = "Operands are double")]
        [TestCase(7, double.PositiveInfinity, ExpectedResult = 7 / double.PositiveInfinity, Category = "Operands are double")]
        [TestCase(10, double.MaxValue, ExpectedResult = 10 / double.MaxValue, Category = "Operands are double")]
        [TestCase(112.35d, double.MinValue, ExpectedResult = 112.35d / double.MinValue, Category = "Operands are double")]
        [TestCase(123d, double.Epsilon, ExpectedResult = 123d / double.Epsilon, Category = "Operands are double")]
        public double TestDivideWithDifferentOperands(double dividend, double divider)
        {
            return TestDivide.calc.Divide(dividend, divider);
        }
    }
}