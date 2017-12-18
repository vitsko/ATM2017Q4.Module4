namespace TestCalculator.MSTest
{
    using System;
    using CSharpCalculator;
    using NUnit.Framework;

    [TestFixture]
    public class TestIsPositive
    {
        private static Calculator calc;
        private static object value;

        /// <summary>
        /// Initialize Calculator for test of operation IsPositive
        /// </summary>
        [OneTimeSetUp]
        public void TestAddInitialize()
        {
            TestIsPositive.calc = new Calculator();
        }

        /// <summary>
        /// Clean up Calculator for test of operation IsPositive
        /// </summary>
        [OneTimeTearDown]
        public void TestIsNegativeCleanup()
        {
            TestIsPositive.calc = null;
        }

        /// <summary>
        ///  Initializer for any test of operation IsPositive
        /// </summary>
        [SetUp]
        public void Initialize()
        {
            TestIsPositive.value = 10.8;
        }

        /// <summary>
        /// Clean up all data for any test of IsPositive
        /// </summary>
        [TearDown]
        public void CleanAllTests()
        {
            TestIsPositive.value = null;
        }

        /// <summary>
        /// Test operation IsPositive with operand is any object
        /// </summary>
        [Test]
        public void TestIsPositiveWithAnyOperand()
        {
            double result;

            if (double.TryParse(TestIsPositive.value.ToString(), out result))
            {
                Assert.AreEqual(true, TestIsPositive.calc.isPositive(result));
            }
            else
            {
                AssertionException.Equals(TestIsPositive.calc.isPositive(result), new Exception());
            }
        }
    }
}