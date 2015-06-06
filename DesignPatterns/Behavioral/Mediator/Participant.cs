using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Mediator
{
    public abstract class Participant
    {
        public Participant(string name)
        {
            this.Name = name;
        }

        public string Name { get; private set; }

        public IChatroom Chatroom { get; set; }

        public void Send(string to, string message)
        {
            Chatroom.Send(this.Name, to, message);
        }

        public virtual void Receive(string from, string message)
        {
            Debug.WriteLine("{0} to {1}: '{2}'", from, Name, message);
        }
    }
}
