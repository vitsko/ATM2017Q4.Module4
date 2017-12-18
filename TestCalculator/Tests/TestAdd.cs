namespace TestCalculator
{
    using System;
    using CSharpCalculator;
    using NUnit.Framework;

    [TestFixture]
    public class TestAdd
    {
        private static Calculator calc;
        private static object first, second;

        /// <summary>
        /// Initialize Calculator for test of operation Add
        /// </summary>
        [OneTimeSetUp]
        public void TestAddInitialize()
        {
            TestAdd.calc = new Calculator();
        }

        /// <summary>
        /// Clean up Calculator for test of operation Add
        /// </summary>
        [OneTimeTearDown]
        public void TestAddCleanup()
        {
            TestAdd.calc = null;
        }

        /// <summary>
        ///  Initializer for any test of operation Add
        /// </summary>
        [SetUp]
        public void Initialize()
        {
            switch (TestContext.CurrentContext.Test.Name)
            {
                case "TestAddWithAnyOperand":
                    this.InitializeTestAddWithAnyOperand();
                    break;
                case "TestAddWithZero":
                    this.InitializeTestAddWithZero();
                    break;
                case "TestAddWithNegativeInfinity":
                    this.InitializeTestAddWithNegativeInfinity();
                    break;
                case "TestAddWithPositiveInfinity":
                    this.InitializeTestAddWithPositiveInfinity();
                    break;
                case "TestAddWithNaN":
                    this.InitializeTestAddWithNaN();
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// Clean up all data for any test of Add
        /// </summary>
        [TearDown]
        public void CleanAllTests()
        {
            TestAdd.first = null;
            TestAdd.second = null;
        }

        /// <summary>
        /// Initialize data for TestAddWithAnyOperand
        /// </summary>         
        public void InitializeTestAddWithAnyOperand()
        {
            TestAdd.first = 10d;
            TestAdd.second = "20";
        }

        /// <summary>
        /// Test operation Add with any type of operand
        /// </summary>
        [Test]
        public void TestAddWithAnyOperand()
        {
            Assert.Throws<InvalidCastException>(() =>
                                                Assert.AreEqual(
                                                                double.Parse(TestAdd.first.ToString()) + double.Parse(TestAdd.second.ToString()),
                                                                TestAdd.calc.Add(TestAdd.first, TestAdd.second)));
        }

        /// <summary>
        /// Initialize data for TestAddWithZero
        /// </summary>         
        public void InitializeTestAddWithZero()
        {
            TestAdd.first = 10d;
            TestAdd.second = 0;
        }

        /// <summary>
        /// Test operation Add with operand is zero
        /// </summary>
        [Test]
        public void TestAddWithZero()
        {
            var toParse1 = double.Parse(TestAdd.first.ToString());
            var toParse2 = double.Parse(TestAdd.second.ToString());

            Assert.AreEqual(toParse1, TestAdd.calc.Add(toParse1, toParse2));
        }

        /// <summary>
        /// Initialize data for TestAddWithNegativeInfinity
        /// </summary>         
        public void InitializeTestAddWithNegativeInfinity()
        {
            TestAdd.first = double.NegativeInfinity;
            TestAdd.second = 2d;
        }

        /// <summary>
        /// Test operation Add with operand is double.NegativeInfinity
        /// </summary>
        [Test]
        public void TestAddWithNegativeInfinity()
        {
            Assert.AreEqual(double.NegativeInfinity, TestAdd.calc.Add(TestAdd.first, TestAdd.second));
        }

        /// <summary>
        /// Initialize data for TestAddWithNegativeInfinity
        /// </summary>         
        public void InitializeTestAddWithPositiveInfinity()
        {
            TestAdd.first = double.PositiveInfinity;
            TestAdd.second = 2d;
        }

        /// <summary>
        /// Test operation Add with operand is double.PositiveInfinity
        /// </summary>
        [Test]
        public void TestAddWithPositiveInfinity()
        {
            Assert.AreEqual(double.PositiveInfinity, TestAdd.calc.Add(TestAdd.first, TestAdd.second));
        }

        /// <summary>
        /// Initialize data for TestAddWithNaN
        /// </summary>         
        public void InitializeTestAddWithNaN()
        {
            TestAdd.first = double.NaN;
            TestAdd.second = 2d;
        }

        /// <summary>
        /// Test operation Add with operand is double.NaN
        /// </summary>
        [Test]
        public void TestAddWithNaN()
        {
            Assert.AreEqual(double.NaN, TestAdd.calc.Add(TestAdd.first, TestAdd.second));
        }
    }
}