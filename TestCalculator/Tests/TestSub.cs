namespace TestCalculator
{
    using System;
    using CSharpCalculator;
    using NUnit.Framework;

    [TestFixture]
    public class TestSub
    {
        private static Calculator calc;
        private static object minuend, subtrahend;

        /// <summary>
        /// Initialize Calculator for test of operation Sub
        /// </summary>        
        [OneTimeSetUp]
        public void TestSubInitialize()
        {
            TestSub.calc = new Calculator();
        }

        /// <summary>
        /// Clean up Calculator for test of operation Sub
        /// </summary>
        [OneTimeTearDown]
        public void TestSubCleanup()
        {
            TestSub.calc = null;
        }

        /// <summary>
        ///  Initializer for any test of operation Add
        /// </summary>
        [SetUp]
        public void Initialize()
        {
            switch (TestContext.CurrentContext.Test.Name)
            {
                case "TestSubWithAnyOperand":
                    this.InitializeTestSubWithAnyOperand();
                    break;
                case "TestSubZero":
                    this.InitializeTestSubZero();
                    break;
                case "TestSubFromZero":
                    this.InitializeTestSubFromZero();
                    break;
                case "TestSubWithNumber":
                    this.InitializeTestSubWithNumber();
                    break;
                case "TestSubWithNegativeInfinity":
                    this.InitializeTestSubWithNegativeInfinity();
                    break;
                case "TestSubWithPositiveInfinity":
                    this.InitializeTestSubWithPositiveInfinity();
                    break;
                case "TestSubWithNan":
                    this.InitializeTestSubWithNan();
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// Clean up all data for any test of Sub
        /// </summary>
        [TearDown]
        public void CleanAllTests()
        {
            TestSub.minuend = null;
            TestSub.subtrahend = null;
        }

        /// <summary>
        /// Initialize data for TestSubWithAnyOperand
        /// </summary>         
        public void InitializeTestSubWithAnyOperand()
        {
            TestSub.minuend = 10d;
            TestSub.subtrahend = "20";
        }

        /// <summary>
        /// Test operation Sub with any type of operand
        /// </summary>
        [Test]
        public void TestSubWithAnyOperand()
        {
            Assert.Throws<InvalidCastException>(() =>
                                                Assert.AreEqual(
                                                                double.Parse(TestSub.minuend.ToString()) + double.Parse(TestSub.subtrahend.ToString()),
                                                                TestSub.calc.Add(TestSub.minuend, TestSub.subtrahend)));
        }

        /// <summary>
        /// Initialize data for TestSubZero
        /// </summary>         
        public void InitializeTestSubZero()
        {
            TestSub.minuend = 10d;
            TestSub.subtrahend = 0;
        }

        /// <summary>
        /// Test operation Sub with subtrahend is zero
        /// </summary>
        [Test]
        public void TestSubZero()
        {
            var toParse1 = double.Parse(TestSub.minuend.ToString());
            var toParse2 = double.Parse(TestSub.subtrahend.ToString());

            Assert.AreEqual(toParse1, TestSub.calc.Sub(toParse1, toParse2));
        }

        /// <summary>
        /// Initialize data for TestSubFromZero
        /// </summary>         
        public void InitializeTestSubFromZero()
        {
            TestSub.minuend = 0;
            TestSub.subtrahend = 10;
        }

        /// <summary>
        /// Test operation Sub with minuend is zero
        /// </summary>
        [Test]
        public void TestSubFromZero()
        {
            var calc = new CSharpCalculator.Calculator();
            var toParse1 = double.Parse(TestSub.minuend.ToString());
            var toParse2 = double.Parse(TestSub.subtrahend.ToString());

            Assert.AreEqual(toParse2 * -1, calc.Sub(toParse1, toParse2));
        }

        /// <summary>
        /// Initialize data for TestSubWithNumber
        /// </summary>         
        public void InitializeTestSubWithNumber()
        {
            TestSub.minuend = 10.5d;
            TestSub.subtrahend = 1;
        }

        /// <summary>
        /// Test operation Sub with operands are double
        /// </summary>
        [Test]
        public void TestSubWithNumber()
        {
            var toParse1 = double.Parse(TestSub.minuend.ToString());
            var toParse2 = double.Parse(TestSub.subtrahend.ToString());

            Assert.AreEqual(toParse1 - toParse2, TestSub.calc.Sub(toParse1, toParse2));
        }

        /// <summary>
        /// Initialize data for TestSubWithNegativeInfinity
        /// </summary>         
        public void InitializeTestSubWithNegativeInfinity()
        {
            TestSub.minuend = double.NegativeInfinity;
            TestSub.subtrahend = 12d;
        }

        /// <summary>
        /// Test operation Sub with minuend is double.NegativeInfinity
        /// </summary>
        [Test]
        public void TestSubWithNegativeInfinity()
        {
            Assert.AreEqual(double.NegativeInfinity, TestSub.calc.Sub(TestSub.minuend, TestSub.subtrahend));
        }

        /// <summary>
        /// Initialize data for TestSubWithPositiveInfinity
        /// </summary>         
        public void InitializeTestSubWithPositiveInfinity()
        {
            TestSub.minuend = double.PositiveInfinity;
            TestSub.subtrahend = 198d;
        }

        /// <summary>
        /// Test operation Sub with minuend is double.PositiveInfinity
        /// </summary>
        [Test]
        public void TestSubWithPositiveInfinity()
        {
            Assert.AreEqual(double.PositiveInfinity, TestSub.calc.Sub(TestSub.minuend, TestSub.subtrahend));
        }

        /// <summary>
        /// Initialize data for TestSubWithNan
        /// </summary>         
        public void InitializeTestSubWithNan()
        {
            TestSub.minuend = double.NaN;
            TestSub.subtrahend = 123;
        }

        /// <summary>
        /// Test operation Sub with minuend is double.NaN
        /// </summary>
        [Test]
        public void TestSubWithNan()
        {
            Assert.AreEqual(double.NaN, TestSub.calc.Sub(TestSub.minuend, TestSub.subtrahend));
        }
    }
}