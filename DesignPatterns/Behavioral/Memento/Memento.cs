using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Memento
{
    public class Memento
    {
        public Memento(string state)
        {
            this.State = state;
        }

        public string State { get; private set; }
    }
}
