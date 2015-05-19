using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPatterns.Structural.Composite;

namespace UnitTests.Structural.Composite
{
    [TestClass]
    public class CompositeTest
    {
        [TestMethod]
        public void CompositeUsage()
        {
            IComponent c1 = new Leaf();
            IComponent c2 = new Leaf();
            IComponent c3 = new Leaf();

            DesignPatterns.Structural.Composite.Composite composite = new DesignPatterns.Structural.Composite.Composite(c1, c2);
            composite.Add(c3);

            composite.Operation();

            Assert.IsTrue(true);
        }
    }
}
