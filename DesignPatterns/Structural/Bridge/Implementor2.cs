using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Bridge
{
    public class Implementor2 : IImplementor
    {
        public string Function1()
        {
            return "Fuction 1 of " + this.GetType().ToString();
        }

        public string Function2()
        {
            return "Fuction 2 of " + this.GetType().ToString();
        }
    }
}
