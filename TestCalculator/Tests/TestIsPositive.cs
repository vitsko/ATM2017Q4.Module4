namespace TestCalculator.MSTest
{
    using System;
    using CSharpCalculator;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class TestIsPositive
    {
        private static Calculator calc;
        private static object value;

        public TestContext TestContext { get; set; }

        /// <summary>
        /// Initialize Calculator for test of operation IsPositive
        /// </summary>
        /// <param name="context"></param>
        [ClassInitialize]
        public static void TestAddInitialize(TestContext context)
        {
            TestIsPositive.calc = new Calculator();
        }

        /// <summary>
        /// Clean up Calculator for test of operation IsPositive
        /// </summary>
        [ClassCleanup]
        public static void TestIsNegativeCleanup()
        {
            TestIsPositive.calc = null;
        }

        /// <summary>
        ///  Initializer for any test of operation IsPositive
        /// </summary>
        [TestInitialize]
        public void Initialize()
        {
            TestIsPositive.value = 10.8;
        }

        /// <summary>
        /// Clean up all data for any test of IsPositive
        /// </summary>
        [TestCleanup]
        public void CleanAllTests()
        {
            TestIsPositive.value = null;
        }

        /// <summary>
        /// Test operation IsPositive with operand is any object
        /// </summary>
        [TestMethod]
        public void TestIsPositiveWithAnyOperand()
        {
            double result;

            if (double.TryParse(TestIsPositive.value.ToString(), out result))
            {
                Assert.AreEqual(true, TestIsPositive.calc.isPositive(result));
            }
            else
            {
                AssertFailedException.Equals(TestIsPositive.calc.isPositive(result), new Exception());
            }
        }
    }
}