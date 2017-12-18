namespace TestCalculator
{
    using System;
    using CSharpCalculator;
    using NUnit.Framework;

    [TestFixture]
    public class TestDivide
    {
        private static Calculator calc;
        private static double dividend, divider;

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
        ///  Initializer for any test of operation Divide
        /// </summary>
        [SetUp]
        public void Initialize()
        {
            switch (TestContext.CurrentContext.Test.Name)
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
        [TearDown]
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
        [Test]
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
        [Test]
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
        [Test]
        public void TestDivideByZero()
        {
            AssertionException.Equals(new Exception(), TestDivide.calc.Divide(TestDivide.dividend, 0));
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
        [Test]
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
        [Test]
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
        [Test]
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
        [Test]
        public void TestDivideWithNaN()
        {
            Assert.AreEqual(double.NaN, TestDivide.calc.Divide(TestDivide.dividend, TestDivide.divider));
        }
    }
}