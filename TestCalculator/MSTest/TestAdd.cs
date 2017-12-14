namespace TestCalculator
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class TestAdd
    {
        [TestMethod]
        public void TestAddWithIncorrectOperand()
        {
            object toAdd1 = 10d;
            object toAdd2 = "20";
            var calc = new CSharpCalculator.Calculator();

            try
            {
                calc.Add(toAdd1, toAdd2);
            }
            catch
            {
                Assert.IsFalse(false);
            }
        }

        [TestMethod]
        public void TestAddWithZero()
        {
            object toAdd1 = 10d;
            object toAdd2 = 0;

            var calc = new CSharpCalculator.Calculator();
            var toParse1 = double.Parse(toAdd1.ToString());
            var toParse2 = double.Parse(toAdd2.ToString());

            Assert.AreEqual(toParse1, calc.Add(toParse1, toParse2));
        }

        [TestMethod]
        public void TestAddWithNumber()
        {
            object toAdd1 = 10.5D;
            object toAdd2 = -1;

            var calc = new CSharpCalculator.Calculator();
            var toParse1 = double.Parse(toAdd1.ToString());
            var toParse2 = double.Parse(toAdd2.ToString());

            Assert.AreEqual(toParse1 + toParse2, calc.Add(toParse1, toParse2));
        }
    }
}