namespace TestCalculator.MSTest
{
    using System;
    using CSharpCalculator;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class TestDivide
    {
        private static Calculator calc;
        private static double dividend, divider;

        public TestContext TestContext { get; set; }

        /// <summary>
        /// Initialize Calculator for test of operation Divide
        /// </summary>
        /// <param name="context"></param>
        [ClassInitialize]
        public static void TestDivideInitialize(TestContext context)
        {
            TestDivide.calc = new Calculator();
        }

        /// <summary>
        /// Clean up Calculator for test of operation Divide
        /// </summary>
        [ClassCleanup]
        public static void TestDivideCleanup()
        {
            TestDivide.calc = null;
        }

        /// <summary>
        ///  Initializer for any test of operation Divide
        /// </summary>
        [TestInitialize]
        public void Initialize()
        {
            switch (TestContext.TestName)
            {
                case "TestDivideBySelf":
                    this.InitializeTestDivideBySelf();
                    break;
                case "TestDivideByOne":
                    this.InitializeTestDivideByOne();
                    break;
                case "TestDivideByZero":
                    this.InitializeTestDivideByZero();
                    break;
                case "TestDivideWithDifferentOperands":
                    this.InitializeTestDivideWithDifferentOperands();
                    break;
                case "TestDivideWithNegativeInfinity":
                    this.InitializeTestDivideWithNegativeInfinity();
                    break;
                case "TestDivideWithPositiveInfinity":
                    this.InitializeTestDivideWithPositiveInfinity();
                    break;
                case "TestDivideWithNaN":
                    this.InitializeTestDivideWithNaN();
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// Clean up all data for any test of Divide
        /// </summary>
        [TestCleanup]
        public void CleanAllTests()
        {
            TestDivide.dividend = 0;
            TestDivide.divider = 0;
        }

        /// <summary>
        /// Initialize dividend for TestDivideBySelf
        /// </summary>         
        public void InitializeTestDivideBySelf()
        {
            TestDivide.dividend = 10.8d;
        }

        /// <summary>
        /// Test operation Divide with operand is self
        /// </summary>
        [TestMethod]
        public void TestDivideBySelf()
        {
            Assert.AreEqual(1.0d, TestDivide.calc.Divide(TestDivide.dividend, TestDivide.dividend));
        }

        /// <summary>
        /// Initialize dividend for TestDivideByOne
        /// </summary>         
        public void InitializeTestDivideByOne()
        {
            TestDivide.dividend = 10.2d;
        }

        /// <summary>
        /// Test operation Divide with operand is 1
        /// </summary>
        [TestMethod]
        public void TestDivideByOne()
        {
            Assert.AreEqual(TestDivide.dividend, TestDivide.calc.Divide(TestDivide.dividend, 1));
        }

        /// <summary>
        /// Initialize dividend for TestDivideByZero
        /// </summary>         
        public void InitializeTestDivideByZero()
        {
            TestDivide.dividend = 12.5;
        }

        /// <summary>
        /// Test operation Divide with operand is 0
        /// </summary>
        [TestMethod]
        public void TestDivideByZero()
        {
            AssertFailedException.Equals(new Exception(), TestDivide.calc.Divide(TestDivide.dividend, 0));
        }

        /// <summary>
        /// Initialize dividend and divider for TestDivideWithDifferentOperands
        /// </summary>         
        public void InitializeTestDivideWithDifferentOperands()
        {
            TestDivide.dividend = 12.5;
            TestDivide.divider = -2d;
        }

        /// <summary>
        /// Test operation Divide with operands are double
        /// </summary>
        [TestMethod]
        public void TestDivideWithDifferentOperands()
        {
            Assert.AreEqual(TestDivide.dividend / TestDivide.divider, TestDivide.calc.Divide(TestDivide.dividend, TestDivide.divider));
        }

        /// <summary>
        /// Initialize dividend and divider for TestDivideWithNegativeInfinity
        /// </summary>         
        public void InitializeTestDivideWithNegativeInfinity()
        {
            TestDivide.dividend = double.NegativeInfinity;

            /// Value must be great than 0
            TestDivide.divider = 2d;
        }

        /// <summary>
        /// Test operation Divide with dividend is double.NegativeInfinity
        /// </summary>
        [TestMethod]
        public void TestDivideWithNegativeInfinity()
        {
            Assert.AreEqual(double.NegativeInfinity, TestDivide.calc.Divide(TestDivide.dividend, TestDivide.divider));
        }

        /// <summary>
        /// Initialize dividend and divider for TestDivideWithPositiveInfinity
        /// </summary>         
        public void InitializeTestDivideWithPositiveInfinity()
        {
            TestDivide.dividend = double.PositiveInfinity;

            /// Value must be great than 0
            TestDivide.divider = 2d;
        }

        /// <summary>
        /// Test operation Divide with dividend is double.PositiveInfinity
        /// </summary>
        [TestMethod]
        public void TestDivideWithPositiveInfinity()
        {
            Assert.AreEqual(double.PositiveInfinity, TestDivide.calc.Divide(TestDivide.dividend, TestDivide.divider));
        }

        /// <summary>
        /// Initialize dividend and divider for TestDivideWithNaN
        /// </summary>         
        public void InitializeTestDivideWithNaN()
        {
            TestDivide.dividend = double.NaN;
            TestDivide.divider = 2d;
        }

        /// <summary>
        /// Test operation Divide with dividend is double.NaN
        /// </summary>
        [TestMethod]
        public void TestDivideWithNaN()
        {
            Assert.AreEqual(double.NaN, TestDivide.calc.Divide(TestDivide.dividend, TestDivide.divider));
        }
    }
}