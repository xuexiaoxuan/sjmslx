using System;
using System.Collections.Generic;
using System.Text;

namespace _16迭代器模式
{
    class ConcreteIterator : Iterator
    {
        private ConcreteAggregate aggregate;
        private int current = 0;
        public ConcreteIterator(ConcreteAggregate aggregate)
        {
            this.aggregate = aggregate;
        }
        public object CurrentItem()
        {
            return aggregate[current];
        }

        public object First()
        {
            return aggregate[0];
        }

        public bool IsDone()
        {
            return current >= aggregate.Count ? true : false;
        }

        public object Next()
        {
            object ret = null;
            current++;
            if (current < aggregate.Count)
            {
                ret = aggregate[current];
            }
            return ret;
        }
    }
}
