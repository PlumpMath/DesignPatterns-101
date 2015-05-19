using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPatterns.Structural.Decorator;

namespace UnitTests.Structural.Decorator
{
    [TestClass]
    public class DecoratorTest
    {
        [TestMethod]
        public void DecoratorUsage()
        {
            ConcreteComponent c = new ConcreteComponent();
            ConcreteDecorator d1 = new ConcreteDecorator(c);
            ConcreteDecorator d2 = new ConcreteDecorator(d1);

            d2.Operation();

            Assert.IsTrue(true);
        }
    }
}
