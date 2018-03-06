using System;
using ConvertEverything.Converters;
using ConvertEverything.Quantities;
using ConvertEverything.Units;
using ConvertEverything.Values;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConvertEverythingUnitTests
{
    [TestClass]
    public class MutableValueTests
    {
        [TestMethod]
        public void TestConvert()
        {
            var val = new MutableValue(2350, 1, new Length(), new MilliMetre());
            var canConvert = val.CanConvert(new Metre());
            Assert.IsTrue(canConvert);

            var res = val.Convert(new Metre());
            Assert.IsTrue(res);

            Assert.IsInstanceOfType(val.Unit, typeof(Metre));
            Assert.AreEqual(2.350, val.Value);
            Assert.AreEqual(0.001, val.Precision);
        }
    }
}
