﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Composite
{
    public class Leaf : IComponent
    {
        public void Operation()
        {
            Debug.WriteLine("Leaf op");
        }
    }
}
