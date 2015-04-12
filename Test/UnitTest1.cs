using Microsoft.VisualStudio.TestTools.UnitTesting;
using Service;

namespace Test
{
    [TestClass]
    public class UnitTest1 : TestBase
    {
        [TestMethod]
        public void TestMethod1()
        {
            var service = this.GetService<IFooService>();
            var result = service.Bar();
            Assert.IsTrue(result.Length > 0);
        }
    }
}
