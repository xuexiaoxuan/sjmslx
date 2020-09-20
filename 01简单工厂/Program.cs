using System;

namespace _01简单工厂
{
    class Program
    {
        static void Main(string[] args)
        {
            var a= OpreationFactory.CreateOpreation("+");
            var b= a.GetResult(2, 3);
            Console.WriteLine(b);
        }
    }
}
