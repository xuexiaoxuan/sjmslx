using System;

namespace _16迭代器模式
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteAggregate a = new ConcreteAggregate();
            a[0] = "大鸟";
            a[1] = "小菜";
            a[2] = "行李";
            Iterator i = new ConcreteIterator(a);
            object item = i.First();
            while (!i.IsDone())
            {
                Console.WriteLine("{0}请买票!", i.CurrentItem());
                i.Next();
            }
            Console.Read();
        }
    }
}
