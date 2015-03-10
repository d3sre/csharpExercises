using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace L4M1.Test
{
    [TestClass]
    public class UnitTest1
    {
        private IZhawCal _calc = new Program();

        [TestMethod]
        public void TestMethodSuccess()
        {
            Assert.AreEqual(_calc.Div("2", "1"), 2);
        }
        [TestMethod]
        public void TestMethodFail()
        {
            try
            {
                _calc.Div("2+", "1");
            }
            catch (Exception e)
            {
                    Assert.IsInstanceOfType(e, typeof(OwnException));
            }
        }
    }
}
