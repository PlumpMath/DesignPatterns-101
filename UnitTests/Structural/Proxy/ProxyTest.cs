using DesignPatterns.Structural.Proxy;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests.Structural.Proxy
{
    [TestClass]
    public class ProxyTest
    {
        [TestMethod]
        public void ProxyUsage()
        {
            ICar car = new ProxyCar(new Driver(16));
            car.DriveCar();
 
            car = new ProxyCar(new Driver(25));
            car.DriveCar();

            Assert.IsTrue(true);
        }
    }
}
