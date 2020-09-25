using System;
using System.Collections.Generic;
using System.Text;

namespace _15组合模式
{
    class Composite : Component
    {
        public Composite(string name) : base(name)
        {

        }
        private List<Component> children = new List<Component>();
        public override void Add(Component c)
        {
            children.Add(c);
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new String('-', depth) + name);
            foreach(Component component in children)
            {
                component.Display(depth + 2);
            }
        }

        public override void Remove(Component c)
        {
            children.Remove(c);
        }
    }
}
