using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Observer
{
    public class ConcreteSubject : Subject
    {
        public string SubjectState { get; set; }
    }
}
