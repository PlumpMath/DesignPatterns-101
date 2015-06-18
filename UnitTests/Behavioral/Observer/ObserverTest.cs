using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPatterns.Behavioral.Observer;

namespace UnitTests.Behavioral.Observer
{
    [TestClass]
    public class ObserverTest
    {
        [TestMethod]
        public void ObserverUsage()
        {
            ConcreteSubject s = new ConcreteSubject();

            s.Attach(new ConcreteObserver(s, "X"));
            s.Attach(new ConcreteObserver(s, "Y"));
            s.Attach(new ConcreteObserver(s, "Z"));

            // Change subject and notify observers
            s.SubjectState = "ABC";
            s.Notify();

            Assert.IsTrue(true);
        }
    }
}
