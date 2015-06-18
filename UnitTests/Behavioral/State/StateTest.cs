using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPatterns.Behavioral.State;

namespace UnitTests.Behavioral.State
{
    [TestClass]
    public class StateTest
    {
        [TestMethod]
        public void StateUsage()
        {
            // Setup context in a state
            Context c = new Context(new ConcreteStateA());

            // Issue requests, which toggles state
            c.Request();
            c.Request();
            c.Request();
            c.Request();

            Assert.IsTrue(true);
        }
    }
}
