namespace TestCalculator.MSTest
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class TestIsNegative
    {
        [TestMethod]
        public void TestIsNegativeWithObject()
        {
            object value = "-10.67";
            var calc = new CSharpCalculator.Calculator();
            double result;

            if (double.TryParse(value.ToString(), out result))
            {
                Assert.AreEqual(true, calc.isNegative(result));
            }
            else
            {
                Assert.IsFalse(false);
            }
        }
    }
}