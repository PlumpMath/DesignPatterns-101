using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Facade
{
    class SubsystemA
    {
        public string OperationA1()
        {
            return "Subsystem A, Method A1";
        }
        public string OperationA2()
        {
            return "Subsystem A, Method A2";
        }
    }

    class SubsystemB
    {
        public string OperationB1()
        {
            return "Subsystem B, Method B1";
        }

        public string OperationB2()
        {
            return "Subsystem B, Method B2";
        }
    }

    class SubsystemC
    {
        public string OperationC1()
        {
            return "Subsystem C, Method C1";
        }

        public string OperationC2()
        {
            return "Subsystem C, Method C2";
        }
    }
}
