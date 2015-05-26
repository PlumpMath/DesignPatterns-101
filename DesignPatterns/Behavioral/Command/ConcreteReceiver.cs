using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Command
{
    public class ConcreteReceiver : IReceiver
    {
        public void Action()
        {
            Debug.WriteLine(this.GetType().ToString() + " action invoked");
        }
    }
}
