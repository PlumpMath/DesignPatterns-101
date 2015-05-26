using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPatterns.Structural.Flyweight;

namespace UnitTests.Structural.Flyweight
{
    [TestClass]
    public class FlyweightTest
    {
        [TestMethod]
        public void FlyweightUsage()
        {
            string document = "AAZZBBZB";
            char[] chars = document.ToCharArray();

            CharacterFactory factory = new CharacterFactory();

            int pointSize = 10;

            foreach (char c in chars)
            {
                pointSize++;
                Character character = factory.GetCharacter(c);
                character.Display(pointSize);
            }

            Assert.IsTrue(true);
        }
    }
}
