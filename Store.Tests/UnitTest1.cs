using Microsoft.VisualStudio.TestTools.UnitTesting;
using Store.Domain.StoreContext.Entities;

namespace Store.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var c = new Customer("vanessa", "camargo", "154544454", "van@gmail.com", "19999999", "Rua abcd, 1024");
        }
    }
}
