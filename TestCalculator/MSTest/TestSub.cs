namespace TestCalculator
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class TestSub
    {
        [TestMethod]
        public void TestSubWithAnyOperand()
        {
            object toSub1 = 10d;
            object toSub2 = "20";
            var calc = new CSharpCalculator.Calculator();

            try
            {
                calc.Sub(toSub1, toSub2);
            }
            catch
            {
                Assert.IsFalse(false);
            }
        }

        [TestMethod]
        public void TestSubZero()
        {
            object toSub1 = 10d;
            object toSub2 = 0;

            var calc = new CSharpCalculator.Calculator();
            var toParse1 = double.Parse(toSub1.ToString());
            var toParse2 = double.Parse(toSub2.ToString());

            Assert.AreEqual(toParse1, calc.Sub(toParse1, toParse2));
        }

        [TestMethod]
        public void TestSubFromZero()
        {
            object toSub1 = 0d;
            object toSub2 = 10;

            var calc = new CSharpCalculator.Calculator();
            var toParse1 = double.Parse(toSub1.ToString());
            var toParse2 = double.Parse(toSub2.ToString());

            Assert.AreEqual(toParse2 * -1, calc.Sub(toParse1, toParse2));
        }

        [TestMethod]
        public void TestSubWithNumber()
        {
            object toSub1 = 10.5D;
            object toSub2 = -1;

            var calc = new CSharpCalculator.Calculator();
            var toParse1 = double.Parse(toSub1.ToString());
            var toParse2 = double.Parse(toSub2.ToString());

            Assert.AreEqual(toParse1 - toParse2, calc.Sub(toParse1, toParse2));
        }

        [TestMethod]
        public void TestSubWithNegativeInfinity()
        {
            double first = double.NegativeInfinity,
                   second = 2d;
            var calc = new CSharpCalculator.Calculator();

            Assert.AreEqual(double.NegativeInfinity, calc.Sub(first, second));
        }

        [TestMethod]
        public void TestSubWithPositiveInfinity()
        {
            double first = double.PositiveInfinity,
                   second = 2d;
            var calc = new CSharpCalculator.Calculator();

            Assert.AreEqual(double.PositiveInfinity, calc.Sub(first, second));
        }

        [TestMethod]
        public void TestSubWithNan()
        {
            double first = double.NaN,
                   second = 2d;
            var calc = new CSharpCalculator.Calculator();

            Assert.AreEqual(double.NaN, calc.Sub(first, second));
        }
    }
}