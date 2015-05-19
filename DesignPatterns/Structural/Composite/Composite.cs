using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Composite
{
    public class Composite : IComponent
    {
        private List<IComponent> _childs;

        public Composite(params IComponent[] components)
        {
            _childs = new List<IComponent>();
            _childs.AddRange(components);
        }

        public void Add(IComponent component)
        {
            _childs.Add(component);
        }
        
        public void AddRange(params IComponent[] components)
        {
            _childs.AddRange(components);
        }

        public void Delete(IComponent component)
        {
            _childs.Remove(component);
        }

        public void Operation()
        {
            foreach (IComponent cmp in _childs)
            {
                cmp.Operation();
            }
        }
    }
}
