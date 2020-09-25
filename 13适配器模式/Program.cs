using System;

namespace _13适配器模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Target target = new Adpater();
            target.Request();
            Console.Read();
        }
    }
}
