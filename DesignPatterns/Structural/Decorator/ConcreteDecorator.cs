using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Decorator
{
    public class ConcreteDecorator : Decorator
    {
        public ConcreteDecorator(IComponent cmp) : base(cmp) { }

        public override void Operation()
        {
            base.Operation();
            Debug.WriteLine("ConcreteDecorator");
        }
    }
}
