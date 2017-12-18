namespace TestCalculator
{
    using System;
    using CSharpCalculator;
    using NUnit.Framework;

    /// <summary>
    /// Tests are written by https://msdn.microsoft.com/ru-ru/library/system.math.pow(v=vs.110).aspx.
    /// </summary>
    [TestFixture]
    public class TestPow
    {
        private static Calculator calc;
        private static object number, power;

        /// <summary>
        /// Initialize Calculator for test of operation Pow
        /// </summary>      
        [OneTimeSetUp]
        public void TestAddInitialize()
        {
            TestPow.calc = new Calculator();
        }

        /// <summary>
        /// Clean up Calculator for test of operation Pow
        /// </summary>
        [OneTimeTearDown]
        public void TestPowCleanup()
        {
            TestPow.calc = null;
        }

        /// <summary>
        ///  Initializer for any test of operation Pow
        /// </summary>
        [SetUp]
        public void Initialize()
        {
            switch (TestContext.CurrentContext.Test.Name)
            {
                case "TestPowWithAnyOperands":
                    this.InitializeTestPowWithAnyOperands();
                    break;
                case "TestPowByOne":
                    this.InitializeTestPowByOne();
                    break;
                case "TestPowWithPowerZero":
                    this.InitializeTestPowWithPowerZero();
                    break;
                case "TestPowByPowerNaN":
                    this.InitializeTestPowByPowerNaN();
                    break;
                case "TestPowByNumberNaN":
                    this.InitializeTestPowByNumberNaN();
                    break;
                case "TestPowByNumberNegativeInfinity":
                    this.InitializeTestPowByNumberNegativeInfinity();
                    break;
                case "TestPowByOddPower":
                    this.InitializeTestPowByOddPower();
                    break;
                case "TestPowByEvenPower":
                    this.InitializeTestPowByEvenPower();
                    break;
                case "TestPowByDoublePower":
                    this.InitializeTestPowByDoublePower();
                    break;
                case "TestPowByMinusOne":
                    this.InitializeTestPowByMinusOne();
                    break;
                case "TestPowByRangeMinus1By1AndNegativeInfinity":
                    this.InitializeTestPowByRangeMinus1By1AndNegativeInfinity();
                    break;
                case "TestPowByRangeMinus1By1AndPositiveInfinity":
                    this.InitializeTestPowByRangeMinus1By1AndPositiveInfinity();
                    break;
                case "TestPowWithLessThanMinus1AndNegativeInfinity":
                    this.InitializeTestPowWithLessThanMinus1AndNegativeInfinity();
                    break;
                case "TestPowWithGreatThan1AndNegativeInfinity":
                    this.InitializeTestPowWithGreatThan1AndNegativeInfinity();
                    break;
                case "TestPowWithLessThanMinus1AndPositiveInfinity":
                    this.InitializeTestPowWithLessThanMinus1AndPositiveInfinity();
                    break;
                case "TestPowWithGreatThan1AndPositiveInfinity":
                    this.InitializeTestPowWithGreatThan1AndPositiveInfinity();
                    break;
                case "TestPowWithNumberZeroAndPowerLessZero":
                    this.InitializeTestPowWithNumberZeroAndPowerLessZero();
                    break;
                case "TestPowWithNumberZeroAndPowerGreatZero":
                    this.InitializeTestPowWithNumberZeroAndPowerGreatZero();
                    break;
                case "TestPowWithNumberOneAndPowerNotNaN":
                    this.InitializeTestPowWithNumberOneAndPowerNotNaN();
                    break;
                case "TestPowWithNumberPositiveInfinityAndPowerLessZero":
                    this.InitializeTestPowWithNumberPositiveInfinityAndPowerLessZero();
                    break;
                case "TestPowWithNumberPositiveInfinityAndPowerGreatZero":
                    this.InitializeTestPowWithNumberPositiveInfinityAndPowerGreatZero();
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// Clean up all data for any test of Pow
        /// </summary>
        [TearDown]
        public void CleanAllTests()
        {
            TestPow.number = null;
            TestPow.power = null;
        }

        /// <summary>
        /// Initialize data for TestPowWithAnyOperands
        /// </summary>         
        public void InitializeTestPowWithAnyOperands()
        {
            TestPow.number = 10d;
            TestPow.power = "20";
        }

        /// <summary>
        /// Test operation Pow with any type of operand
        /// </summary>
        [Test]
        public void TestPowWithAnyOperands()
        {
            Assert.Throws<NotFiniteNumberException>(() =>
                                                    Assert.AreEqual(
                                                                    double.Parse(TestPow.number.ToString()) + double.Parse(TestPow.power.ToString()),
                                                                    TestPow.calc.Pow(TestPow.number, TestPow.power)));
        }

        /// <summary>
        /// Initialize data for TestPowByOne
        /// </summary>         
        public void InitializeTestPowByOne()
        {
            TestPow.number = 10;
        }

        /// <summary>
        ///  Test operation Pow with power is 1
        /// </summary>
        [Test]
        public void TestPowByOne()
        {
            Assert.AreEqual(TestPow.number, TestPow.calc.Pow(TestPow.number, 1));
        }

        /// <summary>
        /// Initialize data for TestPowByOne
        /// </summary>         
        public void InitializeTestPowWithPowerZero()
        {
            TestPow.number = 10d;
        }

        /// <summary>
        /// Test operation Pow with power is 0
        /// </summary>
        [Test]
        public void TestPowWithPowerZero()
        {
            Assert.AreEqual(1d, TestPow.calc.Pow(TestPow.number, 0));
        }

        /// <summary>
        /// Initialize data for TestPowByPowerNaN
        /// </summary>         
        public void InitializeTestPowByPowerNaN()
        {
            TestPow.number = 10d;
        }

        /// <summary>
        /// Test operation Pow with power is double.NaN
        /// </summary>
        [Test]
        public void TestPowByPowerNaN()
        {
            Assert.AreEqual(double.NaN, TestPow.calc.Pow(TestPow.number, double.NaN));
        }

        /// <summary>
        /// Initialize data for TestPowByPowerNaN
        /// </summary>         
        public void InitializeTestPowByNumberNaN()
        {
            TestPow.power = 10d;
        }

        /// <summary>
        /// Test operation Pow with number is double.NaN
        /// </summary>
        [Test]
        public void TestPowByNumberNaN()
        {
            Assert.AreEqual(double.NaN, TestPow.calc.Pow(double.NaN, TestPow.power));
        }

        /// <summary>
        /// Initialize data for TestPowByNumberNegativeInfinity
        /// </summary>         
        public void InitializeTestPowByNumberNegativeInfinity()
        {
            // Value must be less than 0
            TestPow.power = -10d;
        }

        /// <summary>
        /// Test operation Pow with number is double.NegativeInfinity and power is less than 0
        /// </summary>
        [Test]
        public void TestPowByNumberNegativeInfinity()
        {
            Assert.AreEqual(0d, TestPow.calc.Pow(double.NegativeInfinity, TestPow.power));
        }

        /// <summary>
        /// Initialize data for TestPowByOddPower
        /// </summary>         
        public void InitializeTestPowByOddPower()
        {
            // Value must be a positive odd integer
            TestPow.power = 5;
        }

        /// <summary>
        ///  Test operation Pow with number is double.NegativeInfinity and power is a positive odd integer
        /// </summary>
        [Test]
        public void TestPowByOddPower()
        {
            Assert.AreEqual(double.NegativeInfinity, TestPow.calc.Pow(double.NegativeInfinity, TestPow.power));
        }

        /// <summary>
        /// Initialize data for TestPowByEvenPower
        /// </summary>         
        public void InitializeTestPowByEvenPower()
        {
            // Value must be even positive integer
            TestPow.power = 4;
        }

        /// <summary>
        /// Test operation Pow with number is double.NegativeInfinity and power is a positive even integer
        /// </summary>
        [Test]
        public void TestPowByEvenPower()
        {
            Assert.AreEqual(double.PositiveInfinity, TestPow.calc.Pow(double.NegativeInfinity, TestPow.power));
        }

        /// <summary>
        /// Initialize data for TestPowByDoublePower
        /// </summary>         
        public void InitializeTestPowByDoublePower()
        {
            // Value is negative, but isn't NegativeInfinity
            TestPow.number = -10;

            // Value isn't an integer, NegativeInfinity, or PositiveInfinity. 
            TestPow.power = 4.8;
        }

        /// <summary>
        /// Test operation Pow with number is negative, but isn't NegativeInfinity, and power isn't an integer, NegativeInfinity, or PositiveInfinity
        /// </summary>
        [Test]
        public void TestPowByDoublePower()
        {
            Assert.AreEqual(double.NaN, TestPow.calc.Pow(TestPow.number, TestPow.power));
        }

        /// <summary>
        /// Initialize data for TestPowByMinusOne
        /// </summary>         
        public void InitializeTestPowByMinusOne()
        {
            // Value is -1
            TestPow.number = -1;

            // Value is NegativeInfinity or PositiveInfinity
            TestPow.power = double.NegativeInfinity;
        }

        /// <summary>
        /// Test operation Pow with number is -1, and power is double.NegativeInfinity
        /// </summary>
        [Test]
        public void TestPowByMinusOne()
        {
            Assert.AreEqual(double.NaN, TestPow.calc.Pow(TestPow.number, TestPow.power));
        }

        /// <summary>
        /// Initialize data for TestPowByRangeMinus1By1AndNegativeInfinity
        /// </summary>         
        public void InitializeTestPowByRangeMinus1By1AndNegativeInfinity()
        {
            // Value is in  range from -1 to 1
            TestPow.number = -0.5;

            // Value is NegativeInfinity 
            TestPow.power = double.NegativeInfinity;
        }

        /// <summary>
        /// Test operation Pow with number is in  range from -1 to 1 and power is double.NegativeInfinity
        /// </summary>
        [Test]
        public void TestPowByRangeMinus1By1AndNegativeInfinity()
        {
            Assert.AreEqual(double.PositiveInfinity, TestPow.calc.Pow(TestPow.number, TestPow.power));
        }

        /// <summary>
        /// Initialize data for TestPowByRangeMinus1By1AndPositiveInfinity
        /// </summary>         
        public void InitializeTestPowByRangeMinus1By1AndPositiveInfinity()
        {
            // Value is in  range from -1 to 1.
            TestPow.number = -0.5;

            // Value is PositiveInfinity. 
            TestPow.power = double.PositiveInfinity;
        }

        /// <summary>
        /// Test operation Pow with number is in  range from -1 to 1 and power is double.PositiveInfinity
        /// </summary>
        [Test]
        public void TestPowByRangeMinus1By1AndPositiveInfinity()
        {
            Assert.AreEqual(0d, TestPow.calc.Pow(TestPow.number, TestPow.power));
        }

        /// <summary>
        /// Initialize data for TestPowWithLessThanMinus1AndNegativeInfinity
        /// </summary>         
        public void InitializeTestPowWithLessThanMinus1AndNegativeInfinity()
        {
            // Value is less than -1
            TestPow.number = -0.5;

            // Value is NegativeInfinity
            TestPow.power = double.NegativeInfinity;
        }

        /// <summary>
        /// Test operation Pow with number is less than -1 and power is double.NegativeInfinity
        /// </summary>
        [Test]
        public void TestPowWithLessThanMinus1AndNegativeInfinity()
        {
            Assert.AreEqual(0d, TestPow.calc.Pow(TestPow.number, TestPow.power));
        }

        /// <summary>
        /// Initialize data for TestPowWithGreatThan1AndNegativeInfinity
        /// </summary>         
        public void InitializeTestPowWithGreatThan1AndNegativeInfinity()
        {
            // Value is great than 1
            TestPow.number = 2;

            // Value is NegativeInfinity. 
            TestPow.power = double.NegativeInfinity;
        }

        /// <summary>
        ///  Test operation Pow with number is great than 1 and power is double.NegativeInfinity
        /// </summary>
        [Test]
        public void TestPowWithGreatThan1AndNegativeInfinity()
        {
            Assert.AreEqual(0d, TestPow.calc.Pow(TestPow.number, TestPow.power));
        }

        /// <summary>
        /// Initialize data for TestPowWithLessThanMinus1AndPositiveInfinity
        /// </summary>         
        public void InitializeTestPowWithLessThanMinus1AndPositiveInfinity()
        {
            // Value is less than -1
            TestPow.number = -2;

            // Value is PositiveInfinity 
            TestPow.power = double.PositiveInfinity;
        }

        /// <summary>
        /// Test operation Pow with number is less than -1 and power is double.PositiveInfinity
        /// </summary>
        [Test]
        public void TestPowWithLessThanMinus1AndPositiveInfinity()
        {
            Assert.AreEqual(double.PositiveInfinity, TestPow.calc.Pow(TestPow.number, TestPow.power));
        }

        /// <summary>
        /// Initialize data for TestPowWithGreatThan1AndPositiveInfinity
        /// </summary>         
        public void InitializeTestPowWithGreatThan1AndPositiveInfinity()
        {
            // Value is great than 1
            TestPow.number = 2;

            // Value is PositiveInfinity 
            TestPow.power = double.PositiveInfinity;
        }

        /// <summary>
        /// Test operation Pow with number is great than 1 and power is double.PositiveInfinity
        /// </summary>
        [Test]
        public void TestPowWithGreatThan1AndPositiveInfinity()
        {
            Assert.AreEqual(double.PositiveInfinity, TestPow.calc.Pow(TestPow.number, TestPow.power));
        }

        /// <summary>
        /// Initialize data for TestPowWithNumberZeroAndPowerLessZero
        /// </summary>         
        public void InitializeTestPowWithNumberZeroAndPowerLessZero()
        {
            // Value is 0
            TestPow.number = 0;

            // Value is less than 0
            TestPow.power = -7;
        }

        /// <summary>
        ///  Test operation Pow with number is 0 and power is less than 0
        /// </summary>
        [Test]
        public void TestPowWithNumberZeroAndPowerLessZero()
        {
            Assert.AreEqual(double.PositiveInfinity, TestPow.calc.Pow(TestPow.number, TestPow.power));
        }

        /// <summary>
        /// Initialize data for TestPowWithNumberZeroAndPowerGreatZero
        /// </summary>         
        public void InitializeTestPowWithNumberZeroAndPowerGreatZero()
        {
            // Value is 0
            TestPow.number = 0;

            // Value is great than 0. 
            TestPow.power = 7;
        }

        /// <summary>
        ///  Test operation Pow with number is 0 and power is great than 0
        /// </summary>
        [Test]
        public void TestPowWithNumberZeroAndPowerGreatZero()
        {
            Assert.AreEqual(0d, TestPow.calc.Pow(TestPow.number, TestPow.power));
        }

        /// <summary>
        /// Initialize data for TestPowWithNumberOneAndPowerNotNaN
        /// </summary>         
        public void InitializeTestPowWithNumberOneAndPowerNotNaN()
        {
            // Value is 1
            TestPow.number = 1;

            // Value isn't NaN
            TestPow.power = 7;
        }

        /// <summary>
        ///  Test operation Pow with number is 1 and power isn't NaN
        /// </summary>
        [Test]
        public void TestPowWithNumberOneAndPowerNotNaN()
        {
            Assert.AreEqual(1d, TestPow.calc.Pow(TestPow.number, TestPow.power));
        }

        /// <summary>
        /// Initialize data for TestPowWithNumberPositiveInfinityAndPowerLessZero
        /// </summary>         
        public void InitializeTestPowWithNumberPositiveInfinityAndPowerLessZero()
        {
            // Value is double.PositiveInfinity
            TestPow.number = double.PositiveInfinity;

            // Value is less than 0
            TestPow.power = -7;
        }

        /// <summary>
        /// Test operation Pow with number is double.PositiveInfinity and power is less than 0
        /// </summary>
        [Test]
        public void TestPowWithNumberPositiveInfinityAndPowerLessZero()
        {
            Assert.AreEqual(0d, TestPow.calc.Pow(TestPow.number, TestPow.power));
        }

        /// <summary>
        /// Initialize data for TestPowWithNumberPositiveInfinityAndPowerGreatZero
        /// </summary>         
        public void InitializeTestPowWithNumberPositiveInfinityAndPowerGreatZero()
        {
            // Value is double.PositiveInfinity
            TestPow.number = double.PositiveInfinity;

            // Value is great than 0
            TestPow.power = 26;
        }

        /// <summary>
        /// Test operation Pow with number is double.PositiveInfinity and power is great than 0
        /// </summary>
        [Test]
        public void TestPowWithNumberPositiveInfinityAndPowerGreatZero()
        {
            Assert.AreEqual(double.PositiveInfinity, TestPow.calc.Pow(TestPow.number, TestPow.power));
        }
    }
}