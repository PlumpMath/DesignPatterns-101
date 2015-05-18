using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Bridge
{
    public class RefinedAbstraction : Abstraction
    {
        public RefinedAbstraction(IImplementor implementator) : base(implementator) { }

        public override void CallMethod1()
        {
            Console.WriteLine(Implementator.Function1());
        }

        public override void CallMethod2()
        {
            Console.WriteLine(Implementator.Function2());
        }
    }
}
