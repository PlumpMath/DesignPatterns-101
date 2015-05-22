using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Facade
{
    public class Facade
    {
        private SubsystemA a = new SubsystemA();
        private SubsystemB b = new SubsystemB();
        private SubsystemC c = new SubsystemC();

        public void Operation1()
        {
            Console.WriteLine("Operation 1" +
            a.OperationA1() +
            a.OperationA2() +
            b.OperationB1());
        }

        public void Operation2()
        {
            Console.WriteLine("Operation 2" +
            b.OperationB2() +
            c.OperationC1() +
            c.OperationC2());
        }
    }
}
