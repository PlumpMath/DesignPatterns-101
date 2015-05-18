using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Bridge
{
    public abstract class Abstraction
    {
        protected IImplementor Implementator { get; private set; }

        public Abstraction(IImplementor implementator)
        {
            Implementator = implementator;
        }

        public abstract void CallMethod1();
        
        public abstract void CallMethod2();
    }
}
