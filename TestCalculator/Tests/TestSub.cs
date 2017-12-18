namespace TestCalculator
{
    using System;
    using CSharpCalculator;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class TestSub
    {
        private static Calculator calc;
        private static object minuend, subtrahend;

        public TestContext TestContext { get; set; }

        /// <summary>
        /// Initialize Calculator for test of operation Sub
        /// </summary>
        /// <param name="context"></param>
        [ClassInitialize]
        public static void TestSubInitialize(TestContext context)
        {
            TestSub.calc = new Calculator();
        }

        /// <summary>
        /// Clean up Calculator for test of operation Sub
        /// </summary>
        [ClassCleanup]
        public static void TestSubCleanup()
        {
            TestSub.calc = null;
        }

        /// <summary>
        ///  Initializer for any test of operation Add
        /// </summary>
        [TestInitialize]
        public void Initialize()
        {
            switch (TestContext.TestName)
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
        [TestCleanup]
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
        [TestMethod]
        [ExpectedException(typeof(InvalidCastException))]
        public void TestSubWithAnyOperand()
        {
            Assert.AreEqual(
                                double.Parse(TestSub.minuend.ToString()) + double.Parse(TestSub.subtrahend.ToString()),
                                TestSub.calc.Add(TestSub.minuend, TestSub.subtrahend));
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
        [TestMethod]
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
        [TestMethod]
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
        [TestMethod]
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
        [TestMethod]
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
        [TestMethod]
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
        [TestMethod]
        public void TestSubWithNan()
        {
            Assert.AreEqual(double.NaN, TestSub.calc.Sub(TestSub.minuend, TestSub.subtrahend));
        }
    }
}