namespace TestCalculator
{
    using System;
    using CSharpCalculator;
    using NUnit.Framework;

    [TestFixture]
    public class TestIsNegative
    {
        private static Calculator calc;
        private static object value;

        /// <summary>
        /// Initialize Calculator for test of operation IsNegative
        /// </summary>        
        [OneTimeSetUp]
        public void TestAddInitialize()
        {
            TestIsNegative.calc = new Calculator();
        }

        /// <summary>
        /// Clean up Calculator for test of operation IsNegative
        /// </summary>
        [OneTimeTearDown]
        public void TestIsNegativeCleanup()
        {
            TestIsNegative.calc = null;
        }

        /// <summary>
        ///  Initializer for any test of operation IsNegative
        /// </summary>
        [SetUp]
        public void Initialize()
        {
            TestIsNegative.value = -10.8;
        }

        /// <summary>
        /// Clean up all data for any test of IsNegative
        /// </summary>
        [TearDown]
        public void CleanAllTests()
        {
            TestIsNegative.value = null;
        }

        /// <summary>
        /// Test operation IsNegative with operand is any object
        /// </summary>
        [Test]
        public void TestIsNegativeWithAnyOperand()
        {
            double result;

            if (double.TryParse(TestIsNegative.value.ToString(), out result))
            {
                Assert.AreEqual(true, TestIsNegative.calc.isNegative(result));
            }
            else
            {
                AssertionException.Equals(TestIsNegative.calc.isNegative(result), new Exception());
            }
        }
    }
}