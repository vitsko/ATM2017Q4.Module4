namespace TestCalculator
{
    using System;
    using CSharpCalculator;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class TestAbs
    {
        private static Calculator calc;
        private static object toAbs;

        public TestContext TestContext { get; set; }

        /// <summary>
        /// Initialize Calculator for test of operation Abs
        /// </summary>
        /// <param name="context"></param>
        [ClassInitialize]
        public static void TestAbsInitialize(TestContext context)
        {
            TestAbs.calc = new Calculator();
        }

        /// <summary>
        /// Clean up Calculator for test of operation Abs
        /// </summary>
        [ClassCleanup]
        public static void TestAbsCleanup()
        {
            TestAbs.calc = null;
        }

        /// <summary>
        ///  Initializer for any test of operation Abs
        /// </summary>
        [TestInitialize]
        public void Initialize()
        {
            switch (TestContext.TestName)
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
                case "TestFailAbsWithNotInt":
                    this.InitializeTestFailAbsWithNotInt();
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// Clean up all data for any test of Abs
        /// </summary>
        [TestCleanup]
        public void CleanAllTests()
        {
            TestAbs.toAbs = null;
        }

        /// <summary>
        /// Initialize toAbs for TestAbsWithAnyOperandAndInt
        /// </summary>         
        public void InitializeTestAbsWithAnyOperandAndInt()
        {
            TestAbs.toAbs = "10";
        }

        /// <summary>
        /// Test operation Abs with any type of operand
        /// </summary>
        [TestMethod]
        public void TestAbsWithAnyOperandAndInt()
        {
            double result;

            if (double.TryParse(TestAbs.toAbs.ToString(), out result))
            {
                Assert.AreEqual(Math.Abs(result), TestAbs.calc.Abs(result));
            }
            else
            {
                AssertFailedException.Equals(TestAbs.calc.Abs(result), new Exception());
            }
        }

        /// <summary>
        /// Initialize toAbs for InitializeTestAbsWithZero
        /// </summary>      
        public void InitializeTestAbsWithZero()
        {
            TestAbs.toAbs = "0.0";
        }

        /// <summary>
        /// Test operation Abs with operand is zero
        /// </summary>
        [TestMethod]
        public void TestAbsWithZero()
        {
            var result = double.Parse(toAbs.ToString());
            Assert.AreEqual(result, TestAbs.calc.Abs(result));
        }

        /// <summary>
        /// Initialize toAbs for TestAbsIntWithLessThanZero
        /// </summary>
        public void InitializeTestAbsIntWithLessThanZero()
        {
            TestAbs.toAbs = "-3.0";
        }

        /// <summary>
        /// Test operation Abs with operand is less than zero
        /// </summary>
        [TestMethod]
        public void TestAbsIntWithLessThanZero()
        {
            var result = double.Parse(toAbs.ToString());
            Assert.AreEqual(result * -1, TestAbs.calc.Abs(result));
        }

        /// <summary>
        /// Initialize toAbs for TestAbsIntWithGreatThanZero
        /// </summary>
        public void InitializeTestAbsIntWithGreatThanZero()
        {
            TestAbs.toAbs = "100.0";
        }

        /// <summary>
        /// Test operation Abs with operand is great than zero
        /// </summary>
        [TestMethod]
        public void TestAbsIntWithGreatThanZero()
        {
            var result = double.Parse(toAbs.ToString());
            Assert.AreEqual(result, TestAbs.calc.Abs(result));
        }

        /// <summary>
        /// Initialize toAbs for TestFailAbsWithNotInt
        /// </summary>
        public void InitializeTestFailAbsWithNotInt()
        {
            TestAbs.toAbs = "-10.2";
        }

        /// <summary>
        /// Test operation Abs with operand isn't integer.
        /// </summary>
        [TestMethod]
        public void TestFailAbsWithNotInt()
        {
            var result = double.Parse(toAbs.ToString());

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