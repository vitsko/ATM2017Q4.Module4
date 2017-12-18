namespace TestCalculator.MSTest
{
    using System;
    using CSharpCalculator;
    using NUnit.Framework;

    /// <summary>
    /// Tests are written by https://msdn.microsoft.com/ru-ru/library/system.math.sqrt(v=vs.110).aspx
    /// </summary>
    [TestFixture]
    public class TestSqrt
    {
        private static Calculator calc;
        private static object toSqrt;

        /// <summary>
        /// Initialize Calculator for test of operation Sqrt
        /// </summary>        
        [OneTimeSetUp]
        public void TestSqrtInitialize()
        {
            TestSqrt.calc = new Calculator();
        }

        /// <summary>
        /// Clean up Calculator for test of operation Sqrt
        /// </summary>
        [OneTimeTearDown]
        public void TestSqrtCleanup()
        {
            TestSqrt.calc = null;
        }

        /// <summary>
        ///  Initializer for any test of operation Sqrt
        /// </summary>
        [SetUp]
        public void Initialize()
        {
            switch (TestContext.CurrentContext.Test.Name)
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
        [TearDown]
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
        [Test]
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
                    AssertionException.Equals(TestSqrt.calc.Sqrt(result), new Exception());
                }
            }
            else
            {
                AssertionException.Equals(TestSqrt.calc.Sqrt(result), new Exception());
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
        [Test]
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
        [Test]
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
        [Test]
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
        [Test]
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
        [Test]
        public void TestSqrtWithPositiveInfinity()
        {
            Assert.AreEqual(double.PositiveInfinity, TestSqrt.calc.Sqrt(TestSqrt.toSqrt));
        }
    }
}