namespace TestCalculator.MSTest
{
    using System;
    using CSharpCalculator;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class TestCos
    {
        private static Calculator calc;
        private static object angleInRadian;

        public TestContext TestContext { get; set; }

        /// <summary>
        /// Initialize Calculator for test of operation Cos
        /// </summary>
        /// <param name="context"></param>
        [ClassInitialize]
        public static void TestAddInitialize(TestContext context)
        {
            TestCos.calc = new Calculator();
        }

        /// <summary>
        /// Clean up Calculator for test of operation Cos
        /// </summary>
        [ClassCleanup]
        public static void TestCosCleanup()
        {
            TestCos.calc = null;
        }

        /// <summary>
        ///  Initializer for any test of operation Cos
        /// </summary>
        [TestInitialize]
        public void Initialize()
        {
            switch (TestContext.TestName)
            {
                case "TestCosWithAnyOperand":
                    this.InitializeTestCosWithAnyOperand();
                    break;
                case "TestCosWithZero":
                    this.InitializeTestCosWithZero();
                    break;
                case "TestCosWith180degrees":
                    this.InitializeTestCosWith180degrees();
                    break;
                case "TestCosWithNegativeInfinity":
                    this.InitializeTestCosWithNegativeInfinity();
                    break;
                case "TestCosWithPositiveInfinity":
                    this.InitializeTestCosWithPositiveInfinity();
                    break;
                case "TestCosWithNaN":
                    this.InitializeTestCosWithNaN();
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// Clean up all data for any test of Cos
        /// </summary>
        [TestCleanup]
        public void CleanAllTests()
        {
            TestCos.angleInRadian = null;
        }

        /// <summary>
        /// Initialize angleInRadian for TestCosWithAnyOperand
        /// </summary>         
        public void InitializeTestCosWithAnyOperand()
        {
            TestCos.angleInRadian = "10";
        }

        /// <summary>
        /// Test operation Cos with any type of operand
        /// </summary>
        [TestMethod]
        public void TestCosWithAnyOperand()
        {
            double result;

            if (double.TryParse(TestCos.angleInRadian.ToString(), out result))
            {
                Assert.AreEqual(Math.Cos(result), TestCos.calc.Cos(result));
            }
            else
            {
                AssertFailedException.Equals(TestCos.calc.Cos(result), new Exception());
            }
        }

        /// <summary>
        /// Initialize angleInRadian for TestCosWithZero
        /// </summary>         
        public void InitializeTestCosWithZero()
        {
            TestCos.angleInRadian = 0;
        }

        /// <summary>
        /// Test operation Cos with operand is zero
        /// </summary>
        [TestMethod]
        public void TestCosWithZero()
        {
            var calc = new CSharpCalculator.Calculator();

            Assert.AreEqual(1, calc.Cos(TestCos.angleInRadian));
        }

        /// <summary>
        /// Initialize angleInRadian for TestCosWith180degrees
        /// </summary>         
        public void InitializeTestCosWith180degrees()
        {
            TestCos.angleInRadian = Math.PI;
        }

        /// <summary>
        /// Test operation Cos with operand is 180 degrees
        /// </summary>
        [TestMethod]
        public void TestCosWith180degrees()
        {
            Assert.AreEqual(-1, calc.Cos(TestCos.angleInRadian));
        }

        /// <summary>
        /// Initialize angleInRadian for TestCosWithNegativeInfinity
        /// </summary>         
        public void InitializeTestCosWithNegativeInfinity()
        {
            TestCos.angleInRadian = double.NegativeInfinity;
        }

        /// <summary>
        /// Test operation Cos with operand is double.NegativeInfinity
        /// </summary>
        [TestMethod]
        public void TestCosWithNegativeInfinity()
        {
            Assert.AreEqual(double.NaN, calc.Cos(TestCos.angleInRadian));
        }

        /// <summary>
        /// Initialize angleInRadian for TestCosWithPositiveInfinity
        /// </summary>         
        public void InitializeTestCosWithPositiveInfinity()
        {
            TestCos.angleInRadian = double.PositiveInfinity;
        }

        /// <summary>
        /// Test operation Cos with operand is double.PositiveInfinity
        /// </summary>
        [TestMethod]
        public void TestCosWithPositiveInfinity()
        {
            Assert.AreEqual(double.NaN, calc.Cos(TestCos.angleInRadian));
        }

        /// <summary>
        /// Initialize angleInRadian for TestCosWithNaN
        /// </summary>         
        public void InitializeTestCosWithNaN()
        {
            TestCos.angleInRadian = double.NaN;
        }

        /// <summary>
        ///  Test operation Cos with operand is double.NaN
        /// </summary>
        [TestMethod]
        public void TestCosWithNaN()
        {
            Assert.AreEqual(double.NaN, calc.Cos(TestCos.angleInRadian));
        }
    }
}