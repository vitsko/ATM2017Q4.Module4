namespace TestCalculator
{
    using System;
    using CSharpCalculator;
    using NUnit.Framework;

    [TestFixture]
    public class TestAbs
    {
        private static Calculator calc;
        private static object toAbs;

        /// <summary>
        /// Initialize TestAbs.calculator for test of operation Abs
        /// </summary>
        [OneTimeSetUp]
        public void TestAbsInitialize()
        {
            TestAbs.calc = new Calculator();
        }

        /// <summary>
        /// Clean up TestAbs.calculator for test of operation Abs
        /// </summary>
        [OneTimeTearDown]
        public void TestAbsCleanup()
        {
            TestAbs.calc = null;
        }

        /// <summary>
        ///  Initializer for any test of operation Abs
        /// </summary>
        [SetUp]
        public void Initialize()
        {
            switch (TestContext.CurrentContext.Test.Name)
            {
                case "TestAbsWithAnyOperandAndInt":
                    this.InitializeTestAbsWithAnyOperandAndInt();
                    break;
                case "TestAbsWithZero":
                    this.InitializeTestAbsWithZero();
                    break;
                case "TestAbsIntWithLessThanZero":
                    this.InitializeTestAbsIntWithLessThanZero();
                    break;
                case "TestAbsIntWithGreatThanZero":
                    this.InitializeTestAbsIntWithGreatThanZero();
                    break;
                case "TestNUnitFailAbsWithNotInt":
                    this.InitializeTestFailAbsWithNotInt();
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// Clean up all data for any test of Abs
        /// </summary>
        [TearDown]
        public void CleanAllTests()
        {
            TestAbs.toAbs = null;
        }

        /// <summary>
        /// Initialize TestAbs.toAbs for TestAbsWithAnyOperandAndInt
        /// </summary>         
        public void InitializeTestAbsWithAnyOperandAndInt()
        {
            TestAbs.toAbs = "10";
        }

        /// <summary>
        /// Test operation Abs with any type of operand
        /// </summary>
        [Test]
        public void TestAbsWithAnyOperandAndInt()
        {
            double result;

            if (double.TryParse(TestAbs.toAbs.ToString(), out result))
            {
                Assert.AreEqual(Math.Abs(result), TestAbs.calc.Abs(result));
            }
            else
            {
                AssertionException.Equals(TestAbs.calc.Abs(result), new Exception());
            }
        }

        /// <summary>
        /// Initialize TestAbs.toAbs for InitializeTestAbsWithZero
        /// </summary>      
        public void InitializeTestAbsWithZero()
        {
            TestAbs.toAbs = "0.0";
        }

        /// <summary>
        /// Test operation Abs with operand is zero
        /// </summary>
        [Test]
        public void TestAbsWithZero()
        {
            var result = double.Parse(TestAbs.toAbs.ToString());
            Assert.AreEqual(result, TestAbs.calc.Abs(result));
        }

        /// <summary>
        /// Initialize TestAbs.toAbs for TestAbsIntWithLessThanZero
        /// </summary>
        public void InitializeTestAbsIntWithLessThanZero()
        {
            TestAbs.toAbs = "-3.0";
        }

        /// <summary>
        /// Test operation Abs with operand is less than zero
        /// </summary>
        [Test]
        public void TestAbsIntWithLessThanZero()
        {
            var result = double.Parse(TestAbs.toAbs.ToString());
            Assert.AreEqual(result * -1, TestAbs.calc.Abs(result));
        }

        /// <summary>
        /// Initialize TestAbs.toAbs for TestAbsIntWithGreatThanZero
        /// </summary>
        public void InitializeTestAbsIntWithGreatThanZero()
        {
            TestAbs.toAbs = "100.0";
        }

        /// <summary>
        /// Test operation Abs with operand is great than zero
        /// </summary>
        [Test]
        public void TestAbsIntWithGreatThanZero()
        {
            var result = double.Parse(TestAbs.toAbs.ToString());
            Assert.AreEqual(result, TestAbs.calc.Abs(result));
        }

        /// <summary>
        /// Initialize TestAbs.toAbs for TestFailAbsWithNotInt
        /// </summary>
        public void InitializeTestFailAbsWithNotInt()
        {
            TestAbs.toAbs = "-10.2";
        }

        /// <summary>
        /// Test operation Abs with operand isn't integer.
        /// </summary>
        [Test]
        public void TestFailAbsWithNotInt()
        {
            var result = double.Parse(TestAbs.toAbs.ToString());

            if (result > 0)
            {
                Assert.AreEqual(result, TestAbs.calc.Abs(result));
            }
            else
            {
                Assert.AreEqual(result * -1, TestAbs.calc.Abs(result));
            }
        }
    }
}