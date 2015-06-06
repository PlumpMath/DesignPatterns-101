using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;
using System.Collections.Generic;
using DesignPatterns.Behavioral.Interpreter;

namespace UnitTests.Behavioral.Interpreter
{
    [TestClass]
    public class InterpreterTest
    {
        [TestMethod]
        public void InterpreterUsage()
        {
            string roman = "MCMXXVIII";
            Context context = new Context(roman);

            // Build the 'parse tree'
            List<Expression> tree = new List<Expression>();
            tree.Add(new ThousandExpression());
            tree.Add(new HundredExpression());
            tree.Add(new TenExpression());
            tree.Add(new OneExpression());

            foreach (Expression exp in tree)
            {
                exp.Interpret(context);
            }

            Debug.WriteLine("{0} = {1}", roman, context.Output);

            Assert.IsTrue(true);
        }
    }
}
