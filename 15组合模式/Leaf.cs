using System;
using System.Collections.Generic;
using System.Text;

namespace _15组合模式
{
    class Leaf : Component
    {
        public Leaf(string name) : base(name)
        {

        }
        public override void Add(Component c)
        {
            throw new NotImplementedException();
        }

        public override void Display(int depth)
        {
            throw new NotImplementedException();
        }

        public override void Remove(Component c)
        {
            throw new NotImplementedException();
        }
    }
}
