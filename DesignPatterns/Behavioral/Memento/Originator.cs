using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Memento
{
    public class Originator
    {
        public string State { get; set; }

        public Memento CreateMemento()
        {
            return (new Memento(State));
        }

        public void SetMemento(Memento memento)
        {
            Debug.WriteLine("Restoring state...");
            State = memento.State;
        }
    }
}
