using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPatterns.Structural.Adapter;

namespace UnitTests.Structural.Adapter
{
    [TestClass]
    public class AdapterTest
    {
        [TestMethod]
        public void AdapterUsage()
        {
            IClient c1 = new Client();
            IClient c2 = new AdapteeToClientAdapter(new Adaptee());

            bool result = c1.ClientMethod() || c2.ClientMethod();

            Assert.IsTrue(result);
        }
    }
}
