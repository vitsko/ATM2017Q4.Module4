namespace TestCalculator.MSTest
{
    using CSharpCalculator;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class TestMultiply
    {
        private static Calculator calc;
        private static double multiplied, factor;

        public TestContext TestContext { get; set; }

        /// <summary>
        /// Initialize Calculator for test of operation Multiply
        /// </summary>
        /// <param name="context"></param>
        [ClassInitialize]
        public static void TestMultiplyInitialize(TestContext context)
        {
            TestMultiply.calc = new Calculator();
        }

        /// <summary>
        /// Clean up Calculator for test of operation Multiply
        /// </summary>
        [ClassCleanup]
        public static void TestMultiplyCleanup()
        {
            TestMultiply.calc = null;
        }

        /// <summary>
        ///  Initializer for any test of operation Multiply
        /// </summary>
        [TestInitialize]
        public void Initialize()
        {
            switch (TestContext.TestName)
            {
                case "TestMultiplyBySelf":
                    this.InitializeTestMultiplyBySelf();
                    break;
                case "TestMultiplyByOne":
                    this.InitializeTestMultiplyByOne();
                    break;
                case "TestMultiplyByZero":
                    this.InitializeTestMultiplyByZero();
                    break;
                case "TestMultiplyWithDifferentOperands":
                    this.InitializeTestMultiplyWithDifferentOperands();
                    break;
                case "TestMultiplyWithNegativeInfinity":
                    this.InitializeTestMultiplyWithNegativeInfinity();
                    break;
                case "TestMultiplyWithPositiveInfinity":
                    this.InitializeTestMultiplyWithPositiveInfinity();
                    break;
                case "TestMultiplyWithNaN":
                    this.InitializeTestMultiplyWithNaN();
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// Clean up all data for any test of Multiply
        /// </summary>
        [TestCleanup]
        public void CleanAllTests()
        {
            TestMultiply.multiplied = 0;
            TestMultiply.factor = 0;
        }

        /// <summary>
        /// Initialize multiplied for TestMultiplyBySelf
        /// </summary>         
        public void InitializeTestMultiplyBySelf()
        {
            TestMultiply.multiplied = 10.8d;
        }

        /// <summary>
        /// Test operation Multiply with operand is self
        /// </summary>
        [TestMethod]
        public void TestMultiplyBySelf()
        {
            Assert.AreEqual(
                            TestMultiply.multiplied * TestMultiply.multiplied,
                            TestMultiply.calc.Multiply(TestMultiply.multiplied, TestMultiply.multiplied));
        }

        /// <summary>
        /// Initialize multiplied for TestMultiplyByOne
        /// </summary>         
        public void InitializeTestMultiplyByOne()
        {
            TestMultiply.multiplied = 10.8d;
        }

        /// <summary>
        /// Test operation Multiply with factor is 1
        /// </summary>
        [TestMethod]
        public void TestMultiplyByOne()
        {
            Assert.AreEqual(TestMultiply.multiplied, TestMultiply.calc.Multiply(TestMultiply.multiplied, 1));
        }

        /// <summary>
        /// Initialize multiplied for TestMultiplyByZero
        /// </summary>         
        public void InitializeTestMultiplyByZero()
        {
            TestMultiply.multiplied = 5;
        }

        /// <summary>
        /// Test operation Multiply with factor is 0
        /// </summary>
        [TestMethod]
        public void TestMultiplyByZero()
        {
            Assert.AreEqual(0, TestMultiply.calc.Multiply(TestMultiply.multiplied, 0));
        }

        /// <summary>
        /// Initialize multiplied for TestMultiplyWithDifferentOperands
        /// </summary>         
        public void InitializeTestMultiplyWithDifferentOperands()
        {
            TestMultiply.multiplied = 5;
            TestMultiply.factor = 2;
        }

        /// <summary>
        /// Test operation Divide with operands are double
        /// </summary>
        [TestMethod]
        public void TestMultiplyWithDifferentOperands()
        {
            Assert.AreEqual(TestMultiply.multiplied * TestMultiply.factor, TestMultiply.calc.Multiply(TestMultiply.multiplied, TestMultiply.factor));
        }

        /// <summary>
        /// Initialize multiplied for TestMultiplyWithNegativeInfinity
        /// </summary>         
        public void InitializeTestMultiplyWithNegativeInfinity()
        {
            TestMultiply.multiplied = double.NegativeInfinity;

            /// Value must be great than 0
            TestMultiply.factor = 2;
        }

        /// <summary>
        ///  Test operation Multiply with multiplied is double.NegativeInfinity
        /// </summary>
        [TestMethod]
        public void TestMultiplyWithNegativeInfinity()
        {
            Assert.AreEqual(double.NegativeInfinity, TestMultiply.calc.Multiply(TestMultiply.multiplied, TestMultiply.factor));
        }

        /// <summary>
        /// Initialize multiplied for TestMultiplyWithPositiveInfinity
        /// </summary>         
        public void InitializeTestMultiplyWithPositiveInfinity()
        {
            TestMultiply.multiplied = double.PositiveInfinity;

            /// Value must be great than 0
            TestMultiply.factor = 2;
        }

        /// <summary>
        /// Test operation Multiply with multiplied is double.PositiveInfinity
        /// </summary>
        [TestMethod]
        public void TestMultiplyWithPositiveInfinity()
        {
            Assert.AreEqual(double.PositiveInfinity, TestMultiply.calc.Multiply(TestMultiply.multiplied, TestMultiply.factor));
        }

        /// <summary>
        /// Initialize multiplied for TestMultiplyWithNaN
        /// </summary>         
        public void InitializeTestMultiplyWithNaN()
        {
            TestMultiply.multiplied = double.NaN;
            TestMultiply.factor = 2;
        }

        /// <summary>
        /// Test operation Multiply with multiplied is double.NaN
        /// </summary>
        [TestMethod]
        public void TestMultiplyWithNaN()
        {
            Assert.AreEqual(double.NaN, TestMultiply.calc.Multiply(TestMultiply.multiplied, TestMultiply.factor));
        }
    }
}