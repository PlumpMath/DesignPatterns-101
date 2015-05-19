using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Decorator
{
    public abstract class Decorator : IComponent
    {
        IComponent _cmp;

        public Decorator(IComponent cmp)
        {
            _cmp = cmp;
        }

        public virtual void Operation()
        {
            if(_cmp != null)
            {
                _cmp.Operation();
            }
        }
    }
}
