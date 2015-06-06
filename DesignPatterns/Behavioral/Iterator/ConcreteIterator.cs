using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Iterator
{
    public class ConcreteIterator : IIterator<string>
    {
        private ConcreteAggregate _aggregate;
        private int _current = 0;

        public ConcreteIterator(ConcreteAggregate aggregate)
        {
            this._aggregate = aggregate;
        }

        public string First()
        {
            return _aggregate[0];
        }

        public string Next()
        {
            string ret = null;

            if (_current < _aggregate.Count - 1)
            {
                ret = _aggregate[++_current];
            }

            return ret;
        }

        public string CurrentItem()
        {
            return _aggregate[_current];
        }

        public bool IsDone()
        {
            return _current >= _aggregate.Count;
        }
    }
}
