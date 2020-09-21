using System;

namespace _04代理模式
{
    class Program
    {
        static void Main(string[] args)
        {
            SchooGirl jiaojiao = new SchooGirl { Name = "李娇娇" };
            Proxy daili = new Proxy(jiaojiao);
            daili.GiveDolls();
            daili.GiveFlowers();
            daili.GiveDolls();
            Console.Read();
        }
    }
}
