using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Decorator
{
    public class ConcreteComponent : IComponent
    {
        public void Operation()
        {
            Debug.WriteLine("ConcreteComponent");
        }
    }
}
