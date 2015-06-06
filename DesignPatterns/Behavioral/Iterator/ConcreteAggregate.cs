using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Iterator
{
    public class ConcreteAggregate : IAggregate<string>
    {
        private List<string> _items = new List<string>();

        public int Count
        {
            get { return _items.Count; }
        }

        public string this[int index]
        {
            get { return _items[index]; }
            set { _items.Insert(index, value); }
        }

        public IIterator<string> CreateIterator()
        {
            return new ConcreteIterator(this);
        }
    }
}
