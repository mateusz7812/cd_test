using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebApplication3;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var service = new WebApplication3.Services.Service(3);
            Assert.AreEqual(9, service.Calc());
        }

        [TestMethod]
        public void TestMethod2()
        {
            var service = new WebApplication3.Services.Service(0);
            Assert.AreEqual(0, service.Calc());
        }
    }
}
