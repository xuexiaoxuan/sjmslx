using System;
using System.Collections.Generic;
using System.Text;

namespace _16迭代器模式
{
    interface Iterator
    {
        public object First();
        public object Next();
        public bool IsDone();
        public object CurrentItem();
    }
}
