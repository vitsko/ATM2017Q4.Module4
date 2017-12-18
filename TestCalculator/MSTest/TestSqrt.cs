namespace TestCalculator.MSTest
{
    using System;
    using CSharpCalculator;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// Tests are written by https://msdn.microsoft.com/ru-ru/library/system.math.sqrt(v=vs.110).aspx
    /// </summary>
    [TestClass]
    public class TestSqrt
    {
        private static Calculator calc;
        private static object toSqrt;

        public TestContext TestContext { get; set; }

        /// <summary>
        /// Initialize Calculator for test of operation Sqrt
        /// </summary>
        /// <param name="context"></param>
        [ClassInitialize]
        public static void TestSqrtInitialize(TestContext context)
        {
            TestSqrt.calc = new Calculator();
        }

        /// <summary>
        /// Clean up Calculator for test of operation Sqrt
        /// </summary>
        [ClassCleanup]
        public static void TestSqrtCleanup()
        {
            TestSqrt.calc = null;
        }

        /// <summary>
        ///  Initializer for any test of operation Sqrt
        /// </summary>
        [TestInitialize]
        public void Initialize()
        {
            switch (TestContext.TestName)
            {
                case "TestSqrtWithAnyOperand":
                    this.InitializeTestSqrtWithAnyOperand();
                    break;
                case "TestSqrtPositiveNumber":
                    this.InitializeTestSqrtPositiveNumber();
                    break;
                case "TestSqrtWithZero":
                    this.InitializeTestSqrtWithZero();
                    break;
                case "TestSqrtNegativeNumber":
                    this.InitializeTestSqrtNegativeNumber();
                    break;
                case "TestSqrtWithNaN":
                    this.InitializeTestSqrtWithNaN();
                    break;
                case "TestSqrtWithPositiveInfinity":
                    this.InitializeTestSqrtWithPositiveInfinity();
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// Clean up all data for any test of Sqrt
        /// </summary>
        [TestCleanup]
        public void CleanAllTests()
        {
            TestSqrt.toSqrt = null;
        }

        /// <summary>
        /// Initialize toSqrt for TestSqrtWithAnyOperand
        /// </summary>         
        public void InitializeTestSqrtWithAnyOperand()
        {
            TestSqrt.toSqrt = "10";
        }

        /// <summary>
        /// Test operation Sqrt with any type of operand
        /// </summary>
        [TestMethod]
        public void TestSqrtWithAnyOperand()
        {
            double result;

            if (double.TryParse(toSqrt.ToString(), out result))
            {
                if (result > 0)
                {
                    Assert.AreEqual(Math.Sqrt(result), calc.Sqrt(result));
                }
                else
                {
                    AssertFailedException.Equals(TestSqrt.calc.Sqrt(result), new Exception());
                }
            }
            else
            {
                AssertFailedException.Equals(TestSqrt.calc.Sqrt(result), new Exception());
            }
        }

        /// <summary>
        /// Initialize toSqrt for TestSqrtPositiveNumber
        /// </summary>         
        public void InitializeTestSqrtPositiveNumber()
        {
            // Value is positive number
            TestSqrt.toSqrt = 5;
        }

        /// <summary>
        /// Test operation Sqrt with operand is positive number
        /// </summary>
        [TestMethod]
        public void TestSqrtPositiveNumber()
        {
            Assert.AreEqual(Math.Sqrt(double.Parse(TestSqrt.toSqrt.ToString())), TestSqrt.calc.Sqrt(TestSqrt.toSqrt));
        }

        /// <summary>
        /// Initialize toSqrt for TestSqrtWithZero
        /// </summary>         
        public void InitializeTestSqrtWithZero()
        {
            // Value is 0
            TestSqrt.toSqrt = 0;
        }

        /// <summary>
        /// Test operation Sqrt with operand is 0
        /// </summary>
        [TestMethod]
        public void TestSqrtWithZero()
        {
            Assert.AreEqual(0, TestSqrt.calc.Sqrt(TestSqrt.toSqrt));
        }

        /// <summary>
        /// Initialize toSqrt for TestSqrtNegativeNumber
        /// </summary>         
        public void InitializeTestSqrtNegativeNumber()
        {
            // Value is negative number
            TestSqrt.toSqrt = -3;
        }

        /// <summary>
        /// Test operation Sqrt with operand is less than 0
        /// </summary>
        [TestMethod]
        public void TestSqrtNegativeNumber()
        {
            Assert.AreEqual(double.NaN, TestSqrt.calc.Sqrt(TestSqrt.toSqrt));
        }

        /// <summary>
        /// Initialize toSqrt for TestSqrtWithNaN
        /// </summary>         
        public void InitializeTestSqrtWithNaN()
        {
            TestSqrt.toSqrt = double.NaN;
        }

        /// <summary>
        /// Test operation Sqrt with operand is double.NaN
        /// </summary>
        [TestMethod]
        public void TestSqrtWithNaN()
        {
            Assert.AreEqual(double.NaN, TestSqrt.calc.Sqrt(TestSqrt.toSqrt));
        }

        /// <summary>
        /// Initialize toSqrt for TestSqrtWithPositiveInfinity
        /// </summary>         
        public void InitializeTestSqrtWithPositiveInfinity()
        {
            TestSqrt.toSqrt = double.PositiveInfinity;
        }

        /// <summary>
        /// Test operation Sqrt with operand is double.PositiveInfinity
        /// </summary>
        [TestMethod]
        public void TestSqrtWithPositiveInfinity()
        {
            Assert.AreEqual(double.PositiveInfinity, TestSqrt.calc.Sqrt(TestSqrt.toSqrt));
        }
    }
}