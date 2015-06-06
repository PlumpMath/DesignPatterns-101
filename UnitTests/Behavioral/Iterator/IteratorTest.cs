using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPatterns.Behavioral.Iterator;
using System.Diagnostics;

namespace UnitTests.Behavioral.Iterator
{
    [TestClass]
    public class IteratorTest
    {
        [TestMethod]
        public void IteratorUsage()
        {
            ConcreteAggregate a = new ConcreteAggregate();
            a[0] = "Item A";
            a[1] = "Item B";
            a[2] = "Item C";
            a[3] = "Item D";

            IIterator<string> i = a.CreateIterator();

            Debug.WriteLine("Iterating over collection:");

            object item = i.First();
            while (item != null)
            {
                Debug.WriteLine(item);
                item = i.Next();
            }

            Assert.IsTrue(true);
        }
    }
}
