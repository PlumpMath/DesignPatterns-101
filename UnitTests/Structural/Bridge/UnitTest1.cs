using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPatterns.Structural.Bridge;

namespace UnitTests.Structural.Bridge
{
    [TestClass]
    public class BridgeTest
    {
        [TestMethod]
        public void BridgeUsage()
        {
            Abstraction a = new RefinedAbstraction(new Implementor1());
            Abstraction b = new RefinedAbstraction(new Implementor2());

            a.CallMethod1();
            a.CallMethod2();
            b.CallMethod1();
            b.CallMethod2();

            Assert.IsTrue(true);
        }
    }
}
