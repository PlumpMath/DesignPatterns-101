using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPatterns.Behavioral.Command;

namespace UnitTests.Behavioral.Command
{
    [TestClass]
    public class CommandTest
    {
        [TestMethod]
        public void CommandUsage()
        {
            IReceiver receiver = new ConcreteReceiver();
            ICommand command = new ConcreteCommand(receiver);
            Invoker invoker = new Invoker();

            invoker.SetCommand(command);
            invoker.ExecuteCommand();

            Assert.IsTrue(true);
        }
    }
}
