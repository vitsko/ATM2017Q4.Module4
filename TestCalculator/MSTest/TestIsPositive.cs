namespace TestCalculator.MSTest
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class TestIsPositive
    {
        [TestMethod]
        public void TestIsPositiveWithObject()
        {
            object value = "10.67";
            var calc = new CSharpCalculator.Calculator();
            double result;

            if (double.TryParse(value.ToString(), out result))
            {
                Assert.AreEqual(true, calc.isPositive(result));
            }
            else
            {
                Assert.IsFalse(false);
            }
        }
    }
}