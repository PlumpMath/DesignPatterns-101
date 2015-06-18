using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPatterns.Behavioral.Memento;

namespace UnitTests.Behavioral.Memento
{
    /// <summary>
    /// Summary description for MementoTest
    /// </summary>
    [TestClass]
    public class MementoTest
    {
        [TestMethod]
        public void MementoUsage()
        {
            Originator o = new Originator();
            o.State = "On";

            // Store internal state
            Caretaker c = new Caretaker();
            c.Memento = o.CreateMemento();

            // Continue changing originator
            o.State = "Off";

            // Restore saved state
            o.SetMemento(c.Memento);

            Assert.IsTrue(true);
        }
    }
}
