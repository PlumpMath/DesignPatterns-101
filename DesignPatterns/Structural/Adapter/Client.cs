using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Adapter
{
    public class Client : IClient
    {
        public bool ClientMethod()
        {
            return false;
        }
    }
}
