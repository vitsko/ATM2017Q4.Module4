namespace TestCalculator.MSTest
{
    using System;
    using CSharpCalculator;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class TestIsNegative
    {
        private static Calculator calc;
        private static object value;

        public TestContext TestContext { get; set; }

        /// <summary>
        /// Initialize Calculator for test of operation IsNegative
        /// </summary>
        /// <param name="context"></param>
        [ClassInitialize]
        public static void TestAddInitialize(TestContext context)
        {
            TestIsNegative.calc = new Calculator();
        }

        /// <summary>
        /// Clean up Calculator for test of operation IsNegative
        /// </summary>
        [ClassCleanup]
        public static void TestIsNegativeCleanup()
        {
            TestIsNegative.calc = null;
        }

        /// <summary>
        ///  Initializer for any test of operation IsNegative
        /// </summary>
        [TestInitialize]
        public void Initialize()
        {
            TestIsNegative.value = -10.8;
        }

        /// <summary>
        /// Clean up all data for any test of IsNegative
        /// </summary>
        [TestCleanup]
        public void CleanAllTests()
        {
            TestIsNegative.value = null;
        }

        /// <summary>
        /// Test operation IsNegative with operand is any object
        /// </summary>
        [TestMethod]
        public void TestIsNegativeWithAnyOperand()
        {
            double result;

            if (double.TryParse(TestIsNegative.value.ToString(), out result))
            {
                Assert.AreEqual(true, TestIsNegative.calc.isNegative(result));
            }
            else
            {
                AssertFailedException.Equals(TestIsNegative.calc.isNegative(result), new Exception());
            }
        }
    }
}