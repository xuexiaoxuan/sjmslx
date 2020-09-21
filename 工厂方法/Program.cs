using _05工厂方法;
using System;

namespace 工厂方法
{
    class Program
    {
        static void Main(string[] args)
        {
            IFactory operFactory = new AddFactory();
            Operation oper = operFactory.CreateOperation();
            Console.WriteLine(oper.GetResult(1, 2));
        }
    }
}
