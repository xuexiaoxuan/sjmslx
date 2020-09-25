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
            Console.WriteLine("Connot add to aleaf");
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new String('-',depth)+name);
        }

        public override void Remove(Component c)
        {
            Console.WriteLine("Connot add from aleaf");

        }
    }
}
