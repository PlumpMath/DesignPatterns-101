using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Observer
{
    public class ConcreteObserver : Observer
    {
        private string _name;
        private string _observerState;

        public ConcreteObserver(ConcreteSubject subject, string name)
        {
            this.Subject = subject;
            this._name = name;
        }

        public ConcreteSubject Subject { get; set; }

        public override void Update()
        {
            _observerState = this.Subject.SubjectState;
            Debug.WriteLine("Observer {0}'s new state is {1}", _name, _observerState);
        }
    }
}
