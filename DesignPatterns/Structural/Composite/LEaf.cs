﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Composite
{
    public class Leaf : IComponent
    {
        public void Operation()
        {
            Console.WriteLine("Leaf op");
        }
    }
}
