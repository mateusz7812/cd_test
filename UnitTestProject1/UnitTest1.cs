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
            Assert.AreEqual(5, service.Calc());
        }
    }
}
