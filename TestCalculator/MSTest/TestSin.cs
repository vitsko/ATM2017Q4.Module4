namespace TestCalculator.MSTest
{
    using System;
    using CSharpCalculator;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class TestSin
    {
        private static Calculator calc;
        private static object angleInRadian;

        public TestContext TestContext { get; set; }

        /// <summary>
        /// Initialize Calculator for test of operation Sin
        /// </summary>
        /// <param name="context"></param>
        [ClassInitialize]
        public static void TestSqrtInitialize(TestContext context)
        {
            TestSin.calc = new Calculator();
        }

        /// <summary>
        /// Clean up Calculator for test of operation Sin
        /// </summary>
        [ClassCleanup]
        public static void TestSinCleanup()
        {
            TestSin.calc = null;
        }

        /// <summary>
        ///  Initializer for any test of operation Sin
        /// </summary>
        [TestInitialize]
        public void Initialize()
        {
            switch (TestContext.TestName)
            {
                case "TestSinWithAnyOperand":
                    this.InitializeTestSinWithAnyOperand();
                    break;
                case "TestSinWithZero":
                    this.InitializeTestSinWithZero();
                    break;
                case "TestSinWith90degrees":
                    this.InitializeTestSinWith90degrees();
                    break;
                case "TestSinWithNegativeInfinity":
                    this.InitializeTestSinWithNegativeInfinity();
                    break;
                case "TestSinWithPositiveInfinity":
                    this.InitializeTestSinWithPositiveInfinity();
                    break;
                case "TestSinWithNaN":
                    this.InitializeTestSinWithNaN();
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// Clean up all data for any test of Sin
        /// </summary>
        [TestCleanup]
        public void CleanAllTests()
        {
            TestSin.angleInRadian = null;
        }

        /// <summary>
        /// Initialize angleInRadian for TestSinWithAnyOperand
        /// </summary>         
        public void InitializeTestSinWithAnyOperand()
        {
            TestSin.angleInRadian = "10";
        }

        /// <summary>
        /// Test operation Sin with any type of operand
        /// </summary>
        [TestMethod]
        public void TestSinWithAnyOperand()
        {
            double result;

            if (double.TryParse(TestSin.angleInRadian.ToString(), out result))
            {
                Assert.AreEqual(Math.Sin(result), TestSin.calc.Sin(result));
            }
            else
            {
                AssertFailedException.Equals(TestSin.calc.Sin(result), new Exception());
            }
        }

        /// <summary>
        /// Initialize angleInRadian for TestSinWithZero
        /// </summary>         
        public void InitializeTestSinWithZero()
        {
            TestSin.angleInRadian = 0;
        }

        /// <summary>
        /// Test operation Sin with operand is 0
        /// </summary>
        [TestMethod]
        public void TestSinWithZero()
        {
            Assert.AreEqual(0, TestSin.calc.Sin(TestSin.angleInRadian));
        }

        /// <summary>
        /// Initialize angleInRadian for TestSinWith90degrees
        /// </summary>         
        public void InitializeTestSinWith90degrees()
        {
            TestSin.angleInRadian = Math.PI / 2;
        }

        /// <summary>
        /// Test operation Sin with operand is 90 degrees
        /// </summary>
        [TestMethod]
        public void TestSinWith90degrees()
        {
            Assert.AreEqual(1, TestSin.calc.Sin(TestSin.angleInRadian));
        }

        /// <summary>
        /// Initialize angleInRadian for TestSinWithNegativeInfinity
        /// </summary>         
        public void InitializeTestSinWithNegativeInfinity()
        {
            TestSin.angleInRadian = double.NegativeInfinity;
        }

        /// <summary>
        /// Test operation Sin with operand is double.NegativeInfinity
        /// </summary>
        [TestMethod]
        public void TestSinWithNegativeInfinity()
        {
            Assert.AreEqual(double.NaN, TestSin.calc.Sin(TestSin.angleInRadian));
        }

        /// <summary>
        /// Initialize angleInRadian for TestSinWithPositiveInfinity
        /// </summary>         
        public void InitializeTestSinWithPositiveInfinity()
        {
            TestSin.angleInRadian = double.PositiveInfinity;
        }

        /// <summary>
        /// Test operation Sin with operand is double.PositiveInfinity
        /// </summary>
        [TestMethod]
        public void TestSinWithPositiveInfinity()
        {
            Assert.AreEqual(double.NaN, calc.Sin(TestSin.angleInRadian));
        }

        /// <summary>
        /// Initialize angleInRadian for TestSinWithNaN
        /// </summary>         
        public void InitializeTestSinWithNaN()
        {
            TestSin.angleInRadian = double.NaN;
        }

        /// <summary>
        /// Test operation Sin with operand is double.NaN
        /// </summary>
        [TestMethod]
        public void TestSinWithNaN()
        {
            double angleInRad = double.NaN;
            var calc = new CSharpCalculator.Calculator();

            Assert.AreEqual(double.NaN, calc.Sin(angleInRad));
        }
    }
}