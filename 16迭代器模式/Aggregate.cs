using System;
using System.Collections.Generic;
using System.Text;

namespace _16迭代器模式
{
    abstract class Aggregate
    {
        public abstract Iterator CreateIterator();
    }
}
