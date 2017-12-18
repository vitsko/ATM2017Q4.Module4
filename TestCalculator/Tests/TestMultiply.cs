namespace TestCalculator
{
    using CSharpCalculator;
    using NUnit.Framework;

    [TestFixture]
    public class TestMultiply
    {
        private static Calculator calc;
        private static double multiplied, factor;

        /// <summary>
        /// Initialize Calculator for test of operation Multiply
        /// </summary>
        [OneTimeSetUp]
        public static void TestMultiplyInitialize()
        {
            TestMultiply.calc = new Calculator();
        }

        /// <summary>
        /// Clean up Calculator for test of operation Multiply
        /// </summary>
        [OneTimeTearDown]
        public static void TestMultiplyCleanup()
        {
            TestMultiply.calc = null;
        }

        /// <summary>
        ///  Initializer for any test of operation Multiply
        /// </summary>
        [SetUp]
        public void Initialize()
        {
            switch (TestContext.CurrentContext.Test.Name)
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
        [TearDown]
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
        [Test]
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
        [Test]
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
        [Test]
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
        [Test]
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
        [Test]
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
        [Test]
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
        [Test]
        public void TestMultiplyWithNaN()
        {
            Assert.AreEqual(double.NaN, TestMultiply.calc.Multiply(TestMultiply.multiplied, TestMultiply.factor));
        }
    }
}