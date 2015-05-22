using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests.Structural.Facade
{
    [TestClass]
    public class FacadeTest
    {
        [TestMethod]
        public void FacadeUsage()
        {
            DesignPatterns.Structural.Facade.Facade f = new DesignPatterns.Structural.Facade.Facade();
            f.Operation1();

            Assert.IsTrue(true);
        }
    }
}
