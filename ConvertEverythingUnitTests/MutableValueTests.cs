using ConvertEverything.Values;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConvertEverythingUnitTests
{
    [TestClass]
    public class MutableValueTests
    {
        private class MyValue : MutableValue<double>
        {
            public MyValue()
            {
                Value = 0.4;
                Precision = 0.1;
                Unit = null;
                Quantity = null;
                Application = null;
            }
        }

        [TestMethod]
        public void TestMethod1()
        {
            
        }
    }
}
